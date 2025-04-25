using System.Logging.Interpolators;

namespace System.Logging.Contexts;

internal readonly struct LogInterpolatorSpan(ILogInterpolator logInterpolator, int length)
{
    public readonly ILogInterpolator Interpolator = logInterpolator;

    public readonly int Length = length;
}
