using System.Logging.Utils;

namespace System.Logging.Renderers;

internal sealed class ThreeInstanceArgumentsMessageLogMessageRenderer<T1, T2, T3>
(
    string? message,
    T1 argument1,
    T2 argument2,
    T3 argument3
) : PersistentLogMessageRenderer
{
    protected override string RenderCore()
    {
        return LogMessageArgumentsInterpolationUtils.Interpolate(message,
            argument1?.ToString(),
            argument2?.ToString(),
            argument3?.ToString());
    }
}
