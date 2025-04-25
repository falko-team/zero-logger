using System.Logging.Contexts;
using System.Text;

namespace System.Logging.Interpolators;

internal sealed class PersistentLogInterpolator(ILogInterpolator interpolator) : ILogInterpolator
{
    private char[]? _cache;

    public void Interpolate(in LogContext logContext, StringBuilder logBuilder)
    {
        if (_cache is not null)
        {
            logBuilder.Append(_cache, 0, _cache.Length);
            return;
        }

        var from = logBuilder.Length;

        interpolator.Interpolate(logContext, logBuilder);

        var length = logBuilder.Length - from;

        var cache = new char[length];
        logBuilder.CopyTo(from, cache, 0, length);
        _cache = cache;
    }
}
