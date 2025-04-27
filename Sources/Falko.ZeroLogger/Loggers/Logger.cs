using System.Logging.Contexts;
using System.Logging.Debugs;
using System.Logging.Factories;
using System.Logging.Logs;
using System.Logging.Renderers;
using System.Logging.Runtimes;
using System.Logging.Targets;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Logging.Loggers;

[method: MethodImpl(MethodImplOptions.AggressiveInlining)]
public readonly partial struct Logger(string name)
{
    #region Log()

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, string? message)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        if (message is null) return;

        var time = DateTimeOffset.Now;

        var messageProvider = new SingleMessageLogMessageRenderer(message);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, string? message)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        if (exception is null && message is null) return;

        var time = DateTimeOffset.Now;

        var messageProvider = new SingleMessageLogMessageRenderer(message);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider)
        {
            Exception = exception
        });
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, LogMessageFactory messageFactory)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var messageProvider = new SingleMessageFactoryLogMessageRenderer(messageFactory);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, LogMessageFactory messageFactory)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var messageProvider = new SingleMessageFactoryLogMessageRenderer(messageFactory);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider)
        {
            Exception = exception
        });
    }

    #endregion

    #region Log(short)

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, string? message,
        short argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        if (message is null) return;

        var time = DateTimeOffset.Now;

        var messageProvider = ValueTypeArgumentMessageLogMessageProviderFactory.CreateMessageProvider(message, argument);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, string? message,
        short argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        if (exception is null && message is null) return;

        var time = DateTimeOffset.Now;

        var messageProvider = ValueTypeArgumentMessageLogMessageProviderFactory.CreateMessageProvider(message, argument);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider)
        {
            Exception = exception
        });
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, LogMessageFactory messageFactory,
        short argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var messageProvider = ValueTypeArgumentMessageLogMessageProviderFactory.CreateMessageProvider(messageFactory, argument);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, LogMessageFactory messageFactory,
        short argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var messageProvider = ValueTypeArgumentMessageLogMessageProviderFactory.CreateMessageProvider(messageFactory, argument);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider)
        {
            Exception = exception
        });
    }

    #endregion

    #region Log(ushort)

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, string? message,
        ushort argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        if (message is null) return;

        var time = DateTimeOffset.Now;

        var messageProvider = ValueTypeArgumentMessageLogMessageProviderFactory.CreateMessageProvider(message, argument);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, string? message,
        ushort argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        if (exception is null && message is null) return;

        var time = DateTimeOffset.Now;

        var messageProvider = ValueTypeArgumentMessageLogMessageProviderFactory.CreateMessageProvider(message, argument);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider)
        {
            Exception = exception
        });
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, LogMessageFactory messageFactory,
        ushort argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var messageProvider = ValueTypeArgumentMessageLogMessageProviderFactory.CreateMessageProvider(messageFactory, argument);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, LogMessageFactory messageFactory,
        ushort argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var messageProvider = ValueTypeArgumentMessageLogMessageProviderFactory.CreateMessageProvider(messageFactory, argument);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider)
        {
            Exception = exception
        });
    }

    #endregion

    #region Log(int)

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, string? message,
        int argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        if (message is null) return;

        var time = DateTimeOffset.Now;

        var messageProvider = ValueTypeArgumentMessageLogMessageProviderFactory.CreateMessageProvider(message, argument);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, string? message,
        int argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        if (exception is null && message is null) return;

        var time = DateTimeOffset.Now;

        var messageProvider = ValueTypeArgumentMessageLogMessageProviderFactory.CreateMessageProvider(message, argument);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider)
        {
            Exception = exception
        });
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, LogMessageFactory messageFactory,
        int argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var messageProvider = ValueTypeArgumentMessageLogMessageProviderFactory.CreateMessageProvider(messageFactory, argument);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, LogMessageFactory messageFactory,
        int argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var messageProvider = ValueTypeArgumentMessageLogMessageProviderFactory.CreateMessageProvider(messageFactory, argument);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider)
        {
            Exception = exception
        });
    }

    #endregion

    #region Log(nint)

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, string? message,
        nint argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        if (message is null) return;

        var time = DateTimeOffset.Now;

        var messageProvider = ValueTypeArgumentMessageLogMessageProviderFactory.CreateMessageProvider(message, argument);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, string? message,
        nint argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        if (exception is null && message is null) return;

        var time = DateTimeOffset.Now;

        var messageProvider = ValueTypeArgumentMessageLogMessageProviderFactory.CreateMessageProvider(message, argument);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider)
        {
            Exception = exception
        });
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, LogMessageFactory messageFactory,
        nint argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var messageProvider = ValueTypeArgumentMessageLogMessageProviderFactory.CreateMessageProvider(messageFactory, argument);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, LogMessageFactory messageFactory,
        nint argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var messageProvider = ValueTypeArgumentMessageLogMessageProviderFactory.CreateMessageProvider(messageFactory, argument);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider)
        {
            Exception = exception
        });
    }

    #endregion

    #region Log(uint)

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, string? message,
        uint argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        if (message is null) return;

        var time = DateTimeOffset.Now;

        var messageProvider = ValueTypeArgumentMessageLogMessageProviderFactory.CreateMessageProvider(message, argument);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, string? message,
        uint argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        if (exception is null && message is null) return;

        var time = DateTimeOffset.Now;

        var messageProvider = ValueTypeArgumentMessageLogMessageProviderFactory.CreateMessageProvider(message, argument);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider)
        {
            Exception = exception
        });
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, LogMessageFactory messageFactory,
        uint argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var messageProvider = ValueTypeArgumentMessageLogMessageProviderFactory.CreateMessageProvider(messageFactory, argument);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, LogMessageFactory messageFactory,
        uint argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var messageProvider = ValueTypeArgumentMessageLogMessageProviderFactory.CreateMessageProvider(messageFactory, argument);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider)
        {
            Exception = exception
        });
    }

    #endregion

    #region Log(nuint)

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, string? message,
        nuint argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        if (message is null) return;

        var time = DateTimeOffset.Now;

        var messageProvider = ValueTypeArgumentMessageLogMessageProviderFactory.CreateMessageProvider(message, argument);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, string? message,
        nuint argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        if (exception is null && message is null) return;

        var time = DateTimeOffset.Now;

        var messageProvider = ValueTypeArgumentMessageLogMessageProviderFactory.CreateMessageProvider(message, argument);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider)
        {
            Exception = exception
        });
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, LogMessageFactory messageFactory,
        nuint argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var messageProvider = ValueTypeArgumentMessageLogMessageProviderFactory.CreateMessageProvider(messageFactory, argument);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, LogMessageFactory messageFactory,
        nuint argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var messageProvider = ValueTypeArgumentMessageLogMessageProviderFactory.CreateMessageProvider(messageFactory, argument);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider)
        {
            Exception = exception
        });
    }

    #endregion

    #region Log(long)

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, string? message,
        long argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        if (message is null) return;

        var time = DateTimeOffset.Now;

        var messageProvider = ValueTypeArgumentMessageLogMessageProviderFactory.CreateMessageProvider(message, argument);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, string? message,
        long argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        if (exception is null && message is null) return;

        var time = DateTimeOffset.Now;

        var messageProvider = ValueTypeArgumentMessageLogMessageProviderFactory.CreateMessageProvider(message, argument);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider)
        {
            Exception = exception
        });
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, LogMessageFactory messageFactory,
        long argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var messageProvider = ValueTypeArgumentMessageLogMessageProviderFactory.CreateMessageProvider(messageFactory, argument);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, LogMessageFactory messageFactory,
        long argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var messageProvider = ValueTypeArgumentMessageLogMessageProviderFactory.CreateMessageProvider(messageFactory, argument);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider)
        {
            Exception = exception
        });
    }

    #endregion

    #region Log(ulong)

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, string? message,
        ulong argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        if (message is null) return;

        var time = DateTimeOffset.Now;

        var messageProvider = ValueTypeArgumentMessageLogMessageProviderFactory.CreateMessageProvider(message, argument);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, string? message,
        ulong argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        if (exception is null && message is null) return;

        var time = DateTimeOffset.Now;

        var messageProvider = ValueTypeArgumentMessageLogMessageProviderFactory.CreateMessageProvider(message, argument);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider)
        {
            Exception = exception
        });
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, LogMessageFactory messageFactory,
        ulong argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var messageProvider = ValueTypeArgumentMessageLogMessageProviderFactory.CreateMessageProvider(messageFactory, argument);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, LogMessageFactory messageFactory,
        ulong argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var messageProvider = ValueTypeArgumentMessageLogMessageProviderFactory.CreateMessageProvider(messageFactory, argument);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider)
        {
            Exception = exception
        });
    }

    #endregion

    #region Log(BigInteger)

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, string? message,
        BigInteger argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        if (message is null) return;

        var time = DateTimeOffset.Now;

        var messageProvider = ValueTypeArgumentMessageLogMessageProviderFactory.CreateMessageProvider(message, argument);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, string? message,
        BigInteger argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        if (exception is null && message is null) return;

        var time = DateTimeOffset.Now;

        var messageProvider = ValueTypeArgumentMessageLogMessageProviderFactory.CreateMessageProvider(message, argument);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider)
        {
            Exception = exception
        });
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, LogMessageFactory messageFactory,
        BigInteger argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var messageProvider = ValueTypeArgumentMessageLogMessageProviderFactory.CreateMessageProvider(messageFactory, argument);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, LogMessageFactory messageFactory,
        BigInteger argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var messageProvider = ValueTypeArgumentMessageLogMessageProviderFactory.CreateMessageProvider(messageFactory, argument);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider)
        {
            Exception = exception
        });
    }

    #endregion

    #region Log(float)

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, string? message,
        float argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        if (message is null) return;

        var time = DateTimeOffset.Now;

        var messageProvider = ValueTypeArgumentMessageLogMessageProviderFactory.CreateMessageProvider(message, argument);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, string? message,
        float argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        if (exception is null && message is null) return;

        var time = DateTimeOffset.Now;

        var messageProvider = ValueTypeArgumentMessageLogMessageProviderFactory.CreateMessageProvider(message, argument);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider)
        {
            Exception = exception
        });
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, LogMessageFactory messageFactory,
        float argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var messageProvider = ValueTypeArgumentMessageLogMessageProviderFactory.CreateMessageProvider(messageFactory, argument);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, LogMessageFactory messageFactory,
        float argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var messageProvider = ValueTypeArgumentMessageLogMessageProviderFactory.CreateMessageProvider(messageFactory, argument);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider)
        {
            Exception = exception
        });
    }

    #endregion

    #region Log(double)

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, string? message,
        double argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        if (message is null) return;

        var time = DateTimeOffset.Now;

        var messageProvider = ValueTypeArgumentMessageLogMessageProviderFactory.CreateMessageProvider(message, argument);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, string? message,
        double argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        if (exception is null && message is null) return;

        var time = DateTimeOffset.Now;

        var messageProvider = ValueTypeArgumentMessageLogMessageProviderFactory.CreateMessageProvider(message, argument);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider)
        {
            Exception = exception
        });
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, LogMessageFactory messageFactory,
        double argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var messageProvider = ValueTypeArgumentMessageLogMessageProviderFactory.CreateMessageProvider(messageFactory, argument);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, LogMessageFactory messageFactory,
        double argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var messageProvider = ValueTypeArgumentMessageLogMessageProviderFactory.CreateMessageProvider(messageFactory, argument);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider)
        {
            Exception = exception
        });
    }

    #endregion

    #region Log(decimal)

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, string? message,
        decimal argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        if (message is null) return;

        var time = DateTimeOffset.Now;

        var messageProvider = ValueTypeArgumentMessageLogMessageProviderFactory.CreateMessageProvider(message, argument);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, string? message,
        decimal argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        if (exception is null && message is null) return;

        var time = DateTimeOffset.Now;

        var messageProvider = ValueTypeArgumentMessageLogMessageProviderFactory.CreateMessageProvider(message, argument);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider)
        {
            Exception = exception
        });
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, LogMessageFactory messageFactory,
        decimal argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var messageProvider = ValueTypeArgumentMessageLogMessageProviderFactory.CreateMessageProvider(messageFactory, argument);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, LogMessageFactory messageFactory,
        decimal argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var messageProvider = ValueTypeArgumentMessageLogMessageProviderFactory.CreateMessageProvider(messageFactory, argument);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider)
        {
            Exception = exception
        });
    }

    #endregion

    #region Log(Guid)

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, string? message,
        Guid argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        if (message is null) return;

        var time = DateTimeOffset.Now;

        var messageProvider = ValueTypeArgumentMessageLogMessageProviderFactory.CreateMessageProvider(message, argument);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, string? message,
        Guid argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        if (exception is null && message is null) return;

        var time = DateTimeOffset.Now;

        var messageProvider = ValueTypeArgumentMessageLogMessageProviderFactory.CreateMessageProvider(message, argument);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider)
        {
            Exception = exception
        });
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, LogMessageFactory messageFactory,
        Guid argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var messageProvider = ValueTypeArgumentMessageLogMessageProviderFactory.CreateMessageProvider(messageFactory, argument);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, LogMessageFactory messageFactory,
        Guid argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var messageProvider = ValueTypeArgumentMessageLogMessageProviderFactory.CreateMessageProvider(messageFactory, argument);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider)
        {
            Exception = exception
        });
    }

    #endregion

    #region Log(TimeSpan)

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, string? message,
        TimeSpan argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        if (message is null) return;

        var time = DateTimeOffset.Now;

        var messageProvider = ValueTypeArgumentMessageLogMessageProviderFactory.CreateMessageProvider(message, argument);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, string? message,
        TimeSpan argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        if (exception is null && message is null) return;

        var time = DateTimeOffset.Now;

        var messageProvider = ValueTypeArgumentMessageLogMessageProviderFactory.CreateMessageProvider(message, argument);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider)
        {
            Exception = exception
        });
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, LogMessageFactory messageFactory,
        TimeSpan argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var messageProvider = ValueTypeArgumentMessageLogMessageProviderFactory.CreateMessageProvider(messageFactory, argument);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, LogMessageFactory messageFactory,
        TimeSpan argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var messageProvider = ValueTypeArgumentMessageLogMessageProviderFactory.CreateMessageProvider(messageFactory, argument);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider)
        {
            Exception = exception
        });
    }

    #endregion

    #region Log(TimeOnly)

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, string? message,
        TimeOnly argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        if (message is null) return;

        var time = DateTimeOffset.Now;

        var messageProvider = ValueTypeArgumentMessageLogMessageProviderFactory.CreateMessageProvider(message, argument);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, string? message,
        TimeOnly argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        if (exception is null && message is null) return;

        var time = DateTimeOffset.Now;

        var messageProvider = ValueTypeArgumentMessageLogMessageProviderFactory.CreateMessageProvider(message, argument);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider)
        {
            Exception = exception
        });
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, LogMessageFactory messageFactory,
        TimeOnly argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var messageProvider = ValueTypeArgumentMessageLogMessageProviderFactory.CreateMessageProvider(messageFactory, argument);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, LogMessageFactory messageFactory,
        TimeOnly argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var messageProvider = ValueTypeArgumentMessageLogMessageProviderFactory.CreateMessageProvider(messageFactory, argument);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider)
        {
            Exception = exception
        });
    }

    #endregion

    #region Log(DateTime)

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, string? message,
        DateTime argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        if (message is null) return;

        var time = DateTimeOffset.Now;

        var messageProvider = ValueTypeArgumentMessageLogMessageProviderFactory.CreateMessageProvider(message, argument);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, string? message,
        DateTime argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        if (exception is null && message is null) return;

        var time = DateTimeOffset.Now;

        var messageProvider = ValueTypeArgumentMessageLogMessageProviderFactory.CreateMessageProvider(message, argument);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider)
        {
            Exception = exception
        });
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, LogMessageFactory messageFactory,
        DateTime argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var messageProvider = ValueTypeArgumentMessageLogMessageProviderFactory.CreateMessageProvider(messageFactory, argument);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, LogMessageFactory messageFactory,
        DateTime argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var messageProvider = ValueTypeArgumentMessageLogMessageProviderFactory.CreateMessageProvider(messageFactory, argument);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider)
        {
            Exception = exception
        });
    }

    #endregion

    #region Log(DateTimeOffset)

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, string? message,
        DateTimeOffset argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        if (message is null) return;

        var time = DateTimeOffset.Now;

        var messageProvider = ValueTypeArgumentMessageLogMessageProviderFactory.CreateMessageProvider(message, argument);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, string? message,
        DateTimeOffset argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        if (exception is null && message is null) return;

        var time = DateTimeOffset.Now;

        var messageProvider = ValueTypeArgumentMessageLogMessageProviderFactory.CreateMessageProvider(message, argument);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider)
        {
            Exception = exception
        });
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, LogMessageFactory messageFactory,
        DateTimeOffset argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var messageProvider = ValueTypeArgumentMessageLogMessageProviderFactory.CreateMessageProvider(messageFactory, argument);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, LogMessageFactory messageFactory,
        DateTimeOffset argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var messageProvider = ValueTypeArgumentMessageLogMessageProviderFactory.CreateMessageProvider(messageFactory, argument);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider)
        {
            Exception = exception
        });
    }

    #endregion

    #region Log(DateOnly)

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, string? message,
        DateOnly argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        if (message is null) return;

        var time = DateTimeOffset.Now;

        var messageProvider = ValueTypeArgumentMessageLogMessageProviderFactory.CreateMessageProvider(message, argument);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, string? message,
        DateOnly argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        if (exception is null && message is null) return;

        var time = DateTimeOffset.Now;

        var messageProvider = ValueTypeArgumentMessageLogMessageProviderFactory.CreateMessageProvider(message, argument);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider)
        {
            Exception = exception
        });
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, LogMessageFactory messageFactory,
        DateOnly argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var messageProvider = ValueTypeArgumentMessageLogMessageProviderFactory.CreateMessageProvider(messageFactory, argument);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, LogMessageFactory messageFactory,
        DateOnly argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var messageProvider = ValueTypeArgumentMessageLogMessageProviderFactory.CreateMessageProvider(messageFactory, argument);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider)
        {
            Exception = exception
        });
    }

    #endregion

    #region Log(byte)

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, string? message,
        byte argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        if (message is null) return;

        var time = DateTimeOffset.Now;

        var messageProvider = ValueTypeArgumentMessageLogMessageProviderFactory.CreateMessageProvider(message, argument);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, string? message,
        byte argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        if (exception is null && message is null) return;

        var time = DateTimeOffset.Now;

        var messageProvider = ValueTypeArgumentMessageLogMessageProviderFactory.CreateMessageProvider(message, argument);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider)
        {
            Exception = exception
        });
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, LogMessageFactory messageFactory,
        byte argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var messageProvider = ValueTypeArgumentMessageLogMessageProviderFactory.CreateMessageProvider(messageFactory, argument);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, LogMessageFactory messageFactory,
        byte argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var messageProvider = ValueTypeArgumentMessageLogMessageProviderFactory.CreateMessageProvider(messageFactory, argument);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider)
        {
            Exception = exception
        });
    }

    #endregion

    #region Log(sbyte)

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, string? message,
        sbyte argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        if (message is null) return;

        var time = DateTimeOffset.Now;

        var messageProvider = ValueTypeArgumentMessageLogMessageProviderFactory.CreateMessageProvider(message, argument);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, string? message,
        sbyte argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        if (exception is null && message is null) return;

        var time = DateTimeOffset.Now;

        var messageProvider = ValueTypeArgumentMessageLogMessageProviderFactory.CreateMessageProvider(message, argument);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider)
        {
            Exception = exception
        });
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, LogMessageFactory messageFactory,
        sbyte argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var messageProvider = ValueTypeArgumentMessageLogMessageProviderFactory.CreateMessageProvider(messageFactory, argument);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, LogMessageFactory messageFactory,
        sbyte argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var messageProvider = ValueTypeArgumentMessageLogMessageProviderFactory.CreateMessageProvider(messageFactory, argument);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider)
        {
            Exception = exception
        });
    }

    #endregion

    #region Log(char)

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, string? message,
        char argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        if (message is null) return;

        var time = DateTimeOffset.Now;

        var messageProvider = ValueTypeArgumentMessageLogMessageProviderFactory.CreateMessageProvider(message, argument);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, string? message,
        char argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        if (exception is null && message is null) return;

        var time = DateTimeOffset.Now;

        var messageProvider = ValueTypeArgumentMessageLogMessageProviderFactory.CreateMessageProvider(message, argument);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider)
        {
            Exception = exception
        });
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, LogMessageFactory messageFactory,
        char argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var messageProvider = ValueTypeArgumentMessageLogMessageProviderFactory.CreateMessageProvider(messageFactory, argument);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, LogMessageFactory messageFactory,
        char argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var messageProvider = ValueTypeArgumentMessageLogMessageProviderFactory.CreateMessageProvider(messageFactory, argument);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider)
        {
            Exception = exception
        });
    }

    #endregion

    #region Log(string)

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, string? message,
        string? argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        if (message is null) return;

        var time = DateTimeOffset.Now;

        var messageProvider = new SingleStringArgumentMessageLogMessageRenderer(message,
            argument);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, string? message,
        string? argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        if (exception is null && message is null) return;

        var time = DateTimeOffset.Now;

        var messageProvider = new SingleStringArgumentMessageLogMessageRenderer(message,
            argument);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider)
        {
            Exception = exception
        });
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, LogMessageFactory messageFactory,
        string? argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var messageProvider = new SingleStringArgumentMessageFactoryLogMessageRenderer(messageFactory,
            argument);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, LogMessageFactory messageFactory,
        string? argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var messageProvider = new SingleStringArgumentMessageFactoryLogMessageRenderer(messageFactory,
            argument);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider)
        {
            Exception = exception
        });
    }

    #endregion

    #region Log(string, string)

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, string? message,
        string? argument1,
        string? argument2)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        if (message is null) return;

        var time = DateTimeOffset.Now;

        var messageProvider = new TwoStringArgumentsMessageLogMessageRenderer(message,
            argument1,
            argument2);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, string? message,
        string? argument1,
        string? argument2)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        if (exception is null && message is null) return;

        var time = DateTimeOffset.Now;

        var messageProvider = new TwoStringArgumentsMessageLogMessageRenderer(message,
            argument1,
            argument2);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider)
        {
            Exception = exception
        });
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, LogMessageFactory messageFactory,
        string? argument1,
        string? argument2)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var messageProvider = new TwoStringArgumentsMessageFactoryLogMessageRenderer(messageFactory,
            argument1,
            argument2);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, LogMessageFactory messageFactory,
        string? argument1,
        string? argument2)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var messageProvider = new TwoStringArgumentsMessageFactoryLogMessageRenderer(messageFactory,
            argument1,
            argument2);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider)
        {
            Exception = exception
        });
    }

    #endregion

    #region Log(string, string, string)

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, string? message,
        string? argument1,
        string? argument2,
        string? argument3)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        if (message is null) return;

        var time = DateTimeOffset.Now;

        var messageProvider = new ThreeStringArgumentsMessageLogMessageRenderer(message,
            argument1,
            argument2,
            argument3);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, string? message,
        string? argument1,
        string? argument2,
        string? argument3)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        if (exception is null && message is null) return;

        var time = DateTimeOffset.Now;

        var messageProvider = new ThreeStringArgumentsMessageLogMessageRenderer(message,
            argument1,
            argument2,
            argument3);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider)
        {
            Exception = exception
        });
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

        var messageProvider = new ThreeStringArgumentsMessageFactoryLogMessageRenderer(messageFactory,
            argument1,
            argument2,
            argument3);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider));
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

        var messageProvider = new ThreeStringArgumentsMessageFactoryLogMessageRenderer(messageFactory,
            argument1,
            argument2,
            argument3);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider)
        {
            Exception = exception
        });
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
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        if (message is null) return;

        var time = DateTimeOffset.Now;

        var messageProvider = new FourStringArgumentsMessageLogMessageRenderer(message,
            argument1,
            argument2,
            argument3,
            argument4);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, string? message,
        string? argument1,
        string? argument2,
        string? argument3,
        string? argument4)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        if (exception is null && message is null) return;

        var time = DateTimeOffset.Now;

        var messageProvider = new FourStringArgumentsMessageLogMessageRenderer(message,
            argument1,
            argument2,
            argument3,
            argument4);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider)
        {
            Exception = exception
        });
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

        var messageProvider = new FourStringArgumentsMessageFactoryLogMessageRenderer(messageFactory,
            argument1,
            argument2,
            argument3,
            argument4);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider));
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

        var messageProvider = new FourStringArgumentsMessageFactoryLogMessageRenderer(messageFactory,
            argument1,
            argument2,
            argument3,
            argument4);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider)
        {
            Exception = exception
        });
    }

    #endregion

    #region Log(string...)

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, string? message,
        params string?[] arguments)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        if (message is null) return;

        var time = DateTimeOffset.Now;

        var messageProvider = new ManyStringArgumentsMessageLogMessageRenderer(message,
            arguments);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, string? message,
        params string?[] arguments)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        if (exception is null && message is null) return;

        var time = DateTimeOffset.Now;

        var messageProvider = new ManyStringArgumentsMessageLogMessageRenderer(message,
            arguments);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider)
        {
            Exception = exception
        });
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, LogMessageFactory messageFactory,
        params string?[] arguments)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var messageProvider = new ManyStringArgumentsMessageFactoryLogMessageRenderer(messageFactory,
            arguments);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, LogMessageFactory messageFactory,
        params string?[] arguments)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var messageProvider = new ManyStringArgumentsMessageFactoryLogMessageRenderer(messageFactory,
            arguments);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider)
        {
            Exception = exception
        });
    }

    #endregion

    #region Log(T)

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log<T>(LogLevel level, string? message,
        T argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        if (message is null) return;

        var time = DateTimeOffset.Now;

        var messageProvider = new SingleInstanceArgumentMessageLogMessageRenderer<T>(message, argument);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log<T>(LogLevel level, Exception? exception, string? message,
        T argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        if (exception is null && message is null) return;

        var time = DateTimeOffset.Now;

        var messageProvider = new SingleInstanceArgumentMessageLogMessageRenderer<T>(message, argument);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider)
        {
            Exception = exception
        });
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log<T>(LogLevel level, LogMessageFactory messageFactory,
        T argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var messageProvider = new SingleInstanceArgumentMessageFactoryLogMessageRenderer<T>(messageFactory, argument);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log<T>(LogLevel level, Exception? exception, LogMessageFactory messageFactory,
        T argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var messageProvider = new SingleInstanceArgumentMessageFactoryLogMessageRenderer<T>(messageFactory, argument);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider) { Exception = exception });
    }

    #endregion

    #region Log(T, T)

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log<T1, T2>(LogLevel level, string? message,
        T1 argument1,
        T2 argument2)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        if (message is null) return;

        var time = DateTimeOffset.Now;

        var messageProvider = new TwoInstanceArgumentsMessageLogMessageRenderer<T1, T2>(message,
            argument1,
            argument2);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log<T1, T2>(LogLevel level, Exception? exception, string? message,
        T1 argument1,
        T2 argument2)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        if (exception is null && message is null) return;

        var time = DateTimeOffset.Now;

        var messageProvider = new TwoInstanceArgumentsMessageLogMessageRenderer<T1, T2>(message,
            argument1,
            argument2);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider)
        {
            Exception = exception
        });
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log<T1, T2>(LogLevel level, LogMessageFactory messageFactory,
        T1 argument1,
        T2 argument2)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var messageProvider = new TwoInstanceArgumentsMessageFactoryLogMessageRenderer<T1, T2>(messageFactory,
            argument1,
            argument2);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log<T1, T2>(LogLevel level, Exception? exception, LogMessageFactory messageFactory,
        T1 argument1,
        T2 argument2)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var messageProvider = new TwoInstanceArgumentsMessageFactoryLogMessageRenderer<T1, T2>(messageFactory,
            argument1,
            argument2);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider)
        {
            Exception = exception
        });
    }

    #endregion

    #region Log(T, T, T)

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log<T1, T2, T3>(LogLevel level, string? message,
        T1 argument1,
        T2 argument2,
        T3 argument3)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        if (message is null) return;

        var time = DateTimeOffset.Now;

        var messageProvider = new ThreeInstanceArgumentsMessageLogMessageRenderer<T1, T2, T3>(message,
            argument1,
            argument2,
            argument3);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log<T1, T2, T3>(LogLevel level, Exception? exception, string? message,
        T1 argument1,
        T2 argument2,
        T3 argument3)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        if (exception is null && message is null) return;

        var time = DateTimeOffset.Now;

        var messageProvider = new ThreeInstanceArgumentsMessageLogMessageRenderer<T1, T2, T3>(message,
            argument1,
            argument2,
            argument3);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider)
        {
            Exception = exception
        });
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

        var messageProvider = new ThreeInstanceArgumentsMessageFactoryLogMessageRenderer<T1, T2, T3>(messageFactory,
            argument1,
            argument2,
            argument3);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider));
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

        var messageProvider = new ThreeInstanceArgumentsMessageFactoryLogMessageRenderer<T1, T2, T3>(messageFactory,
            argument1,
            argument2,
            argument3);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider)
        {
            Exception = exception
        });
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
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        if (message is null) return;

        var time = DateTimeOffset.Now;

        var messageProvider = new FourInstanceArgumentsMessageLogMessageRenderer<T1, T2, T3, T4>(message,
            argument1,
            argument2,
            argument3,
            argument4);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log<T1, T2, T3, T4>(LogLevel level, Exception? exception, string? message,
        T1 argument1,
        T2 argument2,
        T3 argument3,
        T4 argument4)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        if (exception is null && message is null) return;

        var time = DateTimeOffset.Now;

        var messageProvider = new FourInstanceArgumentsMessageLogMessageRenderer<T1, T2, T3, T4>(message,
            argument1,
            argument2,
            argument3,
            argument4);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider)
        {
            Exception = exception
        });
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

        var messageProvider = new FourInstanceArgumentsMessageFactoryLogMessageRenderer<T1, T2, T3, T4>(messageFactory,
            argument1,
            argument2,
            argument3,
            argument4);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider));
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

        var messageProvider = new FourInstanceArgumentsMessageFactoryLogMessageRenderer<T1, T2, T3, T4>(messageFactory,
            argument1,
            argument2,
            argument3,
            argument4);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider)
        {
            Exception = exception
        });
    }

    #endregion

    #region Log(object...)

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, string? message,
        params object?[] arguments)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        if (message is null) return;

        var time = DateTimeOffset.Now;

        var messageProvider = new ManyInstanceArgumentsMessageLogMessageRenderer(message,
            arguments);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, string? message,
        params object?[] arguments)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        if (exception is null && message is null) return;

        var time = DateTimeOffset.Now;

        var messageProvider = new ManyInstanceArgumentsMessageLogMessageRenderer(message,
            arguments);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider)
        {
            Exception = exception
        });
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, LogMessageFactory messageFactory,
        params object?[] arguments)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var messageProvider = new ManyInstanceArgumentsMessageFactoryLogMessageRenderer(messageFactory,
            arguments);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, LogMessageFactory messageFactory,
        params object?[] arguments)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var messageProvider = new ManyInstanceArgumentsMessageFactoryLogMessageRenderer(messageFactory,
            arguments);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider)
        {
            Exception = exception
        });
    }

    #endregion

    #region Log(LogMessageArgument)

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log<T>(LogLevel level, string? message,
        LogMessageArgument<T> argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        if (message is null) return;

        var time = DateTimeOffset.Now;

        var messageProvider = new SingleArgumentMessageLogMessageRenderer<T>(message,
            argument);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log<T>(LogLevel level, Exception? exception, string? message,
        LogMessageArgument<T> argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        if (exception is null && message is null) return;

        var time = DateTimeOffset.Now;

        var messageProvider = new SingleArgumentMessageLogMessageRenderer<T>(message,
            argument);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider)
        {
            Exception = exception
        });
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log<T>(LogLevel level, LogMessageFactory messageFactory,
        LogMessageArgument<T> argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var messageProvider = new SingleArgumentMessageFactoryLogMessageRenderer<T>(messageFactory,
            argument);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log<T>(LogLevel level, Exception? exception, LogMessageFactory messageFactory,
        LogMessageArgument<T> argument)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var messageProvider = new SingleArgumentMessageFactoryLogMessageRenderer<T>(messageFactory,
            argument);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider)
        {
            Exception = exception
        });
    }

    #endregion

    #region Log(LogMessageArgument, LogMessageArgument)

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log<T1, T2>(LogLevel level, string? message,
        LogMessageArgument<T1> argument1,
        LogMessageArgument<T2> argument2)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        if (message is null) return;

        var time = DateTimeOffset.Now;

        var messageProvider = new TwoArgumentsMessageLogMessageRenderer<T1, T2>(message,
            argument1,
            argument2);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log<T1, T2>(LogLevel level, Exception? exception, string? message,
        LogMessageArgument<T1> argument1,
        LogMessageArgument<T2> argument2)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        if (exception is null && message is null) return;

        var time = DateTimeOffset.Now;

        var messageProvider = new TwoArgumentsMessageLogMessageRenderer<T1, T2>(message,
            argument1,
            argument2);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider)
        {
            Exception = exception
        });
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log<T1, T2>(LogLevel level, LogMessageFactory messageFactory,
        LogMessageArgument<T1> argument1,
        LogMessageArgument<T2> argument2)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var messageProvider = new TwoArgumentsMessageFactoryLogMessageRenderer<T1, T2>(messageFactory,
            argument1,
            argument2);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log<T1, T2>(LogLevel level, Exception? exception, LogMessageFactory messageFactory,
        LogMessageArgument<T1> argument1,
        LogMessageArgument<T2> argument2)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var messageProvider = new TwoArgumentsMessageFactoryLogMessageRenderer<T1, T2>(messageFactory,
            argument1,
            argument2);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider)
        {
            Exception = exception
        });
    }

    #endregion

    #region Log(LogMessageArgument, LogMessageArgument, LogMessageArgument)

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log<T1, T2, T3>(LogLevel level, string? message,
        LogMessageArgument<T1> argument1,
        LogMessageArgument<T2> argument2,
        LogMessageArgument<T3> argument3)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        if (message is null) return;

        var time = DateTimeOffset.Now;

        var messageProvider = new ThreeArgumentsMessageLogMessageRenderer<T1, T2, T3>(message,
            argument1,
            argument2,
            argument3);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log<T1, T2, T3>(LogLevel level, Exception? exception, string? message,
        LogMessageArgument<T1> argument1,
        LogMessageArgument<T2> argument2,
        LogMessageArgument<T3> argument3)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        if (exception is null && message is null) return;

        var time = DateTimeOffset.Now;

        var messageProvider = new ThreeArgumentsMessageLogMessageRenderer<T1, T2, T3>(message,
            argument1,
            argument2,
            argument3);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider)
        {
            Exception = exception
        });
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log<T1, T2, T3>(LogLevel level, LogMessageFactory messageFactory,
        LogMessageArgument<T1> argument1,
        LogMessageArgument<T2> argument2,
        LogMessageArgument<T3> argument3)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var messageProvider = new ThreeArgumentsMessageFactoryLogMessageRenderer<T1, T2, T3>(messageFactory,
            argument1,
            argument2,
            argument3);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log<T1, T2, T3>(LogLevel level, Exception? exception, LogMessageFactory messageFactory,
        LogMessageArgument<T1> argument1,
        LogMessageArgument<T2> argument2,
        LogMessageArgument<T3> argument3)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var messageProvider = new ThreeArgumentsMessageFactoryLogMessageRenderer<T1, T2, T3>(messageFactory,
            argument1,
            argument2,
            argument3);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider)
        {
            Exception = exception
        });
    }

    #endregion

    #region Log(LogMessageArgument, LogMessageArgument, LogMessageArgument, LogMessageArgument)

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log<T1, T2, T3, T4>(LogLevel level, string? message,
        LogMessageArgument<T1> argument1,
        LogMessageArgument<T2> argument2,
        LogMessageArgument<T3> argument3,
        LogMessageArgument<T4> argument4)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        if (message is null) return;

        var time = DateTimeOffset.Now;

        var messageProvider = new FourArgumentsMessageLogMessageRenderer<T1, T2, T3, T4>(message,
            argument1,
            argument2,
            argument3,
            argument4);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log<T1, T2, T3, T4>(LogLevel level, Exception? exception, string? message,
        LogMessageArgument<T1> argument1,
        LogMessageArgument<T2> argument2,
        LogMessageArgument<T3> argument3,
        LogMessageArgument<T4> argument4)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        if (exception is null && message is null) return;

        var time = DateTimeOffset.Now;

        var messageProvider = new FourArgumentsMessageLogMessageRenderer<T1, T2, T3, T4>(message,
            argument1,
            argument2,
            argument3,
            argument4);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider)
        {
            Exception = exception
        });
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log<T1, T2, T3, T4>(LogLevel level, LogMessageFactory messageFactory,
        LogMessageArgument<T1> argument1,
        LogMessageArgument<T2> argument2,
        LogMessageArgument<T3> argument3,
        LogMessageArgument<T4> argument4)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var messageProvider = new FourArgumentsMessageFactoryLogMessageRenderer<T1, T2, T3, T4>(messageFactory,
            argument1,
            argument2,
            argument3,
            argument4);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log<T1, T2, T3, T4>(LogLevel level, Exception? exception, LogMessageFactory messageFactory,
        LogMessageArgument<T1> argument1,
        LogMessageArgument<T2> argument2,
        LogMessageArgument<T3> argument3,
        LogMessageArgument<T4> argument4)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var messageProvider = new FourArgumentsMessageFactoryLogMessageRenderer<T1, T2, T3, T4>(messageFactory,
            argument1,
            argument2,
            argument3,
            argument4);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider)
        {
            Exception = exception
        });
    }

    #endregion

    #region Log(LogMessageArgumentFactory)

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, string? message,
        LogMessageArgumentFactory argumentFactory)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        if (message is null) return;

        var time = DateTimeOffset.Now;

        var messageProvider = new SingleFactoryArgumentMessageLogMessageRenderer(message,
            argumentFactory);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, string? message,
        LogMessageArgumentFactory argumentFactory)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        if (exception is null && message is null) return;

        var time = DateTimeOffset.Now;

        var messageProvider = new SingleFactoryArgumentMessageLogMessageRenderer(message,
            argumentFactory);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider)
        {
            Exception = exception
        });
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, LogMessageFactory messageFactory,
        LogMessageArgumentFactory argumentFactory)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var messageProvider = new SingleFactoryArgumentMessageFactoryLogMessageRenderer(messageFactory,
            argumentFactory);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, LogMessageFactory messageFactory,
        LogMessageArgumentFactory argumentFactory)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var messageProvider = new SingleFactoryArgumentMessageFactoryLogMessageRenderer(messageFactory,
            argumentFactory);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider)
        {
            Exception = exception
        });
    }

    #endregion

    #region Log(LogMessageArgumentFactory, LogMessageArgumentFactory)

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, string? message,
        LogMessageArgumentFactory argumentFactory1,
        LogMessageArgumentFactory argumentFactory2)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        if (message is null) return;

        var time = DateTimeOffset.Now;

        var messageProvider = new TwoFactoryArgumentsMessageLogMessageRenderer(message,
            argumentFactory1,
            argumentFactory2);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, string? message,
        LogMessageArgumentFactory argumentFactory1,
        LogMessageArgumentFactory argumentFactory2)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        if (exception is null && message is null) return;

        var time = DateTimeOffset.Now;

        var messageProvider = new TwoFactoryArgumentsMessageLogMessageRenderer(message,
            argumentFactory1,
            argumentFactory2);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider)
        {
            Exception = exception
        });
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, LogMessageFactory messageFactory,
        LogMessageArgumentFactory argumentFactory1,
        LogMessageArgumentFactory argumentFactory2)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var messageProvider = new TwoFactoryArgumentsMessageFactoryLogMessageRenderer(messageFactory,
            argumentFactory1,
            argumentFactory2);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, LogMessageFactory messageFactory,
        LogMessageArgumentFactory argumentFactory1,
        LogMessageArgumentFactory argumentFactory2)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var messageProvider = new TwoFactoryArgumentsMessageFactoryLogMessageRenderer(messageFactory,
            argumentFactory1,
            argumentFactory2);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider)
        {
            Exception = exception
        });
    }

    #endregion

    #region Log(LogMessageArgumentFactory, LogMessageArgumentFactory, LogMessageArgumentFactory)

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, string? message,
        LogMessageArgumentFactory argumentFactory1,
        LogMessageArgumentFactory argumentFactory2,
        LogMessageArgumentFactory argumentFactory3)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        if (message is null) return;

        var time = DateTimeOffset.Now;

        var messageProvider = new ThreeFactoryArgumentsMessageLogMessageRenderer(message,
            argumentFactory1,
            argumentFactory2,
            argumentFactory3);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, string? message,
        LogMessageArgumentFactory argumentFactory1,
        LogMessageArgumentFactory argumentFactory2,
        LogMessageArgumentFactory argumentFactory3)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        if (exception is null && message is null) return;

        var time = DateTimeOffset.Now;

        var messageProvider = new ThreeFactoryArgumentsMessageLogMessageRenderer(message,
            argumentFactory1,
            argumentFactory2,
            argumentFactory3);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider)
        {
            Exception = exception
        });
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

        var messageProvider = new ThreeFactoryArgumentsMessageFactoryLogMessageRenderer(messageFactory,
            argumentFactory1,
            argumentFactory2,
            argumentFactory3);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider));
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

        var messageProvider = new ThreeFactoryArgumentsMessageFactoryLogMessageRenderer(messageFactory,
            argumentFactory1,
            argumentFactory2,
            argumentFactory3);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider)
        {
            Exception = exception
        });
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
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        if (message is null) return;

        var time = DateTimeOffset.Now;

        var messageProvider = new FourFactoryArgumentsMessageLogMessageRenderer(message,
            argumentFactory1,
            argumentFactory2,
            argumentFactory3,
            argumentFactory4);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, string? message,
        LogMessageArgumentFactory argumentFactory1,
        LogMessageArgumentFactory argumentFactory2,
        LogMessageArgumentFactory argumentFactory3,
        LogMessageArgumentFactory argumentFactory4)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        if (exception is null && message is null) return;

        var time = DateTimeOffset.Now;

        var messageProvider = new FourFactoryArgumentsMessageLogMessageRenderer(message,
            argumentFactory1,
            argumentFactory2,
            argumentFactory3,
            argumentFactory4);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider)
        {
            Exception = exception
        });
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

        var messageProvider = new FourFactoryArgumentsMessageFactoryLogMessageRenderer(messageFactory,
            argumentFactory1,
            argumentFactory2,
            argumentFactory3,
            argumentFactory4);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider));
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

        var messageProvider = new FourFactoryArgumentsMessageFactoryLogMessageRenderer(messageFactory,
            argumentFactory1,
            argumentFactory2,
            argumentFactory3,
            argumentFactory4);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider)
        {
            Exception = exception
        });
    }

    #endregion

    #region Log(LogMessageArgumentFactory...)

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, string? message,
        params LogMessageArgumentFactory[] argumentFactories)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        if (message is null) return;

        var time = DateTimeOffset.Now;

        var messageProvider = new ManyFactoryArgumentsMessageLogMessageRenderer(message,
            argumentFactories);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, string? message,
        params LogMessageArgumentFactory[] argumentFactories)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        if (exception is null && message is null) return;

        var time = DateTimeOffset.Now;

        var messageProvider = new ManyFactoryArgumentsMessageLogMessageRenderer(message,
            argumentFactories);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider)
        {
            Exception = exception
        });
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, LogMessageFactory messageFactory,
        params LogMessageArgumentFactory[] argumentFactories)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var messageProvider = new ManyFactoryArgumentsMessageFactoryLogMessageRenderer(messageFactory,
            argumentFactories);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void Log(LogLevel level, Exception? exception, LogMessageFactory messageFactory,
        params LogMessageArgumentFactory[] argumentFactories)
    {
        var loggerContext = LoggerRuntime.Context;

        if (CantLog(loggerContext, level)) return;

        var time = DateTimeOffset.Now;

        var messageProvider = new ManyFactoryArgumentsMessageFactoryLogMessageRenderer(messageFactory,
            argumentFactories);

        PublishLog(loggerContext, new LogContext(name, level, time, messageProvider)
        {
            Exception = exception
        });
    }

    #endregion

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void PublishLog(in LoggerContext loggerContext, in LogContext logContext)
    {
        var targets = loggerContext.Targets;
        var interpolators = loggerContext.Renderers;

        var targetsLength = targets.Length;

        // ReSharper disable once ConvertIfStatementToSwitchStatement
        if (targetsLength > 1)
        {
            var cancellationToken = loggerContext.CancellationToken;

            ref var targetsRef = ref MemoryMarshal.GetArrayDataReference(targets);

            var interpolatorsLength = interpolators.Length;

            if (interpolatorsLength > 1)
            {
                ref var interpolatorsRef = ref MemoryMarshal.GetArrayDataReference(loggerContext.Renderers);

                var targetIndex = 0;

                for (var interpolatorIndex = 0; interpolatorIndex < interpolatorsLength; interpolatorIndex++)
                {
                    var logInterpolatorSpan = Unsafe.Add(ref interpolatorsRef, interpolatorIndex);
                    var logInterpolatorSpanLength = logInterpolatorSpan.Count;

                    if (logInterpolatorSpanLength is 1)
                    {
                        var target = Unsafe.Add(ref targetsRef, targetIndex);

                        ++targetIndex;

                        PublishLog(target, logContext, logInterpolatorSpan.Renderer, cancellationToken);

                        continue;
                    }

                    var logInterpolator = new PersistentLogContextRenderer(logInterpolatorSpan.Renderer);

                    for (var i = 0; i < logInterpolatorSpanLength; i++)
                    {
                        var target = Unsafe.Add(ref targetsRef, targetIndex);

                        ++targetIndex;

                        PublishLog(target, logContext, logInterpolator, cancellationToken);
                    }
                }
            }
            else
            {
                var logInterpolator = new PersistentLogContextRenderer(interpolators[0].Renderer);

                for (var targetIndex = 0; targetIndex < targetsLength; targetIndex++)
                {
                    var target = Unsafe.Add(ref targetsRef, targetIndex);

                    PublishLog(target, logContext, logInterpolator, cancellationToken);
                }
            }
        }
        else if (targetsLength is 1)
        {
            PublishLog(targets[0], logContext, interpolators[0].Renderer, loggerContext.CancellationToken);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static void PublishLog(in LoggerTarget target, in LogContext logContext, ILogContextRenderer logContextRenderer, CancellationToken cancellationToken)
    {
        try
        {
            target.Publish(logContext, logContextRenderer, cancellationToken);
        }
        catch (Exception exception)
        {
            DebugEventLogger.Handle("Error while publishing log", exception);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static bool CantLog(in LoggerContext loggerContext, LogLevel level)
    {
        return loggerContext.MinimumLevel > level;
    }
}
