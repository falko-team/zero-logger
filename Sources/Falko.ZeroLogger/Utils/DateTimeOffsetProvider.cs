using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace System.Logging.Utils;

public static class DateTimeOffsetProvider
{
    private static readonly Stopwatch Stopwatch = Stopwatch.StartNew();

    private static DateTimeOffset _cachedTime = DateTimeOffset.Now;

    private static long _lastUpdateTicksTime = Stopwatch.ElapsedTicks;

    private const long CachedTimeUpdateIntervalTicks = 10 * 1000 * 1000; // 10ms

    public static DateTimeOffset Now
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            var currentTimestamp = Stopwatch.ElapsedTicks;

            var currentTimestampDelta = currentTimestamp - _lastUpdateTicksTime;

            if (currentTimestampDelta < CachedTimeUpdateIntervalTicks)
            {
                return _cachedTime.AddTicks(currentTimestampDelta);
            }

            _cachedTime = DateTimeOffset.Now;
            _lastUpdateTicksTime = currentTimestamp;

            return _cachedTime;
        }
    }
}
