using System.Logging.Logs;
using System.Logging.Targets;

namespace System.Logging.Contexts;

internal readonly struct LoggerContext
{
    public readonly LogLevel MinimumLevel;

    public readonly LoggerTarget[] Targets;

    public readonly LogContextRendererSpan[] Renderers;

    public readonly CancellationToken CancellationToken;

    internal LoggerContext(LogLevel minimumLevel, LoggerTarget[] targets, LogContextRendererSpan[] renderers, CancellationToken cancellationToken)
    {
        MinimumLevel = minimumLevel;
        Targets = targets;
        Renderers = renderers;
        CancellationToken = cancellationToken;
    }
}
