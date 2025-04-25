using System.Logging.Factories;
using System.Logging.Interpolators;
using System.Logging.Logs;

namespace System.Logging.Providers;

internal sealed class ThreeArgumentsMessageFactoryLogMessageProvider<T1, T2, T3>
(
    LogMessageFactory messageFactory,
    LogMessageArgument<T1> argument1,
    LogMessageArgument<T2> argument2,
    LogMessageArgument<T3> argument3
) : PersistentLogMessageProvider
{
    protected override string? CreateString()
    {
        return LogMessageArgumentsInterpolator.Interpolate(messageFactory(),
            argument1.Factory(argument1.Value),
            argument2.Factory(argument2.Value),
            argument3.Factory(argument3.Value));
    }
}
