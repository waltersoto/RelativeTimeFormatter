
namespace RelativeTimeFormatter
{
    public interface ITimeLocalization
    {
        string GetHumanizedTime(TimeSpan span);
    }
}
