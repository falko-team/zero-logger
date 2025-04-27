namespace System.Logging.Debugs;

public static class DebugEventLogger
{
#if DEBUG
    private static event DebugLogEventHandler? Handlers;
#endif

    public static void AddHandler(DebugLogEventHandler handler)
    {
#if DEBUG
        Handlers += handler;
#endif
    }

    public static void RemoveHandler(DebugLogEventHandler handler)
    {
#if DEBUG
        Handlers -= handler;
#endif
    }

    public static void Handle(string? message, Exception? exception = null)
    {
#if DEBUG
        try
        {
            Handlers?.Invoke(message, exception);
        }
        catch
        {
            // Nothing to do
        }
#endif
    }
}
