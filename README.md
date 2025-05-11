# RelativeTimeFormatter

**RelativeTimeFormatter** is a lightweight C# library that turns `TimeSpan` and `DateTime` differences into natural, human-friendly text. It's ideal for logs, notifications, and UIs that need readable time expressions like:

> "just now", "3 minutes ago", "in 2 hours", "7 days from now"

## ✨ Features

- Format `TimeSpan` or `DateTime` differences
- Outputs expressions like "5 hours ago", "in 3 minutes", or "just now"
- Fully pluggable localization (English and Spanish included)
- Designed for .NET (supports .NET 8.0)

---

## 🛠 Installation

```bash
dotnet add package RelativeTimeFormatter
