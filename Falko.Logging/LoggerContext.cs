namespace Falko.Logging;

internal readonly struct LoggerContext
{
    public readonly LogLevel MinimumLevel;

    public readonly LoggerTarget[] Targets;

    public readonly CancellationToken CancellationToken;

    internal LoggerContext(LogLevel minimumLevel, LoggerTarget[] targets, CancellationToken cancellationToken)
    {
        MinimumLevel = minimumLevel;
        Targets = targets;
        CancellationToken = cancellationToken;
    }
}
