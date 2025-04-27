using System.Logging.Factories;
using System.Logging.Utils;

namespace System.Logging.Renderers;

internal sealed class FourStringArgumentsMessageFactoryLogMessageRenderer
(
    LogMessageFactory messageFactory,
    string? argument1,
    string? argument2,
    string? argument3,
    string? argument4
) : PersistentLogMessageRenderer
{
    protected override string RenderCore()
    {
        return LogMessageArgumentsInterpolationUtils.Interpolate(messageFactory(),
            argument1,
            argument2,
            argument3,
            argument4);
    }
}
