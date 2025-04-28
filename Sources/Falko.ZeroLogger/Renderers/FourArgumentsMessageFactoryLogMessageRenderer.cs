using System.Logging.Factories;
using System.Logging.Logs;
using System.Logging.Utils;

namespace System.Logging.Renderers;

internal sealed class FourArgumentsMessageFactoryLogMessageRenderer<T1, T2, T3, T4>
(
    LogMessageFactory messageFactory,
    LogMessageArgument<T1> argument1,
    LogMessageArgument<T2> argument2,
    LogMessageArgument<T3> argument3,
    LogMessageArgument<T4> argument4
) : PersistentLogMessageRenderer
{
    protected override string RenderCore()
    {
        return MessageArgumentsInterpolationUtils.Interpolate(messageFactory(),
            argument1.Factory(argument1.Value),
            argument2.Factory(argument2.Value),
            argument3.Factory(argument3.Value),
            argument4.Factory(argument4.Value));
    }
}
