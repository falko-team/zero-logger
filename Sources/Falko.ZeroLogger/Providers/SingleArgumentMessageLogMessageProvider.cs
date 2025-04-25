using System.Logging.Interpolators;
using System.Logging.Logs;

namespace System.Logging.Providers;

internal sealed class SingleArgumentMessageLogMessageProvider<T>
(
    string? message,
    LogMessageArgument<T> argument
) : PersistentLogMessageProvider
{
    protected override string? CreateString()
    {
        return LogMessageArgumentsInterpolator.Interpolate(message,
            argument.Factory(argument.Value));
    }
}
