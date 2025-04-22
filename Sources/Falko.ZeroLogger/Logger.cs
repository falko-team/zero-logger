using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Logging;

[method: MethodImpl(MethodImplOptions.AggressiveInlining)]
public readonly partial struct Logger(string name)
{
    #region Log()

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, string? message)
    {
        if (message is null) return;

        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        PublishLog(loggerContext, new LogContext(name, level, time, message));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, string? message)
    {
        if (exception is null && message is null) return;

        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        PublishLog(loggerContext, new LogContext(name, level, time, message) { Exception = exception });
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, LogMessageFactory messageFactory)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var message = messageFactory();

        if (message is null) return;

        PublishLog(loggerContext, new LogContext(name, level, time, message));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, LogMessageFactory messageFactory)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var message = messageFactory();

        if (exception is null && message is null) return;

        PublishLog(loggerContext, new LogContext(name, level, time, message) { Exception = exception });
    }

    #endregion

    #region Log(short)

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, string? message,
        short argument)
    {
        if (message is null) return;

        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument.ToString());

        PublishLog(loggerContext, new LogContext(name, level, time, message));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, string? message,
        short argument)
    {
        if (exception is null && message is null) return;

        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument.ToString());

        PublishLog(loggerContext, new LogContext(name, level, time, message) { Exception = exception });
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, LogMessageFactory messageFactory,
        short argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var message = messageFactory();

        if (message is null) return;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument.ToString());

        PublishLog(loggerContext, new LogContext(name, level, time, message));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, LogMessageFactory messageFactory,
        short argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var message = messageFactory();

        if (exception is null && message is null) return;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument.ToString());

        PublishLog(loggerContext, new LogContext(name, level, time, message) { Exception = exception });
    }

    #endregion

    #region Log(ushort)

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, string? message,
        ushort argument)
    {
        if (message is null) return;

        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument.ToString());

        PublishLog(loggerContext, new LogContext(name, level, time, message));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, string? message,
        ushort argument)
    {
        if (exception is null && message is null) return;

        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument.ToString());

        PublishLog(loggerContext, new LogContext(name, level, time, message) { Exception = exception });
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, LogMessageFactory messageFactory,
        ushort argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var message = messageFactory();

        if (message is null) return;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument.ToString());

        PublishLog(loggerContext, new LogContext(name, level, time, message));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, LogMessageFactory messageFactory,
        ushort argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var message = messageFactory();

        if (exception is null && message is null) return;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument.ToString());

        PublishLog(loggerContext, new LogContext(name, level, time, message) { Exception = exception });
    }

    #endregion

    #region Log(int)

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, string? message,
        int argument)
    {
        if (message is null) return;

        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument.ToString());

        PublishLog(loggerContext, new LogContext(name, level, time, message));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, string? message,
        int argument)
    {
        if (exception is null && message is null) return;

        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument.ToString());

        PublishLog(loggerContext, new LogContext(name, level, time, message) { Exception = exception });
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, LogMessageFactory messageFactory,
        int argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var message = messageFactory();

        if (message is null) return;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument.ToString());

        PublishLog(loggerContext, new LogContext(name, level, time, message));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, LogMessageFactory messageFactory,
        int argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var message = messageFactory();

        if (exception is null && message is null) return;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument.ToString());

        PublishLog(loggerContext, new LogContext(name, level, time, message) { Exception = exception });
    }

    #endregion

    #region Log(nint)

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, string? message,
        nint argument)
    {
        if (message is null) return;

        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument.ToString());

        PublishLog(loggerContext, new LogContext(name, level, time, message));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, string? message,
        nint argument)
    {
        if (exception is null && message is null) return;

        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument.ToString());

        PublishLog(loggerContext, new LogContext(name, level, time, message) { Exception = exception });
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, LogMessageFactory messageFactory,
        nint argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var message = messageFactory();

        if (message is null) return;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument.ToString());

        PublishLog(loggerContext, new LogContext(name, level, time, message));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, LogMessageFactory messageFactory,
        nint argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var message = messageFactory();

        if (exception is null && message is null) return;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument.ToString());

        PublishLog(loggerContext, new LogContext(name, level, time, message) { Exception = exception });
    }

    #endregion

    #region Log(uint)

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, string? message,
        uint argument)
    {
        if (message is null) return;

        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument.ToString());

        PublishLog(loggerContext, new LogContext(name, level, time, message));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, string? message,
        uint argument)
    {
        if (exception is null && message is null) return;

        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument.ToString());

        PublishLog(loggerContext, new LogContext(name, level, time, message) { Exception = exception });
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, LogMessageFactory messageFactory,
        uint argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var message = messageFactory();

        if (message is null) return;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument.ToString());

        PublishLog(loggerContext, new LogContext(name, level, time, message));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, LogMessageFactory messageFactory,
        uint argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var message = messageFactory();

        if (exception is null && message is null) return;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument.ToString());

        PublishLog(loggerContext, new LogContext(name, level, time, message) { Exception = exception });
    }

    #endregion

    #region Log(nuint)

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, string? message,
        nuint argument)
    {
        if (message is null) return;

        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument.ToString());

        PublishLog(loggerContext, new LogContext(name, level, time, message));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, string? message,
        nuint argument)
    {
        if (exception is null && message is null) return;

        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument.ToString());

        PublishLog(loggerContext, new LogContext(name, level, time, message) { Exception = exception });
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, LogMessageFactory messageFactory,
        nuint argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var message = messageFactory();

        if (message is null) return;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument.ToString());

        PublishLog(loggerContext, new LogContext(name, level, time, message));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, LogMessageFactory messageFactory,
        nuint argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var message = messageFactory();

        if (exception is null && message is null) return;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument.ToString());

        PublishLog(loggerContext, new LogContext(name, level, time, message) { Exception = exception });
    }

    #endregion

    #region Log(long)

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, string? message,
        long argument)
    {
        if (message is null) return;

        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument.ToString());

        PublishLog(loggerContext, new LogContext(name, level, time, message));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, string? message,
        long argument)
    {
        if (exception is null && message is null) return;

        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument.ToString());

        PublishLog(loggerContext, new LogContext(name, level, time, message) { Exception = exception });
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, LogMessageFactory messageFactory,
        long argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var message = messageFactory();

        if (message is null) return;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument.ToString());

        PublishLog(loggerContext, new LogContext(name, level, time, message));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, LogMessageFactory messageFactory,
        long argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var message = messageFactory();

        if (exception is null && message is null) return;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument.ToString());

        PublishLog(loggerContext, new LogContext(name, level, time, message) { Exception = exception });
    }

    #endregion

    #region Log(ulong)

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, string? message,
        ulong argument)
    {
        if (message is null) return;

        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument.ToString());

        PublishLog(loggerContext, new LogContext(name, level, time, message));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, string? message,
        ulong argument)
    {
        if (exception is null && message is null) return;

        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument.ToString());

        PublishLog(loggerContext, new LogContext(name, level, time, message) { Exception = exception });
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, LogMessageFactory messageFactory,
        ulong argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var message = messageFactory();

        if (message is null) return;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument.ToString());

        PublishLog(loggerContext, new LogContext(name, level, time, message));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, LogMessageFactory messageFactory,
        ulong argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var message = messageFactory();

        if (exception is null && message is null) return;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument.ToString());

        PublishLog(loggerContext, new LogContext(name, level, time, message) { Exception = exception });
    }

    #endregion

    #region Log(BigInteger)

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, string? message,
        BigInteger argument)
    {
        if (message is null) return;

        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument.ToString());

        PublishLog(loggerContext, new LogContext(name, level, time, message));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, string? message,
        BigInteger argument)
    {
        if (exception is null && message is null) return;

        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument.ToString());

        PublishLog(loggerContext, new LogContext(name, level, time, message) { Exception = exception });
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, LogMessageFactory messageFactory,
        BigInteger argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var message = messageFactory();

        if (message is null) return;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument.ToString());

        PublishLog(loggerContext, new LogContext(name, level, time, message));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, LogMessageFactory messageFactory,
        BigInteger argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var message = messageFactory();

        if (exception is null && message is null) return;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument.ToString());

        PublishLog(loggerContext, new LogContext(name, level, time, message) { Exception = exception });
    }

    #endregion

    #region Log(float)

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, string? message,
        float argument)
    {
        if (message is null) return;

        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        // ReSharper disable once SpecifyACultureInStringConversionExplicitly
        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument.ToString());

        PublishLog(loggerContext, new LogContext(name, level, time, message));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, string? message,
        float argument)
    {
        if (exception is null && message is null) return;

        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        // ReSharper disable once SpecifyACultureInStringConversionExplicitly
        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument.ToString());

        PublishLog(loggerContext, new LogContext(name, level, time, message) { Exception = exception });
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, LogMessageFactory messageFactory,
        float argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var message = messageFactory();

        if (message is null) return;

        // ReSharper disable once SpecifyACultureInStringConversionExplicitly
        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument.ToString());

        PublishLog(loggerContext, new LogContext(name, level, time, message));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, LogMessageFactory messageFactory,
        float argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var message = messageFactory();

        if (exception is null && message is null) return;

        // ReSharper disable once SpecifyACultureInStringConversionExplicitly
        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument.ToString());

        PublishLog(loggerContext, new LogContext(name, level, time, message) { Exception = exception });
    }

    #endregion

    #region Log(double)

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, string? message,
        double argument)
    {
        if (message is null) return;

        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        // ReSharper disable once SpecifyACultureInStringConversionExplicitly
        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument.ToString());

        PublishLog(loggerContext, new LogContext(name, level, time, message));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, string? message,
        double argument)
    {
        if (exception is null && message is null) return;

        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        // ReSharper disable once SpecifyACultureInStringConversionExplicitly
        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument.ToString());

        PublishLog(loggerContext, new LogContext(name, level, time, message) { Exception = exception });
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, LogMessageFactory messageFactory,
        double argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var message = messageFactory();

        if (message is null) return;

        // ReSharper disable once SpecifyACultureInStringConversionExplicitly
        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument.ToString());

        PublishLog(loggerContext, new LogContext(name, level, time, message));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, LogMessageFactory messageFactory,
        double argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var message = messageFactory();

        if (exception is null && message is null) return;

        // ReSharper disable once SpecifyACultureInStringConversionExplicitly
        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument.ToString());

        PublishLog(loggerContext, new LogContext(name, level, time, message) { Exception = exception });
    }

    #endregion

    #region Log(decimal)

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, string? message,
        decimal argument)
    {
        if (message is null) return;

        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        // ReSharper disable once SpecifyACultureInStringConversionExplicitly
        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument.ToString());

        PublishLog(loggerContext, new LogContext(name, level, time, message));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, string? message,
        decimal argument)
    {
        if (exception is null && message is null) return;

        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        // ReSharper disable once SpecifyACultureInStringConversionExplicitly
        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument.ToString());

        PublishLog(loggerContext, new LogContext(name, level, time, message) { Exception = exception });
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, LogMessageFactory messageFactory,
        decimal argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var message = messageFactory();

        if (message is null) return;

        // ReSharper disable once SpecifyACultureInStringConversionExplicitly
        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument.ToString());

        PublishLog(loggerContext, new LogContext(name, level, time, message));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, LogMessageFactory messageFactory,
        decimal argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var message = messageFactory();

        if (exception is null && message is null) return;

        // ReSharper disable once SpecifyACultureInStringConversionExplicitly
        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument.ToString());

        PublishLog(loggerContext, new LogContext(name, level, time, message) { Exception = exception });
    }

    #endregion

    #region Log(Guid)

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, string? message,
        Guid argument)
    {
        if (message is null) return;

        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument.ToString());

        PublishLog(loggerContext, new LogContext(name, level, time, message));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, string? message,
        Guid argument)
    {
        if (exception is null && message is null) return;

        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument.ToString());

        PublishLog(loggerContext, new LogContext(name, level, time, message) { Exception = exception });
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, LogMessageFactory messageFactory,
        Guid argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var message = messageFactory();

        if (message is null) return;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument.ToString());

        PublishLog(loggerContext, new LogContext(name, level, time, message));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, LogMessageFactory messageFactory,
        Guid argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var message = messageFactory();

        if (exception is null && message is null) return;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument.ToString());

        PublishLog(loggerContext, new LogContext(name, level, time, message) { Exception = exception });
    }

    #endregion

    #region Log(TimeSpan)

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, string? message,
        TimeSpan argument)
    {
        if (message is null) return;

        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument.ToString());

        PublishLog(loggerContext, new LogContext(name, level, time, message));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, string? message,
        TimeSpan argument)
    {
        if (exception is null && message is null) return;

        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument.ToString());

        PublishLog(loggerContext, new LogContext(name, level, time, message) { Exception = exception });
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, LogMessageFactory messageFactory,
        TimeSpan argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var message = messageFactory();

        if (message is null) return;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument.ToString());

        PublishLog(loggerContext, new LogContext(name, level, time, message));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, LogMessageFactory messageFactory,
        TimeSpan argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var message = messageFactory();

        if (exception is null && message is null) return;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument.ToString());

        PublishLog(loggerContext, new LogContext(name, level, time, message) { Exception = exception });
    }

    #endregion

    #region Log(TimeOnly)

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, string? message,
        TimeOnly argument)
    {
        if (message is null) return;

        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument.ToString());

        PublishLog(loggerContext, new LogContext(name, level, time, message));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, string? message,
        TimeOnly argument)
    {
        if (exception is null && message is null) return;

        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument.ToString());

        PublishLog(loggerContext, new LogContext(name, level, time, message) { Exception = exception });
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, LogMessageFactory messageFactory,
        TimeOnly argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var message = messageFactory();

        if (message is null) return;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument.ToString());

        PublishLog(loggerContext, new LogContext(name, level, time, message));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, LogMessageFactory messageFactory,
        TimeOnly argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var message = messageFactory();

        if (exception is null && message is null) return;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument.ToString());

        PublishLog(loggerContext, new LogContext(name, level, time, message) { Exception = exception });
    }

    #endregion

    #region Log(DateTime)

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, string? message,
        DateTime argument)
    {
        if (message is null) return;

        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        // ReSharper disable once SpecifyACultureInStringConversionExplicitly
        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument.ToString());

        PublishLog(loggerContext, new LogContext(name, level, time, message));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, string? message,
        DateTime argument)
    {
        if (exception is null && message is null) return;

        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        // ReSharper disable once SpecifyACultureInStringConversionExplicitly
        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument.ToString());

        PublishLog(loggerContext, new LogContext(name, level, time, message) { Exception = exception });
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, LogMessageFactory messageFactory,
        DateTime argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var message = messageFactory();

        if (message is null) return;

        // ReSharper disable once SpecifyACultureInStringConversionExplicitly
        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument.ToString());

        PublishLog(loggerContext, new LogContext(name, level, time, message));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, LogMessageFactory messageFactory,
        DateTime argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var message = messageFactory();

        if (exception is null && message is null) return;

        // ReSharper disable once SpecifyACultureInStringConversionExplicitly
        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument.ToString());

        PublishLog(loggerContext, new LogContext(name, level, time, message) { Exception = exception });
    }

    #endregion

    #region Log(DateTimeOffset)

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, string? message,
        DateTimeOffset argument)
    {
        if (message is null) return;

        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument.ToString());

        PublishLog(loggerContext, new LogContext(name, level, time, message));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, string? message,
        DateTimeOffset argument)
    {
        if (exception is null && message is null) return;

        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument.ToString());

        PublishLog(loggerContext, new LogContext(name, level, time, message) { Exception = exception });
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, LogMessageFactory messageFactory,
        DateTimeOffset argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var message = messageFactory();

        if (message is null) return;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument.ToString());

        PublishLog(loggerContext, new LogContext(name, level, time, message));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, LogMessageFactory messageFactory,
        DateTimeOffset argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var message = messageFactory();

        if (exception is null && message is null) return;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument.ToString());

        PublishLog(loggerContext, new LogContext(name, level, time, message) { Exception = exception });
    }

    #endregion

    #region Log(DateOnly)

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, string? message,
        DateOnly argument)
    {
        if (message is null) return;

        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument.ToString());

        PublishLog(loggerContext, new LogContext(name, level, time, message));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, string? message,
        DateOnly argument)
    {
        if (exception is null && message is null) return;

        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument.ToString());

        PublishLog(loggerContext, new LogContext(name, level, time, message) { Exception = exception });
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, LogMessageFactory messageFactory,
        DateOnly argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var message = messageFactory();

        if (message is null) return;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument.ToString());

        PublishLog(loggerContext, new LogContext(name, level, time, message));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, LogMessageFactory messageFactory,
        DateOnly argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var message = messageFactory();

        if (exception is null && message is null) return;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument.ToString());

        PublishLog(loggerContext, new LogContext(name, level, time, message) { Exception = exception });
    }

    #endregion

    #region Log(byte)

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, string? message,
        byte argument)
    {
        if (message is null) return;

        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument.ToString());

        PublishLog(loggerContext, new LogContext(name, level, time, message));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, string? message,
        byte argument)
    {
        if (exception is null && message is null) return;

        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument.ToString());

        PublishLog(loggerContext, new LogContext(name, level, time, message) { Exception = exception });
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, LogMessageFactory messageFactory,
        byte argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var message = messageFactory();

        if (message is null) return;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument.ToString());

        PublishLog(loggerContext, new LogContext(name, level, time, message));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, LogMessageFactory messageFactory,
        byte argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var message = messageFactory();

        if (exception is null && message is null) return;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument.ToString());

        PublishLog(loggerContext, new LogContext(name, level, time, message) { Exception = exception });
    }

    #endregion

    #region Log(sbyte)

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, string? message,
        sbyte argument)
    {
        if (message is null) return;

        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument.ToString());

        PublishLog(loggerContext, new LogContext(name, level, time, message));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, string? message,
        sbyte argument)
    {
        if (exception is null && message is null) return;

        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument.ToString());

        PublishLog(loggerContext, new LogContext(name, level, time, message) { Exception = exception });
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, LogMessageFactory messageFactory,
        sbyte argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var message = messageFactory();

        if (message is null) return;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument.ToString());

        PublishLog(loggerContext, new LogContext(name, level, time, message));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, LogMessageFactory messageFactory,
        sbyte argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var message = messageFactory();

        if (exception is null && message is null) return;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument.ToString());

        PublishLog(loggerContext, new LogContext(name, level, time, message) { Exception = exception });
    }

    #endregion

    #region Log(char)

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, string? message,
        char argument)
    {
        if (message is null) return;

        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument.ToString());

        PublishLog(loggerContext, new LogContext(name, level, time, message));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, string? message,
        char argument)
    {
        if (exception is null && message is null) return;

        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument.ToString());

        PublishLog(loggerContext, new LogContext(name, level, time, message) { Exception = exception });
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, LogMessageFactory messageFactory,
        char argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var message = messageFactory();

        if (message is null) return;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument.ToString());

        PublishLog(loggerContext, new LogContext(name, level, time, message));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, LogMessageFactory messageFactory,
        char argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var message = messageFactory();

        if (exception is null && message is null) return;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument.ToString());

        PublishLog(loggerContext, new LogContext(name, level, time, message) { Exception = exception });
    }

    #endregion

    #region Log(string)

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, string? message,
        string? argument)
    {
        if (message is null) return;

        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument);

        PublishLog(loggerContext, new LogContext(name, level, time, message));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, string? message,
        string? argument)
    {
        if (exception is null && message is null) return;

        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument);

        PublishLog(loggerContext, new LogContext(name, level, time, message) { Exception = exception });
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, LogMessageFactory messageFactory,
        string? argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var message = messageFactory();

        if (message is null) return;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument);

        PublishLog(loggerContext, new LogContext(name, level, time, message));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, LogMessageFactory messageFactory,
        string? argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var message = messageFactory();

        if (exception is null && message is null) return;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument);

        PublishLog(loggerContext, new LogContext(name, level, time, message) { Exception = exception });
    }

    #endregion

    #region Log(string, string)

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, string? message,
        string? argument1,
        string? argument2)
    {
        if (message is null) return;

        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument1,
            argument2);

        PublishLog(loggerContext, new LogContext(name, level, time, message));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, string? message,
        string? argument1,
        string? argument2)
    {
        if (exception is null && message is null) return;

        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument1,
            argument2);

        PublishLog(loggerContext, new LogContext(name, level, time, message) { Exception = exception });
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, LogMessageFactory messageFactory,
        string? argument1,
        string? argument2)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var message = messageFactory();

        if (message is null) return;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument1,
            argument2);

        PublishLog(loggerContext, new LogContext(name, level, time, message));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, LogMessageFactory messageFactory,
        string? argument1,
        string? argument2)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var message = messageFactory();

        if (exception is null && message is null) return;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument1,
            argument2);

        PublishLog(loggerContext, new LogContext(name, level, time, message) { Exception = exception });
    }

    #endregion

    #region Log(string, string, string)

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, string? message,
        string? argument1,
        string? argument2,
        string? argument3)
    {
        if (message is null) return;

        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument1,
            argument2,
            argument3);

        PublishLog(loggerContext, new LogContext(name, level, time, message));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, string? message,
        string? argument1,
        string? argument2,
        string? argument3)
    {
        if (exception is null && message is null) return;

        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument1,
            argument2,
            argument3);

        PublishLog(loggerContext, new LogContext(name, level, time, message) { Exception = exception });
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, LogMessageFactory messageFactory,
        string? argument1,
        string? argument2,
        string? argument3)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var message = messageFactory();

        if (message is null) return;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument1,
            argument2,
            argument3);

        PublishLog(loggerContext, new LogContext(name, level, time, message));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, LogMessageFactory messageFactory,
        string? argument1,
        string? argument2,
        string? argument3)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var message = messageFactory();

        if (exception is null && message is null) return;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument1,
            argument2,
            argument3);

        PublishLog(loggerContext, new LogContext(name, level, time, message) { Exception = exception });
    }

    #endregion

    #region Log(string, string, string, string)

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, string? message,
        string? argument1,
        string? argument2,
        string? argument3,
        string? argument4)
    {
        if (message is null) return;

        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument1,
            argument2,
            argument3,
            argument4);

        PublishLog(loggerContext, new LogContext(name, level, time, message));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, string? message,
        string? argument1,
        string? argument2,
        string? argument3,
        string? argument4)
    {
        if (exception is null && message is null) return;

        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument1,
            argument2,
            argument3,
            argument4);

        PublishLog(loggerContext, new LogContext(name, level, time, message) { Exception = exception });
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, LogMessageFactory messageFactory,
        string? argument1,
        string? argument2,
        string? argument3,
        string? argument4)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var message = messageFactory();

        if (message is null) return;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument1,
            argument2,
            argument3,
            argument4);

        PublishLog(loggerContext, new LogContext(name, level, time, message));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, LogMessageFactory messageFactory,
        string? argument1,
        string? argument2,
        string? argument3,
        string? argument4)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var message = messageFactory();

        if (exception is null && message is null) return;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument1,
            argument2,
            argument3,
            argument4);

        PublishLog(loggerContext, new LogContext(name, level, time, message) { Exception = exception });
    }

    #endregion

    #region Log(string, string, string, string, string)

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, string? message,
        string? argument1,
        string? argument2,
        string? argument3,
        string? argument4,
        string? argument5)
    {
        if (message is null) return;

        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument1,
            argument2,
            argument3,
            argument4,
            argument5);

        PublishLog(loggerContext, new LogContext(name, level, time, message));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, string? message,
        string? argument1,
        string? argument2,
        string? argument3,
        string? argument4,
        string? argument5)
    {
        if (exception is null && message is null) return;

        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument1,
            argument2,
            argument3,
            argument4,
            argument5);

        PublishLog(loggerContext, new LogContext(name, level, time, message) { Exception = exception });
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, LogMessageFactory messageFactory,
        string? argument1,
        string? argument2,
        string? argument3,
        string? argument4,
        string? argument5)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var message = messageFactory();

        if (message is null) return;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument1,
            argument2,
            argument3,
            argument4,
            argument5);

        PublishLog(loggerContext, new LogContext(name, level, time, message));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, LogMessageFactory messageFactory,
        string? argument1,
        string? argument2,
        string? argument3,
        string? argument4,
        string? argument5)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var message = messageFactory();

        if (exception is null && message is null) return;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument1,
            argument2,
            argument3,
            argument4,
            argument5);

        PublishLog(loggerContext, new LogContext(name, level, time, message) { Exception = exception });
    }

    #endregion

    #region Log(LogMessageArgumentFactory)

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, string? message,
        LogMessageArgumentFactory argumentFactory)
    {
        if (message is null) return;

        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argumentFactory());

        PublishLog(loggerContext, new LogContext(name, level, time, message));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, string? message,
        LogMessageArgumentFactory argumentFactory)
    {
        if (exception is null && message is null) return;

        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argumentFactory());

        PublishLog(loggerContext, new LogContext(name, level, time, message) { Exception = exception });
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, LogMessageFactory messageFactory,
        LogMessageArgumentFactory argumentFactory)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var message = messageFactory();

        if (message is null) return;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argumentFactory());

        PublishLog(loggerContext, new LogContext(name, level, time, message));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, LogMessageFactory messageFactory,
        LogMessageArgumentFactory argumentFactory)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var message = messageFactory();

        if (exception is null && message is null) return;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argumentFactory());

        PublishLog(loggerContext, new LogContext(name, level, time, message) { Exception = exception });
    }

    #endregion

    #region Log(LogMessageArgumentFactory, LogMessageArgumentFactory)

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, string? message,
        LogMessageArgumentFactory argumentFactory1,
        LogMessageArgumentFactory argumentFactory2)
    {
        if (message is null) return;

        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argumentFactory1(),
            argumentFactory2());

        PublishLog(loggerContext, new LogContext(name, level, time, message));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, string? message,
        LogMessageArgumentFactory argumentFactory1,
        LogMessageArgumentFactory argumentFactory2)
    {
        if (exception is null && message is null) return;

        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argumentFactory1(),
            argumentFactory2());

        PublishLog(loggerContext, new LogContext(name, level, time, message) { Exception = exception });
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, LogMessageFactory messageFactory,
        LogMessageArgumentFactory argumentFactory1,
        LogMessageArgumentFactory argumentFactory2)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var message = messageFactory();

        if (message is null) return;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argumentFactory1(),
            argumentFactory2());

        PublishLog(loggerContext, new LogContext(name, level, time, message));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, LogMessageFactory messageFactory,
        LogMessageArgumentFactory argumentFactory1,
        LogMessageArgumentFactory argumentFactory2)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var message = messageFactory();

        if (exception is null && message is null) return;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argumentFactory1(),
            argumentFactory2());

        PublishLog(loggerContext, new LogContext(name, level, time, message) { Exception = exception });
    }

    #endregion

    #region Log(LogMessageArgumentFactory, LogMessageArgumentFactory, LogMessageArgumentFactory)

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, string? message,
        LogMessageArgumentFactory argumentFactory1,
        LogMessageArgumentFactory argumentFactory2,
        LogMessageArgumentFactory argumentFactory3)
    {
        if (message is null) return;

        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argumentFactory1(),
            argumentFactory2(),
            argumentFactory3());

        PublishLog(loggerContext, new LogContext(name, level, time, message));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, string? message,
        LogMessageArgumentFactory argumentFactory1,
        LogMessageArgumentFactory argumentFactory2,
        LogMessageArgumentFactory argumentFactory3)
    {
        if (exception is null && message is null) return;

        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argumentFactory1(),
            argumentFactory2(),
            argumentFactory3());

        PublishLog(loggerContext, new LogContext(name, level, time, message) { Exception = exception });
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, LogMessageFactory messageFactory,
        LogMessageArgumentFactory argumentFactory1,
        LogMessageArgumentFactory argumentFactory2,
        LogMessageArgumentFactory argumentFactory3)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var message = messageFactory();

        if (message is null) return;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argumentFactory1(),
            argumentFactory2(),
            argumentFactory3());

        PublishLog(loggerContext, new LogContext(name, level, time, message));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, LogMessageFactory messageFactory,
        LogMessageArgumentFactory argumentFactory1,
        LogMessageArgumentFactory argumentFactory2,
        LogMessageArgumentFactory argumentFactory3)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var message = messageFactory();

        if (exception is null && message is null) return;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argumentFactory1(),
            argumentFactory2(),
            argumentFactory3());

        PublishLog(loggerContext, new LogContext(name, level, time, message) { Exception = exception });
    }

    #endregion

    #region Log(LogMessageArgumentFactory, LogMessageArgumentFactory, LogMessageArgumentFactory, LogMessageArgumentFactory)

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, string? message,
        LogMessageArgumentFactory argumentFactory1,
        LogMessageArgumentFactory argumentFactory2,
        LogMessageArgumentFactory argumentFactory3,
        LogMessageArgumentFactory argumentFactory4)
    {
        if (message is null) return;

        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argumentFactory1(),
            argumentFactory2(),
            argumentFactory3(),
            argumentFactory4());

        PublishLog(loggerContext, new LogContext(name, level, time, message));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, string? message,
        LogMessageArgumentFactory argumentFactory1,
        LogMessageArgumentFactory argumentFactory2,
        LogMessageArgumentFactory argumentFactory3,
        LogMessageArgumentFactory argumentFactory4)
    {
        if (exception is null && message is null) return;

        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argumentFactory1(),
            argumentFactory2(),
            argumentFactory3(),
            argumentFactory4());

        PublishLog(loggerContext, new LogContext(name, level, time, message) { Exception = exception });
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, LogMessageFactory messageFactory,
        LogMessageArgumentFactory argumentFactory1,
        LogMessageArgumentFactory argumentFactory2,
        LogMessageArgumentFactory argumentFactory3,
        LogMessageArgumentFactory argumentFactory4)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var message = messageFactory();

        if (message is null) return;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argumentFactory1(),
            argumentFactory2(),
            argumentFactory3(),
            argumentFactory4());

        PublishLog(loggerContext, new LogContext(name, level, time, message));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, LogMessageFactory messageFactory,
        LogMessageArgumentFactory argumentFactory1,
        LogMessageArgumentFactory argumentFactory2,
        LogMessageArgumentFactory argumentFactory3,
        LogMessageArgumentFactory argumentFactory4)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var message = messageFactory();

        if (exception is null && message is null) return;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argumentFactory1(),
            argumentFactory2(),
            argumentFactory3(),
            argumentFactory4());

        PublishLog(loggerContext, new LogContext(name, level, time, message) { Exception = exception });
    }

    #endregion

    #region Log(LogMessageArgumentFactory, LogMessageArgumentFactory, LogMessageArgumentFactory, LogMessageArgumentFactory, LogMessageArgumentFactory)

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, string? message,
        LogMessageArgumentFactory argumentFactory1,
        LogMessageArgumentFactory argumentFactory2,
        LogMessageArgumentFactory argumentFactory3,
        LogMessageArgumentFactory argumentFactory4,
        LogMessageArgumentFactory argumentFactory5)
    {
        if (message is null) return;

        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argumentFactory1(),
            argumentFactory2(),
            argumentFactory3(),
            argumentFactory4(),
            argumentFactory5());

        PublishLog(loggerContext, new LogContext(name, level, time, message));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, string? message,
        LogMessageArgumentFactory argumentFactory1,
        LogMessageArgumentFactory argumentFactory2,
        LogMessageArgumentFactory argumentFactory3,
        LogMessageArgumentFactory argumentFactory4,
        LogMessageArgumentFactory argumentFactory5)
    {
        if (exception is null && message is null) return;

        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argumentFactory1(),
            argumentFactory2(),
            argumentFactory3(),
            argumentFactory4(),
            argumentFactory5());

        PublishLog(loggerContext, new LogContext(name, level, time, message) { Exception = exception });
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, LogMessageFactory messageFactory,
        LogMessageArgumentFactory argumentFactory1,
        LogMessageArgumentFactory argumentFactory2,
        LogMessageArgumentFactory argumentFactory3,
        LogMessageArgumentFactory argumentFactory4,
        LogMessageArgumentFactory argumentFactory5)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var message = messageFactory();

        if (message is null) return;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argumentFactory1(),
            argumentFactory2(),
            argumentFactory3(),
            argumentFactory4(),
            argumentFactory5());

        PublishLog(loggerContext, new LogContext(name, level, time, message));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, LogMessageFactory messageFactory,
        LogMessageArgumentFactory argumentFactory1,
        LogMessageArgumentFactory argumentFactory2,
        LogMessageArgumentFactory argumentFactory3,
        LogMessageArgumentFactory argumentFactory4,
        LogMessageArgumentFactory argumentFactory5)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var message = messageFactory();

        if (exception is null && message is null) return;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argumentFactory1(),
            argumentFactory2(),
            argumentFactory3(),
            argumentFactory4(),
            argumentFactory5());

        PublishLog(loggerContext, new LogContext(name, level, time, message) { Exception = exception });
    }

    #endregion

    #region Log(T)

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log<T>(LogLevel level, string? message,
        T argument)
    {
        if (message is null) return;

        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument?.ToString());

        PublishLog(loggerContext, new LogContext(name, level, time, message));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log<T>(LogLevel level, Exception? exception, string? message,
        T argument)
    {
        if (exception is null && message is null) return;

        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument?.ToString());

        PublishLog(loggerContext, new LogContext(name, level, time, message) { Exception = exception });
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log<T>(LogLevel level, LogMessageFactory messageFactory,
        T argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var message = messageFactory();

        if (message is null) return;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument?.ToString());

        PublishLog(loggerContext, new LogContext(name, level, time, message));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log<T>(LogLevel level, Exception? exception, LogMessageFactory messageFactory,
        T argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var message = messageFactory();

        if (exception is null && message is null) return;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument?.ToString());

        PublishLog(loggerContext, new LogContext(name, level, time, message) { Exception = exception });
    }

    #endregion

    #region Log(T, T)

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log<T1, T2>(LogLevel level, string? message,
        T1 argument1,
        T2 argument2)
    {
        if (message is null) return;

        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument1?.ToString(),
            argument2?.ToString());

        PublishLog(loggerContext, new LogContext(name, level, time, message));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log<T1, T2>(LogLevel level, Exception? exception, string? message,
        T1 argument1,
        T2 argument2)
    {
        if (exception is null && message is null) return;

        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument1?.ToString(),
            argument2?.ToString());

        PublishLog(loggerContext, new LogContext(name, level, time, message) { Exception = exception });
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log<T1, T2>(LogLevel level, LogMessageFactory messageFactory,
        T1 argument1,
        T2 argument2)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var message = messageFactory();

        if (message is null) return;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument1?.ToString(),
            argument2?.ToString());

        PublishLog(loggerContext, new LogContext(name, level, time, message));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log<T1, T2>(LogLevel level, Exception? exception, LogMessageFactory messageFactory,
        T1 argument1,
        T2 argument2)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var message = messageFactory();

        if (exception is null && message is null) return;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument1?.ToString(),
            argument2?.ToString());

        PublishLog(loggerContext, new LogContext(name, level, time, message) { Exception = exception });
    }

    #endregion

    #region Log(T, T, T)

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log<T1, T2, T3>(LogLevel level, string? message,
        T1 argument1,
        T2 argument2,
        T3 argument3)
    {
        if (message is null) return;

        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument1?.ToString(),
            argument2?.ToString(),
            argument3?.ToString());

        PublishLog(loggerContext, new LogContext(name, level, time, message));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log<T1, T2, T3>(LogLevel level, Exception? exception, string? message,
        T1 argument1,
        T2 argument2,
        T3 argument3)
    {
        if (exception is null && message is null) return;

        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument1?.ToString(),
            argument2?.ToString(),
            argument3?.ToString());

        PublishLog(loggerContext, new LogContext(name, level, time, message) { Exception = exception });
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log<T1, T2, T3>(LogLevel level, LogMessageFactory messageFactory,
        T1 argument1,
        T2 argument2,
        T3 argument3)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var message = messageFactory();

        if (message is null) return;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument1?.ToString(),
            argument2?.ToString(),
            argument3?.ToString());

        PublishLog(loggerContext, new LogContext(name, level, time, message));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log<T1, T2, T3>(LogLevel level, Exception? exception, LogMessageFactory messageFactory,
        T1 argument1,
        T2 argument2,
        T3 argument3)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var message = messageFactory();

        if (exception is null && message is null) return;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument1?.ToString(),
            argument2?.ToString(),
            argument3?.ToString());

        PublishLog(loggerContext, new LogContext(name, level, time, message) { Exception = exception });
    }

    #endregion

    #region Log(T, T, T, T)

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log<T1, T2, T3, T4>(LogLevel level, string? message,
        T1 argument1,
        T2 argument2,
        T3 argument3,
        T4 argument4)
    {
        if (message is null) return;

        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument1?.ToString(),
            argument2?.ToString(),
            argument3?.ToString(),
            argument4?.ToString());

        PublishLog(loggerContext, new LogContext(name, level, time, message));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log<T1, T2, T3, T4>(LogLevel level, Exception? exception, string? message,
        T1 argument1,
        T2 argument2,
        T3 argument3,
        T4 argument4)
    {
        if (exception is null && message is null) return;

        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument1?.ToString(),
            argument2?.ToString(),
            argument3?.ToString(),
            argument4?.ToString());

        PublishLog(loggerContext, new LogContext(name, level, time, message) { Exception = exception });
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log<T1, T2, T3, T4>(LogLevel level, LogMessageFactory messageFactory,
        T1 argument1,
        T2 argument2,
        T3 argument3,
        T4 argument4)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var message = messageFactory();

        if (message is null) return;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument1?.ToString(),
            argument2?.ToString(),
            argument3?.ToString(),
            argument4?.ToString());

        PublishLog(loggerContext, new LogContext(name, level, time, message));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log<T1, T2, T3, T4>(LogLevel level, Exception? exception, LogMessageFactory messageFactory,
        T1 argument1,
        T2 argument2,
        T3 argument3,
        T4 argument4)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var message = messageFactory();

        if (exception is null && message is null) return;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument1?.ToString(),
            argument2?.ToString(),
            argument3?.ToString(),
            argument4?.ToString());

        PublishLog(loggerContext, new LogContext(name, level, time, message) { Exception = exception });
    }

    #endregion

    #region Log(T, T, T, T, T)

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log<T1, T2, T3, T4, T5>(LogLevel level, string? message,
        T1 argument1,
        T2 argument2,
        T3 argument3,
        T4 argument4,
        T5 argument5)
    {
        if (message is null) return;

        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument1?.ToString(),
            argument2?.ToString(),
            argument3?.ToString(),
            argument4?.ToString(),
            argument5?.ToString());

        PublishLog(loggerContext, new LogContext(name, level, time, message));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log<T1, T2, T3, T4, T5>(LogLevel level, Exception? exception, string? message,
        T1 argument1,
        T2 argument2,
        T3 argument3,
        T4 argument4,
        T5 argument5)
    {
        if (exception is null && message is null) return;

        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument1?.ToString(),
            argument2?.ToString(),
            argument3?.ToString(),
            argument4?.ToString(),
            argument5?.ToString());

        PublishLog(loggerContext, new LogContext(name, level, time, message) { Exception = exception });
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log<T1, T2, T3, T4, T5>(LogLevel level, LogMessageFactory messageFactory,
        T1 argument1,
        T2 argument2,
        T3 argument3,
        T4 argument4,
        T5 argument5)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var message = messageFactory();

        if (message is null) return;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument1?.ToString(),
            argument2?.ToString(),
            argument3?.ToString(),
            argument4?.ToString(),
            argument5?.ToString());

        PublishLog(loggerContext, new LogContext(name, level, time, message));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log<T1, T2, T3, T4, T5>(LogLevel level, Exception? exception, LogMessageFactory messageFactory,
        T1 argument1,
        T2 argument2,
        T3 argument3,
        T4 argument4,
        T5 argument5)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var message = messageFactory();

        if (exception is null && message is null) return;

        message = LogMessageArgumentsInterpolator.Interpolate(message,
            argument1?.ToString(),
            argument2?.ToString(),
            argument3?.ToString(),
            argument4?.ToString(),
            argument5?.ToString());

        PublishLog(loggerContext, new LogContext(name, level, time, message) { Exception = exception });
    }

    #endregion

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static void PublishLog(in LoggerContext loggerContext, in LogContext logContext)
    {
        var targets = loggerContext.Targets;

        var targetsLength = targets.Length;

        // ReSharper disable once ConvertIfStatementToSwitchStatement
        if (targetsLength > 1)
        {
            var cancellationToken = loggerContext.CancellationToken;

            ref var targetsRef = ref MemoryMarshal.GetArrayDataReference(targets);

            for (var targetIndex = 0; targetIndex < targetsLength; targetIndex++)
            {
                var target = Unsafe.Add(ref targetsRef, targetIndex);

                PublishLog(target, logContext, cancellationToken);
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
        catch (Exception exception)
        {
#if DEBUG
            DebugEventLogger.Notify(exception, "Error while publishing log");
#endif
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static bool CantLog(in LoggerContext loggerContext, LogLevel level)
    {
        return loggerContext.MinimumLevel >= level;
    }
}
