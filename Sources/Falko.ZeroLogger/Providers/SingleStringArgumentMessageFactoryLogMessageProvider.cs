using System.Logging.Factories;
using System.Logging.Interpolators;

namespace System.Logging.Providers;

internal sealed class SingleStringArgumentMessageFactoryLogMessageProvider
(
    LogMessageFactory messageFactory,
    string? argument
) : PersistentLogMessageProvider
{
    protected override string? CreateString()
    {
        return LogMessageArgumentsInterpolator.Interpolate(messageFactory(),
            argument);
    }
}
