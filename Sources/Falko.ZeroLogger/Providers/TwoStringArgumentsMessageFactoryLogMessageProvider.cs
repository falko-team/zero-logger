using System.Logging.Factories;
using System.Logging.Interpolators;

namespace System.Logging.Providers;

internal sealed class TwoStringArgumentsMessageFactoryLogMessageProvider
(
    LogMessageFactory messageFactory,
    string? argument1,
    string? argument2
) : PersistentLogMessageProvider
{
    protected override string? CreateString()
    {
        return LogMessageArgumentsInterpolator.Interpolate(messageFactory(),
            argument1,
            argument2);
    }
}
