using System.Logging.Utils;

namespace System.Logging.Renderers;

internal sealed class TwoInstanceArgumentsMessageLogMessageRenderer<T1, T2>
(
    string? message,
    T1 argument1,
    T2 argument2
) : PersistentLogMessageRenderer
{
    protected override string RenderCore()
    {
        return MessageArgumentsInterpolationUtils.Interpolate(message,
            StringUtils.ToString(argument1),
            StringUtils.ToString(argument2));
    }
}
