
namespace RelativeTimeFormatter.Localizations
{
    public class SpanishTimeLocalization : ITimeLocalization
    {
        public string GetHumanizedTime(TimeSpan span)
        {
            string suffix = span.TotalSeconds >= 0 ? "en" : "hace";
            span = span.Duration();

            if (span.TotalSeconds < 5)
                return "justo ahora";
            if (span.TotalSeconds < 60)
                return $"{suffix} {(int)span.TotalSeconds} segundos";
            if (span.TotalMinutes < 60)
                return $"{suffix} {(int)span.TotalMinutes} minutos";
            if (span.TotalHours < 24)
                return $"{suffix} {(int)span.TotalHours} horas";
            if (span.TotalDays < 30)
                return $"{suffix} {(int)span.TotalDays} días";
            if (span.TotalDays < 365)
                return $"{suffix} {(int)(span.TotalDays / 30)} meses";

            return $"{suffix} {(int)(span.TotalDays / 365)} años";
        }
    }
}
