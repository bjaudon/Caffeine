# .NET 10.0 Upgrade Plan

## Execution Steps

Execute steps below sequentially one by one in the order they are listed.

1. Validate that an .NET 10.0 SDK required for this upgrade is installed on the machine and if not, help to get it installed.
2. Ensure that the SDK version specified in global.json files is compatible with the .NET 10.0 upgrade.
3. Upgrade Caffeine\Caffeine.csproj


## Settings

This section contains settings and data used by execution steps.

### Excluded projects

Table below contains projects that do belong to the dependency graph for selected projects and should not be included in the upgrade.

| Project name                                   | Description                 |
|:-----------------------------------------------|:---------------------------:|


### Aggregate NuGet packages modifications across all projects

NuGet packages used across all selected projects or their dependencies that need version update in projects that reference them.

| Package Name                        | Current Version | New Version | Description                                   |
|:------------------------------------|:---------------:|:-----------:|:----------------------------------------------|


### Project upgrade details
This section contains details about each project upgrade and modifications that need to be done in the project.

#### Caffeine\\Caffeine.csproj modifications

Project properties changes:
  - Project needs to be converted to SDK-style project format.
  - Target framework should be changed from `.NETFramework,Version=v4.8` to `net10.0-windows`.

NuGet packages changes:
  - No NuGet package updates were identified by analysis. If later analysis finds package issues, they will be added here.

Feature upgrades:
  - Convert old .NET Framework project layout and properties to SDK-style format.
  - Ensure any Windows-specific APIs or app model differences are addressed after conversion.

Other changes:
  - After SDK conversion and target framework change, run a full build and address compile errors related to API surface differences between .NET Framework 4.8 and .NET 10.0.
  - Update or replace any unsupported packages or APIs discovered during build.
