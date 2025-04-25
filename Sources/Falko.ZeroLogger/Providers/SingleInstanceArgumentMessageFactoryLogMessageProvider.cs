using System.Logging.Factories;
using System.Logging.Interpolators;

namespace System.Logging.Providers;

internal sealed class SingleInstanceArgumentMessageFactoryLogMessageProvider<T>
(
    LogMessageFactory messageFactory,
    T argument
) : PersistentLogMessageProvider
{
    protected override string? CreateString()
    {
        return LogMessageArgumentsInterpolator.Interpolate(messageFactory(),
            argument?.ToString());
    }
}
