using System.Logging.Builders;

namespace System.Logging.Runtimes;

public static partial class LoggerRuntime
{
    private static TimeSpan DefaultTimeout => TimeSpan.FromSeconds(30);

    #region Initialize

    public static void Initialize(LoggerContextBuilder loggerBuilder)
    {
        Initialize(loggerBuilder, CancellationToken.None);
    }

    public static void Initialize(LoggerContextBuilder loggerBuilder, TimeSpan timeout)
    {
        using var source = CreateTimeoutCancellationSource(timeout);

        Initialize(loggerBuilder, source.Token);
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
