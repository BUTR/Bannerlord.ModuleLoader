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

            var implementationAssemblies = new List<Assembly>();

            var assemblies = AppDomain.CurrentDomain.GetAssemblies().Where(a => !a.IsDynamic).ToList();

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
            if (implementations.Length == 0)
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


            var implementationsFiles = implementations.Where(x => assemblies.All(a => Path.GetFileNameWithoutExtension(a.Location) != Path.GetFileNameWithoutExtension(x.Name)));
            var implementationsWithVersions = GetImplementations(implementationsFiles).ToList();
            if (implementationsWithVersions.Count == 0)
            {
                Trace.TraceError("No compatible implementations were found!");
                yield break;
            }

            var implementationsForGameVersion = ImplementationForGameVersion(gameVersion, implementationsWithVersions).ToList();
            switch (implementationsForGameVersion.Count)
            {
                case > 1:
                {
                    Trace.TraceInformation("Found multiple matching implementations:");
                    foreach (var (implementation1, version1) in implementationsForGameVersion)
                        Trace.TraceInformation("Implementation {0} for game {1}.", implementation1.Name, version1);


                    Trace.TraceInformation("Loading the latest available.");

                    var (implementation, version) = ImplementationLatest(implementationsForGameVersion);
                    Trace.TraceInformation("Implementation {0} for game {1} is loaded.", implementation.Name, version);
                    implementationAssemblies.Add(Assembly.LoadFrom(implementation.FullName));
                    break;
                }

                case 1:
                {
                    Trace.TraceInformation("Found matching implementation. Loading it.");

                    var (implementation, version) = implementationsForGameVersion[0];
                    Trace.TraceInformation("Implementation {0} for game {1} is loaded.", implementation.Name, version);
                    implementationAssemblies.Add(Assembly.LoadFrom(implementation.FullName));
                    break;
                }

                case 0:
                {
                    Trace.TraceInformation("Found no matching implementations. Loading the latest available.");

                    var (implementation, version) = ImplementationLatest(implementationsWithVersions);
                    Trace.TraceInformation("Implementation {0} for game {1} is loaded.", implementation.Name, version);
                    implementationAssemblies.Add(Assembly.LoadFrom(implementation.FullName));
                    break;
                }
            }

            var subModules = implementationAssemblies.SelectMany(a =>
            {
                try
                {
                    return AccessTools2.GetTypesFromAssembly(a).Where(t => typeof(MBSubModuleBase).IsAssignableFrom(t));
                }
                catch (ReflectionTypeLoadException e)
                {
                    Trace.TraceError("Implementation {0} is not compatible with the current game! Exception: {1}", Path.GetFileName(a.Location), e);
                    return e.Types.Where(t => typeof(MBSubModuleBase).IsAssignableFrom(t));
                }

            }).ToList();

            if (subModules.Count == 0)
                Trace.TraceError("No implementation was initialized!");

            foreach (var subModuleType in subModules)
            {
                var constructor = AccessTools2.Constructor(subModuleType, Type.EmptyTypes);
                if (constructor is null)
                {
                    Trace.TraceError("SubModule {0} is missing a default constructor!", subModuleType);
                    continue;
                }

                var constructorFunc = AccessTools2.GetDelegate<ConstructorDelegate>(constructor);
                if (constructorFunc is null)
                {
                    Trace.TraceError("SubModule {0}'s default constructor could not be converted to a delegate!", subModuleType);
                    continue;
                }

                yield return constructorFunc();
            }

            Trace.TraceInformation("Finished loading implementations.");
        }

        private static IEnumerable<ImplementationFile> GetImplementations(IEnumerable<FileInfo> implementations)
        {
            foreach (var implementation in implementations)
            {
                bool found = false;
                Trace.TraceInformation("Found implementation {0}.", implementation.Name);

                using var fs = File.OpenRead(implementation.FullName);
                using var peReader = new PEReader(fs);
                var mdReader = peReader.GetMetadataReader(MetadataReaderOptions.None);
                foreach (var attr in mdReader.GetAssemblyDefinition().GetCustomAttributes().Select(ah => mdReader.GetCustomAttribute(ah)))
                {
                    var ctorHandle = attr.Constructor;
                    if (ctorHandle.Kind != HandleKind.MemberReference) continue;

                    var container = mdReader.GetMemberReference((MemberReferenceHandle) ctorHandle).Parent;
                    var name = mdReader.GetTypeReference((TypeReferenceHandle) container).Name;
                    if (!string.Equals(mdReader.GetString(name), "AssemblyMetadataAttribute", StringComparison.Ordinal)) continue;

                    var attributeReader = mdReader.GetBlobReader(attr.Value);
                    attributeReader.ReadByte();
                    attributeReader.ReadByte();
                    var key = attributeReader.ReadSerializedString();
                    var value = attributeReader.ReadSerializedString();
                    if (string.Equals(key, "GameVersion", StringComparison.Ordinal))
                    {
                        if (!ApplicationVersion.TryParse(value, out var implementationGameVersion))
                        {
                            Trace.TraceError("Implementation {0} has invalid GameVersion AssemblyMetadataAttribute!", implementation.Name);
                            continue;
                        }

                        found = true;
                        yield return new(implementation, implementationGameVersion);
                        break;
                    }
                }

                if (!found)
                    Trace.TraceError("Implementation {0} is missing GameVersion AssemblyMetadataAttribute!", implementation.Name);
            }
        }

        private static IEnumerable<ImplementationFile> ImplementationForGameVersion(ApplicationVersion gameVersion, IEnumerable<ImplementationFile> implementations)
        {
            foreach (var (implementation, version) in implementations)
            {
                if (gameVersion.IsSame(version))
                {
                    yield return new(implementation, version);
                }
            }
        }
        private static ImplementationFile ImplementationLatest(IEnumerable<ImplementationFile> implementations)
        {
            return implementations.MaxBy(x => x.Version, new ApplicationVersionComparer(), out _);
        }
    }
}