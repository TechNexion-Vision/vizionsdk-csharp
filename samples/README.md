# CSVizionSDK Sample
This is a simple project for demonstrating how to use CSVizionSDK.

## Run the project
Before building the sample, open the project's .csproj file and make sure it includes the correct references and configurations.

### Verify .csproj Settings

Open the .csproj file and confirm it has the proper setup.
Here’s an example configuration:
```xml
<Project Sdk="Microsoft.NET.Sdk">
<PropertyGroup>
    <!-- Target framework version -->
    <TargetFramework>net8.0</TargetFramework>
</PropertyGroup>

<ItemGroup>
    <!-- Reference the CSVizionSDK NuGet package -->
    <PackageReference Include="CSVizionSDK" Version="VERSION" />
    <PackageReference Include="CSVizionSDK.runtime.<OS>" Version="VERSION" />
</ItemGroup>
</Project>
```
:::info
- The sample code uses **Windows** as the default platform. Please replace it with your actual platform type.
- Replace `VERSION` with the correct version of the **CSVizionSDK** package.
- Replace `OS` with the correct operating system identifier.  
  Runtime package names include the target platform:
    - `CSVizionSDK.runtime.win-x64`
    - `CSVizionSDK.runtime.linux-x64`
    - `CSVizionSDK.runtime.linux-arm64`
:::

Ensure that the target framework matches the one supported by the package, such as:
- net8.0 (recommended)
- net6.0
- or netstandard2.0 for library projects.

### Build and Run the Sample
Follow the steps below to build and run the sample:

1. Open a terminal (Command Prompt or PowerShell).

2. Navigate to the sample project directory:
    ```shell
    cd vizionsdk-csharp/samples
    ```

3. Build the project:
    ```shell
    dotnet build
    ```

4. Run the sample:
    ```shell
    dotnet run
    ```

Once executed, the sample application will run using the CSVizionSDK library.

## Other Functions

If you like to use other functions from CSVizionSDK, please visit to our website to see other API.

**API User Guide** : https://developer.technexion.com/docs/category/recommended-api-v25041