using System.Logging.Logs;
using System.Logging.Targets;

namespace System.Logging.Contexts;

internal sealed class LoggerContext
{
    public readonly LogLevel Level;

    public readonly LoggerTarget[] Targets;

    public readonly LogContextRendererSpan[] Renderers;

    public readonly CancellationToken CancellationToken;

    public readonly bool IsTraceLevelEnabled;

    public readonly bool IsDebugLevelEnabled;

    public readonly bool IsInfoLevelEnabled;

    public readonly bool IsWarnLevelEnabled;

    public readonly bool IsErrorLevelEnabled;

    public readonly bool IsFatalLevelEnabled;

    internal LoggerContext(LogLevel level, LoggerTarget[] targets, LogContextRendererSpan[] renderers, CancellationToken cancellationToken)
    {
        Level = level;
        Targets = targets;
        Renderers = renderers;
        CancellationToken = cancellationToken;

        IsTraceLevelEnabled = level.IsEnabled(LogLevel.Trace);
        IsDebugLevelEnabled = level.IsEnabled(LogLevel.Debug);
        IsInfoLevelEnabled = level.IsEnabled(LogLevel.Info);
        IsWarnLevelEnabled = level.IsEnabled(LogLevel.Warn);
        IsErrorLevelEnabled = level.IsEnabled(LogLevel.Error);
        IsFatalLevelEnabled = level.IsEnabled(LogLevel.Fatal);
    }
}
