
namespace RelativeTimeFormatter.Localizations
{
    public class EnglishTimeLocalization : ITimeLocalization
    {
        public string GetHumanizedTime(TimeSpan span)
        {
            string suffix = span.TotalSeconds >= 0 ? "from now" : "ago";
            span = span.Duration();

            if (span.TotalSeconds < 5)
                return "just now";
            if (span.TotalSeconds < 60)
                return $"{(int)span.TotalSeconds} seconds {suffix}";
            if (span.TotalMinutes < 60)
                return $"{(int)span.TotalMinutes} minutes {suffix}";
            if (span.TotalHours < 24)
                return $"{(int)span.TotalHours} hours {suffix}";
            if (span.TotalDays < 30)
                return $"{(int)span.TotalDays} days {suffix}";
            if (span.TotalDays < 365)
                return $"{(int)(span.TotalDays / 30)} months {suffix}";

            return $"{(int)(span.TotalDays / 365)} years {suffix}";
        }
    }
}
