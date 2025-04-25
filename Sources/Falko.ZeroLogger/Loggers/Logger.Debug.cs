using System.ComponentModel;
using System.Logging.Factories;
using System.Logging.Logs;
using System.Numerics;
using JetBrains.Annotations;

namespace System.Logging.Loggers;

public readonly partial struct Logger
{
    #region Log()

    public void Debug([Localizable(false)][StructuredMessageTemplate] string? message)
    {
        Log(LogLevel.Debug, message);
    }

    public void Debug(Exception? exception, [Localizable(false)][StructuredMessageTemplate] string? message)
    {
        Log(LogLevel.Debug, exception, message);
    }

    public void Debug(LogMessageFactory messageFactory)
    {
        Log(LogLevel.Debug, messageFactory);
    }

    public void Debug(Exception? exception, LogMessageFactory messageFactory)
    {
        Log(LogLevel.Debug, exception, messageFactory);
    }

    #endregion

    #region Log(short)

    public void Debug([Localizable(false)][StructuredMessageTemplate] string? message,
        short argument)
    {
        Log(LogLevel.Debug, message,
            argument);
    }

    public void Debug(Exception? exception, [Localizable(false)][StructuredMessageTemplate] string? message,
        short argument)
    {
        Log(LogLevel.Debug, exception, message,
            argument);
    }

    public void Debug(LogMessageFactory messageFactory,
        short argument)
    {
        Log(LogLevel.Debug, messageFactory,
            argument);
    }

    public void Debug(Exception? exception, LogMessageFactory messageFactory,
        short argument)
    {
        Log(LogLevel.Debug, exception, messageFactory,
            argument);
    }

    #endregion

    #region Log(ushort)

    public void Debug([Localizable(false)][StructuredMessageTemplate] string? message,
        ushort argument)
    {
        Log(LogLevel.Debug, message,
            argument);
    }

    public void Debug(Exception? exception, [Localizable(false)][StructuredMessageTemplate] string? message,
        ushort argument)
    {
        Log(LogLevel.Debug, exception, message,
            argument);
    }

    public void Debug(LogMessageFactory messageFactory,
        ushort argument)
    {
        Log(LogLevel.Debug, messageFactory,
            argument);
    }

    public void Debug(Exception? exception, LogMessageFactory messageFactory,
        ushort argument)
    {
        Log(LogLevel.Debug, exception, messageFactory,
            argument);
    }

    #endregion

    #region Log(int)

    public void Debug([Localizable(false)][StructuredMessageTemplate] string? message,
        int argument)
    {
        Log(LogLevel.Debug, message,
            argument);
    }

    public void Debug(Exception? exception, [Localizable(false)][StructuredMessageTemplate] string? message,
        int argument)
    {
        Log(LogLevel.Debug, exception, message,
            argument);
    }

    public void Debug(LogMessageFactory messageFactory,
        int argument)
    {
        Log(LogLevel.Debug, messageFactory,
            argument);
    }

    public void Debug(Exception? exception, LogMessageFactory messageFactory,
        int argument)
    {
        Log(LogLevel.Debug, exception, messageFactory,
            argument);
    }

    #endregion

    #region Log(nint)

    public void Debug([Localizable(false)][StructuredMessageTemplate] string? message,
        nint argument)
    {
        Log(LogLevel.Debug, message,
            argument);
    }

    public void Debug(Exception? exception, [Localizable(false)][StructuredMessageTemplate] string? message,
        nint argument)
    {
        Log(LogLevel.Debug, exception, message,
            argument);
    }

    public void Debug(LogMessageFactory messageFactory,
        nint argument)
    {
        Log(LogLevel.Debug, messageFactory,
            argument);
    }

    public void Debug(Exception? exception, LogMessageFactory messageFactory,
        nint argument)
    {
        Log(LogLevel.Debug, exception, messageFactory,
            argument);
    }

    #endregion

    #region Log(uint)

    public void Debug([Localizable(false)][StructuredMessageTemplate] string? message,
        uint argument)
    {
        Log(LogLevel.Debug, message,
            argument);
    }

    public void Debug(Exception? exception, [Localizable(false)][StructuredMessageTemplate] string? message,
        uint argument)
    {
        Log(LogLevel.Debug, exception, message,
            argument);
    }

    public void Debug(LogMessageFactory messageFactory,
        uint argument)
    {
        Log(LogLevel.Debug, messageFactory,
            argument);
    }

    public void Debug(Exception? exception, LogMessageFactory messageFactory,
        uint argument)
    {
        Log(LogLevel.Debug, exception, messageFactory,
            argument);
    }

    #endregion

    #region Log(nuint)

    public void Debug([Localizable(false)][StructuredMessageTemplate] string? message,
        nuint argument)
    {
        Log(LogLevel.Debug, message,
            argument);
    }

    public void Debug(Exception? exception, [Localizable(false)][StructuredMessageTemplate] string? message,
        nuint argument)
    {
        Log(LogLevel.Debug, exception, message,
            argument);
    }

    public void Debug(LogMessageFactory messageFactory,
        nuint argument)
    {
        Log(LogLevel.Debug, messageFactory,
            argument);
    }

    public void Debug(Exception? exception, LogMessageFactory messageFactory,
        nuint argument)
    {
        Log(LogLevel.Debug, exception, messageFactory,
            argument);
    }

    #endregion

    #region Log(long)

    public void Debug([Localizable(false)][StructuredMessageTemplate] string? message,
        long argument)
    {
        Log(LogLevel.Debug, message,
            argument);
    }

    public void Debug(Exception? exception, [Localizable(false)][StructuredMessageTemplate] string? message,
        long argument)
    {
        Log(LogLevel.Debug, exception, message,
            argument);
    }

    public void Debug(LogMessageFactory messageFactory,
        long argument)
    {
        Log(LogLevel.Debug, messageFactory,
            argument);
    }

    public void Debug(Exception? exception, LogMessageFactory messageFactory,
        long argument)
    {
        Log(LogLevel.Debug, exception, messageFactory,
            argument);
    }

    #endregion

    #region Log(ulong)

    public void Debug([Localizable(false)][StructuredMessageTemplate] string? message,
        ulong argument)
    {
        Log(LogLevel.Debug, message,
            argument);
    }

    public void Debug(Exception? exception, [Localizable(false)][StructuredMessageTemplate] string? message,
        ulong argument)
    {
        Log(LogLevel.Debug, exception, message,
            argument);
    }

    public void Debug(LogMessageFactory messageFactory,
        ulong argument)
    {
        Log(LogLevel.Debug, messageFactory,
            argument);
    }

    public void Debug(Exception? exception, LogMessageFactory messageFactory,
        ulong argument)
    {
        Log(LogLevel.Debug, exception, messageFactory,
            argument);
    }

    #endregion

    #region Log(BigInteger)

    public void Debug([Localizable(false)][StructuredMessageTemplate] string? message,
        BigInteger argument)
    {
        Log(LogLevel.Debug, message,
            argument);
    }

    public void Debug(Exception? exception, [Localizable(false)][StructuredMessageTemplate] string? message,
        BigInteger argument)
    {
        Log(LogLevel.Debug, exception, message,
            argument);
    }

    public void Debug(LogMessageFactory messageFactory,
        BigInteger argument)
    {
        Log(LogLevel.Debug, messageFactory,
            argument);
    }

    public void Debug(Exception? exception, LogMessageFactory messageFactory,
        BigInteger argument)
    {
        Log(LogLevel.Debug, exception, messageFactory,
            argument);
    }

    #endregion

    #region Log(float)

    public void Debug([Localizable(false)][StructuredMessageTemplate] string? message,
        float argument)
    {
        Log(LogLevel.Debug, message,
            argument);
    }

    public void Debug(Exception? exception, [Localizable(false)][StructuredMessageTemplate] string? message,
        float argument)
    {
        Log(LogLevel.Debug, exception, message,
            argument);
    }

    public void Debug(LogMessageFactory messageFactory,
        float argument)
    {
        Log(LogLevel.Debug, messageFactory,
            argument);
    }

    public void Debug(Exception? exception, LogMessageFactory messageFactory,
        float argument)
    {
        Log(LogLevel.Debug, exception, messageFactory,
            argument);
    }

    #endregion

    #region Log(double)

    public void Debug([Localizable(false)][StructuredMessageTemplate] string? message,
        double argument)
    {
        Log(LogLevel.Debug, message,
            argument);
    }

    public void Debug(Exception? exception, [Localizable(false)][StructuredMessageTemplate] string? message,
        double argument)
    {
        Log(LogLevel.Debug, exception, message,
            argument);
    }

    public void Debug(LogMessageFactory messageFactory,
        double argument)
    {
        Log(LogLevel.Debug, messageFactory,
            argument);
    }

    public void Debug(Exception? exception, LogMessageFactory messageFactory,
        double argument)
    {
        Log(LogLevel.Debug, exception, messageFactory,
            argument);
    }

    #endregion

    #region Log(decimal)

    public void Debug([Localizable(false)][StructuredMessageTemplate] string? message,
        decimal argument)
    {
        Log(LogLevel.Debug, message,
            argument);
    }

    public void Debug(Exception? exception, [Localizable(false)][StructuredMessageTemplate] string? message,
        decimal argument)
    {
        Log(LogLevel.Debug, exception, message,
            argument);
    }

    public void Debug(LogMessageFactory messageFactory,
        decimal argument)
    {
        Log(LogLevel.Debug, messageFactory,
            argument);
    }

    public void Debug(Exception? exception, LogMessageFactory messageFactory,
        decimal argument)
    {
        Log(LogLevel.Debug, exception, messageFactory,
            argument);
    }

    #endregion

    #region Log(Guid)

    public void Debug([Localizable(false)][StructuredMessageTemplate] string? message,
        Guid argument)
    {
        Log(LogLevel.Debug, message,
            argument);
    }

    public void Debug(Exception? exception, [Localizable(false)][StructuredMessageTemplate] string? message,
        Guid argument)
    {
        Log(LogLevel.Debug, exception, message,
            argument);
    }

    public void Debug(LogMessageFactory messageFactory,
        Guid argument)
    {
        Log(LogLevel.Debug, messageFactory,
            argument);
    }

    public void Debug(Exception? exception, LogMessageFactory messageFactory,
        Guid argument)
    {
        Log(LogLevel.Debug, exception, messageFactory,
            argument);
    }

    #endregion

    #region Log(TimeSpan)

    public void Debug([Localizable(false)][StructuredMessageTemplate] string? message,
        TimeSpan argument)
    {
        Log(LogLevel.Debug, message,
            argument);
    }

    public void Debug(Exception? exception, [Localizable(false)][StructuredMessageTemplate] string? message,
        TimeSpan argument)
    {
        Log(LogLevel.Debug, exception, message,
            argument);
    }

    public void Debug(LogMessageFactory messageFactory,
        TimeSpan argument)
    {
        Log(LogLevel.Debug, messageFactory,
            argument);
    }

    public void Debug(Exception? exception, LogMessageFactory messageFactory,
        TimeSpan argument)
    {
        Log(LogLevel.Debug, exception, messageFactory,
            argument);
    }

    #endregion

    #region Log(TimeOnly)

    public void Debug([Localizable(false)][StructuredMessageTemplate] string? message,
        TimeOnly argument)
    {
        Log(LogLevel.Debug, message,
            argument);
    }

    public void Debug(Exception? exception, [Localizable(false)][StructuredMessageTemplate] string? message,
        TimeOnly argument)
    {
        Log(LogLevel.Debug, exception, message,
            argument);
    }

    public void Debug(LogMessageFactory messageFactory,
        TimeOnly argument)
    {
        Log(LogLevel.Debug, messageFactory,
            argument);
    }

    public void Debug(Exception? exception, LogMessageFactory messageFactory,
        TimeOnly argument)
    {
        Log(LogLevel.Debug, exception, messageFactory,
            argument);
    }

    #endregion

    #region Log(DateTime)

    public void Debug([Localizable(false)][StructuredMessageTemplate] string? message,
        DateTime argument)
    {
        Log(LogLevel.Debug, message,
            argument);
    }

    public void Debug(Exception? exception, [Localizable(false)][StructuredMessageTemplate] string? message,
        DateTime argument)
    {
        Log(LogLevel.Debug, exception, message,
            argument);
    }

    public void Debug(LogMessageFactory messageFactory,
        DateTime argument)
    {
        Log(LogLevel.Debug, messageFactory,
            argument);
    }

    public void Debug(Exception? exception, LogMessageFactory messageFactory,
        DateTime argument)
    {
        Log(LogLevel.Debug, exception, messageFactory,
            argument);
    }

    #endregion

    #region Log(DateTimeOffset)

    public void Debug([Localizable(false)][StructuredMessageTemplate] string? message,
        DateTimeOffset argument)
    {
        Log(LogLevel.Debug, message,
            argument);
    }

    public void Debug(Exception? exception, [Localizable(false)][StructuredMessageTemplate] string? message,
        DateTimeOffset argument)
    {
        Log(LogLevel.Debug, exception, message,
            argument);
    }

    public void Debug(LogMessageFactory messageFactory,
        DateTimeOffset argument)
    {
        Log(LogLevel.Debug, messageFactory,
            argument);
    }

    public void Debug(Exception? exception, LogMessageFactory messageFactory,
        DateTimeOffset argument)
    {
        Log(LogLevel.Debug, exception, messageFactory,
            argument);
    }

    #endregion

    #region Log(DateOnly)

    public void Debug([Localizable(false)][StructuredMessageTemplate] string? message,
        DateOnly argument)
    {
        Log(LogLevel.Debug, message,
            argument);
    }

    public void Debug(Exception? exception, [Localizable(false)][StructuredMessageTemplate] string? message,
        DateOnly argument)
    {
        Log(LogLevel.Debug, exception, message,
            argument);
    }

    public void Debug(LogMessageFactory messageFactory,
        DateOnly argument)
    {
        Log(LogLevel.Debug, messageFactory,
            argument);
    }

    public void Debug(Exception? exception, LogMessageFactory messageFactory,
        DateOnly argument)
    {
        Log(LogLevel.Debug, exception, messageFactory,
            argument);
    }

    #endregion

    #region Log(byte)

    public void Debug([Localizable(false)][StructuredMessageTemplate] string? message,
        byte argument)
    {
        Log(LogLevel.Debug, message,
            argument);
    }

    public void Debug(Exception? exception, [Localizable(false)][StructuredMessageTemplate] string? message,
        byte argument)
    {
        Log(LogLevel.Debug, exception, message,
            argument);
    }

    public void Debug(LogMessageFactory messageFactory,
        byte argument)
    {
        Log(LogLevel.Debug, messageFactory,
            argument);
    }

    public void Debug(Exception? exception, LogMessageFactory messageFactory,
        byte argument)
    {
        Log(LogLevel.Debug, exception, messageFactory,
            argument);
    }

    #endregion

    #region Log(sbyte)

    public void Debug([Localizable(false)][StructuredMessageTemplate] string? message,
        sbyte argument)
    {
        Log(LogLevel.Debug, message,
            argument);
    }

    public void Debug(Exception? exception, [Localizable(false)][StructuredMessageTemplate] string? message,
        sbyte argument)
    {
        Log(LogLevel.Debug, exception, message,
            argument);
    }

    public void Debug(LogMessageFactory messageFactory,
        sbyte argument)
    {
        Log(LogLevel.Debug, messageFactory,
            argument);
    }

    public void Debug(Exception? exception, LogMessageFactory messageFactory,
        sbyte argument)
    {
        Log(LogLevel.Debug, exception, messageFactory,
            argument);
    }

    #endregion

    #region Log(char)

    public void Debug([Localizable(false)][StructuredMessageTemplate] string? message,
        char argument)
    {
        Log(LogLevel.Debug, message,
            argument);
    }

    public void Debug(Exception? exception, [Localizable(false)][StructuredMessageTemplate] string? message,
        char argument)
    {
        Log(LogLevel.Debug, exception, message,
            argument);
    }

    public void Debug(LogMessageFactory messageFactory,
        char argument)
    {
        Log(LogLevel.Debug, messageFactory,
            argument);
    }

    public void Debug(Exception? exception, LogMessageFactory messageFactory,
        char argument)
    {
        Log(LogLevel.Debug, exception, messageFactory,
            argument);
    }

    #endregion

    #region Log(string)

    public void Debug([Localizable(false)][StructuredMessageTemplate] string? message,
        string? argument)
    {
        Log(LogLevel.Debug, message,
            argument);
    }

    public void Debug(Exception? exception, [Localizable(false)][StructuredMessageTemplate] string? message,
        string? argument)
    {
        Log(LogLevel.Debug, exception, message,
            argument);
    }

    public void Debug(LogMessageFactory messageFactory,
        string? argument)
    {
        Log(LogLevel.Debug, messageFactory,
            argument);
    }

    public void Debug(Exception? exception, LogMessageFactory messageFactory,
        string? argument)
    {
        Log(LogLevel.Debug, exception, messageFactory,
            argument);
    }

    #endregion

    #region Log(string, string)

    public void Debug([Localizable(false)][StructuredMessageTemplate] string? message,
        string? argument1,
        string? argument2)
    {
        Log(LogLevel.Debug, message,
            argument1,
            argument2);
    }

    public void Debug(Exception? exception, [Localizable(false)][StructuredMessageTemplate] string? message,
        string? argument1,
        string? argument2)
    {
        Log(LogLevel.Debug, exception, message,
            argument1,
            argument2);
    }

    public void Debug(LogMessageFactory message,
        string? argument1,
        string? argument2)
    {
        Log(LogLevel.Debug, message,
            argument1,
            argument2);
    }

    public void Debug(Exception? exception, LogMessageFactory message,
        string? argument1,
        string? argument2)
    {
        Log(LogLevel.Debug, exception, message,
            argument1,
            argument2);
    }

    #endregion

    #region Log(string, string, string)

    public void Debug([Localizable(false)][StructuredMessageTemplate] string? message,
        string? argument1,
        string? argument2,
        string? argument3)
    {
        Log(LogLevel.Debug, message,
            argument1,
            argument2,
            argument3);
    }

    public void Debug(Exception? exception, [Localizable(false)][StructuredMessageTemplate] string? message,
        string? argument1,
        string? argument2,
        string? argument3)
    {
        Log(LogLevel.Debug, exception, message,
            argument1,
            argument2,
            argument3);
    }

    public void Debug(LogMessageFactory message,
        string? argument1,
        string? argument2,
        string? argument3)
    {
        Log(LogLevel.Debug, message,
            argument1,
            argument2,
            argument3);
    }

    public void Debug(Exception? exception, LogMessageFactory message,
        string? argument1,
        string? argument2,
        string? argument3)
    {
        Log(LogLevel.Debug, exception, message,
            argument1,
            argument2,
            argument3);
    }

    #endregion

    #region Log(string, string, string, string)

    public void Debug([Localizable(false)][StructuredMessageTemplate] string? message,
        string? argument1,
        string? argument2,
        string? argument3,
        string? argument4)
    {
        Log(LogLevel.Debug, message,
            argument1,
            argument2,
            argument3,
            argument4);
    }

    public void Debug(Exception? exception, [Localizable(false)][StructuredMessageTemplate] string? message,
        string? argument1,
        string? argument2,
        string? argument3,
        string? argument4)
    {
        Log(LogLevel.Debug, exception, message,
            argument1,
            argument2,
            argument3,
            argument4);
    }

    public void Debug(LogMessageFactory message,
        string? argument1,
        string? argument2,
        string? argument3,
        string? argument4)
    {
        Log(LogLevel.Debug, message,
            argument1,
            argument2,
            argument3,
            argument4);
    }

    public void Debug(Exception? exception, LogMessageFactory message,
        string? argument1,
        string? argument2,
        string? argument3,
        string? argument4)
    {
        Log(LogLevel.Debug, exception, message,
            argument1,
            argument2,
            argument3,
            argument4);
    }

    #endregion

    #region Log(string...)

    public void Debug([Localizable(false)][StructuredMessageTemplate] string? message,
        params string?[] arguments)
    {
        Log(LogLevel.Debug, message,
            arguments);
    }

    public void Debug(Exception? exception, [Localizable(false)][StructuredMessageTemplate] string? message,
        params string?[] arguments)
    {
        Log(LogLevel.Debug, exception, message,
            arguments);
    }

    public void Debug(LogMessageFactory message,
        params string?[] arguments)
    {
        Log(LogLevel.Debug, message,
            arguments);
    }

    public void Debug(Exception? exception, LogMessageFactory message,
        params string?[] arguments)
    {
        Log(LogLevel.Debug, exception, message,
            arguments);
    }

    #endregion

    #region Log(T)

    public void Debug<T>([Localizable(false)][StructuredMessageTemplate] string? message,
        T argument)
    {
        Log(LogLevel.Debug, message,
            argument);
    }

    public void Debug<T>(Exception? exception, [Localizable(false)][StructuredMessageTemplate] string? message,
        T argument)
    {
        Log(LogLevel.Debug, exception, message,
            argument);
    }

    public void Debug<T>(LogMessageFactory messageFactory,
        T argument)
    {
        Log(LogLevel.Debug, messageFactory,
            argument);
    }

    public void Debug<T>(Exception? exception, LogMessageFactory messageFactory,
        T argument)
    {
        Log(LogLevel.Debug, exception, messageFactory,
            argument);
    }

    #endregion

    #region Log(T, T)

    public void Debug<T1, T2>([Localizable(false)][StructuredMessageTemplate] string? message,
        T1 argument1,
        T2 argument2)
    {
        Log(LogLevel.Debug, message,
            argument1,
            argument2);
    }

    public void Debug<T1, T2>(Exception? exception, [Localizable(false)][StructuredMessageTemplate] string? message,
        T1 argument1,
        T2 argument2)
    {
        Log(LogLevel.Debug, exception, message,
            argument1,
            argument2);
    }

    public void Debug<T1, T2>(LogMessageFactory message,
        T1 argument1,
        T2 argument2)
    {
        Log(LogLevel.Debug, message,
            argument1,
            argument2);
    }

    public void Debug<T1, T2>(Exception? exception, LogMessageFactory message,
        T1 argument1,
        T2 argument2)
    {
        Log(LogLevel.Debug, exception, message,
            argument1,
            argument2);
    }

    #endregion

    #region Log(T, T, T)

    public void Debug<T1, T2, T3>([Localizable(false)][StructuredMessageTemplate] string? message,
        T1 argument1,
        T2 argument2,
        T3 argument3)
    {
        Log(LogLevel.Debug, message,
            argument1,
            argument2,
            argument3);
    }

    public void Debug<T1, T2, T3>(Exception? exception, [Localizable(false)][StructuredMessageTemplate] string? message,
        T1 argument1,
        T2 argument2,
        T3 argument3)
    {
        Log(LogLevel.Debug, exception, message,
            argument1,
            argument2,
            argument3);
    }

    public void Debug<T1, T2, T3>(LogMessageFactory message,
        T1 argument1,
        T2 argument2,
        T3 argument3)
    {
        Log(LogLevel.Debug, message,
            argument1,
            argument2,
            argument3);
    }

    public void Debug<T1, T2, T3>(Exception? exception, LogMessageFactory message,
        T1 argument1,
        T2 argument2,
        T3 argument3)
    {
        Log(LogLevel.Debug, exception, message,
            argument1,
            argument2,
            argument3);
    }

    #endregion

    #region Log(T, T, T, T)

    public void Debug<T1, T2, T3, T4>([Localizable(false)][StructuredMessageTemplate] string? message,
        T1 argument1,
        T2 argument2,
        T3 argument3,
        T4 argument4)
    {
        Log(LogLevel.Debug, message,
            argument1,
            argument2,
            argument3,
            argument4);
    }

    public void Debug<T1, T2, T3, T4>(Exception? exception, [Localizable(false)][StructuredMessageTemplate] string? message,
        T1 argument1,
        T2 argument2,
        T3 argument3,
        T4 argument4)
    {
        Log(LogLevel.Debug, exception, message,
            argument1,
            argument2,
            argument3,
            argument4);
    }

    public void Debug<T1, T2, T3, T4>(LogMessageFactory message,
        T1 argument1,
        T2 argument2,
        T3 argument3,
        T4 argument4)
    {
        Log(LogLevel.Debug, message,
            argument1,
            argument2,
            argument3,
            argument4);
    }

    public void Debug<T1, T2, T3, T4>(Exception? exception, LogMessageFactory message,
        T1 argument1,
        T2 argument2,
        T3 argument3,
        T4 argument4)
    {
        Log(LogLevel.Debug, exception, message,
            argument1,
            argument2,
            argument3,
            argument4);
    }

    #endregion

    #region Log(object...)

    public void Debug([Localizable(false)][StructuredMessageTemplate] string? message,
        params object?[] arguments)
    {
        Log(LogLevel.Debug, message,
            arguments);
    }

    public void Debug(Exception? exception, [Localizable(false)][StructuredMessageTemplate] string? message,
        params object?[] arguments)
    {
        Log(LogLevel.Debug, exception, message,
            arguments);
    }

    public void Debug(LogMessageFactory message,
        params object?[] arguments)
    {
        Log(LogLevel.Debug, message,
            arguments);
    }

    public void Debug(Exception? exception, LogMessageFactory message,
        params object?[] arguments)
    {
        Log(LogLevel.Debug, exception, message,
            arguments);
    }

    #endregion

    #region Log(LogMessageArgument)

    public void Debug<T>([Localizable(false)][StructuredMessageTemplate] string? message,
        LogMessageArgument<T> argument)
    {
        Log(LogLevel.Debug, message,
            argument);
    }

    public void Debug<T>(Exception? exception, [Localizable(false)][StructuredMessageTemplate] string? message,
        LogMessageArgument<T> argument)
    {
        Log(LogLevel.Debug, exception, message,
            argument);
    }

    public void Debug<T>(LogMessageFactory messageFactory,
        LogMessageArgument<T> argument)
    {
        Log(LogLevel.Debug, messageFactory,
            argument);
    }

    public void Debug<T>(Exception? exception, LogMessageFactory messageFactory,
        LogMessageArgument<T> argument)
    {
        Log(LogLevel.Debug, exception, messageFactory,
            argument);
    }

    #endregion

    #region Log(LogMessageArgument, LogMessageArgument)

    public void Debug<T1, T2>([Localizable(false)][StructuredMessageTemplate] string? message,
        LogMessageArgument<T1> argument1,
        LogMessageArgument<T2> argument2)
    {
        Log(LogLevel.Debug, message,
            argument1,
            argument2);
    }

    public void Debug<T1, T2>(Exception? exception, [Localizable(false)][StructuredMessageTemplate] string? message,
        LogMessageArgument<T1> argument1,
        LogMessageArgument<T2> argument2)
    {
        Log(LogLevel.Debug, exception, message,
            argument1,
            argument2);
    }

    public void Debug<T1, T2>(LogMessageFactory message,
        LogMessageArgument<T1> argument1,
        LogMessageArgument<T2> argument2)
    {
        Log(LogLevel.Debug, message,
            argument1,
            argument2);
    }

    public void Debug<T1, T2>(Exception? exception, LogMessageFactory message,
        LogMessageArgument<T1> argument1,
        LogMessageArgument<T2> argument2)
    {
        Log(LogLevel.Debug, exception, message,
            argument1,
            argument2);
    }

    #endregion

    #region Log(LogMessageArgument, LogMessageArgument, LogMessageArgument)

    public void Debug<T1, T2, T3>([Localizable(false)][StructuredMessageTemplate] string? message,
        LogMessageArgument<T1> argument1,
        LogMessageArgument<T2> argument2,
        LogMessageArgument<T3> argument3)
    {
        Log(LogLevel.Debug, message,
            argument1,
            argument2,
            argument3);
    }

    public void Debug<T1, T2, T3>(Exception? exception, [Localizable(false)][StructuredMessageTemplate] string? message,
        LogMessageArgument<T1> argument1,
        LogMessageArgument<T2> argument2,
        LogMessageArgument<T3> argument3)
    {
        Log(LogLevel.Debug, exception, message,
            argument1,
            argument2,
            argument3);
    }

    public void Debug<T1, T2, T3>(LogMessageFactory message,
        LogMessageArgument<T1> argument1,
        LogMessageArgument<T2> argument2,
        LogMessageArgument<T3> argument3)
    {
        Log(LogLevel.Debug, message,
            argument1,
            argument2,
            argument3);
    }

    public void Debug<T1, T2, T3>(Exception? exception, LogMessageFactory message,
        LogMessageArgument<T1> argument1,
        LogMessageArgument<T2> argument2,
        LogMessageArgument<T3> argument3)
    {
        Log(LogLevel.Debug, exception, message,
            argument1,
            argument2,
            argument3);
    }

    #endregion

    #region Log(LogMessageArgument, LogMessageArgument, LogMessageArgument, LogMessageArgument)

    public void Debug<T1, T2, T3, T4>([Localizable(false)][StructuredMessageTemplate] string? message,
        LogMessageArgument<T1> argument1,
        LogMessageArgument<T2> argument2,
        LogMessageArgument<T3> argument3,
        LogMessageArgument<T4> argument4)
    {
        Log(LogLevel.Debug, message,
            argument1,
            argument2,
            argument3,
            argument4);
    }

    public void Debug<T1, T2, T3, T4>(Exception? exception, [Localizable(false)][StructuredMessageTemplate] string? message,
        LogMessageArgument<T1> argument1,
        LogMessageArgument<T2> argument2,
        LogMessageArgument<T3> argument3,
        LogMessageArgument<T4> argument4)
    {
        Log(LogLevel.Debug, exception, message,
            argument1,
            argument2,
            argument3,
            argument4);
    }

    public void Debug<T1, T2, T3, T4>(LogMessageFactory message,
        LogMessageArgument<T1> argument1,
        LogMessageArgument<T2> argument2,
        LogMessageArgument<T3> argument3,
        LogMessageArgument<T4> argument4)
    {
        Log(LogLevel.Debug, message,
            argument1,
            argument2,
            argument3,
            argument4);
    }

    public void Debug<T1, T2, T3, T4>(Exception? exception, LogMessageFactory message,
        LogMessageArgument<T1> argument1,
        LogMessageArgument<T2> argument2,
        LogMessageArgument<T3> argument3,
        LogMessageArgument<T4> argument4)
    {
        Log(LogLevel.Debug, exception, message,
            argument1,
            argument2,
            argument3,
            argument4);
    }

    #endregion

    #region Log(LogMessageArgumentFactory)

    public void Debug([Localizable(false)][StructuredMessageTemplate] string? message,
        LogMessageArgumentFactory argumentFactory)
    {
        Log(LogLevel.Debug, message,
            argumentFactory);
    }

    public void Debug(Exception? exception, [Localizable(false)][StructuredMessageTemplate] string? message,
        LogMessageArgumentFactory argumentFactory)
    {
        Log(LogLevel.Debug, exception, message,
            argumentFactory);
    }

    public void Debug(LogMessageFactory messageFactory,
        LogMessageArgumentFactory argumentFactory)
    {
        Log(LogLevel.Debug, messageFactory,
            argumentFactory);
    }

    public void Debug(Exception? exception, LogMessageFactory messageFactory,
        LogMessageArgumentFactory argumentFactory)
    {
        Log(LogLevel.Debug, exception, messageFactory,
            argumentFactory);
    }

    #endregion

    #region Log(LogMessageArgumentFactory, LogMessageArgumentFactory)

    public void Debug([Localizable(false)][StructuredMessageTemplate] string? message,
        LogMessageArgumentFactory argumentFactory1,
        LogMessageArgumentFactory argumentFactory2)
    {
        Log(LogLevel.Debug, message,
            argumentFactory1,
            argumentFactory2);
    }

    public void Debug(Exception? exception, [Localizable(false)][StructuredMessageTemplate] string? message,
        LogMessageArgumentFactory argumentFactory1,
        LogMessageArgumentFactory argumentFactory2)
    {
        Log(LogLevel.Debug, exception, message,
            argumentFactory1,
            argumentFactory2);
    }

    public void Debug(LogMessageFactory message,
        LogMessageArgumentFactory argumentFactory1,
        LogMessageArgumentFactory argumentFactory2)
    {
        Log(LogLevel.Debug, message,
            argumentFactory1,
            argumentFactory2);
    }

    public void Debug(Exception? exception, LogMessageFactory message,
        LogMessageArgumentFactory argumentFactory1,
        LogMessageArgumentFactory argumentFactory2)
    {
        Log(LogLevel.Debug, exception, message,
            argumentFactory1,
            argumentFactory2);
    }

    #endregion

    #region Log(LogMessageArgumentFactory, LogMessageArgumentFactory, LogMessageArgumentFactory)

    public void Debug([Localizable(false)][StructuredMessageTemplate] string? message,
        LogMessageArgumentFactory argumentFactory1,
        LogMessageArgumentFactory argumentFactory2,
        LogMessageArgumentFactory argumentFactory3)
    {
        Log(LogLevel.Debug, message,
            argumentFactory1,
            argumentFactory2,
            argumentFactory3);
    }

    public void Debug(Exception? exception, [Localizable(false)][StructuredMessageTemplate] string? message,
        LogMessageArgumentFactory argumentFactory1,
        LogMessageArgumentFactory argumentFactory2,
        LogMessageArgumentFactory argumentFactory3)
    {
        Log(LogLevel.Debug, exception, message,
            argumentFactory1,
            argumentFactory2,
            argumentFactory3);
    }

    public void Debug(LogMessageFactory message,
        LogMessageArgumentFactory argumentFactory1,
        LogMessageArgumentFactory argumentFactory2,
        LogMessageArgumentFactory argumentFactory3)
    {
        Log(LogLevel.Debug, message,
            argumentFactory1,
            argumentFactory2,
            argumentFactory3);
    }

    public void Debug(Exception? exception, LogMessageFactory message,
        LogMessageArgumentFactory argumentFactory1,
        LogMessageArgumentFactory argumentFactory2,
        LogMessageArgumentFactory argumentFactory3)
    {
        Log(LogLevel.Debug, exception, message,
            argumentFactory1,
            argumentFactory2,
            argumentFactory3);
    }

    #endregion

    #region Log(LogMessageArgumentFactory, LogMessageArgumentFactory, LogMessageArgumentFactory, LogMessageArgumentFactory)

    public void Debug([Localizable(false)][StructuredMessageTemplate] string? message,
        LogMessageArgumentFactory argumentFactory1,
        LogMessageArgumentFactory argumentFactory2,
        LogMessageArgumentFactory argumentFactory3,
        LogMessageArgumentFactory argumentFactory4)
    {
        Log(LogLevel.Debug, message,
            argumentFactory1,
            argumentFactory2,
            argumentFactory3,
            argumentFactory4);
    }

    public void Debug(Exception? exception, [Localizable(false)][StructuredMessageTemplate] string? message,
        LogMessageArgumentFactory argumentFactory1,
        LogMessageArgumentFactory argumentFactory2,
        LogMessageArgumentFactory argumentFactory3,
        LogMessageArgumentFactory argumentFactory4)
    {
        Log(LogLevel.Debug, exception, message,
            argumentFactory1,
            argumentFactory2,
            argumentFactory3,
            argumentFactory4);
    }

    public void Debug(LogMessageFactory message,
        LogMessageArgumentFactory argumentFactory1,
        LogMessageArgumentFactory argumentFactory2,
        LogMessageArgumentFactory argumentFactory3,
        LogMessageArgumentFactory argumentFactory4)
    {
        Log(LogLevel.Debug, message,
            argumentFactory1,
            argumentFactory2,
            argumentFactory3,
            argumentFactory4);
    }

    public void Debug(Exception? exception, LogMessageFactory message,
        LogMessageArgumentFactory argumentFactory1,
        LogMessageArgumentFactory argumentFactory2,
        LogMessageArgumentFactory argumentFactory3,
        LogMessageArgumentFactory argumentFactory4)
    {
        Log(LogLevel.Debug, exception, message,
            argumentFactory1,
            argumentFactory2,
            argumentFactory3,
            argumentFactory4);
    }

    #endregion

    #region Log(LogMessageArgumentFactory...)

    public void Debug([Localizable(false)][StructuredMessageTemplate] string? message,
        params LogMessageArgumentFactory[] arguments)
    {
        Log(LogLevel.Debug, message,
            arguments);
    }

    public void Debug(Exception? exception, [Localizable(false)][StructuredMessageTemplate] string? message,
        params LogMessageArgumentFactory[] arguments)
    {
        Log(LogLevel.Debug, exception, message,
            arguments);
    }

    public void Debug(LogMessageFactory message,
        params LogMessageArgumentFactory[] arguments)
    {
        Log(LogLevel.Debug, message,
            arguments);
    }

    public void Debug(Exception? exception, LogMessageFactory message,
        params LogMessageArgumentFactory[] arguments)
    {
        Log(LogLevel.Debug, exception, message,
            arguments);
    }

    #endregion
}
