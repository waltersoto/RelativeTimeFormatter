
namespace RelativeTimeFormatter.Extensions
{
    public static class TimeSpanExtensions
    {
        public static string ToRelativeString(this TimeSpan timeSpan)
        {
            return RelativeTimeFormatter.Format(timeSpan);
        }

        public static string ToRelativeString(this DateTime target, DateTime? reference)
        {
            return RelativeTimeFormatter.Format(target, reference);
        }
    }
}
