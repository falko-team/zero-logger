using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace System.Logging.Utils;

public static class DateTimeOffsetProvider
{
    private const long CachedTimeUpdateIntervalTicks = 3 * 1000 * 1000; // 3ms

    private static readonly Stopwatch Stopwatch = Stopwatch.StartNew();

    private static readonly float StopwatchTickToDateTimeTicks = TimeSpan.TicksPerSecond / (float)Stopwatch.Frequency;

    private static DateTimeOffset _cachedTime = DateTimeOffset.Now;

    private static long _lastTicksTime = Stopwatch.ElapsedTicks;

    public static DateTimeOffset Now
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            var currentTicks = Stopwatch.ElapsedTicks;

            var currentTicksDelta = currentTicks - _lastTicksTime;

            if (currentTicksDelta < CachedTimeUpdateIntervalTicks)
            {
                return _cachedTime.AddTicks((long)(currentTicksDelta * StopwatchTickToDateTimeTicks));
            }

            _cachedTime = DateTimeOffset.Now;
            _lastTicksTime = currentTicks;

            return _cachedTime;
        }
    }
}
