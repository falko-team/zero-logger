using System.Logging.Factories;
using System.Logging.Interpolators;

namespace System.Logging.Providers;

internal sealed class ThreeFactoryArgumentsMessageLogMessageProvider
(
    string? message,
    LogMessageArgumentFactory argumentFactory1,
    LogMessageArgumentFactory argumentFactory2,
    LogMessageArgumentFactory argumentFactory3
) : PersistentLogMessageProvider
{
    protected override string? CreateString()
    {
        return LogMessageArgumentsInterpolator.Interpolate(message,
            argumentFactory1(),
            argumentFactory2(),
            argumentFactory3());
    }
}
