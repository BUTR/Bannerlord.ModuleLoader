using Bannerlord.BUTR.Shared.Helpers;
using Bannerlord.ModuleManager;

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;

using TaleWorlds.Core;
using TaleWorlds.MountAndBlade;

using AccessTools2 = HarmonyLib.BUTR.Extensions.AccessTools2;

namespace Bannerlord.ModuleLoader
{
    internal record ImplementationFile(FileInfo Implementation, ApplicationVersion Version);

    internal static class LoaderHelper
    {
        private delegate MBSubModuleBase ConstructorDelegate();

        private static ApplicationVersion? GameVersion() => ApplicationVersion.TryParse(ApplicationVersionHelper.GameVersionStr(), out var v) ? v : null;

        public static IEnumerable<MBSubModuleBase> LoadAllImplementations(string filterWildcard)
        {
            Trace.TraceInformation("Loading implementations...");

            var thisAssembly = typeof(LoaderHelper).Assembly;

            var assemblyFile = new FileInfo(thisAssembly.Location);
            if (!assemblyFile.Exists)
            {
                Trace.TraceError("Assembly file does not exists!");
                yield break;
            }

            var assemblyDirectory = assemblyFile.Directory;
            if (assemblyDirectory?.Exists != true)
            {
                Trace.TraceError("Assembly directory does not exists!");
                yield break;
            }

            var implementations = assemblyDirectory.GetFiles(filterWildcard);
            if (implementations.Length is 0)
            {
                Trace.TraceError("No implementations found.");
                yield break;
            }

            var gameVersion = GameVersion();
            if (gameVersion is null)
            {
                Trace.TraceError("Failed to get Game version!");
                yield break;
            }

            var loadedAssemblies = AppDomain.CurrentDomain.GetAssemblies()
                .Where(a => !a.IsDynamic && !string.IsNullOrEmpty(a.Location))
                .Select(a => Path.GetFileNameWithoutExtension(a.Location))
                .ToHashSet();

            var implementationsFiles = implementations
                .Where(x => !loadedAssemblies.Contains(Path.GetFileNameWithoutExtension(x.Name)))
                .ToList();

            var implementationsWithVersions = GetImplementations(implementationsFiles);
            if (implementationsWithVersions.Count is 0)
            {
                Trace.TraceError("No compatible implementations were found!");
                yield break;
            }

            var matchingImplementations = implementationsWithVersions.Where(i => gameVersion.IsSame(i.Version)).ToList();

            ImplementationFile? selectedImplementation;
            switch (matchingImplementations.Count)
            {
                case > 1:
                    Trace.TraceInformation("Found multiple matching implementations:");
                    foreach (var impl in matchingImplementations)
                        Trace.TraceInformation("Implementation {0} for game {1}", impl.Implementation.Name, impl.Version);

                    Trace.TraceInformation("Selecting the latest available implementation.");
                    selectedImplementation = SelectLatestImplementation(matchingImplementations);
                    break;
                case 1:
                    Trace.TraceInformation("Found one matching implementation.");
                    selectedImplementation = matchingImplementations.First();
                    break;
                default:
                    Trace.TraceInformation("No exact match found. Selecting the latest available implementation.");
                    selectedImplementation = SelectLatestImplementation(implementationsWithVersions);
                    break;
            }

            if (selectedImplementation is null) yield break;

            Trace.TraceInformation("Loading implementation {0} for game {1}", selectedImplementation.Implementation.Name, selectedImplementation.Version);

            var loadedAssembly = Assembly.LoadFrom(selectedImplementation.Implementation.FullName);

            var found = false;
            foreach (var subModule in LoadSubModules(loadedAssembly))
            {
                found = true;
                yield return subModule;
            }
            if (!found)
                Trace.TraceError("No implementation was initialized!");

            Trace.TraceInformation("Finished loading implementations.");
        }

        private static ImplementationFile? SelectLatestImplementation(IEnumerable<ImplementationFile> implementations)
        {
            return implementations.MaxBy(x => x.Version, new ApplicationVersionComparer(), out _);
        }

        private static IEnumerable<MBSubModuleBase> LoadSubModules(Assembly assembly)
        {
            var subModuleTypes = AccessTools2.GetTypesFromAssembly(assembly)
                .Where(t => !t.IsAbstract && typeof(MBSubModuleBase).IsAssignableFrom(t));

            foreach (var type in subModuleTypes)
            {
                var constructor = AccessTools2.Constructor(type, Type.EmptyTypes, logErrorInTrace: false);
                if (constructor is null)
                {
                    Trace.TraceError("SubModule {0} is missing a default constructor! Assembly: {1}", type.FullName, type.Assembly.FullName);
                    continue;
                }

                var constructorFunc = AccessTools2.GetDelegate<ConstructorDelegate>(constructor, logErrorInTrace: false);
                if (constructorFunc is null)
                {
                    Trace.TraceError("SubModule {0}'s default constructor could not be converted to a delegate! Assembly: {1}", type.FullName, assembly.FullName);
                    continue;
                }

                yield return constructorFunc();
            }
        }

        private static List<ImplementationFile> GetImplementations(IEnumerable<FileInfo> implementations)
        {
            var result = new List<ImplementationFile>();
            foreach (var implementation in implementations)
            {
                Trace.TraceInformation("Found implementation: {0}", implementation.Name);

                var gameVersion = ExtractGameVersion(implementation);
                if (gameVersion is null)
                {
                    Trace.TraceError("Implementation {0} is missing or has an invalid GameVersion AssemblyMetadataAttribute!", implementation.Name);
                    continue;
                }

                result.Add(new ImplementationFile(implementation, gameVersion));
            }
            return result;
        }

        private static ApplicationVersion? ExtractGameVersion(FileInfo implementation)
        {
            using var fs = File.OpenRead(implementation.FullName);
            using var peReader = new PEReader(fs);
            var mdReader = peReader.GetMetadataReader(MetadataReaderOptions.None);

            foreach (var attr in mdReader.GetAssemblyDefinition().GetCustomAttributes().Select(ah => mdReader.GetCustomAttribute(ah)))
            {
                var ctorHandle = attr.Constructor;
                if (ctorHandle.Kind is not HandleKind.MemberReference) continue;

                var container = mdReader.GetMemberReference((MemberReferenceHandle) ctorHandle).Parent;
                var name = mdReader.GetTypeReference((TypeReferenceHandle) container).Name;
                if (!string.Equals(mdReader.GetString(name), "AssemblyMetadataAttribute", StringComparison.Ordinal)) continue;

                var attributeReader = mdReader.GetBlobReader(attr.Value);
                attributeReader.ReadByte(); // Skip prolog
                attributeReader.ReadByte(); // Skip prolog
                var key = attributeReader.ReadSerializedString();
                var value = attributeReader.ReadSerializedString();

                if (string.Equals(key, "GameVersion", StringComparison.Ordinal) && ApplicationVersion.TryParse(value, out var version))
                    return version;
            }

            return null;
        }
    }
}