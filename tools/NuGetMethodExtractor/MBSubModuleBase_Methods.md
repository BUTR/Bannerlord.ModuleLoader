# MBSubModuleBase Method Signatures Across Versions

## All Available Methods (Union of All Versions)

This is the complete list of all methods that exist in any version of `MBSubModuleBase`.

```csharp
protected virtual void AfterAsyncTickTick(float dt)
public virtual void AfterRegisterSubModuleObjects(bool isSavedCampaign)
public virtual void BeginGameStart(Game game)
public virtual bool DoLoading(Game game)
protected virtual void InitializeGameStarter(Game game, IGameStarter starterObject)
public virtual void InitializeSubModuleGameObjects(Game game)
public virtual void OnAfterGameInitializationFinished(Game game, object starterObject)
public virtual void OnAfterGameLoaded(Game game)
protected virtual void OnApplicationTick(float dt)
protected virtual void OnBeforeGameStart(MBGameManager mbGameManager, List<string> disabledModules)
protected virtual void OnBeforeInitialModuleScreenSetAsRoot()
public virtual void OnBeforeMissionBehaviorInitialize(Mission mission)
public virtual void OnCampaignStart(Game game, object starterObject)
public virtual void OnConfigChanged()
public virtual void OnGameEnd(Game game)
public virtual void OnGameInitializationFinished(Game game)
public virtual void OnGameLoaded(Game game, object initializerObject)
protected virtual void OnGameStart(Game game, IGameStarter gameStarterObject)
public virtual void OnInitialState()
public virtual void OnMissionBehaviorInitialize(Mission mission)
public virtual void OnMultiplayerGameStart(Game game, object starterObject)
protected virtual void OnNetworkTick(float dt)
public virtual void OnNewGameCreated(Game game, object initializerObject)
protected virtual void OnNewModuleLoad()
public virtual void OnSubModuleActivated()
public virtual void OnSubModuleDeactivated()
protected virtual void OnSubModuleLoad()
protected virtual void OnSubModuleUnloaded()
public virtual void RegisterSubModuleObjects(bool isSavedCampaign)
protected virtual void RegisterSubModuleTypes()
```

## Method Availability Summary

| Method | First Available | Access | Modifiers |
|--------|-----------------|--------|-----------|
| `AfterAsyncTickTick` | 1.0.0.3624 | protected | virtual |
| `AfterRegisterSubModuleObjects` | 1.0.0.3624 | public | virtual |
| `BeginGameStart` | 1.0.0.3624 | public | virtual |
| `DoLoading` | 1.0.0.3624 | public | virtual |
| `InitializeGameStarter` | 1.0.0.3624 | protected | virtual |
| `InitializeSubModuleGameObjects` | 1.3.0.89406-beta | public | virtual |
| `OnAfterGameInitializationFinished` | 1.0.0.3624 | public | virtual |
| `OnAfterGameLoaded` | 1.3.0.89406-beta | public | virtual |
| `OnApplicationTick` | 1.0.0.3624 | protected | virtual |
| `OnBeforeGameStart` | 1.3.0.89406-beta | protected | virtual |
| `OnBeforeInitialModuleScreenSetAsRoot` | 1.0.0.3624 | protected | virtual |
| `OnBeforeMissionBehaviorInitialize` | 1.0.0.3624 | public | virtual |
| `OnCampaignStart` | 1.0.0.3624 | public | virtual |
| `OnConfigChanged` | 1.0.0.3624 | public | virtual |
| `OnGameEnd` | 1.0.0.3624 | public | virtual |
| `OnGameInitializationFinished` | 1.0.0.3624 | public | virtual |
| `OnGameLoaded` | 1.0.0.3624 | public | virtual |
| `OnGameStart` | 1.0.0.3624 | protected | virtual |
| `OnInitialState` | 1.0.0.3624 | public | virtual |
| `OnMissionBehaviorInitialize` | 1.0.0.3624 | public | virtual |
| `OnMultiplayerGameStart` | 1.0.0.3624 | public | virtual |
| `OnNetworkTick` | 1.2.0.21654-beta | protected | virtual |
| `OnNewGameCreated` | 1.0.0.3624 | public | virtual |
| `OnNewModuleLoad` | 1.3.0.89406-beta | protected | virtual |
| `OnSubModuleActivated` | 1.3.0.89406-beta | public | virtual |
| `OnSubModuleDeactivated` | 1.3.0.89406-beta | public | virtual |
| `OnSubModuleLoad` | 1.0.0.3624 | protected | virtual |
| `OnSubModuleUnloaded` | 1.0.0.3624 | protected | virtual |
| `RegisterSubModuleObjects` | 1.0.0.3624 | public | virtual |
| `RegisterSubModuleTypes` | 1.3.0.89406-beta | protected | virtual |

---

# Method Details By Name

## .ctor

### Versions 1.0.0.3624 - 1.3.9.103334

```csharp
protected void .ctor()
```

## AfterAsyncTickTick

### Versions 1.0.0.3624 - 1.3.9.103334

```csharp
protected virtual void AfterAsyncTickTick(float dt)
```

## AfterRegisterSubModuleObjects

### Versions 1.0.0.3624 - 1.3.9.103334

```csharp
public virtual void AfterRegisterSubModuleObjects(bool isSavedCampaign)
```

## BeginGameStart

### Versions 1.0.0.3624 - 1.3.9.103334

```csharp
public virtual void BeginGameStart(Game game)
```

## DoLoading

### Versions 1.0.0.3624 - 1.3.9.103334

```csharp
public virtual bool DoLoading(Game game)
```

## InitializeGameStarter

### Versions 1.0.0.3624 - 1.3.9.103334

```csharp
protected virtual void InitializeGameStarter(Game game, IGameStarter starterObject)
```

## InitializeSubModuleGameObjects

### Versions 1.3.0.89406-beta - 1.3.9.103334

```csharp
public virtual void InitializeSubModuleGameObjects(Game game)
```

## OnAfterGameInitializationFinished

### Versions 1.0.0.3624 - 1.3.9.103334

```csharp
public virtual void OnAfterGameInitializationFinished(Game game, object starterObject)
```

## OnAfterGameLoaded

### Versions 1.3.0.89406-beta - 1.3.9.103334

```csharp
public virtual void OnAfterGameLoaded(Game game)
```

## OnApplicationTick

### Versions 1.0.0.3624 - 1.3.9.103334

```csharp
protected virtual void OnApplicationTick(float dt)
```

## OnBeforeGameStart

### Versions 1.3.0.89406-beta - 1.3.9.103334

```csharp
protected virtual void OnBeforeGameStart(MBGameManager mbGameManager, List<string> disabledModules)
```

## OnBeforeInitialModuleScreenSetAsRoot

### Versions 1.0.0.3624 - 1.3.9.103334

```csharp
protected virtual void OnBeforeInitialModuleScreenSetAsRoot()
```

## OnBeforeMissionBehaviorInitialize

### Versions 1.0.0.3624 - 1.3.9.103334

```csharp
public virtual void OnBeforeMissionBehaviorInitialize(Mission mission)
```

## OnCampaignStart

### Versions 1.0.0.3624 - 1.3.9.103334

```csharp
public virtual void OnCampaignStart(Game game, object starterObject)
```

## OnConfigChanged

### Versions 1.0.0.3624 - 1.3.9.103334

```csharp
public virtual void OnConfigChanged()
```

## OnGameEnd

### Versions 1.0.0.3624 - 1.3.9.103334

```csharp
public virtual void OnGameEnd(Game game)
```

## OnGameInitializationFinished

### Versions 1.0.0.3624 - 1.3.9.103334

```csharp
public virtual void OnGameInitializationFinished(Game game)
```

## OnGameLoaded

### Versions 1.0.0.3624 - 1.3.9.103334

```csharp
public virtual void OnGameLoaded(Game game, object initializerObject)
```

## OnGameStart

### Versions 1.0.0.3624 - 1.3.9.103334

```csharp
protected virtual void OnGameStart(Game game, IGameStarter gameStarterObject)
```

## OnInitialState

### Versions 1.0.0.3624 - 1.3.9.103334

```csharp
public virtual void OnInitialState()
```

## OnMissionBehaviorInitialize

### Versions 1.0.0.3624 - 1.3.9.103334

```csharp
public virtual void OnMissionBehaviorInitialize(Mission mission)
```

## OnMultiplayerGameStart

### Versions 1.0.0.3624 - 1.3.9.103334

```csharp
public virtual void OnMultiplayerGameStart(Game game, object starterObject)
```

## OnNetworkTick

### Versions 1.2.0.21654-beta - 1.3.9.103334

```csharp
protected virtual void OnNetworkTick(float dt)
```

## OnNewGameCreated

### Versions 1.0.0.3624 - 1.3.9.103334

```csharp
public virtual void OnNewGameCreated(Game game, object initializerObject)
```

## OnNewModuleLoad

### Versions 1.3.0.89406-beta - 1.3.9.103334

```csharp
protected virtual void OnNewModuleLoad()
```

## OnSubModuleActivated

### Versions 1.3.0.89406-beta - 1.3.9.103334

```csharp
public virtual void OnSubModuleActivated()
```

## OnSubModuleDeactivated

### Versions 1.3.0.89406-beta - 1.3.9.103334

```csharp
public virtual void OnSubModuleDeactivated()
```

## OnSubModuleLoad

### Versions 1.0.0.3624 - 1.3.9.103334

```csharp
protected virtual void OnSubModuleLoad()
```

## OnSubModuleUnloaded

### Versions 1.0.0.3624 - 1.3.9.103334

```csharp
protected virtual void OnSubModuleUnloaded()
```

## RegisterSubModuleObjects

### Versions 1.0.0.3624 - 1.3.9.103334

```csharp
public virtual void RegisterSubModuleObjects(bool isSavedCampaign)
```

## RegisterSubModuleTypes

### Versions 1.3.0.89406-beta - 1.3.9.103334

```csharp
protected virtual void RegisterSubModuleTypes()
```


# Full Listing By Version

## Version 1.0.0.3624

```csharp
protected void .ctor()
protected virtual void AfterAsyncTickTick(float dt)
public virtual void AfterRegisterSubModuleObjects(bool isSavedCampaign)
public virtual void BeginGameStart(Game game)
public virtual bool DoLoading(Game game)
protected virtual void InitializeGameStarter(Game game, IGameStarter starterObject)
public virtual void OnAfterGameInitializationFinished(Game game, object starterObject)
protected virtual void OnApplicationTick(float dt)
protected virtual void OnBeforeInitialModuleScreenSetAsRoot()
public virtual void OnBeforeMissionBehaviorInitialize(Mission mission)
public virtual void OnCampaignStart(Game game, object starterObject)
public virtual void OnConfigChanged()
public virtual void OnGameEnd(Game game)
public virtual void OnGameInitializationFinished(Game game)
public virtual void OnGameLoaded(Game game, object initializerObject)
protected virtual void OnGameStart(Game game, IGameStarter gameStarterObject)
public virtual void OnInitialState()
public virtual void OnMissionBehaviorInitialize(Mission mission)
public virtual void OnMultiplayerGameStart(Game game, object starterObject)
public virtual void OnNewGameCreated(Game game, object initializerObject)
protected virtual void OnSubModuleLoad()
protected virtual void OnSubModuleUnloaded()
public virtual void RegisterSubModuleObjects(bool isSavedCampaign)
```

## Version 1.0.0.3729

```csharp
protected void .ctor()
protected virtual void AfterAsyncTickTick(float dt)
public virtual void AfterRegisterSubModuleObjects(bool isSavedCampaign)
public virtual void BeginGameStart(Game game)
public virtual bool DoLoading(Game game)
protected virtual void InitializeGameStarter(Game game, IGameStarter starterObject)
public virtual void OnAfterGameInitializationFinished(Game game, object starterObject)
protected virtual void OnApplicationTick(float dt)
protected virtual void OnBeforeInitialModuleScreenSetAsRoot()
public virtual void OnBeforeMissionBehaviorInitialize(Mission mission)
public virtual void OnCampaignStart(Game game, object starterObject)
public virtual void OnConfigChanged()
public virtual void OnGameEnd(Game game)
public virtual void OnGameInitializationFinished(Game game)
public virtual void OnGameLoaded(Game game, object initializerObject)
protected virtual void OnGameStart(Game game, IGameStarter gameStarterObject)
public virtual void OnInitialState()
public virtual void OnMissionBehaviorInitialize(Mission mission)
public virtual void OnMultiplayerGameStart(Game game, object starterObject)
public virtual void OnNewGameCreated(Game game, object initializerObject)
protected virtual void OnSubModuleLoad()
protected virtual void OnSubModuleUnloaded()
public virtual void RegisterSubModuleObjects(bool isSavedCampaign)
```

## Version 1.0.0.4373

```csharp
protected void .ctor()
protected virtual void AfterAsyncTickTick(float dt)
public virtual void AfterRegisterSubModuleObjects(bool isSavedCampaign)
public virtual void BeginGameStart(Game game)
public virtual bool DoLoading(Game game)
protected virtual void InitializeGameStarter(Game game, IGameStarter starterObject)
public virtual void OnAfterGameInitializationFinished(Game game, object starterObject)
protected virtual void OnApplicationTick(float dt)
protected virtual void OnBeforeInitialModuleScreenSetAsRoot()
public virtual void OnBeforeMissionBehaviorInitialize(Mission mission)
public virtual void OnCampaignStart(Game game, object starterObject)
public virtual void OnConfigChanged()
public virtual void OnGameEnd(Game game)
public virtual void OnGameInitializationFinished(Game game)
public virtual void OnGameLoaded(Game game, object initializerObject)
protected virtual void OnGameStart(Game game, IGameStarter gameStarterObject)
public virtual void OnInitialState()
public virtual void OnMissionBehaviorInitialize(Mission mission)
public virtual void OnMultiplayerGameStart(Game game, object starterObject)
public virtual void OnNewGameCreated(Game game, object initializerObject)
protected virtual void OnSubModuleLoad()
protected virtual void OnSubModuleUnloaded()
public virtual void RegisterSubModuleObjects(bool isSavedCampaign)
```

## Version 1.0.0.4407

```csharp
protected void .ctor()
protected virtual void AfterAsyncTickTick(float dt)
public virtual void AfterRegisterSubModuleObjects(bool isSavedCampaign)
public virtual void BeginGameStart(Game game)
public virtual bool DoLoading(Game game)
protected virtual void InitializeGameStarter(Game game, IGameStarter starterObject)
public virtual void OnAfterGameInitializationFinished(Game game, object starterObject)
protected virtual void OnApplicationTick(float dt)
protected virtual void OnBeforeInitialModuleScreenSetAsRoot()
public virtual void OnBeforeMissionBehaviorInitialize(Mission mission)
public virtual void OnCampaignStart(Game game, object starterObject)
public virtual void OnConfigChanged()
public virtual void OnGameEnd(Game game)
public virtual void OnGameInitializationFinished(Game game)
public virtual void OnGameLoaded(Game game, object initializerObject)
protected virtual void OnGameStart(Game game, IGameStarter gameStarterObject)
public virtual void OnInitialState()
public virtual void OnMissionBehaviorInitialize(Mission mission)
public virtual void OnMultiplayerGameStart(Game game, object starterObject)
public virtual void OnNewGameCreated(Game game, object initializerObject)
protected virtual void OnSubModuleLoad()
protected virtual void OnSubModuleUnloaded()
public virtual void RegisterSubModuleObjects(bool isSavedCampaign)
```

## Version 1.0.0.44071

```csharp
protected void .ctor()
protected virtual void AfterAsyncTickTick(float dt)
public virtual void AfterRegisterSubModuleObjects(bool isSavedCampaign)
public virtual void BeginGameStart(Game game)
public virtual bool DoLoading(Game game)
protected virtual void InitializeGameStarter(Game game, IGameStarter starterObject)
public virtual void OnAfterGameInitializationFinished(Game game, object starterObject)
protected virtual void OnApplicationTick(float dt)
protected virtual void OnBeforeInitialModuleScreenSetAsRoot()
public virtual void OnBeforeMissionBehaviorInitialize(Mission mission)
public virtual void OnCampaignStart(Game game, object starterObject)
public virtual void OnConfigChanged()
public virtual void OnGameEnd(Game game)
public virtual void OnGameInitializationFinished(Game game)
public virtual void OnGameLoaded(Game game, object initializerObject)
protected virtual void OnGameStart(Game game, IGameStarter gameStarterObject)
public virtual void OnInitialState()
public virtual void OnMissionBehaviorInitialize(Mission mission)
public virtual void OnMultiplayerGameStart(Game game, object starterObject)
public virtual void OnNewGameCreated(Game game, object initializerObject)
protected virtual void OnSubModuleLoad()
protected virtual void OnSubModuleUnloaded()
public virtual void RegisterSubModuleObjects(bool isSavedCampaign)
```

## Version 1.0.1.4441

