using System.Logging.Logs;
using System.Logging.Targets;

namespace System.Logging.Contexts;

internal readonly struct LoggerContext
{
    public readonly LogLevel MinimumLevel;

    public readonly LoggerTarget[] Targets;

    public readonly LogInterpolatorSpan[] Interpolators;

    public readonly CancellationToken CancellationToken;

    internal LoggerContext(LogLevel minimumLevel, LoggerTarget[] targets, LogInterpolatorSpan[] interpolators, CancellationToken cancellationToken)
    {
        MinimumLevel = minimumLevel;
        Targets = targets;
        Interpolators = interpolators;
        CancellationToken = cancellationToken;
    }
}
