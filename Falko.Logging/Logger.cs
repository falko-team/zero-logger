using System.Runtime.CompilerServices;

namespace Falko.Logging;

[method: MethodImpl(MethodImplOptions.AggressiveInlining)]
public readonly partial struct Logger(string name)
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, string? message)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var log = new LogContext(name, level, DateTimeOffset.Now)
        {
            Message = message
        };

        PublishLog(loggerContext, log);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, string? message)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var log = new LogContext(name, level, DateTimeOffset.Now)
        {
            Message = message,
            Exception = exception
        };

        PublishLog(loggerContext, log);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, LogMessageFactory messageFactory)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var log = new LogContext(name, level, DateTimeOffset.Now)
        {
            Message = messageFactory()
        };

        PublishLog(loggerContext, log);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, LogMessageFactory messageFactory)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var log = new LogContext(name, level, DateTimeOffset.Now)
        {
            Message = messageFactory(),
            Exception = exception
        };

        PublishLog(loggerContext, log);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, string? message, string? argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        ForceLog(loggerContext, level, time, message, [argument]);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, string? message, string? argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        ForceLog(loggerContext, level, time, exception, message, [argument]);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, string? message, short argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        ForceLog(loggerContext, level, time, message, [argument.ToString()]);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, string? message, short argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        ForceLog(loggerContext, level, time, exception, message, [argument.ToString()]);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, string? message, int argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        ForceLog(loggerContext, level, time, message, [argument.ToString()]);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, string? message, int argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        ForceLog(loggerContext, level, time, exception, message, [argument.ToString()]);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, string? message, long argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        ForceLog(loggerContext, level, time, message, [argument.ToString()]);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, string? message, long argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        ForceLog(loggerContext, level, time, exception, message, [argument.ToString()]);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, string? message, float argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        // ReSharper disable once SpecifyACultureInStringConversionExplicitly
        ForceLog(loggerContext, level, time, message, [argument.ToString()]);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, string? message, float argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        // ReSharper disable once SpecifyACultureInStringConversionExplicitly
        ForceLog(loggerContext, level, time, exception, message, [argument.ToString()]);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, string? message, double argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        // ReSharper disable once SpecifyACultureInStringConversionExplicitly
        ForceLog(loggerContext, level, time, message, [argument.ToString()]);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, string? message, double argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        // ReSharper disable once SpecifyACultureInStringConversionExplicitly
        ForceLog(loggerContext, level, time, exception, message, [argument.ToString()]);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, string? message, decimal argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        // ReSharper disable once SpecifyACultureInStringConversionExplicitly
        ForceLog(loggerContext, level, time, message, [argument.ToString()]);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, string? message, decimal argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        // ReSharper disable once SpecifyACultureInStringConversionExplicitly
        ForceLog(loggerContext, level, time, exception, message, [argument.ToString()]);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, string? message, DateTime argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        // ReSharper disable once SpecifyACultureInStringConversionExplicitly
        ForceLog(loggerContext, level, time, message, [argument.ToString()]);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, string? message, DateTime argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        // ReSharper disable once SpecifyACultureInStringConversionExplicitly
        ForceLog(loggerContext, level, time, exception, message, [argument.ToString()]);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, string? message, DateTimeOffset argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        // ReSharper disable once SpecifyACultureInStringConversionExplicitly
        ForceLog(loggerContext, level, time, message, [argument.ToString()]);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, string? message, DateTimeOffset argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        // ReSharper disable once SpecifyACultureInStringConversionExplicitly
        ForceLog(loggerContext, level, time, exception, message, [argument.ToString()]);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, string? message, DateOnly argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        // ReSharper disable once SpecifyACultureInStringConversionExplicitly
        ForceLog(loggerContext, level, time, message, [argument.ToString()]);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, string? message, DateOnly argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        // ReSharper disable once SpecifyACultureInStringConversionExplicitly
        ForceLog(loggerContext, level, time, exception, message, [argument.ToString()]);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, string? message, TimeSpan argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        // ReSharper disable once SpecifyACultureInStringConversionExplicitly
        ForceLog(loggerContext, level, time, message, [argument.ToString()]);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, string? message, TimeSpan argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        // ReSharper disable once SpecifyACultureInStringConversionExplicitly
        ForceLog(loggerContext, level, time, exception, message, [argument.ToString()]);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, string? message, TimeOnly argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        // ReSharper disable once SpecifyACultureInStringConversionExplicitly
        ForceLog(loggerContext, level, time, message, [argument.ToString()]);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, string? message, TimeOnly argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        // ReSharper disable once SpecifyACultureInStringConversionExplicitly
        ForceLog(loggerContext, level, time, exception, message, [argument.ToString()]);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, string? message, Guid argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        ForceLog(loggerContext, level, time, message, [argument.ToString()]);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, string? message, Guid argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        ForceLog(loggerContext, level, time, exception, message, [argument.ToString()]);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, string? message, bool argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        ForceLog(loggerContext, level, time, message, [argument.ToString()]);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, string? message, bool argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        ForceLog(loggerContext, level, time, exception, message, [argument.ToString()]);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, string? message, char argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        ForceLog(loggerContext, level, time, message, [argument.ToString()]);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, string? message, char argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        ForceLog(loggerContext, level, time, exception, message, [argument.ToString()]);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, string? message, ushort argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        ForceLog(loggerContext, level, time, message, [argument.ToString()]);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, string? message, ushort argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        ForceLog(loggerContext, level, time, exception, message, [argument.ToString()]);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, string? message, uint argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        ForceLog(loggerContext, level, time, message, [argument.ToString()]);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, string? message, uint argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        ForceLog(loggerContext, level, time, exception, message, [argument.ToString()]);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, string? message, ulong argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        ForceLog(loggerContext, level, time, message, [argument.ToString()]);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, string? message, ulong argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        ForceLog(loggerContext, level, time, exception, message, [argument.ToString()]);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, string? message, byte argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        ForceLog(loggerContext, level, time, message, [argument.ToString()]);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, string? message, byte argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        ForceLog(loggerContext, level, time, exception, message, [argument.ToString()]);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, string? message, sbyte argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        ForceLog(loggerContext, level, time, message, [argument.ToString()]);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, string? message, sbyte argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        ForceLog(loggerContext, level, time, exception, message, [argument.ToString()]);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log<T1>(LogLevel level, string? message, T1 argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        ForceLog(loggerContext, level, time, message, [argument?.ToString()]);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log<T1>(LogLevel level, Exception? exception, string? message, T1 argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        ForceLog(loggerContext, level, time, exception, message, [argument?.ToString()]);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log<T1, T2>(LogLevel level, string? message, T1 argument1, T2 argument2)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        ForceLog(loggerContext, level, time, message, [argument1?.ToString(), argument2?.ToString()]);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log<T1, T2>(LogLevel level, Exception? exception, string? message, T1 argument1, T2 argument2)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        ForceLog(loggerContext, level, time, exception, message, [argument1?.ToString(), argument2?.ToString()]);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log<T1, T2, T3>(LogLevel level, string? message, T1 argument1, T2 argument2, T3 argument3)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        ForceLog(loggerContext, level, time, message, [argument1?.ToString(), argument2?.ToString(), argument3?.ToString()]);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log<T1, T2, T3>(LogLevel level, Exception? exception, string? message, T1 argument1, T2 argument2, T3 argument3)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        ForceLog(loggerContext, level, time, exception, message, [argument1?.ToString(), argument2?.ToString(), argument3?.ToString()]);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log<T1, T2, T3, T4>(LogLevel level, string? message, T1 argument1, T2 argument2, T3 argument3, T4 argument4)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        ForceLog(loggerContext, level, time, message, [argument1?.ToString(), argument2?.ToString(), argument3?.ToString(), argument4?.ToString()]);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log<T1, T2, T3, T4>(LogLevel level, Exception? exception, string? message, T1 argument1, T2 argument2, T3 argument3, T4 argument4)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        ForceLog(loggerContext, level, time, exception, message, [argument1?.ToString(), argument2?.ToString(), argument3?.ToString(), argument4?.ToString()]);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log<T1, T2, T3, T4, T5>(LogLevel level, string? message, T1 argument1, T2 argument2, T3 argument3, T4 argument4, T5 argument5)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        ForceLog(loggerContext, level, time, message, [argument1?.ToString(), argument2?.ToString(), argument3?.ToString(), argument4?.ToString(), argument5?.ToString()]);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log<T1, T2, T3, T4, T5>(LogLevel level, Exception? exception, string? message, T1 argument1, T2 argument2, T3 argument3, T4 argument4, T5 argument5)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        ForceLog(loggerContext, level, time, exception, message, [argument1?.ToString(), argument2?.ToString(), argument3?.ToString(), argument4?.ToString(), argument5?.ToString()]);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log<T1, T2, T3, T4, T5, T6>(LogLevel level, string? message, T1 argument1, T2 argument2, T3 argument3, T4 argument4, T5 argument5, T6 argument6)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        ForceLog(loggerContext, level, time, message, [argument1?.ToString(), argument2?.ToString(), argument3?.ToString(), argument4?.ToString(), argument5?.ToString(), argument6?.ToString()]);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log<T1, T2, T3, T4, T5, T6>(LogLevel level, Exception? exception, string? message, T1 argument1, T2 argument2, T3 argument3, T4 argument4, T5 argument5, T6 argument6)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        ForceLog(loggerContext, level, time, exception, message, [argument1?.ToString(), argument2?.ToString(), argument3?.ToString(), argument4?.ToString(), argument5?.ToString(), argument6?.ToString()]);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void ForceLog(in LoggerContext loggerContext, LogLevel level, DateTimeOffset time, string? message, string?[] arguments)
    {
        var log = new LogContext(name, level, time)
        {
            Message = message,
            Arguments = arguments
        };

        PublishLog(loggerContext, log);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void ForceLog(in LoggerContext loggerContext, LogLevel level, DateTimeOffset time, Exception? exception, string? message, string?[] arguments)
    {
        var log = new LogContext(name, level, time)
        {
            Message = message,
            Arguments = arguments,
            Exception = exception
        };

        PublishLog(loggerContext, log);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static void PublishLog(in LoggerContext loggerContext, in LogContext logContext)
    {
        var targets = loggerContext.Targets;

        var targetsLength = targets.Length;

        // ReSharper disable once ConvertIfStatementToSwitchStatement
        if (targetsLength > 1)
        {
            var cancellationToken = loggerContext.CancellationToken;

            var targetsSpan = new ReadOnlySpan<LoggerTarget>(targets);

            for (var targetIndex = 0; targetIndex < targetsLength; targetIndex++)
            {
                PublishLog(targetsSpan[targetIndex], logContext, cancellationToken);
            }
        }
        else if (targetsLength is 1)
        {
            PublishLog(targets[0], logContext, loggerContext.CancellationToken);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static void PublishLog(in LoggerTarget target, in LogContext logContext, CancellationToken cancellationToken)
    {
        try
        {
            target.Publish(logContext, cancellationToken);
        }
#if DEBUG
        catch (Exception exception)
        {
            DebugEventLogger.Notify(exception, "Error while publishing log");
        }
#else
        catch
        {
            // Nothing to do
        }
#endif
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static bool CantLog(in LoggerContext loggerContext, LogLevel level)
    {
        return loggerContext.MinimumLevel >= level;
    }
}
