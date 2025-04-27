using System.Logging.Logs;
using System.Logging.Utils;

namespace System.Logging.Renderers;

internal sealed class ThreeArgumentsMessageLogMessageRenderer<T1, T2, T3>
(
    string? message,
    LogMessageArgument<T1> argument1,
    LogMessageArgument<T2> argument2,
    LogMessageArgument<T3> argument3
) : PersistentLogMessageRenderer
{
    protected override string RenderCore()
    {
        return LogMessageArgumentsInterpolationUtils.Interpolate(message,
            argument1.Factory(argument1.Value),
            argument2.Factory(argument2.Value),
            argument3.Factory(argument3.Value));
    }
}
