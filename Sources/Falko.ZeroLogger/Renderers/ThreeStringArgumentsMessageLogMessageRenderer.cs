using System.Logging.Utils;

namespace System.Logging.Renderers;

internal sealed class ThreeStringArgumentsMessageLogMessageRenderer
(
    string? message,
    string? argument1,
    string? argument2,
    string? argument3
) : PersistentLogMessageRenderer
{
    protected override string RenderCore()
    {
        return LogMessageArgumentsInterpolationUtils.Interpolate(message,
            argument1,
            argument2,
            argument3);
    }
}
