# RelativeTimeFormatter

**RelativeTimeFormatter** is a lightweight C# library that turns `TimeSpan` and `DateTime` differences into natural, human-friendly text.
It's ideal for logs, notifications, and UIs that need readable time expressions like:

> "just now", "3 minutes ago", "in 2 hours", "7 days from now"

---

## ✨ Features

* Format `TimeSpan` or `DateTime` differences into natural language
* Built-in support for English and Spanish
* Pluggable localization (implement `ITimeLocalization`)
* Extension methods for clean syntax
* Easy to integrate into any .NET 8.0+ app

---

## 📋 Installation

```bash
dotnet add package RelativeTimeFormatter
```

---

## 🚀 Usage

### Format `DateTime` Differences

```csharp
using RelativeTimeFormatter;

var now = DateTime.UtcNow;
var fiveMinutesAgo = now.AddMinutes(-5);
var inTwoHours = now.AddHours(2);

Console.WriteLine(Formatter.Format(fiveMinutesAgo)); // "5 minutes ago"
Console.WriteLine(Formatter.Format(inTwoHours));     // "in 2 hours"
```

### Format `TimeSpan` Directly

```csharp
var span = TimeSpan.FromSeconds(45);
Console.WriteLine(Formatter.Format(span)); // "45 seconds from now"
```

### With Extension Methods

```csharp
using RelativeTimeFormatter.Extensions;

TimeSpan delay = TimeSpan.FromMinutes(-10);
Console.WriteLine(delay.ToRelativeString()); // "10 minutes ago"

DateTime scheduled = DateTime.UtcNow.AddDays(3);
Console.WriteLine(scheduled.ToRelativeString()); // "in 3 days"
```

### Change Localization

```csharp
using RelativeTimeFormatter;
using RelativeTimeFormatter.Localizations;

Formatter.Localization = new SpanishTimeLocalization();

Console.WriteLine(DateTime.UtcNow.AddHours(-2).ToRelativeString()); // "hace 2 horas"
```

---

## 📄 License

MIT – do whatever you want, just don’t blame us if your logs become too human.

---

[![NuGet](https://img.shields.io/nuget/v/RelativeTimeFormatter.svg)](https://www.nuget.org/packages/RelativeTimeFormatter)
