# CSVizionSDK
CSVizionSDK is a software development kit for C# wrapped from the original VizionSDK C++ implementation. It supports various versions of .NET on Windows and Linux platforms.

## What is included in the repository
- `samples/` : C# samples project source code.
- `config/` : Configuration resources for TechNexion camera series, including:
  - **VxConfig**: A configuration file used by CSVizionSDK to recognize TechNexion camera series.
  - **VxExposure**: A YAML file defining the default minimum and maximum exposure time values for each sensor and resolution.
  - **RouteConfig**: A folder containing media route YAML file templates.
  
## Supported Versions
CSVizionSDK targets .NET Standard 2.0 and is compatible with:

- .NET Core 2.0+
- .NET Framework 4.6.1+
- .NET 5+

## How to Install CSVizionSDK

#### Install from the [NuGet.org](https://www.nuget.org/packages/CSVizionSDK) directly
```
dotnet add package CSVizionSDK
dotnet add package CSVizionSDK.runtime.<os>
```

#### [Windows x64](https://developer.technexion.com/docs/vision-software/vizionsdk/csharp/csvizionsdk-installation#windows-x64)
- Windows 10 and 11 (64-bit)
#### [Linux x64](https://developer.technexion.com/docs/vision-software/vizionsdk/csharp/csvizionsdk-installation#linux-x86_64)
- Ubuntu Desktop 20.04 and 22.04 (64-bit)
- UP Squared Pro 7000
#### [Linux ARM64](https://developer.technexion.com/docs/vision-software/vizionsdk/csharp/csvizionsdk-installation#arm-aarch64)
- NVIDIA Jetson (JetPack6 or later)
- NXP-i.MX8MM, NXP-i.MX8MQ, NXP-i.MX8MP, NXP-i.MX93, NXP-i.MX95
- TI-TDA4VM
  
## Documents
- Github Pages: https://github.com/TechNexion
- VizionSDK Overview: https://developer.technexion.com/docs/vision-software/vizionsdk
- VizionSDK C# Installation: https://developer.technexion.com/docs/vision-software/vizionsdk/csharp/csvizionsdk-installation
- VizionSDK API User Guide: https://developer.technexion.com/docs/category/vizionsdk-api

## Related links

- [Technexion Main Page](https://www.technexion.com/)

