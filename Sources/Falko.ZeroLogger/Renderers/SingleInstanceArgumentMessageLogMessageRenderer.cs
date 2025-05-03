using System.Logging.Utils;

namespace System.Logging.Renderers;

internal sealed class SingleInstanceArgumentMessageLogMessageRenderer<T>
(
    string? message,
    T argument
) : PersistentLogMessageRenderer
{
    protected override string RenderCore()
    {
        return MessageArgumentsInterpolationUtils.Interpolate(message,
            StringUtils.ToString(argument));
    }
}