```csharp
protected void .ctor()
protected virtual void AfterAsyncTickTick(float dt)
public virtual void AfterRegisterSubModuleObjects(bool isSavedCampaign)
public virtual void BeginGameStart(Game game)
public virtual bool DoLoading(Game game)
protected virtual void InitializeGameStarter(Game game, IGameStarter starterObject)
public virtual void OnAfterGameInitializationFinished(Game game, object starterObject)
protected virtual void OnApplicationTick(float dt)
protected virtual void OnBeforeInitialModuleScreenSetAsRoot()
public virtual void OnBeforeMissionBehaviorInitialize(Mission mission)
public virtual void OnCampaignStart(Game game, object starterObject)
public virtual void OnConfigChanged()
public virtual void OnGameEnd(Game game)
public virtual void OnGameInitializationFinished(Game game)
public virtual void OnGameLoaded(Game game, object initializerObject)
protected virtual void OnGameStart(Game game, IGameStarter gameStarterObject)
public virtual void OnInitialState()
public virtual void OnMissionBehaviorInitialize(Mission mission)
public virtual void OnMultiplayerGameStart(Game game, object starterObject)
public virtual void OnNewGameCreated(Game game, object initializerObject)
protected virtual void OnSubModuleLoad()
protected virtual void OnSubModuleUnloaded()
public virtual void RegisterSubModuleObjects(bool isSavedCampaign)
```

## Version 1.0.1.4833

```csharp
protected void .ctor()
protected virtual void AfterAsyncTickTick(float dt)
public virtual void AfterRegisterSubModuleObjects(bool isSavedCampaign)
public virtual void BeginGameStart(Game game)
public virtual bool DoLoading(Game game)
protected virtual void InitializeGameStarter(Game game, IGameStarter starterObject)
public virtual void OnAfterGameInitializationFinished(Game game, object starterObject)
protected virtual void OnApplicationTick(float dt)
protected virtual void OnBeforeInitialModuleScreenSetAsRoot()
public virtual void OnBeforeMissionBehaviorInitialize(Mission mission)
public virtual void OnCampaignStart(Game game, object starterObject)
public virtual void OnConfigChanged()
public virtual void OnGameEnd(Game game)
public virtual void OnGameInitializationFinished(Game game)
public virtual void OnGameLoaded(Game game, object initializerObject)
protected virtual void OnGameStart(Game game, IGameStarter gameStarterObject)
public virtual void OnInitialState()
public virtual void OnMissionBehaviorInitialize(Mission mission)
public virtual void OnMultiplayerGameStart(Game game, object starterObject)
public virtual void OnNewGameCreated(Game game, object initializerObject)
protected virtual void OnSubModuleLoad()
protected virtual void OnSubModuleUnloaded()
public virtual void RegisterSubModuleObjects(bool isSavedCampaign)
```

## Version 1.0.1.5218

```csharp
protected void .ctor()
protected virtual void AfterAsyncTickTick(float dt)
public virtual void AfterRegisterSubModuleObjects(bool isSavedCampaign)
public virtual void BeginGameStart(Game game)
public virtual bool DoLoading(Game game)
protected virtual void InitializeGameStarter(Game game, IGameStarter starterObject)
public virtual void OnAfterGameInitializationFinished(Game game, object starterObject)
protected virtual void OnApplicationTick(float dt)
protected virtual void OnBeforeInitialModuleScreenSetAsRoot()
public virtual void OnBeforeMissionBehaviorInitialize(Mission mission)
public virtual void OnCampaignStart(Game game, object starterObject)
public virtual void OnConfigChanged()
public virtual void OnGameEnd(Game game)
public virtual void OnGameInitializationFinished(Game game)
public virtual void OnGameLoaded(Game game, object initializerObject)
protected virtual void OnGameStart(Game game, IGameStarter gameStarterObject)
public virtual void OnInitialState()
public virtual void OnMissionBehaviorInitialize(Mission mission)
public virtual void OnMultiplayerGameStart(Game game, object starterObject)
public virtual void OnNewGameCreated(Game game, object initializerObject)
protected virtual void OnSubModuleLoad()
protected virtual void OnSubModuleUnloaded()
public virtual void RegisterSubModuleObjects(bool isSavedCampaign)
```

## Version 1.0.1.5325

```csharp
protected void .ctor()
protected virtual void AfterAsyncTickTick(float dt)
public virtual void AfterRegisterSubModuleObjects(bool isSavedCampaign)
public virtual void BeginGameStart(Game game)
public virtual bool DoLoading(Game game)
protected virtual void InitializeGameStarter(Game game, IGameStarter starterObject)
public virtual void OnAfterGameInitializationFinished(Game game, object starterObject)
protected virtual void OnApplicationTick(float dt)
protected virtual void OnBeforeInitialModuleScreenSetAsRoot()
public virtual void OnBeforeMissionBehaviorInitialize(Mission mission)
public virtual void OnCampaignStart(Game game, object starterObject)
public virtual void OnConfigChanged()
public virtual void OnGameEnd(Game game)
public virtual void OnGameInitializationFinished(Game game)
public virtual void OnGameLoaded(Game game, object initializerObject)
protected virtual void OnGameStart(Game game, IGameStarter gameStarterObject)
public virtual void OnInitialState()
public virtual void OnMissionBehaviorInitialize(Mission mission)
public virtual void OnMultiplayerGameStart(Game game, object starterObject)
public virtual void OnNewGameCreated(Game game, object initializerObject)
protected virtual void OnSubModuleLoad()
protected virtual void OnSubModuleUnloaded()
public virtual void RegisterSubModuleObjects(bool isSavedCampaign)
```

## Version 1.0.1.5590

```csharp
protected void .ctor()
protected virtual void AfterAsyncTickTick(float dt)
public virtual void AfterRegisterSubModuleObjects(bool isSavedCampaign)
public virtual void BeginGameStart(Game game)
public virtual bool DoLoading(Game game)
protected virtual void InitializeGameStarter(Game game, IGameStarter starterObject)
public virtual void OnAfterGameInitializationFinished(Game game, object starterObject)
protected virtual void OnApplicationTick(float dt)
protected virtual void OnBeforeInitialModuleScreenSetAsRoot()
public virtual void OnBeforeMissionBehaviorInitialize(Mission mission)
public virtual void OnCampaignStart(Game game, object starterObject)
public virtual void OnConfigChanged()
public virtual void OnGameEnd(Game game)
public virtual void OnGameInitializationFinished(Game game)
public virtual void OnGameLoaded(Game game, object initializerObject)
protected virtual void OnGameStart(Game game, IGameStarter gameStarterObject)
public virtual void OnInitialState()
public virtual void OnMissionBehaviorInitialize(Mission mission)
public virtual void OnMultiplayerGameStart(Game game, object starterObject)
public virtual void OnNewGameCreated(Game game, object initializerObject)
protected virtual void OnSubModuleLoad()
protected virtual void OnSubModuleUnloaded()
public virtual void RegisterSubModuleObjects(bool isSavedCampaign)
```

## Version 1.0.1.55901

```csharp
protected void .ctor()
protected virtual void AfterAsyncTickTick(float dt)
public virtual void AfterRegisterSubModuleObjects(bool isSavedCampaign)
public virtual void BeginGameStart(Game game)
public virtual bool DoLoading(Game game)
protected virtual void InitializeGameStarter(Game game, IGameStarter starterObject)
public virtual void OnAfterGameInitializationFinished(Game game, object starterObject)
protected virtual void OnApplicationTick(float dt)
protected virtual void OnBeforeInitialModuleScreenSetAsRoot()
public virtual void OnBeforeMissionBehaviorInitialize(Mission mission)
public virtual void OnCampaignStart(Game game, object starterObject)
public virtual void OnConfigChanged()
public virtual void OnGameEnd(Game game)
public virtual void OnGameInitializationFinished(Game game)
public virtual void OnGameLoaded(Game game, object initializerObject)
protected virtual void OnGameStart(Game game, IGameStarter gameStarterObject)
public virtual void OnInitialState()
public virtual void OnMissionBehaviorInitialize(Mission mission)
public virtual void OnMultiplayerGameStart(Game game, object starterObject)
public virtual void OnNewGameCreated(Game game, object initializerObject)
protected virtual void OnSubModuleLoad()
protected virtual void OnSubModuleUnloaded()
public virtual void RegisterSubModuleObjects(bool isSavedCampaign)
```

## Version 1.0.2.5331-beta

```csharp
protected void .ctor()
protected virtual void AfterAsyncTickTick(float dt)
public virtual void AfterRegisterSubModuleObjects(bool isSavedCampaign)
public virtual void BeginGameStart(Game game)
public virtual bool DoLoading(Game game)
protected virtual void InitializeGameStarter(Game game, IGameStarter starterObject)
public virtual void OnAfterGameInitializationFinished(Game game, object starterObject)
protected virtual void OnApplicationTick(float dt)
protected virtual void OnBeforeInitialModuleScreenSetAsRoot()
public virtual void OnBeforeMissionBehaviorInitialize(Mission mission)
public virtual void OnCampaignStart(Game game, object starterObject)
public virtual void OnConfigChanged()
public virtual void OnGameEnd(Game game)
public virtual void OnGameInitializationFinished(Game game)
public virtual void OnGameLoaded(Game game, object initializerObject)
protected virtual void OnGameStart(Game game, IGameStarter gameStarterObject)
public virtual void OnInitialState()
public virtual void OnMissionBehaviorInitialize(Mission mission)
public virtual void OnMultiplayerGameStart(Game game, object starterObject)
public virtual void OnNewGameCreated(Game game, object initializerObject)
protected virtual void OnSubModuleLoad()
protected virtual void OnSubModuleUnloaded()
public virtual void RegisterSubModuleObjects(bool isSavedCampaign)
```

## Version 1.0.2.6150

```csharp
protected void .ctor()
protected virtual void AfterAsyncTickTick(float dt)
public virtual void AfterRegisterSubModuleObjects(bool isSavedCampaign)
public virtual void BeginGameStart(Game game)
public virtual bool DoLoading(Game game)
protected virtual void InitializeGameStarter(Game game, IGameStarter starterObject)
public virtual void OnAfterGameInitializationFinished(Game game, object starterObject)
protected virtual void OnApplicationTick(float dt)
protected virtual void OnBeforeInitialModuleScreenSetAsRoot()
public virtual void OnBeforeMissionBehaviorInitialize(Mission mission)
public virtual void OnCampaignStart(Game game, object starterObject)
public virtual void OnConfigChanged()
public virtual void OnGameEnd(Game game)
public virtual void OnGameInitializationFinished(Game game)
public virtual void OnGameLoaded(Game game, object initializerObject)
protected virtual void OnGameStart(Game game, IGameStarter gameStarterObject)
public virtual void OnInitialState()
public virtual void OnMissionBehaviorInitialize(Mission mission)
public virtual void OnMultiplayerGameStart(Game game, object starterObject)
public virtual void OnNewGameCreated(Game game, object initializerObject)
protected virtual void OnSubModuleLoad()
protected virtual void OnSubModuleUnloaded()
public virtual void RegisterSubModuleObjects(bool isSavedCampaign)
```

## Version 1.0.2.6549

```csharp
protected void .ctor()
protected virtual void AfterAsyncTickTick(float dt)
public virtual void AfterRegisterSubModuleObjects(bool isSavedCampaign)
public virtual void BeginGameStart(Game game)
public virtual bool DoLoading(Game game)
protected virtual void InitializeGameStarter(Game game, IGameStarter starterObject)
public virtual void OnAfterGameInitializationFinished(Game game, object starterObject)
protected virtual void OnApplicationTick(float dt)
protected virtual void OnBeforeInitialModuleScreenSetAsRoot()
public virtual void OnBeforeMissionBehaviorInitialize(Mission mission)
public virtual void OnCampaignStart(Game game, object starterObject)
public virtual void OnConfigChanged()
public virtual void OnGameEnd(Game game)
public virtual void OnGameInitializationFinished(Game game)
public virtual void OnGameLoaded(Game game, object initializerObject)
protected virtual void OnGameStart(Game game, IGameStarter gameStarterObject)
public virtual void OnInitialState()
public virtual void OnMissionBehaviorInitialize(Mission mission)
public virtual void OnMultiplayerGameStart(Game game, object starterObject)
public virtual void OnNewGameCreated(Game game, object initializerObject)
protected virtual void OnSubModuleLoad()
protected virtual void OnSubModuleUnloaded()
public virtual void RegisterSubModuleObjects(bool isSavedCampaign)
```

## Version 1.0.2.6967

```csharp
protected void .ctor()
protected virtual void AfterAsyncTickTick(float dt)
public virtual void AfterRegisterSubModuleObjects(bool isSavedCampaign)
public virtual void BeginGameStart(Game game)
public virtual bool DoLoading(Game game)
protected virtual void InitializeGameStarter(Game game, IGameStarter starterObject)
public virtual void OnAfterGameInitializationFinished(Game game, object starterObject)
protected virtual void OnApplicationTick(float dt)
protected virtual void OnBeforeInitialModuleScreenSetAsRoot()
public virtual void OnBeforeMissionBehaviorInitialize(Mission mission)
public virtual void OnCampaignStart(Game game, object starterObject)
public virtual void OnConfigChanged()
public virtual void OnGameEnd(Game game)
public virtual void OnGameInitializationFinished(Game game)
public virtual void OnGameLoaded(Game game, object initializerObject)
protected virtual void OnGameStart(Game game, IGameStarter gameStarterObject)
public virtual void OnInitialState()
public virtual void OnMissionBehaviorInitialize(Mission mission)
public virtual void OnMultiplayerGameStart(Game game, object starterObject)
public virtual void OnNewGameCreated(Game game, object initializerObject)
protected virtual void OnSubModuleLoad()
protected virtual void OnSubModuleUnloaded()
public virtual void RegisterSubModuleObjects(bool isSavedCampaign)
```

## Version 1.0.2.7585

```csharp
protected void .ctor()
protected virtual void AfterAsyncTickTick(float dt)
public virtual void AfterRegisterSubModuleObjects(bool isSavedCampaign)
public virtual void BeginGameStart(Game game)
public virtual bool DoLoading(Game game)
protected virtual void InitializeGameStarter(Game game, IGameStarter starterObject)
public virtual void OnAfterGameInitializationFinished(Game game, object starterObject)
protected virtual void OnApplicationTick(float dt)
protected virtual void OnBeforeInitialModuleScreenSetAsRoot()
public virtual void OnBeforeMissionBehaviorInitialize(Mission mission)
public virtual void OnCampaignStart(Game game, object starterObject)
public virtual void OnConfigChanged()
public virtual void OnGameEnd(Game game)
public virtual void OnGameInitializationFinished(Game game)
public virtual void OnGameLoaded(Game game, object initializerObject)
protected virtual void OnGameStart(Game game, IGameStarter gameStarterObject)
public virtual void OnInitialState()
public virtual void OnMissionBehaviorInitialize(Mission mission)
public virtual void OnMultiplayerGameStart(Game game, object starterObject)
public virtual void OnNewGameCreated(Game game, object initializerObject)
protected virtual void OnSubModuleLoad()
protected virtual void OnSubModuleUnloaded()
public virtual void RegisterSubModuleObjects(bool isSavedCampaign)
```

## Version 1.0.2.7919

```csharp
protected void .ctor()
protected virtual void AfterAsyncTickTick(float dt)
public virtual void AfterRegisterSubModuleObjects(bool isSavedCampaign)
public virtual void BeginGameStart(Game game)
public virtual bool DoLoading(Game game)
protected virtual void InitializeGameStarter(Game game, IGameStarter starterObject)
public virtual void OnAfterGameInitializationFinished(Game game, object starterObject)
protected virtual void OnApplicationTick(float dt)
protected virtual void OnBeforeInitialModuleScreenSetAsRoot()
public virtual void OnBeforeMissionBehaviorInitialize(Mission mission)
public virtual void OnCampaignStart(Game game, object starterObject)
public virtual void OnConfigChanged()
public virtual void OnGameEnd(Game game)
public virtual void OnGameInitializationFinished(Game game)
public virtual void OnGameLoaded(Game game, object initializerObject)
protected virtual void OnGameStart(Game game, IGameStarter gameStarterObject)
public virtual void OnInitialState()
public virtual void OnMissionBehaviorInitialize(Mission mission)
public virtual void OnMultiplayerGameStart(Game game, object starterObject)
public virtual void OnNewGameCreated(Game game, object initializerObject)
protected virtual void OnSubModuleLoad()
protected virtual void OnSubModuleUnloaded()
public virtual void RegisterSubModuleObjects(bool isSavedCampaign)
```

## Version 1.0.2.8368

```csharp
protected void .ctor()
protected virtual void AfterAsyncTickTick(float dt)
public virtual void AfterRegisterSubModuleObjects(bool isSavedCampaign)
public virtual void BeginGameStart(Game game)
public virtual bool DoLoading(Game game)
protected virtual void InitializeGameStarter(Game game, IGameStarter starterObject)
public virtual void OnAfterGameInitializationFinished(Game game, object starterObject)
protected virtual void OnApplicationTick(float dt)
protected virtual void OnBeforeInitialModuleScreenSetAsRoot()
public virtual void OnBeforeMissionBehaviorInitialize(Mission mission)
public virtual void OnCampaignStart(Game game, object starterObject)
public virtual void OnConfigChanged()
public virtual void OnGameEnd(Game game)
public virtual void OnGameInitializationFinished(Game game)
public virtual void OnGameLoaded(Game game, object initializerObject)
protected virtual void OnGameStart(Game game, IGameStarter gameStarterObject)
public virtual void OnInitialState()
public virtual void OnMissionBehaviorInitialize(Mission mission)
public virtual void OnMultiplayerGameStart(Game game, object starterObject)
public virtual void OnNewGameCreated(Game game, object initializerObject)
protected virtual void OnSubModuleLoad()
protected virtual void OnSubModuleUnloaded()
public virtual void RegisterSubModuleObjects(bool isSavedCampaign)
```

