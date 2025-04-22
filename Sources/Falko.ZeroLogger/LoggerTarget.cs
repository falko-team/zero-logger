namespace System.Logging;

public abstract class LoggerTarget(ILogInterpolator logInterpolator) : IDisposable
{
    protected ILogInterpolator LogInterpolator { get; } = logInterpolator;

    public void Initialize() => Initialize(CancellationToken.None);

    public abstract void Initialize(CancellationToken cancellationToken);

    public abstract void Publish(in LogContext context, CancellationToken cancellationToken);

    public abstract void Dispose(CancellationToken cancellationToken);

    public void Dispose() => Dispose(CancellationToken.None);
}
