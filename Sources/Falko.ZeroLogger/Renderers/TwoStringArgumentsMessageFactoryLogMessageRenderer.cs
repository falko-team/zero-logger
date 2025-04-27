using System.Logging.Factories;
using System.Logging.Utils;

namespace System.Logging.Renderers;

internal sealed class TwoStringArgumentsMessageFactoryLogMessageRenderer
(
    LogMessageFactory messageFactory,
    string? argument1,
    string? argument2
) : PersistentLogMessageRenderer
{
    protected override string RenderCore()
    {
        return LogMessageArgumentsInterpolationUtils.Interpolate(messageFactory(),
            argument1,
            argument2);
    }
}