## Version 1.0.2.83681

```csharp
protected void .ctor()
protected virtual void AfterAsyncTickTick(float dt)
public virtual void AfterRegisterSubModuleObjects(bool isSavedCampaign)
public virtual void BeginGameStart(Game game)
public virtual bool DoLoading(Game game)
protected virtual void InitializeGameStarter(Game game, IGameStarter starterObject)
public virtual void OnAfterGameInitializationFinished(Game game, object starterObject)
protected virtual void OnApplicationTick(float dt)
protected virtual void OnBeforeInitialModuleScreenSetAsRoot()
public virtual void OnBeforeMissionBehaviorInitialize(Mission mission)
public virtual void OnCampaignStart(Game game, object starterObject)
public virtual void OnConfigChanged()
public virtual void OnGameEnd(Game game)
public virtual void OnGameInitializationFinished(Game game)
public virtual void OnGameLoaded(Game game, object initializerObject)
protected virtual void OnGameStart(Game game, IGameStarter gameStarterObject)
public virtual void OnInitialState()
public virtual void OnMissionBehaviorInitialize(Mission mission)
public virtual void OnMultiplayerGameStart(Game game, object starterObject)
public virtual void OnNewGameCreated(Game game, object initializerObject)
protected virtual void OnSubModuleLoad()
protected virtual void OnSubModuleUnloaded()
public virtual void RegisterSubModuleObjects(bool isSavedCampaign)
```

## Version 1.0.3.8791

```csharp
protected void .ctor()
protected virtual void AfterAsyncTickTick(float dt)
public virtual void AfterRegisterSubModuleObjects(bool isSavedCampaign)
public virtual void BeginGameStart(Game game)
public virtual bool DoLoading(Game game)
protected virtual void InitializeGameStarter(Game game, IGameStarter starterObject)
public virtual void OnAfterGameInitializationFinished(Game game, object starterObject)
protected virtual void OnApplicationTick(float dt)
protected virtual void OnBeforeInitialModuleScreenSetAsRoot()
public virtual void OnBeforeMissionBehaviorInitialize(Mission mission)
public virtual void OnCampaignStart(Game game, object starterObject)
public virtual void OnConfigChanged()
public virtual void OnGameEnd(Game game)
public virtual void OnGameInitializationFinished(Game game)
public virtual void OnGameLoaded(Game game, object initializerObject)
protected virtual void OnGameStart(Game game, IGameStarter gameStarterObject)
public virtual void OnInitialState()
public virtual void OnMissionBehaviorInitialize(Mission mission)
public virtual void OnMultiplayerGameStart(Game game, object starterObject)
public virtual void OnNewGameCreated(Game game, object initializerObject)
protected virtual void OnSubModuleLoad()
protected virtual void OnSubModuleUnloaded()
public virtual void RegisterSubModuleObjects(bool isSavedCampaign)
```

## Version 1.0.3.9055

```csharp
protected void .ctor()
protected virtual void AfterAsyncTickTick(float dt)
public virtual void AfterRegisterSubModuleObjects(bool isSavedCampaign)
public virtual void BeginGameStart(Game game)
public virtual bool DoLoading(Game game)
protected virtual void InitializeGameStarter(Game game, IGameStarter starterObject)
public virtual void OnAfterGameInitializationFinished(Game game, object starterObject)
protected virtual void OnApplicationTick(float dt)
protected virtual void OnBeforeInitialModuleScreenSetAsRoot()
public virtual void OnBeforeMissionBehaviorInitialize(Mission mission)
public virtual void OnCampaignStart(Game game, object starterObject)
public virtual void OnConfigChanged()
public virtual void OnGameEnd(Game game)
public virtual void OnGameInitializationFinished(Game game)
public virtual void OnGameLoaded(Game game, object initializerObject)
protected virtual void OnGameStart(Game game, IGameStarter gameStarterObject)
public virtual void OnInitialState()
public virtual void OnMissionBehaviorInitialize(Mission mission)
public virtual void OnMultiplayerGameStart(Game game, object starterObject)
public virtual void OnNewGameCreated(Game game, object initializerObject)
protected virtual void OnSubModuleLoad()
protected virtual void OnSubModuleUnloaded()
public virtual void RegisterSubModuleObjects(bool isSavedCampaign)
```

## Version 1.0.3.9860

```csharp
protected void .ctor()
protected virtual void AfterAsyncTickTick(float dt)
public virtual void AfterRegisterSubModuleObjects(bool isSavedCampaign)
public virtual void BeginGameStart(Game game)
public virtual bool DoLoading(Game game)
protected virtual void InitializeGameStarter(Game game, IGameStarter starterObject)
public virtual void OnAfterGameInitializationFinished(Game game, object starterObject)
protected virtual void OnApplicationTick(float dt)
protected virtual void OnBeforeInitialModuleScreenSetAsRoot()
public virtual void OnBeforeMissionBehaviorInitialize(Mission mission)
public virtual void OnCampaignStart(Game game, object starterObject)
public virtual void OnConfigChanged()
public virtual void OnGameEnd(Game game)
public virtual void OnGameInitializationFinished(Game game)
public virtual void OnGameLoaded(Game game, object initializerObject)
protected virtual void OnGameStart(Game game, IGameStarter gameStarterObject)
public virtual void OnInitialState()
public virtual void OnMissionBehaviorInitialize(Mission mission)
public virtual void OnMultiplayerGameStart(Game game, object starterObject)
public virtual void OnNewGameCreated(Game game, object initializerObject)
protected virtual void OnSubModuleLoad()
protected virtual void OnSubModuleUnloaded()
public virtual void RegisterSubModuleObjects(bool isSavedCampaign)
```

## Version 1.0.3.98601

```csharp
protected void .ctor()
protected virtual void AfterAsyncTickTick(float dt)
public virtual void AfterRegisterSubModuleObjects(bool isSavedCampaign)
public virtual void BeginGameStart(Game game)
public virtual bool DoLoading(Game game)
protected virtual void InitializeGameStarter(Game game, IGameStarter starterObject)
public virtual void OnAfterGameInitializationFinished(Game game, object starterObject)
protected virtual void OnApplicationTick(float dt)
protected virtual void OnBeforeInitialModuleScreenSetAsRoot()
public virtual void OnBeforeMissionBehaviorInitialize(Mission mission)
public virtual void OnCampaignStart(Game game, object starterObject)
public virtual void OnConfigChanged()
public virtual void OnGameEnd(Game game)
public virtual void OnGameInitializationFinished(Game game)
public virtual void OnGameLoaded(Game game, object initializerObject)
protected virtual void OnGameStart(Game game, IGameStarter gameStarterObject)
public virtual void OnInitialState()
public virtual void OnMissionBehaviorInitialize(Mission mission)
public virtual void OnMultiplayerGameStart(Game game, object starterObject)
public virtual void OnNewGameCreated(Game game, object initializerObject)
protected virtual void OnSubModuleLoad()
protected virtual void OnSubModuleUnloaded()
public virtual void RegisterSubModuleObjects(bool isSavedCampaign)
```

## Version 1.1.0.9638-beta

```csharp
protected void .ctor()
protected virtual void AfterAsyncTickTick(float dt)
public virtual void AfterRegisterSubModuleObjects(bool isSavedCampaign)
public virtual void BeginGameStart(Game game)
public virtual bool DoLoading(Game game)
protected virtual void InitializeGameStarter(Game game, IGameStarter starterObject)
public virtual void OnAfterGameInitializationFinished(Game game, object starterObject)
protected virtual void OnApplicationTick(float dt)
protected virtual void OnBeforeInitialModuleScreenSetAsRoot()
public virtual void OnBeforeMissionBehaviorInitialize(Mission mission)
public virtual void OnCampaignStart(Game game, object starterObject)
public virtual void OnConfigChanged()
public virtual void OnGameEnd(Game game)
public virtual void OnGameInitializationFinished(Game game)
public virtual void OnGameLoaded(Game game, object initializerObject)
protected virtual void OnGameStart(Game game, IGameStarter gameStarterObject)
public virtual void OnInitialState()
public virtual void OnMissionBehaviorInitialize(Mission mission)
public virtual void OnMultiplayerGameStart(Game game, object starterObject)
public virtual void OnNewGameCreated(Game game, object initializerObject)
protected virtual void OnSubModuleLoad()
protected virtual void OnSubModuleUnloaded()
public virtual void RegisterSubModuleObjects(bool isSavedCampaign)
```

## Version 1.1.0.10414-beta

```csharp
protected void .ctor()
protected virtual void AfterAsyncTickTick(float dt)
public virtual void AfterRegisterSubModuleObjects(bool isSavedCampaign)
public virtual void BeginGameStart(Game game)
public virtual bool DoLoading(Game game)
protected virtual void InitializeGameStarter(Game game, IGameStarter starterObject)
public virtual void OnAfterGameInitializationFinished(Game game, object starterObject)
protected virtual void OnApplicationTick(float dt)
protected virtual void OnBeforeInitialModuleScreenSetAsRoot()
public virtual void OnBeforeMissionBehaviorInitialize(Mission mission)
public virtual void OnCampaignStart(Game game, object starterObject)
public virtual void OnConfigChanged()
public virtual void OnGameEnd(Game game)
public virtual void OnGameInitializationFinished(Game game)
public virtual void OnGameLoaded(Game game, object initializerObject)
protected virtual void OnGameStart(Game game, IGameStarter gameStarterObject)
public virtual void OnInitialState()
public virtual void OnMissionBehaviorInitialize(Mission mission)
public virtual void OnMultiplayerGameStart(Game game, object starterObject)
public virtual void OnNewGameCreated(Game game, object initializerObject)
protected virtual void OnSubModuleLoad()
protected virtual void OnSubModuleUnloaded()
public virtual void RegisterSubModuleObjects(bool isSavedCampaign)
```

## Version 1.1.0.10976-beta

```csharp
protected void .ctor()
protected virtual void AfterAsyncTickTick(float dt)
public virtual void AfterRegisterSubModuleObjects(bool isSavedCampaign)
public virtual void BeginGameStart(Game game)
public virtual bool DoLoading(Game game)
protected virtual void InitializeGameStarter(Game game, IGameStarter starterObject)
public virtual void OnAfterGameInitializationFinished(Game game, object starterObject)
protected virtual void OnApplicationTick(float dt)
protected virtual void OnBeforeInitialModuleScreenSetAsRoot()
public virtual void OnBeforeMissionBehaviorInitialize(Mission mission)
public virtual void OnCampaignStart(Game game, object starterObject)
public virtual void OnConfigChanged()
public virtual void OnGameEnd(Game game)
public virtual void OnGameInitializationFinished(Game game)
public virtual void OnGameLoaded(Game game, object initializerObject)
protected virtual void OnGameStart(Game game, IGameStarter gameStarterObject)
public virtual void OnInitialState()
public virtual void OnMissionBehaviorInitialize(Mission mission)
public virtual void OnMultiplayerGameStart(Game game, object starterObject)
public virtual void OnNewGameCreated(Game game, object initializerObject)
protected virtual void OnSubModuleLoad()
protected virtual void OnSubModuleUnloaded()
public virtual void RegisterSubModuleObjects(bool isSavedCampaign)
```

## Version 1.1.0.11398-beta

```csharp
protected void .ctor()
protected virtual void AfterAsyncTickTick(float dt)
public virtual void AfterRegisterSubModuleObjects(bool isSavedCampaign)
public virtual void BeginGameStart(Game game)
public virtual bool DoLoading(Game game)
protected virtual void InitializeGameStarter(Game game, IGameStarter starterObject)
public virtual void OnAfterGameInitializationFinished(Game game, object starterObject)
protected virtual void OnApplicationTick(float dt)
protected virtual void OnBeforeInitialModuleScreenSetAsRoot()
public virtual void OnBeforeMissionBehaviorInitialize(Mission mission)
public virtual void OnCampaignStart(Game game, object starterObject)
public virtual void OnConfigChanged()
public virtual void OnGameEnd(Game game)
public virtual void OnGameInitializationFinished(Game game)
public virtual void OnGameLoaded(Game game, object initializerObject)
protected virtual void OnGameStart(Game game, IGameStarter gameStarterObject)
public virtual void OnInitialState()
public virtual void OnMissionBehaviorInitialize(Mission mission)
public virtual void OnMultiplayerGameStart(Game game, object starterObject)
public virtual void OnNewGameCreated(Game game, object initializerObject)
protected virtual void OnSubModuleLoad()
protected virtual void OnSubModuleUnloaded()
public virtual void RegisterSubModuleObjects(bool isSavedCampaign)
```

## Version 1.1.0.11746-beta

```csharp
protected void .ctor()
protected virtual void AfterAsyncTickTick(float dt)
public virtual void AfterRegisterSubModuleObjects(bool isSavedCampaign)
public virtual void BeginGameStart(Game game)
public virtual bool DoLoading(Game game)
protected virtual void InitializeGameStarter(Game game, IGameStarter starterObject)
public virtual void OnAfterGameInitializationFinished(Game game, object starterObject)
protected virtual void OnApplicationTick(float dt)
protected virtual void OnBeforeInitialModuleScreenSetAsRoot()
public virtual void OnBeforeMissionBehaviorInitialize(Mission mission)
public virtual void OnCampaignStart(Game game, object starterObject)
public virtual void OnConfigChanged()
public virtual void OnGameEnd(Game game)
public virtual void OnGameInitializationFinished(Game game)
public virtual void OnGameLoaded(Game game, object initializerObject)
protected virtual void OnGameStart(Game game, IGameStarter gameStarterObject)
public virtual void OnInitialState()
public virtual void OnMissionBehaviorInitialize(Mission mission)
public virtual void OnMultiplayerGameStart(Game game, object starterObject)
public virtual void OnNewGameCreated(Game game, object initializerObject)
protected virtual void OnSubModuleLoad()
protected virtual void OnSubModuleUnloaded()
public virtual void RegisterSubModuleObjects(bool isSavedCampaign)
```

## Version 1.1.0.12274-beta

```csharp
protected void .ctor()
protected virtual void AfterAsyncTickTick(float dt)
public virtual void AfterRegisterSubModuleObjects(bool isSavedCampaign)
public virtual void BeginGameStart(Game game)
public virtual bool DoLoading(Game game)
protected virtual void InitializeGameStarter(Game game, IGameStarter starterObject)
public virtual void OnAfterGameInitializationFinished(Game game, object starterObject)
protected virtual void OnApplicationTick(float dt)
protected virtual void OnBeforeInitialModuleScreenSetAsRoot()
public virtual void OnBeforeMissionBehaviorInitialize(Mission mission)
public virtual void OnCampaignStart(Game game, object starterObject)
public virtual void OnConfigChanged()
public virtual void OnGameEnd(Game game)
public virtual void OnGameInitializationFinished(Game game)
public virtual void OnGameLoaded(Game game, object initializerObject)
protected virtual void OnGameStart(Game game, IGameStarter gameStarterObject)
public virtual void OnInitialState()
public virtual void OnMissionBehaviorInitialize(Mission mission)
public virtual void OnMultiplayerGameStart(Game game, object starterObject)
public virtual void OnNewGameCreated(Game game, object initializerObject)
protected virtual void OnSubModuleLoad()
protected virtual void OnSubModuleUnloaded()
public virtual void RegisterSubModuleObjects(bool isSavedCampaign)
```

## Version 1.1.0.12734-beta

```csharp
protected void .ctor()
protected virtual void AfterAsyncTickTick(float dt)
public virtual void AfterRegisterSubModuleObjects(bool isSavedCampaign)
public virtual void BeginGameStart(Game game)
public virtual bool DoLoading(Game game)
protected virtual void InitializeGameStarter(Game game, IGameStarter starterObject)
public virtual void OnAfterGameInitializationFinished(Game game, object starterObject)
protected virtual void OnApplicationTick(float dt)
protected virtual void OnBeforeInitialModuleScreenSetAsRoot()
public virtual void OnBeforeMissionBehaviorInitialize(Mission mission)
public virtual void OnCampaignStart(Game game, object starterObject)
public virtual void OnConfigChanged()
public virtual void OnGameEnd(Game game)
public virtual void OnGameInitializationFinished(Game game)
public virtual void OnGameLoaded(Game game, object initializerObject)
protected virtual void OnGameStart(Game game, IGameStarter gameStarterObject)
public virtual void OnInitialState()
public virtual void OnMissionBehaviorInitialize(Mission mission)
public virtual void OnMultiplayerGameStart(Game game, object starterObject)
public virtual void OnNewGameCreated(Game game, object initializerObject)
protected virtual void OnSubModuleLoad()
protected virtual void OnSubModuleUnloaded()
public virtual void RegisterSubModuleObjects(bool isSavedCampaign)
```

