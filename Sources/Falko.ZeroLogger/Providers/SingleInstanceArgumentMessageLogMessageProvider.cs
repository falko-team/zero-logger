using System.Logging.Interpolators;

namespace System.Logging.Providers;

internal sealed class SingleInstanceArgumentMessageLogMessageProvider<T>
(
    string? message,
    T argument
) : PersistentLogMessageProvider
{
    protected override string? CreateString()
    {
        return LogMessageArgumentsInterpolator.Interpolate(message,
            argument?.ToString());
    }
}
