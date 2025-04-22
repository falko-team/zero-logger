#if DEBUG

namespace Falko.Logging;

public static class DebugEventLogger
{
    public static event DebugLogEvent? Event;

    public static void Notify(Exception? exception = null, string? message = null)
    {
        try
        {
            Event?.Invoke(exception, message);
        }
        catch
        {
            // Nothing to do
        }
    }
}

#endif