## Version 1.1.0.12734

```csharp
protected void .ctor()
protected virtual void AfterAsyncTickTick(float dt)
public virtual void AfterRegisterSubModuleObjects(bool isSavedCampaign)
public virtual void BeginGameStart(Game game)
public virtual bool DoLoading(Game game)
protected virtual void InitializeGameStarter(Game game, IGameStarter starterObject)
public virtual void OnAfterGameInitializationFinished(Game game, object starterObject)
protected virtual void OnApplicationTick(float dt)
protected virtual void OnBeforeInitialModuleScreenSetAsRoot()
public virtual void OnBeforeMissionBehaviorInitialize(Mission mission)
public virtual void OnCampaignStart(Game game, object starterObject)
public virtual void OnConfigChanged()
public virtual void OnGameEnd(Game game)
public virtual void OnGameInitializationFinished(Game game)
public virtual void OnGameLoaded(Game game, object initializerObject)
protected virtual void OnGameStart(Game game, IGameStarter gameStarterObject)
public virtual void OnInitialState()
public virtual void OnMissionBehaviorInitialize(Mission mission)
public virtual void OnMultiplayerGameStart(Game game, object starterObject)
public virtual void OnNewGameCreated(Game game, object initializerObject)
protected virtual void OnSubModuleLoad()
protected virtual void OnSubModuleUnloaded()
public virtual void RegisterSubModuleObjects(bool isSavedCampaign)
```

## Version 1.1.0.127341

```csharp
protected void .ctor()
protected virtual void AfterAsyncTickTick(float dt)
public virtual void AfterRegisterSubModuleObjects(bool isSavedCampaign)
public virtual void BeginGameStart(Game game)
public virtual bool DoLoading(Game game)
protected virtual void InitializeGameStarter(Game game, IGameStarter starterObject)
public virtual void OnAfterGameInitializationFinished(Game game, object starterObject)
protected virtual void OnApplicationTick(float dt)
protected virtual void OnBeforeInitialModuleScreenSetAsRoot()
public virtual void OnBeforeMissionBehaviorInitialize(Mission mission)
public virtual void OnCampaignStart(Game game, object starterObject)
public virtual void OnConfigChanged()
public virtual void OnGameEnd(Game game)
public virtual void OnGameInitializationFinished(Game game)
public virtual void OnGameLoaded(Game game, object initializerObject)
protected virtual void OnGameStart(Game game, IGameStarter gameStarterObject)
public virtual void OnInitialState()
public virtual void OnMissionBehaviorInitialize(Mission mission)
public virtual void OnMultiplayerGameStart(Game game, object starterObject)
public virtual void OnNewGameCreated(Game game, object initializerObject)
protected virtual void OnSubModuleLoad()
protected virtual void OnSubModuleUnloaded()
public virtual void RegisterSubModuleObjects(bool isSavedCampaign)
```

## Version 1.1.1.14148

```csharp
protected void .ctor()
protected virtual void AfterAsyncTickTick(float dt)
public virtual void AfterRegisterSubModuleObjects(bool isSavedCampaign)
public virtual void BeginGameStart(Game game)
public virtual bool DoLoading(Game game)
protected virtual void InitializeGameStarter(Game game, IGameStarter starterObject)
public virtual void OnAfterGameInitializationFinished(Game game, object starterObject)
protected virtual void OnApplicationTick(float dt)
protected virtual void OnBeforeInitialModuleScreenSetAsRoot()
public virtual void OnBeforeMissionBehaviorInitialize(Mission mission)
public virtual void OnCampaignStart(Game game, object starterObject)
public virtual void OnConfigChanged()
public virtual void OnGameEnd(Game game)
public virtual void OnGameInitializationFinished(Game game)
public virtual void OnGameLoaded(Game game, object initializerObject)
protected virtual void OnGameStart(Game game, IGameStarter gameStarterObject)
public virtual void OnInitialState()
public virtual void OnMissionBehaviorInitialize(Mission mission)
public virtual void OnMultiplayerGameStart(Game game, object starterObject)
public virtual void OnNewGameCreated(Game game, object initializerObject)
protected virtual void OnSubModuleLoad()
protected virtual void OnSubModuleUnloaded()
public virtual void RegisterSubModuleObjects(bool isSavedCampaign)
```

## Version 1.1.1.141481

```csharp
protected void .ctor()
protected virtual void AfterAsyncTickTick(float dt)
public virtual void AfterRegisterSubModuleObjects(bool isSavedCampaign)
public virtual void BeginGameStart(Game game)
public virtual bool DoLoading(Game game)
protected virtual void InitializeGameStarter(Game game, IGameStarter starterObject)
public virtual void OnAfterGameInitializationFinished(Game game, object starterObject)
protected virtual void OnApplicationTick(float dt)
protected virtual void OnBeforeInitialModuleScreenSetAsRoot()
public virtual void OnBeforeMissionBehaviorInitialize(Mission mission)
public virtual void OnCampaignStart(Game game, object starterObject)
public virtual void OnConfigChanged()
public virtual void OnGameEnd(Game game)
public virtual void OnGameInitializationFinished(Game game)
public virtual void OnGameLoaded(Game game, object initializerObject)
protected virtual void OnGameStart(Game game, IGameStarter gameStarterObject)
public virtual void OnInitialState()
public virtual void OnMissionBehaviorInitialize(Mission mission)
public virtual void OnMultiplayerGameStart(Game game, object starterObject)
public virtual void OnNewGameCreated(Game game, object initializerObject)
protected virtual void OnSubModuleLoad()
protected virtual void OnSubModuleUnloaded()
public virtual void RegisterSubModuleObjects(bool isSavedCampaign)
```

## Version 1.1.2.14580

```csharp
protected void .ctor()
protected virtual void AfterAsyncTickTick(float dt)
public virtual void AfterRegisterSubModuleObjects(bool isSavedCampaign)
public virtual void BeginGameStart(Game game)
public virtual bool DoLoading(Game game)
protected virtual void InitializeGameStarter(Game game, IGameStarter starterObject)
public virtual void OnAfterGameInitializationFinished(Game game, object starterObject)
protected virtual void OnApplicationTick(float dt)
protected virtual void OnBeforeInitialModuleScreenSetAsRoot()
public virtual void OnBeforeMissionBehaviorInitialize(Mission mission)
public virtual void OnCampaignStart(Game game, object starterObject)
public virtual void OnConfigChanged()
public virtual void OnGameEnd(Game game)
public virtual void OnGameInitializationFinished(Game game)
public virtual void OnGameLoaded(Game game, object initializerObject)
protected virtual void OnGameStart(Game game, IGameStarter gameStarterObject)
public virtual void OnInitialState()
public virtual void OnMissionBehaviorInitialize(Mission mission)
public virtual void OnMultiplayerGameStart(Game game, object starterObject)
public virtual void OnNewGameCreated(Game game, object initializerObject)
protected virtual void OnSubModuleLoad()
protected virtual void OnSubModuleUnloaded()
public virtual void RegisterSubModuleObjects(bool isSavedCampaign)
```

## Version 1.1.2.145801

```csharp
protected void .ctor()
protected virtual void AfterAsyncTickTick(float dt)
public virtual void AfterRegisterSubModuleObjects(bool isSavedCampaign)
public virtual void BeginGameStart(Game game)
public virtual bool DoLoading(Game game)
protected virtual void InitializeGameStarter(Game game, IGameStarter starterObject)
public virtual void OnAfterGameInitializationFinished(Game game, object starterObject)
protected virtual void OnApplicationTick(float dt)
protected virtual void OnBeforeInitialModuleScreenSetAsRoot()
public virtual void OnBeforeMissionBehaviorInitialize(Mission mission)
public virtual void OnCampaignStart(Game game, object starterObject)
public virtual void OnConfigChanged()
public virtual void OnGameEnd(Game game)
public virtual void OnGameInitializationFinished(Game game)
public virtual void OnGameLoaded(Game game, object initializerObject)
protected virtual void OnGameStart(Game game, IGameStarter gameStarterObject)
public virtual void OnInitialState()
public virtual void OnMissionBehaviorInitialize(Mission mission)
public virtual void OnMultiplayerGameStart(Game game, object starterObject)
public virtual void OnNewGameCreated(Game game, object initializerObject)
protected virtual void OnSubModuleLoad()
protected virtual void OnSubModuleUnloaded()
public virtual void RegisterSubModuleObjects(bool isSavedCampaign)
```

## Version 1.1.3.16165

```csharp
protected void .ctor()
protected virtual void AfterAsyncTickTick(float dt)
public virtual void AfterRegisterSubModuleObjects(bool isSavedCampaign)
public virtual void BeginGameStart(Game game)
public virtual bool DoLoading(Game game)
protected virtual void InitializeGameStarter(Game game, IGameStarter starterObject)
public virtual void OnAfterGameInitializationFinished(Game game, object starterObject)
protected virtual void OnApplicationTick(float dt)
protected virtual void OnBeforeInitialModuleScreenSetAsRoot()
public virtual void OnBeforeMissionBehaviorInitialize(Mission mission)
public virtual void OnCampaignStart(Game game, object starterObject)
public virtual void OnConfigChanged()
public virtual void OnGameEnd(Game game)
public virtual void OnGameInitializationFinished(Game game)
public virtual void OnGameLoaded(Game game, object initializerObject)
protected virtual void OnGameStart(Game game, IGameStarter gameStarterObject)
public virtual void OnInitialState()
public virtual void OnMissionBehaviorInitialize(Mission mission)
public virtual void OnMultiplayerGameStart(Game game, object starterObject)
public virtual void OnNewGameCreated(Game game, object initializerObject)
protected virtual void OnSubModuleLoad()
protected virtual void OnSubModuleUnloaded()
public virtual void RegisterSubModuleObjects(bool isSavedCampaign)
```

## Version 1.1.3.161651

```csharp
protected void .ctor()
protected virtual void AfterAsyncTickTick(float dt)
public virtual void AfterRegisterSubModuleObjects(bool isSavedCampaign)
public virtual void BeginGameStart(Game game)
public virtual bool DoLoading(Game game)
protected virtual void InitializeGameStarter(Game game, IGameStarter starterObject)
public virtual void OnAfterGameInitializationFinished(Game game, object starterObject)
protected virtual void OnApplicationTick(float dt)
protected virtual void OnBeforeInitialModuleScreenSetAsRoot()
public virtual void OnBeforeMissionBehaviorInitialize(Mission mission)
public virtual void OnCampaignStart(Game game, object starterObject)
public virtual void OnConfigChanged()
public virtual void OnGameEnd(Game game)
public virtual void OnGameInitializationFinished(Game game)
public virtual void OnGameLoaded(Game game, object initializerObject)
protected virtual void OnGameStart(Game game, IGameStarter gameStarterObject)
public virtual void OnInitialState()
public virtual void OnMissionBehaviorInitialize(Mission mission)
public virtual void OnMultiplayerGameStart(Game game, object starterObject)
public virtual void OnNewGameCreated(Game game, object initializerObject)
protected virtual void OnSubModuleLoad()
protected virtual void OnSubModuleUnloaded()
public virtual void RegisterSubModuleObjects(bool isSavedCampaign)
```

## Version 1.1.4.17949

```csharp
protected void .ctor()
protected virtual void AfterAsyncTickTick(float dt)
public virtual void AfterRegisterSubModuleObjects(bool isSavedCampaign)
public virtual void BeginGameStart(Game game)
public virtual bool DoLoading(Game game)
protected virtual void InitializeGameStarter(Game game, IGameStarter starterObject)
public virtual void OnAfterGameInitializationFinished(Game game, object starterObject)
protected virtual void OnApplicationTick(float dt)
protected virtual void OnBeforeInitialModuleScreenSetAsRoot()
public virtual void OnBeforeMissionBehaviorInitialize(Mission mission)
public virtual void OnCampaignStart(Game game, object starterObject)
public virtual void OnConfigChanged()
public virtual void OnGameEnd(Game game)
public virtual void OnGameInitializationFinished(Game game)
public virtual void OnGameLoaded(Game game, object initializerObject)
protected virtual void OnGameStart(Game game, IGameStarter gameStarterObject)
public virtual void OnInitialState()
public virtual void OnMissionBehaviorInitialize(Mission mission)
public virtual void OnMultiplayerGameStart(Game game, object starterObject)
public virtual void OnNewGameCreated(Game game, object initializerObject)
protected virtual void OnSubModuleLoad()
protected virtual void OnSubModuleUnloaded()
public virtual void RegisterSubModuleObjects(bool isSavedCampaign)
```

## Version 1.1.4.179491

```csharp
protected void .ctor()
protected virtual void AfterAsyncTickTick(float dt)
public virtual void AfterRegisterSubModuleObjects(bool isSavedCampaign)
public virtual void BeginGameStart(Game game)
public virtual bool DoLoading(Game game)
protected virtual void InitializeGameStarter(Game game, IGameStarter starterObject)
public virtual void OnAfterGameInitializationFinished(Game game, object starterObject)
protected virtual void OnApplicationTick(float dt)
protected virtual void OnBeforeInitialModuleScreenSetAsRoot()
public virtual void OnBeforeMissionBehaviorInitialize(Mission mission)
public virtual void OnCampaignStart(Game game, object starterObject)
public virtual void OnConfigChanged()
public virtual void OnGameEnd(Game game)
public virtual void OnGameInitializationFinished(Game game)
public virtual void OnGameLoaded(Game game, object initializerObject)
protected virtual void OnGameStart(Game game, IGameStarter gameStarterObject)
public virtual void OnInitialState()
public virtual void OnMissionBehaviorInitialize(Mission mission)
public virtual void OnMultiplayerGameStart(Game game, object starterObject)
public virtual void OnNewGameCreated(Game game, object initializerObject)
protected virtual void OnSubModuleLoad()
protected virtual void OnSubModuleUnloaded()
public virtual void RegisterSubModuleObjects(bool isSavedCampaign)
```

## Version 1.1.5.21456

```csharp
protected void .ctor()
protected virtual void AfterAsyncTickTick(float dt)
public virtual void AfterRegisterSubModuleObjects(bool isSavedCampaign)
public virtual void BeginGameStart(Game game)
public virtual bool DoLoading(Game game)
protected virtual void InitializeGameStarter(Game game, IGameStarter starterObject)
public virtual void OnAfterGameInitializationFinished(Game game, object starterObject)
protected virtual void OnApplicationTick(float dt)
protected virtual void OnBeforeInitialModuleScreenSetAsRoot()
public virtual void OnBeforeMissionBehaviorInitialize(Mission mission)
public virtual void OnCampaignStart(Game game, object starterObject)
public virtual void OnConfigChanged()
public virtual void OnGameEnd(Game game)
public virtual void OnGameInitializationFinished(Game game)
public virtual void OnGameLoaded(Game game, object initializerObject)
protected virtual void OnGameStart(Game game, IGameStarter gameStarterObject)
public virtual void OnInitialState()
public virtual void OnMissionBehaviorInitialize(Mission mission)
public virtual void OnMultiplayerGameStart(Game game, object starterObject)
public virtual void OnNewGameCreated(Game game, object initializerObject)
protected virtual void OnSubModuleLoad()
protected virtual void OnSubModuleUnloaded()
public virtual void RegisterSubModuleObjects(bool isSavedCampaign)
```

## Version 1.1.5.214561

```csharp
protected void .ctor()
protected virtual void AfterAsyncTickTick(float dt)
public virtual void AfterRegisterSubModuleObjects(bool isSavedCampaign)
public virtual void BeginGameStart(Game game)
public virtual bool DoLoading(Game game)
protected virtual void InitializeGameStarter(Game game, IGameStarter starterObject)
public virtual void OnAfterGameInitializationFinished(Game game, object starterObject)
protected virtual void OnApplicationTick(float dt)
protected virtual void OnBeforeInitialModuleScreenSetAsRoot()
public virtual void OnBeforeMissionBehaviorInitialize(Mission mission)
public virtual void OnCampaignStart(Game game, object starterObject)
public virtual void OnConfigChanged()
public virtual void OnGameEnd(Game game)
public virtual void OnGameInitializationFinished(Game game)
public virtual void OnGameLoaded(Game game, object initializerObject)
protected virtual void OnGameStart(Game game, IGameStarter gameStarterObject)
public virtual void OnInitialState()
public virtual void OnMissionBehaviorInitialize(Mission mission)
public virtual void OnMultiplayerGameStart(Game game, object starterObject)
public virtual void OnNewGameCreated(Game game, object initializerObject)
protected virtual void OnSubModuleLoad()
protected virtual void OnSubModuleUnloaded()
public virtual void RegisterSubModuleObjects(bool isSavedCampaign)
```

## Version 1.1.6.26219

