# CSVizionSDK
CSVizionSDK is a software development kit for C# wrapped from the original VizionSDK C++ implementation. It supports various versions of .NET on Windows and Linux platforms.

## What is included in the repository
- `samples/` : C# samples project source code.
- `config/` : A config file of TechNexion Camera series for CSVizionSDK.

## Supported TechNexion Cameras

| Sensor | MIPI           | FPD-LinkIII      | UVC            |
|--------|----------------|------------------|----------------|
| AR0144 | ✓ TEVS-AR0144  | ✓ VLS3-AR0144    | ✓ VCI-AR0144   |
| AR0145 | ✓ TEVS-AR0145  | ✓ VLS3-AR0145    |                |
| AR0234 | ✓ TEVS-AR0234  | ✓ VLS3-AR0234    | ✓ VCI-AR0234   |
| AR0521 | ✓ TEVS-AR0521  | ✓ VLS3-AR0521    | ✓ VCI-AR0521   |
| AR0522 | ✓ TEVS-AR0522  | ✓ VLS3-AR0522    | ✓ VCI-AR0522   |
| AR0821 | ✓ TEVS-AR0821  | ✓ VLS3-AR0821    | ✓ VCI-AR0821   |
| AR0822 | ✓ TEVS-AR0822  | ✓ VLS3-AR0822    | ✓ VCI-AR0822   |
| AR1335 | ✓ TEVS-AR1335  | ✓ VLS3-AR1335    | ✓ VCI-AR1335   |
  
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
#### [Linux x64](https://developer.technexion.com/docs/vision-software/vizionsdk/csharp/csvizionsdk-installation#linux-x64)
- Ubuntu Desktop 20.04 and 22.04 (64-bit)
- UP Squared Pro 7000
#### [Linux ARM64](https://developer.technexion.com/docs/vision-software/vizionsdk/csharp/csvizionsdk-installation#linux-arm64)
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
