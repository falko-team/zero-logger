using System.Logging.Factories;
using System.Logging.Interpolators;
using System.Logging.Logs;

namespace System.Logging.Providers;

internal sealed class SingleArgumentMessageFactoryLogMessageProvider<T>
(
    LogMessageFactory messageFactory,
    LogMessageArgument<T> argument
) : PersistentLogMessageProvider
{
    protected override string? CreateString()
    {
        return LogMessageArgumentsInterpolator.Interpolate(messageFactory(),
            argument.Factory(argument.Value));
    }
}