```csharp
protected void .ctor()
protected virtual void AfterAsyncTickTick(float dt)
public virtual void AfterRegisterSubModuleObjects(bool isSavedCampaign)
public virtual void BeginGameStart(Game game)
public virtual bool DoLoading(Game game)
protected virtual void InitializeGameStarter(Game game, IGameStarter starterObject)
public virtual void OnAfterGameInitializationFinished(Game game, object starterObject)
protected virtual void OnApplicationTick(float dt)
protected virtual void OnBeforeInitialModuleScreenSetAsRoot()
public virtual void OnBeforeMissionBehaviorInitialize(Mission mission)
public virtual void OnCampaignStart(Game game, object starterObject)
public virtual void OnConfigChanged()
public virtual void OnGameEnd(Game game)
public virtual void OnGameInitializationFinished(Game game)
public virtual void OnGameLoaded(Game game, object initializerObject)
protected virtual void OnGameStart(Game game, IGameStarter gameStarterObject)
public virtual void OnInitialState()
public virtual void OnMissionBehaviorInitialize(Mission mission)
public virtual void OnMultiplayerGameStart(Game game, object starterObject)
public virtual void OnNewGameCreated(Game game, object initializerObject)
protected virtual void OnSubModuleLoad()
protected virtual void OnSubModuleUnloaded()
public virtual void RegisterSubModuleObjects(bool isSavedCampaign)
```

## Version 1.1.6.262191

```csharp
protected void .ctor()
protected virtual void AfterAsyncTickTick(float dt)
public virtual void AfterRegisterSubModuleObjects(bool isSavedCampaign)
public virtual void BeginGameStart(Game game)
public virtual bool DoLoading(Game game)
protected virtual void InitializeGameStarter(Game game, IGameStarter starterObject)
public virtual void OnAfterGameInitializationFinished(Game game, object starterObject)
protected virtual void OnApplicationTick(float dt)
protected virtual void OnBeforeInitialModuleScreenSetAsRoot()
public virtual void OnBeforeMissionBehaviorInitialize(Mission mission)
public virtual void OnCampaignStart(Game game, object starterObject)
public virtual void OnConfigChanged()
public virtual void OnGameEnd(Game game)
public virtual void OnGameInitializationFinished(Game game)
public virtual void OnGameLoaded(Game game, object initializerObject)
protected virtual void OnGameStart(Game game, IGameStarter gameStarterObject)
public virtual void OnInitialState()
public virtual void OnMissionBehaviorInitialize(Mission mission)
public virtual void OnMultiplayerGameStart(Game game, object starterObject)
public virtual void OnNewGameCreated(Game game, object initializerObject)
protected virtual void OnSubModuleLoad()
protected virtual void OnSubModuleUnloaded()
public virtual void RegisterSubModuleObjects(bool isSavedCampaign)
```

## Version 1.2.0.21654-beta

```csharp
protected void .ctor()
protected virtual void AfterAsyncTickTick(float dt)
public virtual void AfterRegisterSubModuleObjects(bool isSavedCampaign)
public virtual void BeginGameStart(Game game)
public virtual bool DoLoading(Game game)
protected virtual void InitializeGameStarter(Game game, IGameStarter starterObject)
public virtual void OnAfterGameInitializationFinished(Game game, object starterObject)
protected virtual void OnApplicationTick(float dt)
protected virtual void OnBeforeInitialModuleScreenSetAsRoot()
public virtual void OnBeforeMissionBehaviorInitialize(Mission mission)
public virtual void OnCampaignStart(Game game, object starterObject)
public virtual void OnConfigChanged()
public virtual void OnGameEnd(Game game)
public virtual void OnGameInitializationFinished(Game game)
public virtual void OnGameLoaded(Game game, object initializerObject)
protected virtual void OnGameStart(Game game, IGameStarter gameStarterObject)
public virtual void OnInitialState()
public virtual void OnMissionBehaviorInitialize(Mission mission)
public virtual void OnMultiplayerGameStart(Game game, object starterObject)
protected virtual void OnNetworkTick(float dt)
public virtual void OnNewGameCreated(Game game, object initializerObject)
protected virtual void OnSubModuleLoad()
protected virtual void OnSubModuleUnloaded()
public virtual void RegisterSubModuleObjects(bool isSavedCampaign)
```

## Version 1.2.1.22001-beta

```csharp
protected void .ctor()
protected virtual void AfterAsyncTickTick(float dt)
public virtual void AfterRegisterSubModuleObjects(bool isSavedCampaign)
public virtual void BeginGameStart(Game game)
public virtual bool DoLoading(Game game)
protected virtual void InitializeGameStarter(Game game, IGameStarter starterObject)
public virtual void OnAfterGameInitializationFinished(Game game, object starterObject)
protected virtual void OnApplicationTick(float dt)
protected virtual void OnBeforeInitialModuleScreenSetAsRoot()
public virtual void OnBeforeMissionBehaviorInitialize(Mission mission)
public virtual void OnCampaignStart(Game game, object starterObject)
public virtual void OnConfigChanged()
public virtual void OnGameEnd(Game game)
public virtual void OnGameInitializationFinished(Game game)
public virtual void OnGameLoaded(Game game, object initializerObject)
protected virtual void OnGameStart(Game game, IGameStarter gameStarterObject)
public virtual void OnInitialState()
public virtual void OnMissionBehaviorInitialize(Mission mission)
public virtual void OnMultiplayerGameStart(Game game, object starterObject)
protected virtual void OnNetworkTick(float dt)
public virtual void OnNewGameCreated(Game game, object initializerObject)
protected virtual void OnSubModuleLoad()
protected virtual void OnSubModuleUnloaded()
public virtual void RegisterSubModuleObjects(bool isSavedCampaign)
```

## Version 1.2.2.22904-beta

```csharp
protected void .ctor()
protected virtual void AfterAsyncTickTick(float dt)
public virtual void AfterRegisterSubModuleObjects(bool isSavedCampaign)
public virtual void BeginGameStart(Game game)
public virtual bool DoLoading(Game game)
protected virtual void InitializeGameStarter(Game game, IGameStarter starterObject)
public virtual void OnAfterGameInitializationFinished(Game game, object starterObject)
protected virtual void OnApplicationTick(float dt)
protected virtual void OnBeforeInitialModuleScreenSetAsRoot()
public virtual void OnBeforeMissionBehaviorInitialize(Mission mission)
public virtual void OnCampaignStart(Game game, object starterObject)
public virtual void OnConfigChanged()
public virtual void OnGameEnd(Game game)
public virtual void OnGameInitializationFinished(Game game)
public virtual void OnGameLoaded(Game game, object initializerObject)
protected virtual void OnGameStart(Game game, IGameStarter gameStarterObject)
public virtual void OnInitialState()
public virtual void OnMissionBehaviorInitialize(Mission mission)
public virtual void OnMultiplayerGameStart(Game game, object starterObject)
protected virtual void OnNetworkTick(float dt)
public virtual void OnNewGameCreated(Game game, object initializerObject)
protected virtual void OnSubModuleLoad()
protected virtual void OnSubModuleUnloaded()
public virtual void RegisterSubModuleObjects(bool isSavedCampaign)
```

## Version 1.2.3.24202-beta

```csharp
protected void .ctor()
protected virtual void AfterAsyncTickTick(float dt)
public virtual void AfterRegisterSubModuleObjects(bool isSavedCampaign)
public virtual void BeginGameStart(Game game)
public virtual bool DoLoading(Game game)
protected virtual void InitializeGameStarter(Game game, IGameStarter starterObject)
public virtual void OnAfterGameInitializationFinished(Game game, object starterObject)
protected virtual void OnApplicationTick(float dt)
protected virtual void OnBeforeInitialModuleScreenSetAsRoot()
public virtual void OnBeforeMissionBehaviorInitialize(Mission mission)
public virtual void OnCampaignStart(Game game, object starterObject)
public virtual void OnConfigChanged()
public virtual void OnGameEnd(Game game)
public virtual void OnGameInitializationFinished(Game game)
public virtual void OnGameLoaded(Game game, object initializerObject)
protected virtual void OnGameStart(Game game, IGameStarter gameStarterObject)
public virtual void OnInitialState()
public virtual void OnMissionBehaviorInitialize(Mission mission)
public virtual void OnMultiplayerGameStart(Game game, object starterObject)
protected virtual void OnNetworkTick(float dt)
public virtual void OnNewGameCreated(Game game, object initializerObject)
protected virtual void OnSubModuleLoad()
protected virtual void OnSubModuleUnloaded()
public virtual void RegisterSubModuleObjects(bool isSavedCampaign)
```

## Version 1.2.4.27066-beta

```csharp
protected void .ctor()
protected virtual void AfterAsyncTickTick(float dt)
public virtual void AfterRegisterSubModuleObjects(bool isSavedCampaign)
public virtual void BeginGameStart(Game game)
public virtual bool DoLoading(Game game)
protected virtual void InitializeGameStarter(Game game, IGameStarter starterObject)
public virtual void OnAfterGameInitializationFinished(Game game, object starterObject)
protected virtual void OnApplicationTick(float dt)
protected virtual void OnBeforeInitialModuleScreenSetAsRoot()
public virtual void OnBeforeMissionBehaviorInitialize(Mission mission)
public virtual void OnCampaignStart(Game game, object starterObject)
public virtual void OnConfigChanged()
public virtual void OnGameEnd(Game game)
public virtual void OnGameInitializationFinished(Game game)
public virtual void OnGameLoaded(Game game, object initializerObject)
protected virtual void OnGameStart(Game game, IGameStarter gameStarterObject)
public virtual void OnInitialState()
public virtual void OnMissionBehaviorInitialize(Mission mission)
public virtual void OnMultiplayerGameStart(Game game, object starterObject)
protected virtual void OnNetworkTick(float dt)
public virtual void OnNewGameCreated(Game game, object initializerObject)
protected virtual void OnSubModuleLoad()
protected virtual void OnSubModuleUnloaded()
public virtual void RegisterSubModuleObjects(bool isSavedCampaign)
```

## Version 1.2.5.30268-beta

```csharp
protected void .ctor()
protected virtual void AfterAsyncTickTick(float dt)
public virtual void AfterRegisterSubModuleObjects(bool isSavedCampaign)
public virtual void BeginGameStart(Game game)
public virtual bool DoLoading(Game game)
protected virtual void InitializeGameStarter(Game game, IGameStarter starterObject)
public virtual void OnAfterGameInitializationFinished(Game game, object starterObject)
protected virtual void OnApplicationTick(float dt)
protected virtual void OnBeforeInitialModuleScreenSetAsRoot()
public virtual void OnBeforeMissionBehaviorInitialize(Mission mission)
public virtual void OnCampaignStart(Game game, object starterObject)
public virtual void OnConfigChanged()
public virtual void OnGameEnd(Game game)
public virtual void OnGameInitializationFinished(Game game)
public virtual void OnGameLoaded(Game game, object initializerObject)
protected virtual void OnGameStart(Game game, IGameStarter gameStarterObject)
public virtual void OnInitialState()
public virtual void OnMissionBehaviorInitialize(Mission mission)
public virtual void OnMultiplayerGameStart(Game game, object starterObject)
protected virtual void OnNetworkTick(float dt)
public virtual void OnNewGameCreated(Game game, object initializerObject)
protected virtual void OnSubModuleLoad()
protected virtual void OnSubModuleUnloaded()
public virtual void RegisterSubModuleObjects(bool isSavedCampaign)
```

## Version 1.2.6.30619-beta

```csharp
protected void .ctor()
protected virtual void AfterAsyncTickTick(float dt)
public virtual void AfterRegisterSubModuleObjects(bool isSavedCampaign)
public virtual void BeginGameStart(Game game)
public virtual bool DoLoading(Game game)
protected virtual void InitializeGameStarter(Game game, IGameStarter starterObject)
public virtual void OnAfterGameInitializationFinished(Game game, object starterObject)
protected virtual void OnApplicationTick(float dt)
protected virtual void OnBeforeInitialModuleScreenSetAsRoot()
public virtual void OnBeforeMissionBehaviorInitialize(Mission mission)
public virtual void OnCampaignStart(Game game, object starterObject)
public virtual void OnConfigChanged()
public virtual void OnGameEnd(Game game)
public virtual void OnGameInitializationFinished(Game game)
public virtual void OnGameLoaded(Game game, object initializerObject)
protected virtual void OnGameStart(Game game, IGameStarter gameStarterObject)
public virtual void OnInitialState()
public virtual void OnMissionBehaviorInitialize(Mission mission)
public virtual void OnMultiplayerGameStart(Game game, object starterObject)
protected virtual void OnNetworkTick(float dt)
public virtual void OnNewGameCreated(Game game, object initializerObject)
protected virtual void OnSubModuleLoad()
protected virtual void OnSubModuleUnloaded()
public virtual void RegisterSubModuleObjects(bool isSavedCampaign)
```

## Version 1.2.6.30619

```csharp
protected void .ctor()
protected virtual void AfterAsyncTickTick(float dt)
public virtual void AfterRegisterSubModuleObjects(bool isSavedCampaign)
public virtual void BeginGameStart(Game game)
public virtual bool DoLoading(Game game)
protected virtual void InitializeGameStarter(Game game, IGameStarter starterObject)
public virtual void OnAfterGameInitializationFinished(Game game, object starterObject)
protected virtual void OnApplicationTick(float dt)
protected virtual void OnBeforeInitialModuleScreenSetAsRoot()
public virtual void OnBeforeMissionBehaviorInitialize(Mission mission)
public virtual void OnCampaignStart(Game game, object starterObject)
public virtual void OnConfigChanged()
public virtual void OnGameEnd(Game game)
public virtual void OnGameInitializationFinished(Game game)
public virtual void OnGameLoaded(Game game, object initializerObject)
protected virtual void OnGameStart(Game game, IGameStarter gameStarterObject)
public virtual void OnInitialState()
public virtual void OnMissionBehaviorInitialize(Mission mission)
public virtual void OnMultiplayerGameStart(Game game, object starterObject)
protected virtual void OnNetworkTick(float dt)
public virtual void OnNewGameCreated(Game game, object initializerObject)
protected virtual void OnSubModuleLoad()
protected virtual void OnSubModuleUnloaded()
public virtual void RegisterSubModuleObjects(bool isSavedCampaign)
```

## Version 1.2.6.306191

```csharp
protected void .ctor()
protected virtual void AfterAsyncTickTick(float dt)
public virtual void AfterRegisterSubModuleObjects(bool isSavedCampaign)
public virtual void BeginGameStart(Game game)
public virtual bool DoLoading(Game game)
protected virtual void InitializeGameStarter(Game game, IGameStarter starterObject)
public virtual void OnAfterGameInitializationFinished(Game game, object starterObject)
protected virtual void OnApplicationTick(float dt)
protected virtual void OnBeforeInitialModuleScreenSetAsRoot()
public virtual void OnBeforeMissionBehaviorInitialize(Mission mission)
public virtual void OnCampaignStart(Game game, object starterObject)
public virtual void OnConfigChanged()
public virtual void OnGameEnd(Game game)
public virtual void OnGameInitializationFinished(Game game)
public virtual void OnGameLoaded(Game game, object initializerObject)
protected virtual void OnGameStart(Game game, IGameStarter gameStarterObject)
public virtual void OnInitialState()
public virtual void OnMissionBehaviorInitialize(Mission mission)
public virtual void OnMultiplayerGameStart(Game game, object starterObject)
protected virtual void OnNetworkTick(float dt)
public virtual void OnNewGameCreated(Game game, object initializerObject)
protected virtual void OnSubModuleLoad()
protected virtual void OnSubModuleUnloaded()
public virtual void RegisterSubModuleObjects(bool isSavedCampaign)
```

## Version 1.2.7.31207

```csharp
protected void .ctor()
protected virtual void AfterAsyncTickTick(float dt)
public virtual void AfterRegisterSubModuleObjects(bool isSavedCampaign)
public virtual void BeginGameStart(Game game)
public virtual bool DoLoading(Game game)
protected virtual void InitializeGameStarter(Game game, IGameStarter starterObject)
public virtual void OnAfterGameInitializationFinished(Game game, object starterObject)
protected virtual void OnApplicationTick(float dt)
protected virtual void OnBeforeInitialModuleScreenSetAsRoot()
public virtual void OnBeforeMissionBehaviorInitialize(Mission mission)
public virtual void OnCampaignStart(Game game, object starterObject)
public virtual void OnConfigChanged()
public virtual void OnGameEnd(Game game)
public virtual void OnGameInitializationFinished(Game game)
public virtual void OnGameLoaded(Game game, object initializerObject)
protected virtual void OnGameStart(Game game, IGameStarter gameStarterObject)
public virtual void OnInitialState()
public virtual void OnMissionBehaviorInitialize(Mission mission)
public virtual void OnMultiplayerGameStart(Game game, object starterObject)
protected virtual void OnNetworkTick(float dt)
public virtual void OnNewGameCreated(Game game, object initializerObject)
protected virtual void OnSubModuleLoad()
protected virtual void OnSubModuleUnloaded()
public virtual void RegisterSubModuleObjects(bool isSavedCampaign)
```

## Version 1.2.7.312071

