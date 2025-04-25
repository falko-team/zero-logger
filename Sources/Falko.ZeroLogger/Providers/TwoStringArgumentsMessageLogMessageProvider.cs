using System.Logging.Interpolators;

namespace System.Logging.Providers;

internal sealed class TwoStringArgumentsMessageLogMessageProvider
(
    string? message,
    string? argument1,
    string? argument2
) : PersistentLogMessageProvider
{
    protected override string? CreateString()
    {
        return LogMessageArgumentsInterpolator.Interpolate(message,
            argument1,
            argument2);
    }
}
