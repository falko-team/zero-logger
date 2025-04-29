using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace System.Logging.Utils;

public static class DateTimeOffsetProvider
{
    private static readonly Stopwatch Stopwatch = Stopwatch.StartNew();

    private static DateTimeOffset _lastTime = DateTimeOffset.Now;

    private static long _lastTick;

    public static DateTimeOffset Now
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            var currentTick = Stopwatch.ElapsedMilliseconds;

            if (currentTick == _lastTick) return _lastTime;

            _lastTime = DateTimeOffset.Now;
            _lastTick = currentTick;

            return _lastTime;
        }
    }
}
