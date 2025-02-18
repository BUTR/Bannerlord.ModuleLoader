using Bannerlord.BUTR.Shared.Helpers;
using Bannerlord.ModuleLoader.SubModuleWrappers;
using Bannerlord.ModuleLoader.SubModuleWrappers.Patches;
using Bannerlord.ModuleManager;

using HarmonyLib;

using System;
using System.Diagnostics;
using System.Linq;

namespace Bannerlord.ModuleLoader
{
    public sealed class SubModule : MBSubModuleBaseListWrapper
    {
        private readonly ModuleInfoExtended? ModuleInfo;
        private readonly Harmony _harmonyWrappers;

        private bool ServiceRegistrationWasCalled { get; set; }

        public SubModule()
        {
            ModuleInfo = ModuleInfoHelper.GetModuleByType(typeof(LoaderHelper));
            _harmonyWrappers = new(ModuleInfo?.Id ?? "Bannerlord.ModuleLoader ERROR");
            _ = MBSubModuleBasePatch.Enable(_harmonyWrappers);
        }

        public override void OnServiceRegistration()
        {
            ServiceRegistrationWasCalled = true;

            Load();

            base.OnServiceRegistration();
        }

        public override void OnSubModuleLoad()
        {
            if (!ServiceRegistrationWasCalled)
            {
                Load();
            }

            base.OnSubModuleLoad();
        }

        private void Load()
        {
            if (ModuleInfo is null)
            {
                Trace.TraceError("Failed to find LoaderSubModule!");
                return;
            }

            var subModule = ModuleInfo.SubModules.FirstOrDefault(x => string.Equals(x.Name, "Bannerlord Module Loader", StringComparison.Ordinal));
            if (subModule is null)
            {
                Trace.TraceError("Failed to find 'Bannerlord Module Loader' in '{0}'!", ModuleInfo.Id);
                return;
            }

            var filter = subModule.Tags.TryGetValue("LoaderFilter", out var loaderFilter) ? loaderFilter.FirstOrDefault() : string.Empty;
            if (filter is null)
            {
                Trace.TraceError("Failed to find 'LoaderFilter' in 'Bannerlord Module Loader' in '{0}'!", ModuleInfo.Id);
                return;
            }

            var subModuleOrder = subModule.Tags.TryGetValue("LoaderSubModuleOrder", out var loaderSubModuleOrder) ? loaderSubModuleOrder : Array.Empty<string>();
            var indexLookup = subModuleOrder.Select((v, i) => (v, i)).ToDictionary(x => x.v, x => x.i);

            var implementations = LoaderHelper.LoadAllImplementations(filter).OrderBy(x => indexLookup.TryGetValue(x.GetType().FullName, out var val) ? val : int.MaxValue);
            _subModules.AddRange(implementations.Select(x => new MBSubModuleBaseWrapper(x)));
        }
    }
}