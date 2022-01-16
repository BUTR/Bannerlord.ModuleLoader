using Microsoft.CodeAnalysis;

using Mono.Cecil;

using System.Globalization;
using System.IO;
using System.Linq;

namespace Bannerlord.ModuleLoader.Injector
{
    [Generator]
    public class InjectorGenerator : ISourceGenerator
    {
        public void Initialize(GeneratorInitializationContext context) { }

        public void Execute(GeneratorExecutionContext context)
        {
            if (!context.AnalyzerConfigOptions.GlobalOptions.TryGetValue("build_property.outputpath", out var path))
            {
                return;
            }
            if (!context.AnalyzerConfigOptions.GlobalOptions.TryGetValue("build_property.msbuildprojectfullpath", out var csPath))
            {
                return;
            }

            var fullPath = Path.Combine(Path.GetDirectoryName(csPath), path);

            var moduleName = context.AnalyzerConfigOptions.GlobalOptions.TryGetValue("build_property.modulename", out var moduleNameStr)
                ? moduleNameStr
                : context.Compilation.Assembly.Name.Split('.').FirstOrDefault();

            using (var dllStream = typeof(InjectorGenerator).Assembly.GetManifestResourceStream("Bannerlord.ModuleLoader.dll"))
            using (var newAsmStream = SetName(moduleName, dllStream))
            using (var fileStream = new FileStream(Path.Combine(fullPath, $"Bannerlord.ModuleLoader.{moduleName}.dll"), FileMode.Create, FileAccess.Write))
            {
                newAsmStream.CopyTo(fileStream);
            }

            using (var pdbStream = typeof(InjectorGenerator).Assembly.GetManifestResourceStream("Bannerlord.ModuleLoader.pdb"))
            using (var fileStream = new FileStream(Path.Combine(fullPath, $"Bannerlord.ModuleLoader.{moduleName}.pdb"), FileMode.Create, FileAccess.Write))
            {
                pdbStream?.CopyTo(fileStream);
            }
        }

        private static Stream SetName(string moduleName, Stream? assemblyStream)
        {
            if (assemblyStream is null)
                return Stream.Null;

            assemblyStream.Seek(0, SeekOrigin.Begin);

            using var modifiedAss = AssemblyDefinition.ReadAssembly(assemblyStream);
            modifiedAss.Name.Name = moduleName;
            var type = modifiedAss.MainModule.GetType("Bannerlord.ModuleLoader.SubModule");
            var validClassName = new string(moduleName.Select((c, i) => IsValidInIdentifier(c, i == 0) ? c : '_').ToArray());
            type.Name = validClassName;

            var ms = new MemoryStream();
            modifiedAss.Write(ms, new WriterParameters() { DeterministicMvid = true });
            ms.Seek(0, SeekOrigin.Begin);
            return ms;
        }
        private static bool IsValidInIdentifier(char c, bool firstChar = true) => char.GetUnicodeCategory(c) switch
        {
            // Always allowed in C# identifiers
            UnicodeCategory.UppercaseLetter => true,
            UnicodeCategory.LowercaseLetter => true,
            UnicodeCategory.TitlecaseLetter => true,
            UnicodeCategory.ModifierLetter => true,
            UnicodeCategory.OtherLetter => true,

            // Only allowed after first char
            UnicodeCategory.LetterNumber => !firstChar,
            UnicodeCategory.NonSpacingMark => !firstChar,
            UnicodeCategory.SpacingCombiningMark => !firstChar,
            UnicodeCategory.DecimalDigitNumber => !firstChar,
            UnicodeCategory.ConnectorPunctuation => !firstChar,
            UnicodeCategory.Format => !firstChar,

            _ => false
        };
    }
}