﻿using Microsoft.CodeAnalysis;

using Mono.Cecil;

using System.Globalization;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

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

            var moduleId = context.AnalyzerConfigOptions.GlobalOptions.TryGetValue("build_property.moduleid", out var moduleIdStr)
                ? moduleIdStr
                : context.AnalyzerConfigOptions.GlobalOptions.TryGetValue("build_property.modulename", out var moduleNameStr)
                    ? moduleNameStr
                    : context.Compilation.Assembly.Name.Split('.').FirstOrDefault();

            using (var dllStream = typeof(InjectorGenerator).Assembly.GetManifestResourceStream("Bannerlord.ModuleLoader.dll"))
            using (var newAsmStream = SetName(moduleId, dllStream))
            using (var fileStream = new FileStream(Path.Combine(fullPath, $"Bannerlord.ModuleLoader.{moduleId}.dll"), FileMode.Create, FileAccess.Write))
            {
                newAsmStream.CopyTo(fileStream);
            }

            using (var pdbStream = typeof(InjectorGenerator).Assembly.GetManifestResourceStream("Bannerlord.ModuleLoader.pdb"))
            using (var fileStream = new FileStream(Path.Combine(fullPath, $"Bannerlord.ModuleLoader.{moduleId}.pdb"), FileMode.Create, FileAccess.Write))
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
            var validModuleName = FlatNameRegex(moduleName);
            type.Name = validModuleName;

            var ms = new MemoryStream();
            modifiedAss.Write(ms, new WriterParameters() { DeterministicMvid = true });
            ms.Seek(0, SeekOrigin.Begin);
            return ms;
        }

        private static string FlatNameRegex(string str) => new Regex("[^a-zA-Z0-9]", RegexOptions.Compiled).Replace(str, "_");

        private static string FlatName(string str) => new(str.Select((c, i) => IsValidInIdentifier(c, i == 0) ? c : '_').ToArray());
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