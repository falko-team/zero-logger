using System.Logging.Factories;
using System.Logging.Interpolators;

namespace System.Logging.Providers;

internal sealed class FourFactoryArgumentsMessageFactoryLogMessageProvider
(
    LogMessageFactory messageFactory,
    LogMessageArgumentFactory argumentFactory1,
    LogMessageArgumentFactory argumentFactory2,
    LogMessageArgumentFactory argumentFactory3,
    LogMessageArgumentFactory argumentFactory4
) : PersistentLogMessageProvider
{
    protected override string? CreateString()
    {
        return LogMessageArgumentsInterpolator.Interpolate(messageFactory(),
            argumentFactory1(),
            argumentFactory2(),
            argumentFactory3(),
            argumentFactory4());
    }
}
