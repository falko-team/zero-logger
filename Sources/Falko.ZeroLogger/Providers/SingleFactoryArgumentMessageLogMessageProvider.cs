using System.Logging.Factories;
using System.Logging.Interpolators;

namespace System.Logging.Providers;

internal sealed class SingleFactoryArgumentMessageLogMessageProvider
(
    string? message,
    LogMessageArgumentFactory argumentFactory
) : PersistentLogMessageProvider
{
    protected override string? CreateString()
    {
        return LogMessageArgumentsInterpolator.Interpolate(message,
            argumentFactory());
    }
}
