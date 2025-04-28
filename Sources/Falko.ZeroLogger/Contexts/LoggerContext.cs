using System.Logging.Logs;
using System.Logging.Targets;

namespace System.Logging.Contexts;

internal readonly struct LoggerContext
{
    public readonly LogLevel Level;

    public readonly LoggerTarget[] Targets;

    public readonly LogContextRendererSpan[] Renderers;

    public readonly CancellationToken CancellationToken;

    internal LoggerContext(LogLevel level, LoggerTarget[] targets, LogContextRendererSpan[] renderers, CancellationToken cancellationToken)
    {
        Level = level;
        Targets = targets;
        Renderers = renderers;
        CancellationToken = cancellationToken;
    }
}
