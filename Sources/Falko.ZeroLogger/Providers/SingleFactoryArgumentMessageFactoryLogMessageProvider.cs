using System.Logging.Factories;
using System.Logging.Interpolators;

namespace System.Logging.Providers;

internal sealed class SingleFactoryArgumentMessageFactoryLogMessageProvider
(
    LogMessageFactory messageFactory,
    LogMessageArgumentFactory argumentFactory
) : PersistentLogMessageProvider
{
    protected override string? CreateString()
    {
        return LogMessageArgumentsInterpolator.Interpolate(messageFactory(),
            argumentFactory());
    }
}
