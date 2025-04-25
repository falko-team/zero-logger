namespace System.Logging.Debugs;

public static class DebugEventLogger
{
    public static event DebugLogEvent? Event;

    public static void Notify(string? message) => Notify(null, message);

    public static void Notify(Exception? exception, string? message)
    {
#if DEBUG
        try
        {
            Event?.Invoke(exception, message);
        }
        catch
        {
            // Nothing to do
        }
#endif
    }
}
