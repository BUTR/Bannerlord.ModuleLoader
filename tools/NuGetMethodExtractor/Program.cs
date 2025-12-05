using Mono.Cecil;
using NuGet.Common;
using NuGet.Protocol;
using NuGet.Protocol.Core.Types;
using NuGet.Versioning;
using System.IO.Compression;
using System.Text;

const string PackageId = "Bannerlord.ReferenceAssemblies.Core";
const string TargetDll = "TaleWorlds.MountAndBlade.dll";
const string TargetType = "TaleWorlds.MountAndBlade.MBSubModuleBase";

var cache = new SourceCacheContext();
var repository = Repository.Factory.GetCoreV3("https://api.nuget.org/v3/index.json");
var resource = await repository.GetResourceAsync<FindPackageByIdResource>();

Console.WriteLine($"Fetching versions of {PackageId}...");
var versions = await resource.GetAllVersionsAsync(PackageId, cache, NullLogger.Instance, CancellationToken.None);
var versionList = versions.OrderBy(v => v).ToList();

Console.WriteLine($"Found {versionList.Count} versions");

var allMethods = new Dictionary<NuGetVersion, List<MethodSignature>>();
var tempDir = Path.Combine(Path.GetTempPath(), "NuGetMethodExtractor");
Directory.CreateDirectory(tempDir);

foreach (var version in versionList)
{
    Console.WriteLine($"\nProcessing version {version}...");

    var packagePath = Path.Combine(tempDir, $"{PackageId}.{version}.nupkg");

    // Download if not cached
    if (!File.Exists(packagePath))
    {
        using var packageStream = File.Create(packagePath);
        var downloaded = await resource.CopyNupkgToStreamAsync(
            PackageId, version, packageStream, cache, NullLogger.Instance, CancellationToken.None);

        if (!downloaded)
        {
            Console.WriteLine($"  Failed to download version {version}");
            continue;
        }
    }

    // Extract and analyze
    try
    {
        using var archive = ZipFile.OpenRead(packagePath);
        var dllEntry = archive.Entries.FirstOrDefault(e => e.FullName.EndsWith(TargetDll, StringComparison.OrdinalIgnoreCase));

        if (dllEntry == null)
        {
            Console.WriteLine($"  {TargetDll} not found in package");
            continue;
        }

        var extractPath = Path.Combine(tempDir, $"{version}", dllEntry.FullName);
        Directory.CreateDirectory(Path.GetDirectoryName(extractPath)!);

        if (!File.Exists(extractPath))
        {
            dllEntry.ExtractToFile(extractPath, overwrite: true);
        }

        var methods = ExtractMethods(extractPath);
        allMethods[version] = methods;

        Console.WriteLine($"  Found {methods.Count} methods in {TargetType}");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"  Error processing: {ex.Message}");
    }
}

// Generate report
Console.WriteLine("\n\n========================================");
Console.WriteLine("METHOD SIGNATURES ACROSS ALL VERSIONS");
Console.WriteLine("========================================\n");

// Group methods by signature to track changes
var methodsBySignature = new Dictionary<string, List<(NuGetVersion Version, MethodSignature Method)>>();

foreach (var (version, methods) in allMethods.OrderBy(x => x.Key))
{
    foreach (var method in methods)
    {
        var key = method.FullSignature;
        if (!methodsBySignature.ContainsKey(key))
            methodsBySignature[key] = new List<(NuGetVersion, MethodSignature)>();
        methodsBySignature[key].Add((version, method));
    }
}

// Output grouped by method name
var methodsByName = methodsBySignature
    .GroupBy(x => x.Value.First().Method.Name)
    .OrderBy(x => x.Key);

var sb = new StringBuilder();
sb.AppendLine("# MBSubModuleBase Method Signatures Across Versions\n");

// Add consolidated list of all unique methods
sb.AppendLine("## All Available Methods (Union of All Versions)\n");
sb.AppendLine("This is the complete list of all methods that exist in any version of `MBSubModuleBase`.\n");
sb.AppendLine("```csharp");

var allUniqueSignatures = methodsBySignature
    .Select(kvp => (Signature: kvp.Key, Method: kvp.Value.First().Method, FirstVersion: kvp.Value.Min(x => x.Version)))
    .OrderBy(x => x.Method.Name)
    .ThenBy(x => x.FirstVersion)
    .ToList();

foreach (var (signature, method, firstVersion) in allUniqueSignatures)
{
    // Skip constructor
    if (method.Name == ".ctor") continue;
    sb.AppendLine(signature);
}
sb.AppendLine("```\n");

// Add a summary table
sb.AppendLine("## Method Availability Summary\n");
sb.AppendLine("| Method | First Available | Access | Modifiers |");
sb.AppendLine("|--------|-----------------|--------|-----------|");

foreach (var (signature, method, firstVersion) in allUniqueSignatures)
{
    if (method.Name == ".ctor") continue;

    var access = method.IsPublic ? "public" : method.IsProtected ? "protected" : "private";
    var modifiers = method.IsAbstract ? "abstract" : method.IsVirtual ? "virtual" : "";

    sb.AppendLine($"| `{method.Name}` | {firstVersion} | {access} | {modifiers} |");
}
sb.AppendLine();

sb.AppendLine("---\n");
sb.AppendLine("# Method Details By Name\n");

foreach (var nameGroup in methodsByName)
{
    sb.AppendLine($"## {nameGroup.Key}\n");

    foreach (var sigGroup in nameGroup.OrderBy(x => x.Key))
    {
        var firstVersion = sigGroup.Value.Min(x => x.Version);
        var lastVersion = sigGroup.Value.Max(x => x.Version);
        var sample = sigGroup.Value.First().Method;

        sb.AppendLine($"### Versions {firstVersion} - {lastVersion}\n");
        sb.AppendLine("```csharp");
        sb.AppendLine(sample.FullSignature);
        sb.AppendLine("```\n");
    }
}

