# Bannerlord.ModuleLoader

<p align="center">
  <a href="https://www.nuget.org/packages/Bannerlord.ModuleLoader" alt="NuGet Harmony">
    <img src="https://img.shields.io/nuget/v/Bannerlord.ModuleLoader.svg?label=NuGet%20Bannerlord.ModuleLoader&colorB=blue" />
  </a>
  <a href="https://www.nuget.org/packages/Bannerlord.ModuleLoader.Injector" alt="NuGet Harmony">
    <img src="https://img.shields.io/nuget/v/Bannerlord.ModuleLoader.Injector.svg?label=NuGet%20Bannerlord.ModuleLoader.Injector&colorB=blue" />
  </a>
</p>

Uses the new C# 9 Source Generator (could have used an MSBuild task) to generate a loader library for the implementation-loader technique.  

## Requirements
* Will add a requirement to the `Bannerlord.Harmony` module.
* Requires the `ModuleId` and `ModuleName` MSBuild property widely used in our BUTR stack. Should be the same as the mod's Module Id and Name.  
* Requires standard `MSBuildProjectFullPath` and `OutputPath` properties. Tampering with them will break the injector.  

## Installation
Install the [Bannerlord.ModuleLoader.Injector](https://github.com/BUTR/Bannerlord.ModuleLoader.Injector) package.

## Usage
Each build will create `Bannerlord.ModuleLoader.$(ModuleId).dll|.pdb` files.  

```xml
    <!-- Bannerlord Module Loader. Do not change the name! -->
    <SubModule>
      <Name value="Bannerlord Module Loader" />
      <DLLName value="Bannerlord.ModuleLoader.$moduleid$.dll" />
      <SubModuleClassType value="Bannerlord.ModuleLoader.$moduleid$" />
      <Tags>
        <Tag key="LoaderFilter" value ="$moduleid$.*.dll" />
      </Tags>
    </SubModule>
```

> **ℹ️ NOTE**  
> The `$moduleid$` and `$modulename$` properties is from BUTR's [Bannerlord.BuildResources](https://github.com/BUTR/Bannerlord.BuildResources), it injects MSBuild's $(ModuleId) and $(ModuleName) properties.  
> Just replace it with the actual Module Id if you don't use the package!

> **⚠️ ATTENTION**  
> If the Module Id contains invalid C# identity symbols (like dot '.'), override the `SubModuleClassType` property manually, replacing each invalid char as underscore `_`.
