using System.Logging.Interpolators;

namespace System.Logging.Providers;

internal sealed class TwoInstanceArgumentsMessageLogMessageProvider<T1, T2>
(
    string? message,
    T1 argument1,
    T2 argument2
) : PersistentLogMessageProvider
{
    protected override string? CreateString()
    {
        return LogMessageArgumentsInterpolator.Interpolate(message,
            argument1?.ToString(),
            argument2?.ToString());
    }
}
