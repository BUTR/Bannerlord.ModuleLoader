using Bannerlord.BUTR.Shared.Helpers;
using Bannerlord.ModuleLoader.SubModuleWrappers;
using Bannerlord.ModuleLoader.SubModuleWrappers.Patches;
using Bannerlord.ModuleManager;

using HarmonyLib;

using System;
using System.Diagnostics;
using System.Linq;

namespace Bannerlord.ModuleLoader;

public sealed class SubModule : MBSubModuleBaseListWrapper
{
    private readonly ModuleInfoExtended? ModuleInfo;
    private readonly Harmony _harmonyWrappers;

    private bool ServiceRegistrationWasCalled { get; set; }

    public SubModule()
    {
        ModuleInfo = ModuleInfoHelper.GetModuleByType(typeof(LoaderHelper));
        _harmonyWrappers = new(ModuleInfo?.Id ?? $"Bannerlord.ModuleLoader '{typeof(SubModule).Assembly.GetName().Name}' ERROR");
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
        var dllName = typeof(SubModule).Assembly.GetName().Name;
        
        if (ModuleInfo is null)
        {
            Trace.TraceError("Failed to find ModuleInfo for '{0}!", dllName);
            return;
        }

        var subModule = ModuleInfo.SubModules.FirstOrDefault(x => string.Equals(x.DLLName, dllName, StringComparison.Ordinal));
        if (subModule is null)
        {
            Trace.TraceError("Failed to find SubModule entry for '{0}' in '1'!", dllName, ModuleInfo.Id);
            return;
        }

        var filter = subModule.Tags.TryGetValue("LoaderFilter", out var loaderFilter) ? loaderFilter.FirstOrDefault() : string.Empty;
        if (filter is null)
        {
            Trace.TraceError("Failed to find 'LoaderFilter' in '{0}' in '{1}'!", subModule.Name, ModuleInfo.Id);
            return;
        }
        
        var subModuleOrder = subModule.Tags.TryGetValue("LoaderSubModuleOrder", out var loaderSubModuleOrder) ? loaderSubModuleOrder : [];
        var indexLookup = subModuleOrder.Select((v, i) => (v, i)).ToDictionary(x => x.v, x => x.i);
        
        var optionals = subModule.Tags.TryGetValue("LoadIfModulePresent", out var loadIfModulePresent) ? loadIfModulePresent : [];
        var modulesNames = optionals.Count > 0 ? TaleWorlds.Engine.Utilities.GetModulesNames() : [];
        if (optionals.Any(optional => !modulesNames.Contains(optional)))
        {
            Trace.TraceInformation("Skipping loading implementations for '{0}' because one or more required modules are missing!", ModuleInfo.Id);
            return;
        }

        var implementations = LoaderHelper.LoadAllImplementations(filter).OrderBy(x => indexLookup.TryGetValue(x.GetType().FullName, out var val) ? val : int.MaxValue);
        _subModules.AddRange(implementations.Select(x => new MBSubModuleBaseWrapper(x)));
    }
}