```csharp
protected void .ctor()
protected virtual void AfterAsyncTickTick(float dt)
public virtual void AfterRegisterSubModuleObjects(bool isSavedCampaign)
public virtual void BeginGameStart(Game game)
public virtual bool DoLoading(Game game)
protected virtual void InitializeGameStarter(Game game, IGameStarter starterObject)
public virtual void OnAfterGameInitializationFinished(Game game, object starterObject)
protected virtual void OnApplicationTick(float dt)
protected virtual void OnBeforeInitialModuleScreenSetAsRoot()
public virtual void OnBeforeMissionBehaviorInitialize(Mission mission)
public virtual void OnCampaignStart(Game game, object starterObject)
public virtual void OnConfigChanged()
public virtual void OnGameEnd(Game game)
public virtual void OnGameInitializationFinished(Game game)
public virtual void OnGameLoaded(Game game, object initializerObject)
protected virtual void OnGameStart(Game game, IGameStarter gameStarterObject)
public virtual void OnInitialState()
public virtual void OnMissionBehaviorInitialize(Mission mission)
public virtual void OnMultiplayerGameStart(Game game, object starterObject)
protected virtual void OnNetworkTick(float dt)
public virtual void OnNewGameCreated(Game game, object initializerObject)
protected virtual void OnSubModuleLoad()
protected virtual void OnSubModuleUnloaded()
public virtual void RegisterSubModuleObjects(bool isSavedCampaign)
```

## Version 1.2.8.31530

```csharp
protected void .ctor()
protected virtual void AfterAsyncTickTick(float dt)
public virtual void AfterRegisterSubModuleObjects(bool isSavedCampaign)
public virtual void BeginGameStart(Game game)
public virtual bool DoLoading(Game game)
protected virtual void InitializeGameStarter(Game game, IGameStarter starterObject)
public virtual void OnAfterGameInitializationFinished(Game game, object starterObject)
protected virtual void OnApplicationTick(float dt)
protected virtual void OnBeforeInitialModuleScreenSetAsRoot()
public virtual void OnBeforeMissionBehaviorInitialize(Mission mission)
public virtual void OnCampaignStart(Game game, object starterObject)
public virtual void OnConfigChanged()
public virtual void OnGameEnd(Game game)
public virtual void OnGameInitializationFinished(Game game)
public virtual void OnGameLoaded(Game game, object initializerObject)
protected virtual void OnGameStart(Game game, IGameStarter gameStarterObject)
public virtual void OnInitialState()
public virtual void OnMissionBehaviorInitialize(Mission mission)
public virtual void OnMultiplayerGameStart(Game game, object starterObject)
protected virtual void OnNetworkTick(float dt)
public virtual void OnNewGameCreated(Game game, object initializerObject)
protected virtual void OnSubModuleLoad()
protected virtual void OnSubModuleUnloaded()
public virtual void RegisterSubModuleObjects(bool isSavedCampaign)
```

## Version 1.2.8.315301

```csharp
protected void .ctor()
protected virtual void AfterAsyncTickTick(float dt)
public virtual void AfterRegisterSubModuleObjects(bool isSavedCampaign)
public virtual void BeginGameStart(Game game)
public virtual bool DoLoading(Game game)
protected virtual void InitializeGameStarter(Game game, IGameStarter starterObject)
public virtual void OnAfterGameInitializationFinished(Game game, object starterObject)
protected virtual void OnApplicationTick(float dt)
protected virtual void OnBeforeInitialModuleScreenSetAsRoot()
public virtual void OnBeforeMissionBehaviorInitialize(Mission mission)
public virtual void OnCampaignStart(Game game, object starterObject)
public virtual void OnConfigChanged()
public virtual void OnGameEnd(Game game)
public virtual void OnGameInitializationFinished(Game game)
public virtual void OnGameLoaded(Game game, object initializerObject)
protected virtual void OnGameStart(Game game, IGameStarter gameStarterObject)
public virtual void OnInitialState()
public virtual void OnMissionBehaviorInitialize(Mission mission)
public virtual void OnMultiplayerGameStart(Game game, object starterObject)
protected virtual void OnNetworkTick(float dt)
public virtual void OnNewGameCreated(Game game, object initializerObject)
protected virtual void OnSubModuleLoad()
protected virtual void OnSubModuleUnloaded()
public virtual void RegisterSubModuleObjects(bool isSavedCampaign)
```

## Version 1.2.9.33689

```csharp
protected void .ctor()
protected virtual void AfterAsyncTickTick(float dt)
public virtual void AfterRegisterSubModuleObjects(bool isSavedCampaign)
public virtual void BeginGameStart(Game game)
public virtual bool DoLoading(Game game)
protected virtual void InitializeGameStarter(Game game, IGameStarter starterObject)
public virtual void OnAfterGameInitializationFinished(Game game, object starterObject)
protected virtual void OnApplicationTick(float dt)
protected virtual void OnBeforeInitialModuleScreenSetAsRoot()
public virtual void OnBeforeMissionBehaviorInitialize(Mission mission)
public virtual void OnCampaignStart(Game game, object starterObject)
public virtual void OnConfigChanged()
public virtual void OnGameEnd(Game game)
public virtual void OnGameInitializationFinished(Game game)
public virtual void OnGameLoaded(Game game, object initializerObject)
protected virtual void OnGameStart(Game game, IGameStarter gameStarterObject)
public virtual void OnInitialState()
public virtual void OnMissionBehaviorInitialize(Mission mission)
public virtual void OnMultiplayerGameStart(Game game, object starterObject)
protected virtual void OnNetworkTick(float dt)
public virtual void OnNewGameCreated(Game game, object initializerObject)
protected virtual void OnSubModuleLoad()
protected virtual void OnSubModuleUnloaded()
public virtual void RegisterSubModuleObjects(bool isSavedCampaign)
```

## Version 1.2.9.34019

```csharp
protected void .ctor()
protected virtual void AfterAsyncTickTick(float dt)
public virtual void AfterRegisterSubModuleObjects(bool isSavedCampaign)
public virtual void BeginGameStart(Game game)
public virtual bool DoLoading(Game game)
protected virtual void InitializeGameStarter(Game game, IGameStarter starterObject)
public virtual void OnAfterGameInitializationFinished(Game game, object starterObject)
protected virtual void OnApplicationTick(float dt)
protected virtual void OnBeforeInitialModuleScreenSetAsRoot()
public virtual void OnBeforeMissionBehaviorInitialize(Mission mission)
public virtual void OnCampaignStart(Game game, object starterObject)
public virtual void OnConfigChanged()
public virtual void OnGameEnd(Game game)
public virtual void OnGameInitializationFinished(Game game)
public virtual void OnGameLoaded(Game game, object initializerObject)
protected virtual void OnGameStart(Game game, IGameStarter gameStarterObject)
public virtual void OnInitialState()
public virtual void OnMissionBehaviorInitialize(Mission mission)
public virtual void OnMultiplayerGameStart(Game game, object starterObject)
protected virtual void OnNetworkTick(float dt)
public virtual void OnNewGameCreated(Game game, object initializerObject)
protected virtual void OnSubModuleLoad()
protected virtual void OnSubModuleUnloaded()
public virtual void RegisterSubModuleObjects(bool isSavedCampaign)
```

## Version 1.2.9.34269

```csharp
protected void .ctor()
protected virtual void AfterAsyncTickTick(float dt)
public virtual void AfterRegisterSubModuleObjects(bool isSavedCampaign)
public virtual void BeginGameStart(Game game)
public virtual bool DoLoading(Game game)
protected virtual void InitializeGameStarter(Game game, IGameStarter starterObject)
public virtual void OnAfterGameInitializationFinished(Game game, object starterObject)
protected virtual void OnApplicationTick(float dt)
protected virtual void OnBeforeInitialModuleScreenSetAsRoot()
public virtual void OnBeforeMissionBehaviorInitialize(Mission mission)
public virtual void OnCampaignStart(Game game, object starterObject)
public virtual void OnConfigChanged()
public virtual void OnGameEnd(Game game)
public virtual void OnGameInitializationFinished(Game game)
public virtual void OnGameLoaded(Game game, object initializerObject)
protected virtual void OnGameStart(Game game, IGameStarter gameStarterObject)
public virtual void OnInitialState()
public virtual void OnMissionBehaviorInitialize(Mission mission)
public virtual void OnMultiplayerGameStart(Game game, object starterObject)
protected virtual void OnNetworkTick(float dt)
public virtual void OnNewGameCreated(Game game, object initializerObject)
protected virtual void OnSubModuleLoad()
protected virtual void OnSubModuleUnloaded()
public virtual void RegisterSubModuleObjects(bool isSavedCampaign)
```

## Version 1.2.9.35636

```csharp
protected void .ctor()
protected virtual void AfterAsyncTickTick(float dt)
public virtual void AfterRegisterSubModuleObjects(bool isSavedCampaign)
public virtual void BeginGameStart(Game game)
public virtual bool DoLoading(Game game)
protected virtual void InitializeGameStarter(Game game, IGameStarter starterObject)
public virtual void OnAfterGameInitializationFinished(Game game, object starterObject)
protected virtual void OnApplicationTick(float dt)
protected virtual void OnBeforeInitialModuleScreenSetAsRoot()
public virtual void OnBeforeMissionBehaviorInitialize(Mission mission)
public virtual void OnCampaignStart(Game game, object starterObject)
public virtual void OnConfigChanged()
public virtual void OnGameEnd(Game game)
public virtual void OnGameInitializationFinished(Game game)
public virtual void OnGameLoaded(Game game, object initializerObject)
protected virtual void OnGameStart(Game game, IGameStarter gameStarterObject)
public virtual void OnInitialState()
public virtual void OnMissionBehaviorInitialize(Mission mission)
public virtual void OnMultiplayerGameStart(Game game, object starterObject)
protected virtual void OnNetworkTick(float dt)
public virtual void OnNewGameCreated(Game game, object initializerObject)
protected virtual void OnSubModuleLoad()
protected virtual void OnSubModuleUnloaded()
public virtual void RegisterSubModuleObjects(bool isSavedCampaign)
```

## Version 1.2.9.38256

```csharp
protected void .ctor()
protected virtual void AfterAsyncTickTick(float dt)
public virtual void AfterRegisterSubModuleObjects(bool isSavedCampaign)
public virtual void BeginGameStart(Game game)
public virtual bool DoLoading(Game game)
protected virtual void InitializeGameStarter(Game game, IGameStarter starterObject)
public virtual void OnAfterGameInitializationFinished(Game game, object starterObject)
protected virtual void OnApplicationTick(float dt)
protected virtual void OnBeforeInitialModuleScreenSetAsRoot()
public virtual void OnBeforeMissionBehaviorInitialize(Mission mission)
public virtual void OnCampaignStart(Game game, object starterObject)
public virtual void OnConfigChanged()
public virtual void OnGameEnd(Game game)
public virtual void OnGameInitializationFinished(Game game)
public virtual void OnGameLoaded(Game game, object initializerObject)
protected virtual void OnGameStart(Game game, IGameStarter gameStarterObject)
public virtual void OnInitialState()
public virtual void OnMissionBehaviorInitialize(Mission mission)
public virtual void OnMultiplayerGameStart(Game game, object starterObject)
protected virtual void OnNetworkTick(float dt)
public virtual void OnNewGameCreated(Game game, object initializerObject)
protected virtual void OnSubModuleLoad()
protected virtual void OnSubModuleUnloaded()
public virtual void RegisterSubModuleObjects(bool isSavedCampaign)
```

## Version 1.2.9.382561

```csharp
protected void .ctor()
protected virtual void AfterAsyncTickTick(float dt)
public virtual void AfterRegisterSubModuleObjects(bool isSavedCampaign)
public virtual void BeginGameStart(Game game)
public virtual bool DoLoading(Game game)
protected virtual void InitializeGameStarter(Game game, IGameStarter starterObject)
public virtual void OnAfterGameInitializationFinished(Game game, object starterObject)
protected virtual void OnApplicationTick(float dt)
protected virtual void OnBeforeInitialModuleScreenSetAsRoot()
public virtual void OnBeforeMissionBehaviorInitialize(Mission mission)
public virtual void OnCampaignStart(Game game, object starterObject)
public virtual void OnConfigChanged()
public virtual void OnGameEnd(Game game)
public virtual void OnGameInitializationFinished(Game game)
public virtual void OnGameLoaded(Game game, object initializerObject)
protected virtual void OnGameStart(Game game, IGameStarter gameStarterObject)
public virtual void OnInitialState()
public virtual void OnMissionBehaviorInitialize(Mission mission)
public virtual void OnMultiplayerGameStart(Game game, object starterObject)
protected virtual void OnNetworkTick(float dt)
public virtual void OnNewGameCreated(Game game, object initializerObject)
protected virtual void OnSubModuleLoad()
protected virtual void OnSubModuleUnloaded()
public virtual void RegisterSubModuleObjects(bool isSavedCampaign)
```

## Version 1.2.10.41450-beta

```csharp
protected void .ctor()
protected virtual void AfterAsyncTickTick(float dt)
public virtual void AfterRegisterSubModuleObjects(bool isSavedCampaign)
public virtual void BeginGameStart(Game game)
public virtual bool DoLoading(Game game)
protected virtual void InitializeGameStarter(Game game, IGameStarter starterObject)
public virtual void OnAfterGameInitializationFinished(Game game, object starterObject)
protected virtual void OnApplicationTick(float dt)
protected virtual void OnBeforeInitialModuleScreenSetAsRoot()
public virtual void OnBeforeMissionBehaviorInitialize(Mission mission)
public virtual void OnCampaignStart(Game game, object starterObject)
public virtual void OnConfigChanged()
public virtual void OnGameEnd(Game game)
public virtual void OnGameInitializationFinished(Game game)
public virtual void OnGameLoaded(Game game, object initializerObject)
protected virtual void OnGameStart(Game game, IGameStarter gameStarterObject)
public virtual void OnInitialState()
public virtual void OnMissionBehaviorInitialize(Mission mission)
public virtual void OnMultiplayerGameStart(Game game, object starterObject)
protected virtual void OnNetworkTick(float dt)
public virtual void OnNewGameCreated(Game game, object initializerObject)
protected virtual void OnSubModuleLoad()
protected virtual void OnSubModuleUnloaded()
public virtual void RegisterSubModuleObjects(bool isSavedCampaign)
```

## Version 1.2.10.42197

```csharp
protected void .ctor()
protected virtual void AfterAsyncTickTick(float dt)
public virtual void AfterRegisterSubModuleObjects(bool isSavedCampaign)
public virtual void BeginGameStart(Game game)
public virtual bool DoLoading(Game game)
protected virtual void InitializeGameStarter(Game game, IGameStarter starterObject)
public virtual void OnAfterGameInitializationFinished(Game game, object starterObject)
protected virtual void OnApplicationTick(float dt)
protected virtual void OnBeforeInitialModuleScreenSetAsRoot()
public virtual void OnBeforeMissionBehaviorInitialize(Mission mission)
public virtual void OnCampaignStart(Game game, object starterObject)
public virtual void OnConfigChanged()
public virtual void OnGameEnd(Game game)
public virtual void OnGameInitializationFinished(Game game)
public virtual void OnGameLoaded(Game game, object initializerObject)
protected virtual void OnGameStart(Game game, IGameStarter gameStarterObject)
public virtual void OnInitialState()
public virtual void OnMissionBehaviorInitialize(Mission mission)
public virtual void OnMultiplayerGameStart(Game game, object starterObject)
protected virtual void OnNetworkTick(float dt)
public virtual void OnNewGameCreated(Game game, object initializerObject)
protected virtual void OnSubModuleLoad()
protected virtual void OnSubModuleUnloaded()
public virtual void RegisterSubModuleObjects(bool isSavedCampaign)
```

## Version 1.2.10.44489

```csharp
protected void .ctor()
protected virtual void AfterAsyncTickTick(float dt)
public virtual void AfterRegisterSubModuleObjects(bool isSavedCampaign)
public virtual void BeginGameStart(Game game)
public virtual bool DoLoading(Game game)
protected virtual void InitializeGameStarter(Game game, IGameStarter starterObject)
public virtual void OnAfterGameInitializationFinished(Game game, object starterObject)
protected virtual void OnApplicationTick(float dt)
protected virtual void OnBeforeInitialModuleScreenSetAsRoot()
public virtual void OnBeforeMissionBehaviorInitialize(Mission mission)
public virtual void OnCampaignStart(Game game, object starterObject)
public virtual void OnConfigChanged()
public virtual void OnGameEnd(Game game)
public virtual void OnGameInitializationFinished(Game game)
public virtual void OnGameLoaded(Game game, object initializerObject)
protected virtual void OnGameStart(Game game, IGameStarter gameStarterObject)
public virtual void OnInitialState()
public virtual void OnMissionBehaviorInitialize(Mission mission)
public virtual void OnMultiplayerGameStart(Game game, object starterObject)
protected virtual void OnNetworkTick(float dt)
public virtual void OnNewGameCreated(Game game, object initializerObject)
protected virtual void OnSubModuleLoad()
protected virtual void OnSubModuleUnloaded()
public virtual void RegisterSubModuleObjects(bool isSavedCampaign)
```

## Version 1.2.10.414501-beta

