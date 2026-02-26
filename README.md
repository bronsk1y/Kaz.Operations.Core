# Kaz.Operations.Core 

Basic package with necessary parameters for the `Kaz.Operations` library.

Used in `Kaz.Operations.Text`, `Kaz.Operations.Numerics` and other dependent libraries.

---
## Enums

- ### UrlScheme

```csharp
public enum UrlScheme
{
    Any,
    Http,
    Https
}
```

- ### IpVersion

```csharp
public enum IpVersion
{
    Any,
    IPv4,
    IPv6
}
```

- ### PercentageCalculationMethod

```csharp
public enum PercentageCalculationMethod
{
    FractionOfTotal,
    RatioOfTotal
}
```

-  ### NumberExtractionOptions

```csharp
public enum NumberExtractionOptions
{
    Digits,
    Decimals,
    Scientific
}
```
---
## Installation 

- **.NET CLI:**

```bash
dotnet add package Kaz.Operations.Core
```

- **NuGet Package Manager:**

```powershell
Install-Package Kaz.Operations.Core
```
---
## Ссылки

- [NuGet](https://www.nuget.org/packages/Kaz.Operations.Core)
