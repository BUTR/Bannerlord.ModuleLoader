using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;

using Mono.Cecil;
using Mono.Cecil.Cil;

using System;
using System.Globalization;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace Bannerlord.ModuleLoader.Injector;

[Generator]
public class InjectorGenerator : IIncrementalGenerator
{
    private readonly record struct BuildProperties(string? OutputPath, string? CsProjPath, string? ModuleId);

    private static readonly DiagnosticDescriptor MissingRequiredBuildProperties = new(
        "INJ001",
        "Missing Required Build Properties",
        "OutputPath, MSBuildProjectFullPath, or ModuleId not provided. Skipping generation.",
        "Generator",
        DiagnosticSeverity.Warning,
        true);

    private static readonly DiagnosticDescriptor StartingModuleGeneration = new(
        "INJ002",
        "Starting Module Generation",
        "Generating module files for {0}...",
        "Generator",
        DiagnosticSeverity.Info,
        true);

    private static readonly DiagnosticDescriptor ModuleGenerationSuccessful = new(
        "INJ003",
        "Module Generation Successful",
        "Successfully generated module files for {0}.",
        "Generator",
        DiagnosticSeverity.Info,
        true);

    private static readonly DiagnosticDescriptor ModuleGenerationFailed = new(
        "INJ004",
        "Module Generation Failed",
        "An error occurred while generating module files for {0}: {1}",
        "Generator",
        DiagnosticSeverity.Error,
        true);

    private static readonly DiagnosticDescriptor MissingEmbeddedResource = new(
        "INJ005",
        "Missing Embedded Resource",
        "Embedded resource '{0}' not found in assembly.",
        "Generator",
        DiagnosticSeverity.Error,
        true);

    private static readonly Regex InvalidIdentifierCharacters = new("[^a-zA-Z0-9]", RegexOptions.Compiled);

    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
        var buildProps = context.AnalyzerConfigOptionsProvider.Select((provider, _) => new BuildProperties
        {
            OutputPath = provider.GlobalOptions.TryGetValue("build_property.outputpath", out var path) ? path : null,
            CsProjPath = provider.GlobalOptions.TryGetValue("build_property.msbuildprojectfullpath", out var csPath) ? csPath : null,
            ModuleId = provider.GlobalOptions.TryGetValue("build_property.moduleid", out var moduleId) ? moduleId :
                provider.GlobalOptions.TryGetValue("build_property.modulename", out var moduleName) ? moduleName : null,
        });

        // Generate output only if all required properties are available
        context.RegisterImplementationSourceOutput(buildProps, (spc, props) =>
        {
            if (props.OutputPath is null || props.CsProjPath is null || props.ModuleId is null)
            {
                spc.ReportDiagnostic(Diagnostic.Create(MissingRequiredBuildProperties, Location.None));

                return;
            }

            spc.ReportDiagnostic(Diagnostic.Create(StartingModuleGeneration, Location.None, props.ModuleId));

            try
            {
                var projectDir = Path.GetDirectoryName(props.CsProjPath);
                if (projectDir is null)
                {
                    spc.ReportDiagnostic(Diagnostic.Create(ModuleGenerationFailed, Location.None, props.ModuleId, "Could not determine project directory"));
                    return;
                }

                var fullPath = Path.Combine(projectDir, props.OutputPath);
                GenerateAssembly(spc, fullPath, props.ModuleId);
                spc.ReportDiagnostic(Diagnostic.Create(ModuleGenerationSuccessful, Location.None, props.ModuleId));
            }
            catch (Exception ex)
            {
                spc.ReportDiagnostic(Diagnostic.Create(ModuleGenerationFailed, Location.None, props.ModuleId, $"{ex.GetType().Name}: {ex.Message}"));
            }
        });
    }

    private static void GenerateAssembly(SourceProductionContext spc, string fullPath, string moduleId)
    {
        using var dllStream = typeof(InjectorGenerator).Assembly.GetManifestResourceStream("Bannerlord.ModuleLoader.dll");
        using var pdbStream = typeof(InjectorGenerator).Assembly.GetManifestResourceStream("Bannerlord.ModuleLoader.pdb");

        if (dllStream is null)
        {
            spc.ReportDiagnostic(Diagnostic.Create(MissingEmbeddedResource, Location.None, "Bannerlord.ModuleLoader.dll"));
            return;
        }

        if (pdbStream is null)
        {
            spc.ReportDiagnostic(Diagnostic.Create(MissingEmbeddedResource, Location.None, "Bannerlord.ModuleLoader.pdb"));
            return;
        }

        using var modifiedAssembly = AssemblyDefinition.ReadAssembly(dllStream, new ReaderParameters
        {
            SymbolStream = pdbStream,
            ReadSymbols = true
        });

        modifiedAssembly.Name.Name = moduleId;

        var type = modifiedAssembly.MainModule.GetType("Bannerlord.ModuleLoader.SubModule");
        type.Name = FlatName(moduleId);

        var dllPath = Path.Combine(fullPath, $"Bannerlord.ModuleLoader.{moduleId}.dll");
        var pdbPath = Path.Combine(fullPath, $"Bannerlord.ModuleLoader.{moduleId}.pdb");

        using var outputDllStream = new FileStream(dllPath, FileMode.Create, FileAccess.Write);
        using var outputPdbStream = new FileStream(pdbPath, FileMode.Create, FileAccess.Write);

        modifiedAssembly.Write(outputDllStream, new WriterParameters
        {
            DeterministicMvid = true,
            WriteSymbols = true,
            SymbolStream = outputPdbStream,
            SymbolWriterProvider = new PortablePdbWriterProvider()
        });
    }

    private static string FlatNameRegex(string str) => InvalidIdentifierCharacters.Replace(str, "_");

    private static string FlatName(string str)
    {
        if (string.IsNullOrWhiteSpace(str))
            return "_";

        var sb = new StringBuilder(str.Length);
        var firstChar = true;

        foreach (var c in str)
        {
            sb.Append(IsValidInIdentifier(c, firstChar) ? c : '_');
            firstChar = false;
        }

        if (char.IsDigit(sb[0]))
            sb.Insert(0, '_');

        var result = sb.ToString();

        // Ensure it's not a C# keyword
        if (SyntaxFacts.IsKeywordKind(SyntaxFacts.GetKeywordKind(result)))
            result = $"{result}_";

        return result;
    }

    private static bool IsValidInIdentifier(char c, bool firstChar = true) => char.GetUnicodeCategory(c) switch
    {
        // Always allowed in C# identifiers
        UnicodeCategory.UppercaseLetter => true,
        UnicodeCategory.LowercaseLetter => true,
        UnicodeCategory.TitlecaseLetter => true,
        UnicodeCategory.ModifierLetter => true,
        UnicodeCategory.OtherLetter => true,

        // Only allowed after the first char
        UnicodeCategory.LetterNumber => !firstChar,
        UnicodeCategory.NonSpacingMark => !firstChar,
        UnicodeCategory.SpacingCombiningMark => !firstChar,
        UnicodeCategory.DecimalDigitNumber => !firstChar,
        UnicodeCategory.ConnectorPunctuation => !firstChar,
        UnicodeCategory.Format => !firstChar,

        _ => false,
    };
}