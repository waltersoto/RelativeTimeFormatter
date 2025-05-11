
namespace RelativeTimeFormatter.Extensions
{
    public static class TimeSpanExtensions
    {
        public static string ToRelativeString(this TimeSpan timeSpan)
        {
            return Formatter.Format(timeSpan);
        }

        public static string ToRelativeString(this DateTime target, DateTime? reference)
        {
            return Formatter.Format(target, reference);
        }
    }
}
