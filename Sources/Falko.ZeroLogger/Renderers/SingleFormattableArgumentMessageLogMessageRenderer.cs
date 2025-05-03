using System.Logging.Utils;

namespace System.Logging.Renderers;

internal sealed class SingleFormattableArgumentMessageLogMessageRenderer<T>
(
    string? message,
    T argument
) : PersistentLogMessageRenderer where T : IFormattable
{
    protected override string RenderCore()
    {
        return MessageArgumentsInterpolationUtils.Interpolate(message,
            argument.ToString(null, null));
    }
}
