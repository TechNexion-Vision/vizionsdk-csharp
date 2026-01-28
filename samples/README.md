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
</ItemGroup>
</Project>
```
> Replace `VERSION` with the appropriate version of the CSVizionSDK package.  
> The core CSVizionSDK will automatically load the required runtime package as a dependency.

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

**API User Guide** : https://developer.technexion.com/docs/category/vizionsdk-api