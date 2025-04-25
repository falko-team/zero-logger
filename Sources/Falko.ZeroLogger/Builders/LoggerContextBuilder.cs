using System.Logging.Contexts;
using System.Logging.Interpolators;
using System.Logging.Logs;
using System.Logging.Targets;

namespace System.Logging.Builders;

public ref struct LoggerContextBuilder()
{
    private readonly Dictionary<ILogInterpolator, List<LoggerTarget>> _targets = new();

    private LogLevel _minimumLevel = LogLevel.Trace;

    public LoggerContextBuilder SetLevel(LogLevel minimumLevel)
    {
        _minimumLevel = minimumLevel;
        return this;
    }

    public LoggerContextBuilder AddTarget(ILogInterpolator interpolator, LoggerTarget target)
    {
        ArgumentNullException.ThrowIfNull(interpolator, nameof(interpolator));
        ArgumentNullException.ThrowIfNull(target, nameof(target));

        if (_targets.TryGetValue(interpolator, out var targets))
        {
            targets.Add(target);
        }
        else
        {
            _targets[interpolator] = [target];
        }

        return this;
    }

    internal LoggerContext Build(CancellationToken cancellationToken)
    {
        var targets = new List<LoggerTarget>();
        var interpolators = new List<LogInterpolatorSpan>();

        foreach (var interpolatorTargets in _targets)
        {
            targets.AddRange(interpolatorTargets.Value);

            interpolators.Add(new LogInterpolatorSpan(interpolatorTargets.Key, interpolatorTargets.Value.Count));
        }

        return new LoggerContext(_minimumLevel, targets.ToArray(), interpolators.ToArray(), cancellationToken);
    }
}
