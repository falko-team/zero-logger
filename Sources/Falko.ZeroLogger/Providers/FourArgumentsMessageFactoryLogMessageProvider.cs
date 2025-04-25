using System.Logging.Factories;
using System.Logging.Interpolators;
using System.Logging.Logs;

namespace System.Logging.Providers;

internal sealed class FourArgumentsMessageFactoryLogMessageProvider<T1, T2, T3, T4>
(
    LogMessageFactory messageFactory,
    LogMessageArgument<T1> argument1,
    LogMessageArgument<T2> argument2,
    LogMessageArgument<T3> argument3,
    LogMessageArgument<T4> argument4
) : PersistentLogMessageProvider
{
    protected override string? CreateString()
    {
        return LogMessageArgumentsInterpolator.Interpolate(messageFactory(),
            argument1.Factory(argument1.Value),
            argument2.Factory(argument2.Value),
            argument3.Factory(argument3.Value),
            argument4.Factory(argument4.Value));
    }
}
