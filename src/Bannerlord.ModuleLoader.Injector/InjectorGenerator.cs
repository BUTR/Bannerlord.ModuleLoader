using Microsoft.CodeAnalysis;

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

            var name = context.AnalyzerConfigOptions.GlobalOptions.TryGetValue("build_property.modulename", out var moduleName)
                ? $"{moduleName}.Loader"
                : $"{context.Compilation.Assembly.Name.Split('.').FirstOrDefault()}.Loader";

            using (var dllStream = typeof(InjectorGenerator).Assembly.GetManifestResourceStream("Bannerlord.ModuleLoader.dll"))
            using (var fileStream = new FileStream(Path.Combine(fullPath, $"{name}.dll"), FileMode.Create, FileAccess.Write))
            {
                dllStream?.CopyTo(fileStream);
            }

            using (var pdbStream = typeof(InjectorGenerator).Assembly.GetManifestResourceStream("Bannerlord.ModuleLoader.pdb"))
            using (var fileStream = new FileStream(Path.Combine(fullPath, $"{name}.pdb"), FileMode.Create, FileAccess.Write))
            {
                pdbStream?.CopyTo(fileStream);
            }
        }
    }
}