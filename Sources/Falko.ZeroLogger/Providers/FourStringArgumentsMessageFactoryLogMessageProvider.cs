using System.Logging.Factories;
using System.Logging.Interpolators;

namespace System.Logging.Providers;

internal sealed class FourStringArgumentsMessageFactoryLogMessageProvider
(
    LogMessageFactory messageFactory,
    string? argument1,
    string? argument2,
    string? argument3,
    string? argument4
) : PersistentLogMessageProvider
{
    protected override string? CreateString()
    {
        return LogMessageArgumentsInterpolator.Interpolate(messageFactory(),
            argument1,
            argument2,
            argument3,
            argument4);
    }
}
