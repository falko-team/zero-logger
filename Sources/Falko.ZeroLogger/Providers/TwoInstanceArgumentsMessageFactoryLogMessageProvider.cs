using System.Logging.Factories;
using System.Logging.Interpolators;

namespace System.Logging.Providers;

internal sealed class TwoInstanceArgumentsMessageFactoryLogMessageProvider<T1, T2>
(
    LogMessageFactory messageFactory,
    T1 argument1,
    T2 argument2
) : PersistentLogMessageProvider
{
    protected override string? CreateString()
    {
        return LogMessageArgumentsInterpolator.Interpolate(messageFactory(),
            argument1?.ToString(),
            argument2?.ToString());
    }
}
