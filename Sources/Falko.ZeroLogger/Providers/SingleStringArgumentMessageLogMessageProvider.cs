using System.Logging.Interpolators;

namespace System.Logging.Providers;

internal sealed class SingleStringArgumentMessageLogMessageProvider
(
    string? message,
    string? argument
) : PersistentLogMessageProvider
{
    protected override string? CreateString()
    {
        return LogMessageArgumentsInterpolator.Interpolate(message,
            argument);
    }
}
