using System.Logging.Interpolators;

namespace System.Logging.Providers;

internal sealed class FourInstanceArgumentsMessageLogMessageProvider<T1, T2, T3, T4>
(
    string? message,
    T1 argument1,
    T2 argument2,
    T3 argument3,
    T4 argument4
) : PersistentLogMessageProvider
{
    protected override string? CreateString()
    {
        return LogMessageArgumentsInterpolator.Interpolate(message,
            argument1?.ToString(),
            argument2?.ToString(),
            argument3?.ToString(),
            argument4?.ToString());
    }
}
