using System.Logging.Utils;

namespace System.Logging.Renderers;

internal sealed class FourInstanceArgumentsMessageLogMessageRenderer<T1, T2, T3, T4>
(
    string? message,
    T1 argument1,
    T2 argument2,
    T3 argument3,
    T4 argument4
) : PersistentLogMessageRenderer
{
    protected override string RenderCore()
    {
        return LogMessageArgumentsInterpolationUtils.Interpolate(message,
            argument1?.ToString(),
            argument2?.ToString(),
            argument3?.ToString(),
            argument4?.ToString());
    }
}
