using System.Logging.Factories;
using System.Logging.Interpolators;
using System.Logging.Logs;

namespace System.Logging.Providers;

internal sealed class TwoArgumentsMessageFactoryLogMessageProvider<T1, T2>
(
    LogMessageFactory messageFactory,
    LogMessageArgument<T1> argument1,
    LogMessageArgument<T2> argument2
) : PersistentLogMessageProvider
{
    protected override string? CreateString()
    {
        return LogMessageArgumentsInterpolator.Interpolate(messageFactory(),
            argument1.Factory(argument1.Value),
            argument2.Factory(argument2.Value));
    }
}
