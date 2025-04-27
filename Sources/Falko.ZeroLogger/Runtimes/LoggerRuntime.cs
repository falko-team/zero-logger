using System.Logging.Builders;
using System.Logging.Contexts;
using System.Logging.Debugs;
using System.Logging.Logs;
using System.Logging.Targets;
using System.Runtime.CompilerServices;

namespace System.Logging.Runtimes;

public static partial class LoggerRuntime
{
    private static readonly Lock Locker = new();

    private static readonly LoggerContext DefaultContext = new(LogLevel.Trace, [], [], new CancellationToken(true));

    private static CancellationTokenSource? _contextCancellation;

    internal static LoggerContext Context = DefaultContext;

    public static LogLevel MinimumLevel => Context.MinimumLevel;

    public static void Initialize(LoggerContextBuilder loggerBuilder, CancellationToken cancellationToken)
    {
        lock (Locker)
        {
            Dispose(cancellationToken);

            var contextCancellation = new CancellationTokenSource();

            _contextCancellation = contextCancellation;
            var context = loggerBuilder.Build(contextCancellation.Token);
            Context = context;

            var targetsLength = context.Targets.Length;

            // ReSharper disable once ConvertIfStatementToSwitchStatement
            if (targetsLength > 1)
            {
                var targetsSpan = new ReadOnlySpan<LoggerTarget>(context.Targets);

                for (var targetIndex = 0; targetIndex < targetsLength; targetIndex++)
                {
                    InitializeTarget(targetsSpan[targetIndex], cancellationToken);
                }
            }
            else if (targetsLength is 1)
            {
                InitializeTarget(context.Targets[0], cancellationToken);
            }
        }
    }

    public static void Dispose(CancellationToken cancellationToken)
    {
        lock (Locker)
        {
            var loggerContext = Context;

            if (loggerContext.CancellationToken.IsCancellationRequested) return;

            var cancellationTokenSource = _contextCancellation!;

            try
            {
                cancellationTokenSource.Cancel();
            }
            catch (Exception exception)
            {
#if DEBUG
                DebugEventLogger.Handle("Error while cancelling logger context", exception);
#endif
            }

            try
            {
                cancellationTokenSource.Dispose();
            }
            catch (Exception exception)
            {
#if DEBUG
                DebugEventLogger.Handle("Error while disposing logger context", exception);
#endif
            }

            var targets = loggerContext.Targets;

            var targetsLength = targets.Length;

            // ReSharper disable once ConvertIfStatementToSwitchStatement
            if (targetsLength > 1)
            {
                var targetsSpan = new ReadOnlySpan<LoggerTarget>(targets);

                for (var targetIndex = 0; targetIndex < targetsLength; targetIndex++)
                {
                    // ReSharper disable once PossiblyMistakenUseOfCancellationToken
                    DisposeTarget(targetsSpan[targetIndex], cancellationToken);
                }
            }
            else if (targetsLength is 1)
            {
                // ReSharper disable once PossiblyMistakenUseOfCancellationToken
                DisposeTarget(targets[0], cancellationToken);
            }

            _contextCancellation = null;
            Context = DefaultContext;
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static void InitializeTarget(LoggerTarget target, CancellationToken cancellationToken)
    {
        try
        {
            target.Initialize(cancellationToken);
        }
        catch (Exception exception)
        {
#if DEBUG
            DebugEventLogger.Handle("Error while initializing logger target", exception);
#endif
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static void DisposeTarget(LoggerTarget target, CancellationToken cancellationToken)
    {
        try
        {
            target.Dispose(cancellationToken);
        }
        catch (Exception exception)
        {
#if DEBUG
            DebugEventLogger.Handle("Error while disposing logger target", exception);
#endif
        }
    }
}
