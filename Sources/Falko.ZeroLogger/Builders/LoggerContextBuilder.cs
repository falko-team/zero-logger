using System.Logging.Contexts;
using System.Logging.Logs;
using System.Logging.Renderers;
using System.Logging.Targets;

namespace System.Logging.Builders;

public ref struct LoggerContextBuilder()
{
    private readonly Dictionary<ILogContextRenderer, List<LoggerTarget>> _targets = new();

    private LogLevel _minimumLevel = LogLevel.Trace;

    public LoggerContextBuilder SetLevel(LogLevel minimumLevel)
    {
        _minimumLevel = minimumLevel;
        return this;
    }

    public LoggerContextBuilder AddTarget(ILogContextRenderer renderer, LoggerTarget target)
    {
        ArgumentNullException.ThrowIfNull(renderer, nameof(renderer));
        ArgumentNullException.ThrowIfNull(target, nameof(target));

        if (_targets.TryGetValue(renderer, out var targets))
        {
            targets.Add(target);
        }
        else
        {
            _targets[renderer] = [target];
        }

        return this;
    }

    internal LoggerContext Build(CancellationToken cancellationToken)
    {
        var targets = new List<LoggerTarget>();
        var renderers = new List<LogContextRendererSpan>();

        foreach (var interpolatorTargets in _targets)
        {
            targets.AddRange(interpolatorTargets.Value);

            renderers.Add(new LogContextRendererSpan(interpolatorTargets.Key, interpolatorTargets.Value.Count));
        }

        return new LoggerContext(_minimumLevel, targets.ToArray(), renderers.ToArray(), cancellationToken);
    }
}
