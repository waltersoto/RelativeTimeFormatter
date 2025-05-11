using RelativeTimeFormatter.Localizations;
using System;

namespace RelativeTimeFormatter
{
    public static class Formatter
    {
        public static ITimeLocalization Localization { get; set; } = new EnglishTimeLocalization();

        public static string Format(DateTime target, DateTime? reference = null)
        {
            reference ??= DateTime.UtcNow;
            var span = target - reference.Value;
            return Format(span);
        }

        public static string Format(TimeSpan span)
        {
            return Localization.GetHumanizedTime(span);
        }
    }
}
