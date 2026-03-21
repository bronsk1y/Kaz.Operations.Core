# Kaz.Operations.Core 

Basic package with necessary parameters for the `Kaz.Operations` library.


## Important ⚠
- This repository (and its NuGet package) is deprecated and will no longer be maintained. To continue working with the updated structure, install the [Kaz.Operations](https://github.com/bronsk1y/Kaz.Operations).
You can still reference Kaz.Operations.Core in the 1.2.0 version of [Kaz.Operations](https://github.com/bronsk1y/Kaz.Operations/releases/tag/v1.2.0), however future versions will not support the standalone Kaz.Operations.Core package.


## Enums

- ### UrlScheme

```csharp
[Obsolete("Kaz.Operations.Core has been merged into Kaz.Operations. The standalone Kaz.Operations.Core package is deprecated.")]
public enum UrlScheme
{
    Any,
    Http,
    Https
}
```

- ### IpVersion

```csharp
[Obsolete("Kaz.Operations.Core has been merged into Kaz.Operations. The standalone Kaz.Operations.Core package is deprecated.")]
public enum IpVersion
{
    Any,
    IPv4,
    IPv6
}
```

- ### PercentageCalculationMethod

```csharp
[Obsolete("Kaz.Operations.Core has been merged into Kaz.Operations. The standalone Kaz.Operations.Core package is deprecated.")]
public enum PercentageCalculationMethod
{
    FractionOfTotal,
    RatioOfTotal
}
```

-  ### NumberExtractionOptions

```csharp
[Obsolete("Kaz.Operations.Core has been merged into Kaz.Operations. The standalone Kaz.Operations.Core package is deprecated.")]
public enum NumberExtractionOptions
{
    Digits,
    Decimals,
    Scientific
}
```

## Links

- [NuGet](https://www.nuget.org/packages/Kaz.Operations.Core)