```csharp
protected void .ctor()
protected virtual void AfterAsyncTickTick(float dt)
public virtual void AfterRegisterSubModuleObjects(bool isSavedCampaign)
public virtual void BeginGameStart(Game game)
public virtual bool DoLoading(Game game)
protected virtual void InitializeGameStarter(Game game, IGameStarter starterObject)
public virtual void OnAfterGameInitializationFinished(Game game, object starterObject)
protected virtual void OnApplicationTick(float dt)
protected virtual void OnBeforeInitialModuleScreenSetAsRoot()
public virtual void OnBeforeMissionBehaviorInitialize(Mission mission)
public virtual void OnCampaignStart(Game game, object starterObject)
public virtual void OnConfigChanged()
public virtual void OnGameEnd(Game game)
public virtual void OnGameInitializationFinished(Game game)
public virtual void OnGameLoaded(Game game, object initializerObject)
protected virtual void OnGameStart(Game game, IGameStarter gameStarterObject)
public virtual void OnInitialState()
public virtual void OnMissionBehaviorInitialize(Mission mission)
public virtual void OnMultiplayerGameStart(Game game, object starterObject)
protected virtual void OnNetworkTick(float dt)
public virtual void OnNewGameCreated(Game game, object initializerObject)
protected virtual void OnSubModuleLoad()
protected virtual void OnSubModuleUnloaded()
public virtual void RegisterSubModuleObjects(bool isSavedCampaign)
```

## Version 1.2.11.45088

```csharp
protected void .ctor()
protected virtual void AfterAsyncTickTick(float dt)
public virtual void AfterRegisterSubModuleObjects(bool isSavedCampaign)
public virtual void BeginGameStart(Game game)
public virtual bool DoLoading(Game game)
protected virtual void InitializeGameStarter(Game game, IGameStarter starterObject)
public virtual void OnAfterGameInitializationFinished(Game game, object starterObject)
protected virtual void OnApplicationTick(float dt)
protected virtual void OnBeforeInitialModuleScreenSetAsRoot()
public virtual void OnBeforeMissionBehaviorInitialize(Mission mission)
public virtual void OnCampaignStart(Game game, object starterObject)
public virtual void OnConfigChanged()
public virtual void OnGameEnd(Game game)
public virtual void OnGameInitializationFinished(Game game)
public virtual void OnGameLoaded(Game game, object initializerObject)
protected virtual void OnGameStart(Game game, IGameStarter gameStarterObject)
public virtual void OnInitialState()
public virtual void OnMissionBehaviorInitialize(Mission mission)
public virtual void OnMultiplayerGameStart(Game game, object starterObject)
protected virtual void OnNetworkTick(float dt)
public virtual void OnNewGameCreated(Game game, object initializerObject)
protected virtual void OnSubModuleLoad()
protected virtual void OnSubModuleUnloaded()
public virtual void RegisterSubModuleObjects(bool isSavedCampaign)
```

## Version 1.2.11.45697

```csharp
protected void .ctor()
protected virtual void AfterAsyncTickTick(float dt)
public virtual void AfterRegisterSubModuleObjects(bool isSavedCampaign)
public virtual void BeginGameStart(Game game)
public virtual bool DoLoading(Game game)
protected virtual void InitializeGameStarter(Game game, IGameStarter starterObject)
public virtual void OnAfterGameInitializationFinished(Game game, object starterObject)
protected virtual void OnApplicationTick(float dt)
protected virtual void OnBeforeInitialModuleScreenSetAsRoot()
public virtual void OnBeforeMissionBehaviorInitialize(Mission mission)
public virtual void OnCampaignStart(Game game, object starterObject)
public virtual void OnConfigChanged()
public virtual void OnGameEnd(Game game)
public virtual void OnGameInitializationFinished(Game game)
public virtual void OnGameLoaded(Game game, object initializerObject)
protected virtual void OnGameStart(Game game, IGameStarter gameStarterObject)
public virtual void OnInitialState()
public virtual void OnMissionBehaviorInitialize(Mission mission)
public virtual void OnMultiplayerGameStart(Game game, object starterObject)
protected virtual void OnNetworkTick(float dt)
public virtual void OnNewGameCreated(Game game, object initializerObject)
protected virtual void OnSubModuleLoad()
protected virtual void OnSubModuleUnloaded()
public virtual void RegisterSubModuleObjects(bool isSavedCampaign)
```

## Version 1.2.12.54620

```csharp
protected void .ctor()
protected virtual void AfterAsyncTickTick(float dt)
public virtual void AfterRegisterSubModuleObjects(bool isSavedCampaign)
public virtual void BeginGameStart(Game game)
public virtual bool DoLoading(Game game)
protected virtual void InitializeGameStarter(Game game, IGameStarter starterObject)
public virtual void OnAfterGameInitializationFinished(Game game, object starterObject)
protected virtual void OnApplicationTick(float dt)
protected virtual void OnBeforeInitialModuleScreenSetAsRoot()
public virtual void OnBeforeMissionBehaviorInitialize(Mission mission)
public virtual void OnCampaignStart(Game game, object starterObject)
public virtual void OnConfigChanged()
public virtual void OnGameEnd(Game game)
public virtual void OnGameInitializationFinished(Game game)
public virtual void OnGameLoaded(Game game, object initializerObject)
protected virtual void OnGameStart(Game game, IGameStarter gameStarterObject)
public virtual void OnInitialState()
public virtual void OnMissionBehaviorInitialize(Mission mission)
public virtual void OnMultiplayerGameStart(Game game, object starterObject)
protected virtual void OnNetworkTick(float dt)
public virtual void OnNewGameCreated(Game game, object initializerObject)
protected virtual void OnSubModuleLoad()
protected virtual void OnSubModuleUnloaded()
public virtual void RegisterSubModuleObjects(bool isSavedCampaign)
```

## Version 1.2.12.66233

```csharp
protected void .ctor()
protected virtual void AfterAsyncTickTick(float dt)
public virtual void AfterRegisterSubModuleObjects(bool isSavedCampaign)
public virtual void BeginGameStart(Game game)
public virtual bool DoLoading(Game game)
protected virtual void InitializeGameStarter(Game game, IGameStarter starterObject)
public virtual void OnAfterGameInitializationFinished(Game game, object starterObject)
protected virtual void OnApplicationTick(float dt)
protected virtual void OnBeforeInitialModuleScreenSetAsRoot()
public virtual void OnBeforeMissionBehaviorInitialize(Mission mission)
public virtual void OnCampaignStart(Game game, object starterObject)
public virtual void OnConfigChanged()
public virtual void OnGameEnd(Game game)
public virtual void OnGameInitializationFinished(Game game)
public virtual void OnGameLoaded(Game game, object initializerObject)
protected virtual void OnGameStart(Game game, IGameStarter gameStarterObject)
public virtual void OnInitialState()
public virtual void OnMissionBehaviorInitialize(Mission mission)
public virtual void OnMultiplayerGameStart(Game game, object starterObject)
protected virtual void OnNetworkTick(float dt)
public virtual void OnNewGameCreated(Game game, object initializerObject)
protected virtual void OnSubModuleLoad()
protected virtual void OnSubModuleUnloaded()
public virtual void RegisterSubModuleObjects(bool isSavedCampaign)
```

## Version 1.2.12.77991

```csharp
protected void .ctor()
protected virtual void AfterAsyncTickTick(float dt)
public virtual void AfterRegisterSubModuleObjects(bool isSavedCampaign)
public virtual void BeginGameStart(Game game)
public virtual bool DoLoading(Game game)
protected virtual void InitializeGameStarter(Game game, IGameStarter starterObject)
public virtual void OnAfterGameInitializationFinished(Game game, object starterObject)
protected virtual void OnApplicationTick(float dt)
protected virtual void OnBeforeInitialModuleScreenSetAsRoot()
public virtual void OnBeforeMissionBehaviorInitialize(Mission mission)
public virtual void OnCampaignStart(Game game, object starterObject)
public virtual void OnConfigChanged()
public virtual void OnGameEnd(Game game)
public virtual void OnGameInitializationFinished(Game game)
public virtual void OnGameLoaded(Game game, object initializerObject)
protected virtual void OnGameStart(Game game, IGameStarter gameStarterObject)
public virtual void OnInitialState()
public virtual void OnMissionBehaviorInitialize(Mission mission)
public virtual void OnMultiplayerGameStart(Game game, object starterObject)
protected virtual void OnNetworkTick(float dt)
public virtual void OnNewGameCreated(Game game, object initializerObject)
protected virtual void OnSubModuleLoad()
protected virtual void OnSubModuleUnloaded()
public virtual void RegisterSubModuleObjects(bool isSavedCampaign)
```

## Version 1.3.0.89406-beta

```csharp
protected void .ctor()
protected virtual void AfterAsyncTickTick(float dt)
public virtual void AfterRegisterSubModuleObjects(bool isSavedCampaign)
public virtual void BeginGameStart(Game game)
public virtual bool DoLoading(Game game)
protected virtual void InitializeGameStarter(Game game, IGameStarter starterObject)
public virtual void InitializeSubModuleGameObjects(Game game)
public virtual void OnAfterGameInitializationFinished(Game game, object starterObject)
public virtual void OnAfterGameLoaded(Game game)
protected virtual void OnApplicationTick(float dt)
protected virtual void OnBeforeGameStart(MBGameManager mbGameManager, List<string> disabledModules)
protected virtual void OnBeforeInitialModuleScreenSetAsRoot()
public virtual void OnBeforeMissionBehaviorInitialize(Mission mission)
public virtual void OnCampaignStart(Game game, object starterObject)
public virtual void OnConfigChanged()
public virtual void OnGameEnd(Game game)
public virtual void OnGameInitializationFinished(Game game)
public virtual void OnGameLoaded(Game game, object initializerObject)
protected virtual void OnGameStart(Game game, IGameStarter gameStarterObject)
public virtual void OnInitialState()
public virtual void OnMissionBehaviorInitialize(Mission mission)
public virtual void OnMultiplayerGameStart(Game game, object starterObject)
protected virtual void OnNetworkTick(float dt)
public virtual void OnNewGameCreated(Game game, object initializerObject)
protected virtual void OnNewModuleLoad()
public virtual void OnSubModuleActivated()
public virtual void OnSubModuleDeactivated()
protected virtual void OnSubModuleLoad()
protected virtual void OnSubModuleUnloaded()
public virtual void RegisterSubModuleObjects(bool isSavedCampaign)
protected virtual void RegisterSubModuleTypes()
```

## Version 1.3.0.89661-beta

```csharp
protected void .ctor()
protected virtual void AfterAsyncTickTick(float dt)
public virtual void AfterRegisterSubModuleObjects(bool isSavedCampaign)
public virtual void BeginGameStart(Game game)
public virtual bool DoLoading(Game game)
protected virtual void InitializeGameStarter(Game game, IGameStarter starterObject)
public virtual void InitializeSubModuleGameObjects(Game game)
public virtual void OnAfterGameInitializationFinished(Game game, object starterObject)
public virtual void OnAfterGameLoaded(Game game)
protected virtual void OnApplicationTick(float dt)
protected virtual void OnBeforeGameStart(MBGameManager mbGameManager, List<string> disabledModules)
protected virtual void OnBeforeInitialModuleScreenSetAsRoot()
public virtual void OnBeforeMissionBehaviorInitialize(Mission mission)
public virtual void OnCampaignStart(Game game, object starterObject)
public virtual void OnConfigChanged()
public virtual void OnGameEnd(Game game)
public virtual void OnGameInitializationFinished(Game game)
public virtual void OnGameLoaded(Game game, object initializerObject)
protected virtual void OnGameStart(Game game, IGameStarter gameStarterObject)
public virtual void OnInitialState()
public virtual void OnMissionBehaviorInitialize(Mission mission)
public virtual void OnMultiplayerGameStart(Game game, object starterObject)
protected virtual void OnNetworkTick(float dt)
public virtual void OnNewGameCreated(Game game, object initializerObject)
protected virtual void OnNewModuleLoad()
public virtual void OnSubModuleActivated()
public virtual void OnSubModuleDeactivated()
protected virtual void OnSubModuleLoad()
protected virtual void OnSubModuleUnloaded()
public virtual void RegisterSubModuleObjects(bool isSavedCampaign)
protected virtual void RegisterSubModuleTypes()
```

## Version 1.3.1.90869-beta

```csharp
protected void .ctor()
protected virtual void AfterAsyncTickTick(float dt)
public virtual void AfterRegisterSubModuleObjects(bool isSavedCampaign)
public virtual void BeginGameStart(Game game)
public virtual bool DoLoading(Game game)
protected virtual void InitializeGameStarter(Game game, IGameStarter starterObject)
public virtual void InitializeSubModuleGameObjects(Game game)
public virtual void OnAfterGameInitializationFinished(Game game, object starterObject)
public virtual void OnAfterGameLoaded(Game game)
protected virtual void OnApplicationTick(float dt)
protected virtual void OnBeforeGameStart(MBGameManager mbGameManager, List<string> disabledModules)
protected virtual void OnBeforeInitialModuleScreenSetAsRoot()
public virtual void OnBeforeMissionBehaviorInitialize(Mission mission)
public virtual void OnCampaignStart(Game game, object starterObject)
public virtual void OnConfigChanged()
public virtual void OnGameEnd(Game game)
public virtual void OnGameInitializationFinished(Game game)
public virtual void OnGameLoaded(Game game, object initializerObject)
protected virtual void OnGameStart(Game game, IGameStarter gameStarterObject)
public virtual void OnInitialState()
public virtual void OnMissionBehaviorInitialize(Mission mission)
public virtual void OnMultiplayerGameStart(Game game, object starterObject)
protected virtual void OnNetworkTick(float dt)
public virtual void OnNewGameCreated(Game game, object initializerObject)
protected virtual void OnNewModuleLoad()
public virtual void OnSubModuleActivated()
public virtual void OnSubModuleDeactivated()
protected virtual void OnSubModuleLoad()
protected virtual void OnSubModuleUnloaded()
public virtual void RegisterSubModuleObjects(bool isSavedCampaign)
protected virtual void RegisterSubModuleTypes()
```

## Version 1.3.2.96234-beta

```csharp
protected void .ctor()
protected virtual void AfterAsyncTickTick(float dt)
public virtual void AfterRegisterSubModuleObjects(bool isSavedCampaign)
public virtual void BeginGameStart(Game game)
public virtual bool DoLoading(Game game)
protected virtual void InitializeGameStarter(Game game, IGameStarter starterObject)
public virtual void InitializeSubModuleGameObjects(Game game)
public virtual void OnAfterGameInitializationFinished(Game game, object starterObject)
public virtual void OnAfterGameLoaded(Game game)
protected virtual void OnApplicationTick(float dt)
protected virtual void OnBeforeGameStart(MBGameManager mbGameManager, List<string> disabledModules)
protected virtual void OnBeforeInitialModuleScreenSetAsRoot()
public virtual void OnBeforeMissionBehaviorInitialize(Mission mission)
public virtual void OnCampaignStart(Game game, object starterObject)
public virtual void OnConfigChanged()
public virtual void OnGameEnd(Game game)
public virtual void OnGameInitializationFinished(Game game)
public virtual void OnGameLoaded(Game game, object initializerObject)
protected virtual void OnGameStart(Game game, IGameStarter gameStarterObject)
public virtual void OnInitialState()
public virtual void OnMissionBehaviorInitialize(Mission mission)
public virtual void OnMultiplayerGameStart(Game game, object starterObject)
protected virtual void OnNetworkTick(float dt)
public virtual void OnNewGameCreated(Game game, object initializerObject)
protected virtual void OnNewModuleLoad()
public virtual void OnSubModuleActivated()
public virtual void OnSubModuleDeactivated()
protected virtual void OnSubModuleLoad()
protected virtual void OnSubModuleUnloaded()
public virtual void RegisterSubModuleObjects(bool isSavedCampaign)
protected virtual void RegisterSubModuleTypes()
```

## Version 1.3.4.102430

```csharp
protected void .ctor()
protected virtual void AfterAsyncTickTick(float dt)
public virtual void AfterRegisterSubModuleObjects(bool isSavedCampaign)
public virtual void BeginGameStart(Game game)
public virtual bool DoLoading(Game game)
protected virtual void InitializeGameStarter(Game game, IGameStarter starterObject)
public virtual void InitializeSubModuleGameObjects(Game game)
public virtual void OnAfterGameInitializationFinished(Game game, object starterObject)
public virtual void OnAfterGameLoaded(Game game)
protected virtual void OnApplicationTick(float dt)
protected virtual void OnBeforeGameStart(MBGameManager mbGameManager, List<string> disabledModules)
protected virtual void OnBeforeInitialModuleScreenSetAsRoot()
public virtual void OnBeforeMissionBehaviorInitialize(Mission mission)
public virtual void OnCampaignStart(Game game, object starterObject)
public virtual void OnConfigChanged()
public virtual void OnGameEnd(Game game)
public virtual void OnGameInitializationFinished(Game game)
public virtual void OnGameLoaded(Game game, object initializerObject)
protected virtual void OnGameStart(Game game, IGameStarter gameStarterObject)
public virtual void OnInitialState()
public virtual void OnMissionBehaviorInitialize(Mission mission)
public virtual void OnMultiplayerGameStart(Game game, object starterObject)
protected virtual void OnNetworkTick(float dt)
public virtual void OnNewGameCreated(Game game, object initializerObject)
protected virtual void OnNewModuleLoad()
public virtual void OnSubModuleActivated()
public virtual void OnSubModuleDeactivated()
protected virtual void OnSubModuleLoad()
protected virtual void OnSubModuleUnloaded()
public virtual void RegisterSubModuleObjects(bool isSavedCampaign)
protected virtual void RegisterSubModuleTypes()
```

