# Kaz.Operations.Core 

Базовый пакет с исключениями для библиотеки `Kaz.Operations`.

Используется в `Kaz.Operations.Text`, `Kaz.Operations.Numerics` и других зависимых библиотеках для унифицированной обработки ошибок.

---
## Назначение

Определяет специализированные исключения вместо использования `System.Exception`.

---
## Исключения

- ### StringValidationException

```csharp
throw new StringValidationException("Invalid string value.");
```

-  ### NumericConvertationException

```csharp
throw new NumericConvertationException("Will be used later.")
```
---
## Установка

```bash
dotnet add package Kaz.Operations.Core
```
---
## Ссылки

- [NuGet](https://www.nuget.org/packages/Kaz.Operations.Core)