// Also create a version-by-version listing
sb.AppendLine("\n# Full Listing By Version\n");

foreach (var (version, methods) in allMethods.OrderBy(x => x.Key))
{
    sb.AppendLine($"## Version {version}\n");
    sb.AppendLine("```csharp");
    foreach (var method in methods.OrderBy(m => m.Name))
    {
        sb.AppendLine(method.FullSignature);
    }
    sb.AppendLine("```\n");
}

var outputPath = "MBSubModuleBase_Methods.md";
File.WriteAllText(outputPath, sb.ToString());
Console.WriteLine($"\nReport saved to: {Path.GetFullPath(outputPath)}");

// Also output to console
Console.WriteLine(sb.ToString());

static List<MethodSignature> ExtractMethods(string dllPath)
{
    var methods = new List<MethodSignature>();

    using var assembly = AssemblyDefinition.ReadAssembly(dllPath, new ReaderParameters { ReadSymbols = false });
    var type = assembly.MainModule.Types.FirstOrDefault(t => t.FullName == TargetType);

    if (type == null)
        return methods;

    foreach (var method in type.Methods)
    {
        // Skip compiler-generated methods, property accessors we'll handle separately
        if (method.IsCompilerControlled || method.Name.StartsWith("<"))
            continue;

        var sig = new MethodSignature
        {
            Name = method.Name,
            ReturnType = FormatType(method.ReturnType),
            Parameters = method.Parameters.Select(p => new ParameterSignature
            {
                Name = p.Name,
                Type = FormatType(p.ParameterType),
                IsOut = p.IsOut,
                IsRef = p.ParameterType.IsByReference && !p.IsOut,
                HasDefault = p.HasDefault,
                DefaultValue = p.HasDefault ? p.Constant?.ToString() : null
            }).ToList(),
            IsVirtual = method.IsVirtual,
            IsAbstract = method.IsAbstract,
            IsStatic = method.IsStatic,
            IsProtected = method.IsFamily || method.IsFamilyOrAssembly,
            IsPublic = method.IsPublic,
            IsPrivate = method.IsPrivate,
            GenericParameters = method.GenericParameters.Select(g => g.Name).ToList()
        };

        methods.Add(sig);
    }

    return methods;
}

static string FormatType(TypeReference type)
{
    if (type is GenericInstanceType git)
    {
        var baseName = git.ElementType.Name;
        if (baseName.Contains('`'))
            baseName = baseName.Substring(0, baseName.IndexOf('`'));
        var args = string.Join(", ", git.GenericArguments.Select(FormatType));
        return $"{baseName}<{args}>";
    }

    if (type.IsByReference)
    {
        var elementType = ((ByReferenceType)type).ElementType;
        return FormatType(elementType);
    }

    if (type.IsArray)
    {
        var elementType = ((ArrayType)type).ElementType;
        return $"{FormatType(elementType)}[]";
    }

    // Simplify common types
    return type.Name switch
    {
        "Void" => "void",
        "Boolean" => "bool",
        "Int32" => "int",
        "Int64" => "long",
        "Single" => "float",
        "Double" => "double",
        "String" => "string",
        "Object" => "object",
        _ => type.Name
    };
}

record MethodSignature
{
    public required string Name { get; init; }
    public required string ReturnType { get; init; }
    public required List<ParameterSignature> Parameters { get; init; }
    public required bool IsVirtual { get; init; }
    public required bool IsAbstract { get; init; }
    public required bool IsStatic { get; init; }
    public required bool IsProtected { get; init; }
    public required bool IsPublic { get; init; }
    public required bool IsPrivate { get; init; }
    public required List<string> GenericParameters { get; init; }

    public string FullSignature
    {
        get
        {
            var sb = new StringBuilder();

            // Access modifier
            if (IsPublic) sb.Append("public ");
            else if (IsProtected) sb.Append("protected ");
            else if (IsPrivate) sb.Append("private ");

            // Modifiers
            if (IsStatic) sb.Append("static ");
            if (IsAbstract) sb.Append("abstract ");
            else if (IsVirtual) sb.Append("virtual ");

            // Return type
            sb.Append(ReturnType);
            sb.Append(' ');

            // Method name
            sb.Append(Name);

            // Generic parameters
            if (GenericParameters.Count > 0)
            {
                sb.Append('<');
                sb.Append(string.Join(", ", GenericParameters));
                sb.Append('>');
            }

            // Parameters
            sb.Append('(');
            var paramStrings = Parameters.Select(p =>
            {
                var paramSb = new StringBuilder();
                if (p.IsOut) paramSb.Append("out ");
                else if (p.IsRef) paramSb.Append("ref ");
                paramSb.Append(p.Type);
                paramSb.Append(' ');
                paramSb.Append(p.Name);
                if (p.HasDefault)
                {
                    paramSb.Append(" = ");
                    paramSb.Append(p.DefaultValue ?? "default");
                }
                return paramSb.ToString();
            });
            sb.Append(string.Join(", ", paramStrings));
            sb.Append(')');

            return sb.ToString();
        }
    }
}

record ParameterSignature
{
    public required string Name { get; init; }
    public required string Type { get; init; }
    public required bool IsOut { get; init; }
    public required bool IsRef { get; init; }
    public required bool HasDefault { get; init; }
    public string? DefaultValue { get; init; }
}
