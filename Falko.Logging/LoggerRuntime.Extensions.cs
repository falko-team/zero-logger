namespace Falko.Logging;

public static partial class LoggerRuntime
{
    private const LogLevel DefaultLevel = LogLevel.Debug;

    private static TimeSpan DefaultTimeout => TimeSpan.FromSeconds(30);

    #region Initialize

    public static void Initialize(params LoggerTarget[] targets)
    {
        using var source = CreateTimeoutCancellationSource();

        Initialize(targets, DefaultLevel, source.Token);
    }

    public static void Initialize(LoggerTarget[] targets, LogLevel level)
    {
        using var source = CreateTimeoutCancellationSource();

        Initialize(targets, level, source.Token);
    }

    public static void Initialize(LoggerTarget[] targets, CancellationToken cancellationToken)
    {
        Initialize(targets, DefaultLevel, cancellationToken);
    }

    public static void Initialize(LoggerTarget[] targets, TimeSpan timeout)
    {
        using var source = CreateTimeoutCancellationSource(timeout);

        Initialize(targets, DefaultLevel, source.Token);
    }

    public static void Initialize(LoggerTarget[] targets, LogLevel level, TimeSpan timeout)
    {
        using var source = CreateTimeoutCancellationSource(timeout);

        Initialize(targets, level, source.Token);
    }

    #endregion

    #region Dispose

    public static void Dispose()
    {
        using var source = CreateTimeoutCancellationSource();

        Dispose(source.Token);
    }

    public static void Dispose(TimeSpan timeout)
    {
        using var source = CreateTimeoutCancellationSource(timeout);

        Dispose(source.Token);
    }

    #endregion

    private static CancellationTokenSource CreateTimeoutCancellationSource()
    {
        return CreateTimeoutCancellationSource(DefaultTimeout);
    }

    private static CancellationTokenSource CreateTimeoutCancellationSource(TimeSpan timeout)
    {
        var source = new CancellationTokenSource();

        source.CancelAfter(timeout);

        return source;
    }
}