## Version 1.3.5.102453-beta

```csharp
protected void .ctor()
protected virtual void AfterAsyncTickTick(float dt)
public virtual void AfterRegisterSubModuleObjects(bool isSavedCampaign)
public virtual void BeginGameStart(Game game)
public virtual bool DoLoading(Game game)
protected virtual void InitializeGameStarter(Game game, IGameStarter starterObject)
public virtual void InitializeSubModuleGameObjects(Game game)
public virtual void OnAfterGameInitializationFinished(Game game, object starterObject)
public virtual void OnAfterGameLoaded(Game game)
protected virtual void OnApplicationTick(float dt)
protected virtual void OnBeforeGameStart(MBGameManager mbGameManager, List<string> disabledModules)
protected virtual void OnBeforeInitialModuleScreenSetAsRoot()
public virtual void OnBeforeMissionBehaviorInitialize(Mission mission)
public virtual void OnCampaignStart(Game game, object starterObject)
public virtual void OnConfigChanged()
public virtual void OnGameEnd(Game game)
public virtual void OnGameInitializationFinished(Game game)
public virtual void OnGameLoaded(Game game, object initializerObject)
protected virtual void OnGameStart(Game game, IGameStarter gameStarterObject)
public virtual void OnInitialState()
public virtual void OnMissionBehaviorInitialize(Mission mission)
public virtual void OnMultiplayerGameStart(Game game, object starterObject)
protected virtual void OnNetworkTick(float dt)
public virtual void OnNewGameCreated(Game game, object initializerObject)
protected virtual void OnNewModuleLoad()
public virtual void OnSubModuleActivated()
public virtual void OnSubModuleDeactivated()
protected virtual void OnSubModuleLoad()
protected virtual void OnSubModuleUnloaded()
public virtual void RegisterSubModuleObjects(bool isSavedCampaign)
protected virtual void RegisterSubModuleTypes()
```

## Version 1.3.5.102453

```csharp
protected void .ctor()
protected virtual void AfterAsyncTickTick(float dt)
public virtual void AfterRegisterSubModuleObjects(bool isSavedCampaign)
public virtual void BeginGameStart(Game game)
public virtual bool DoLoading(Game game)
protected virtual void InitializeGameStarter(Game game, IGameStarter starterObject)
public virtual void InitializeSubModuleGameObjects(Game game)
public virtual void OnAfterGameInitializationFinished(Game game, object starterObject)
public virtual void OnAfterGameLoaded(Game game)
protected virtual void OnApplicationTick(float dt)
protected virtual void OnBeforeGameStart(MBGameManager mbGameManager, List<string> disabledModules)
protected virtual void OnBeforeInitialModuleScreenSetAsRoot()
public virtual void OnBeforeMissionBehaviorInitialize(Mission mission)
public virtual void OnCampaignStart(Game game, object starterObject)
public virtual void OnConfigChanged()
public virtual void OnGameEnd(Game game)
public virtual void OnGameInitializationFinished(Game game)
public virtual void OnGameLoaded(Game game, object initializerObject)
protected virtual void OnGameStart(Game game, IGameStarter gameStarterObject)
public virtual void OnInitialState()
public virtual void OnMissionBehaviorInitialize(Mission mission)
public virtual void OnMultiplayerGameStart(Game game, object starterObject)
protected virtual void OnNetworkTick(float dt)
public virtual void OnNewGameCreated(Game game, object initializerObject)
protected virtual void OnNewModuleLoad()
public virtual void OnSubModuleActivated()
public virtual void OnSubModuleDeactivated()
protected virtual void OnSubModuleLoad()
protected virtual void OnSubModuleUnloaded()
public virtual void RegisterSubModuleObjects(bool isSavedCampaign)
protected virtual void RegisterSubModuleTypes()
```

## Version 1.3.6.102656-beta

```csharp
protected void .ctor()
protected virtual void AfterAsyncTickTick(float dt)
public virtual void AfterRegisterSubModuleObjects(bool isSavedCampaign)
public virtual void BeginGameStart(Game game)
public virtual bool DoLoading(Game game)
protected virtual void InitializeGameStarter(Game game, IGameStarter starterObject)
public virtual void InitializeSubModuleGameObjects(Game game)
public virtual void OnAfterGameInitializationFinished(Game game, object starterObject)
public virtual void OnAfterGameLoaded(Game game)
protected virtual void OnApplicationTick(float dt)
protected virtual void OnBeforeGameStart(MBGameManager mbGameManager, List<string> disabledModules)
protected virtual void OnBeforeInitialModuleScreenSetAsRoot()
public virtual void OnBeforeMissionBehaviorInitialize(Mission mission)
public virtual void OnCampaignStart(Game game, object starterObject)
public virtual void OnConfigChanged()
public virtual void OnGameEnd(Game game)
public virtual void OnGameInitializationFinished(Game game)
public virtual void OnGameLoaded(Game game, object initializerObject)
protected virtual void OnGameStart(Game game, IGameStarter gameStarterObject)
public virtual void OnInitialState()
public virtual void OnMissionBehaviorInitialize(Mission mission)
public virtual void OnMultiplayerGameStart(Game game, object starterObject)
protected virtual void OnNetworkTick(float dt)
public virtual void OnNewGameCreated(Game game, object initializerObject)
protected virtual void OnNewModuleLoad()
public virtual void OnSubModuleActivated()
public virtual void OnSubModuleDeactivated()
protected virtual void OnSubModuleLoad()
protected virtual void OnSubModuleUnloaded()
public virtual void RegisterSubModuleObjects(bool isSavedCampaign)
protected virtual void RegisterSubModuleTypes()
```

## Version 1.3.6.102656

```csharp
protected void .ctor()
protected virtual void AfterAsyncTickTick(float dt)
public virtual void AfterRegisterSubModuleObjects(bool isSavedCampaign)
public virtual void BeginGameStart(Game game)
public virtual bool DoLoading(Game game)
protected virtual void InitializeGameStarter(Game game, IGameStarter starterObject)
public virtual void InitializeSubModuleGameObjects(Game game)
public virtual void OnAfterGameInitializationFinished(Game game, object starterObject)
public virtual void OnAfterGameLoaded(Game game)
protected virtual void OnApplicationTick(float dt)
protected virtual void OnBeforeGameStart(MBGameManager mbGameManager, List<string> disabledModules)
protected virtual void OnBeforeInitialModuleScreenSetAsRoot()
public virtual void OnBeforeMissionBehaviorInitialize(Mission mission)
public virtual void OnCampaignStart(Game game, object starterObject)
public virtual void OnConfigChanged()
public virtual void OnGameEnd(Game game)
public virtual void OnGameInitializationFinished(Game game)
public virtual void OnGameLoaded(Game game, object initializerObject)
protected virtual void OnGameStart(Game game, IGameStarter gameStarterObject)
public virtual void OnInitialState()
public virtual void OnMissionBehaviorInitialize(Mission mission)
public virtual void OnMultiplayerGameStart(Game game, object starterObject)
protected virtual void OnNetworkTick(float dt)
public virtual void OnNewGameCreated(Game game, object initializerObject)
protected virtual void OnNewModuleLoad()
public virtual void OnSubModuleActivated()
public virtual void OnSubModuleDeactivated()
protected virtual void OnSubModuleLoad()
protected virtual void OnSubModuleUnloaded()
public virtual void RegisterSubModuleObjects(bool isSavedCampaign)
protected virtual void RegisterSubModuleTypes()
```

## Version 1.3.7.102919

```csharp
protected void .ctor()
protected virtual void AfterAsyncTickTick(float dt)
public virtual void AfterRegisterSubModuleObjects(bool isSavedCampaign)
public virtual void BeginGameStart(Game game)
public virtual bool DoLoading(Game game)
protected virtual void InitializeGameStarter(Game game, IGameStarter starterObject)
public virtual void InitializeSubModuleGameObjects(Game game)
public virtual void OnAfterGameInitializationFinished(Game game, object starterObject)
public virtual void OnAfterGameLoaded(Game game)
protected virtual void OnApplicationTick(float dt)
protected virtual void OnBeforeGameStart(MBGameManager mbGameManager, List<string> disabledModules)
protected virtual void OnBeforeInitialModuleScreenSetAsRoot()
public virtual void OnBeforeMissionBehaviorInitialize(Mission mission)
public virtual void OnCampaignStart(Game game, object starterObject)
public virtual void OnConfigChanged()
public virtual void OnGameEnd(Game game)
public virtual void OnGameInitializationFinished(Game game)
public virtual void OnGameLoaded(Game game, object initializerObject)
protected virtual void OnGameStart(Game game, IGameStarter gameStarterObject)
public virtual void OnInitialState()
public virtual void OnMissionBehaviorInitialize(Mission mission)
public virtual void OnMultiplayerGameStart(Game game, object starterObject)
protected virtual void OnNetworkTick(float dt)
public virtual void OnNewGameCreated(Game game, object initializerObject)
protected virtual void OnNewModuleLoad()
public virtual void OnSubModuleActivated()
public virtual void OnSubModuleDeactivated()
protected virtual void OnSubModuleLoad()
protected virtual void OnSubModuleUnloaded()
public virtual void RegisterSubModuleObjects(bool isSavedCampaign)
protected virtual void RegisterSubModuleTypes()
```

## Version 1.3.8.103102-beta

```csharp
protected void .ctor()
protected virtual void AfterAsyncTickTick(float dt)
public virtual void AfterRegisterSubModuleObjects(bool isSavedCampaign)
public virtual void BeginGameStart(Game game)
public virtual bool DoLoading(Game game)
protected virtual void InitializeGameStarter(Game game, IGameStarter starterObject)
public virtual void InitializeSubModuleGameObjects(Game game)
public virtual void OnAfterGameInitializationFinished(Game game, object starterObject)
public virtual void OnAfterGameLoaded(Game game)
protected virtual void OnApplicationTick(float dt)
protected virtual void OnBeforeGameStart(MBGameManager mbGameManager, List<string> disabledModules)
protected virtual void OnBeforeInitialModuleScreenSetAsRoot()
public virtual void OnBeforeMissionBehaviorInitialize(Mission mission)
public virtual void OnCampaignStart(Game game, object starterObject)
public virtual void OnConfigChanged()
public virtual void OnGameEnd(Game game)
public virtual void OnGameInitializationFinished(Game game)
public virtual void OnGameLoaded(Game game, object initializerObject)
protected virtual void OnGameStart(Game game, IGameStarter gameStarterObject)
public virtual void OnInitialState()
public virtual void OnMissionBehaviorInitialize(Mission mission)
public virtual void OnMultiplayerGameStart(Game game, object starterObject)
protected virtual void OnNetworkTick(float dt)
public virtual void OnNewGameCreated(Game game, object initializerObject)
protected virtual void OnNewModuleLoad()
public virtual void OnSubModuleActivated()
public virtual void OnSubModuleDeactivated()
protected virtual void OnSubModuleLoad()
protected virtual void OnSubModuleUnloaded()
public virtual void RegisterSubModuleObjects(bool isSavedCampaign)
protected virtual void RegisterSubModuleTypes()
```

## Version 1.3.8.103102

```csharp
protected void .ctor()
protected virtual void AfterAsyncTickTick(float dt)
public virtual void AfterRegisterSubModuleObjects(bool isSavedCampaign)
public virtual void BeginGameStart(Game game)
public virtual bool DoLoading(Game game)
protected virtual void InitializeGameStarter(Game game, IGameStarter starterObject)
public virtual void InitializeSubModuleGameObjects(Game game)
public virtual void OnAfterGameInitializationFinished(Game game, object starterObject)
public virtual void OnAfterGameLoaded(Game game)
protected virtual void OnApplicationTick(float dt)
protected virtual void OnBeforeGameStart(MBGameManager mbGameManager, List<string> disabledModules)
protected virtual void OnBeforeInitialModuleScreenSetAsRoot()
public virtual void OnBeforeMissionBehaviorInitialize(Mission mission)
public virtual void OnCampaignStart(Game game, object starterObject)
public virtual void OnConfigChanged()
public virtual void OnGameEnd(Game game)
public virtual void OnGameInitializationFinished(Game game)
public virtual void OnGameLoaded(Game game, object initializerObject)
protected virtual void OnGameStart(Game game, IGameStarter gameStarterObject)
public virtual void OnInitialState()
public virtual void OnMissionBehaviorInitialize(Mission mission)
public virtual void OnMultiplayerGameStart(Game game, object starterObject)
protected virtual void OnNetworkTick(float dt)
public virtual void OnNewGameCreated(Game game, object initializerObject)
protected virtual void OnNewModuleLoad()
public virtual void OnSubModuleActivated()
public virtual void OnSubModuleDeactivated()
protected virtual void OnSubModuleLoad()
protected virtual void OnSubModuleUnloaded()
public virtual void RegisterSubModuleObjects(bool isSavedCampaign)
protected virtual void RegisterSubModuleTypes()
```

## Version 1.3.8.103119

```csharp
protected void .ctor()
protected virtual void AfterAsyncTickTick(float dt)
public virtual void AfterRegisterSubModuleObjects(bool isSavedCampaign)
public virtual void BeginGameStart(Game game)
public virtual bool DoLoading(Game game)
protected virtual void InitializeGameStarter(Game game, IGameStarter starterObject)
public virtual void InitializeSubModuleGameObjects(Game game)
public virtual void OnAfterGameInitializationFinished(Game game, object starterObject)
public virtual void OnAfterGameLoaded(Game game)
protected virtual void OnApplicationTick(float dt)
protected virtual void OnBeforeGameStart(MBGameManager mbGameManager, List<string> disabledModules)
protected virtual void OnBeforeInitialModuleScreenSetAsRoot()
public virtual void OnBeforeMissionBehaviorInitialize(Mission mission)
public virtual void OnCampaignStart(Game game, object starterObject)
public virtual void OnConfigChanged()
public virtual void OnGameEnd(Game game)
public virtual void OnGameInitializationFinished(Game game)
public virtual void OnGameLoaded(Game game, object initializerObject)
protected virtual void OnGameStart(Game game, IGameStarter gameStarterObject)
public virtual void OnInitialState()
public virtual void OnMissionBehaviorInitialize(Mission mission)
public virtual void OnMultiplayerGameStart(Game game, object starterObject)
protected virtual void OnNetworkTick(float dt)
public virtual void OnNewGameCreated(Game game, object initializerObject)
protected virtual void OnNewModuleLoad()
public virtual void OnSubModuleActivated()
public virtual void OnSubModuleDeactivated()
protected virtual void OnSubModuleLoad()
protected virtual void OnSubModuleUnloaded()
public virtual void RegisterSubModuleObjects(bool isSavedCampaign)
protected virtual void RegisterSubModuleTypes()
```

## Version 1.3.9.103334

```csharp
protected void .ctor()
protected virtual void AfterAsyncTickTick(float dt)
public virtual void AfterRegisterSubModuleObjects(bool isSavedCampaign)
public virtual void BeginGameStart(Game game)
public virtual bool DoLoading(Game game)
protected virtual void InitializeGameStarter(Game game, IGameStarter starterObject)
public virtual void InitializeSubModuleGameObjects(Game game)
public virtual void OnAfterGameInitializationFinished(Game game, object starterObject)
public virtual void OnAfterGameLoaded(Game game)
protected virtual void OnApplicationTick(float dt)
protected virtual void OnBeforeGameStart(MBGameManager mbGameManager, List<string> disabledModules)
protected virtual void OnBeforeInitialModuleScreenSetAsRoot()
public virtual void OnBeforeMissionBehaviorInitialize(Mission mission)
public virtual void OnCampaignStart(Game game, object starterObject)
public virtual void OnConfigChanged()
public virtual void OnGameEnd(Game game)
public virtual void OnGameInitializationFinished(Game game)
public virtual void OnGameLoaded(Game game, object initializerObject)
protected virtual void OnGameStart(Game game, IGameStarter gameStarterObject)
public virtual void OnInitialState()
public virtual void OnMissionBehaviorInitialize(Mission mission)
public virtual void OnMultiplayerGameStart(Game game, object starterObject)
protected virtual void OnNetworkTick(float dt)
public virtual void OnNewGameCreated(Game game, object initializerObject)
protected virtual void OnNewModuleLoad()
public virtual void OnSubModuleActivated()
public virtual void OnSubModuleDeactivated()
protected virtual void OnSubModuleLoad()
protected virtual void OnSubModuleUnloaded()
public virtual void RegisterSubModuleObjects(bool isSavedCampaign)
protected virtual void RegisterSubModuleTypes()
```

