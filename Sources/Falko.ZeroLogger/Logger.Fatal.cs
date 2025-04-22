using System.ComponentModel;
using System.Numerics;
using JetBrains.Annotations;

namespace System.Logging;

public readonly partial struct Logger
{
    #region Log()

    public void Fatal([Localizable(false)][StructuredMessageTemplate] string? message)
    {
        Log(LogLevel.Fatal, message);
    }

    public void Fatal(Exception? exception, [Localizable(false)][StructuredMessageTemplate] string? message)
    {
        Log(LogLevel.Fatal, exception, message);
    }

    public void Fatal(LogMessageFactory messageFactory)
    {
        Log(LogLevel.Fatal, messageFactory);
    }

    public void Fatal(Exception? exception, LogMessageFactory messageFactory)
    {
        Log(LogLevel.Fatal, exception, messageFactory);
    }

    #endregion

    #region Log(short)

    public void Fatal([Localizable(false)][StructuredMessageTemplate] string? message,
        short argument)
    {
        Log(LogLevel.Fatal, message,
            argument);
    }

    public void Fatal(Exception? exception, [Localizable(false)][StructuredMessageTemplate] string? message,
        short argument)
    {
        Log(LogLevel.Fatal, exception, message,
            argument);
    }

    public void Fatal(LogMessageFactory messageFactory,
        short argument)
    {
        Log(LogLevel.Fatal, messageFactory,
            argument);
    }

    public void Fatal(Exception? exception, LogMessageFactory messageFactory,
        short argument)
    {
        Log(LogLevel.Fatal, exception, messageFactory,
            argument);
    }

    #endregion

    #region Log(ushort)

    public void Fatal([Localizable(false)][StructuredMessageTemplate] string? message,
        ushort argument)
    {
        Log(LogLevel.Fatal, message,
            argument);
    }

    public void Fatal(Exception? exception, [Localizable(false)][StructuredMessageTemplate] string? message,
        ushort argument)
    {
        Log(LogLevel.Fatal, exception, message,
            argument);
    }

    public void Fatal(LogMessageFactory messageFactory,
        ushort argument)
    {
        Log(LogLevel.Fatal, messageFactory,
            argument);
    }

    public void Fatal(Exception? exception, LogMessageFactory messageFactory,
        ushort argument)
    {
        Log(LogLevel.Fatal, exception, messageFactory,
            argument);
    }

    #endregion

    #region Log(int)

    public void Fatal([Localizable(false)][StructuredMessageTemplate] string? message,
        int argument)
    {
        Log(LogLevel.Fatal, message,
            argument);
    }

    public void Fatal(Exception? exception, [Localizable(false)][StructuredMessageTemplate] string? message,
        int argument)
    {
        Log(LogLevel.Fatal, exception, message,
            argument);
    }

    public void Fatal(LogMessageFactory messageFactory,
        int argument)
    {
        Log(LogLevel.Fatal, messageFactory,
            argument);
    }

    public void Fatal(Exception? exception, LogMessageFactory messageFactory,
        int argument)
    {
        Log(LogLevel.Fatal, exception, messageFactory,
            argument);
    }

    #endregion

    #region Log(nint)

    public void Fatal([Localizable(false)][StructuredMessageTemplate] string? message,
        nint argument)
    {
        Log(LogLevel.Fatal, message,
            argument);
    }

    public void Fatal(Exception? exception, [Localizable(false)][StructuredMessageTemplate] string? message,
        nint argument)
    {
        Log(LogLevel.Fatal, exception, message,
            argument);
    }

    public void Fatal(LogMessageFactory messageFactory,
        nint argument)
    {
        Log(LogLevel.Fatal, messageFactory,
            argument);
    }

    public void Fatal(Exception? exception, LogMessageFactory messageFactory,
        nint argument)
    {
        Log(LogLevel.Fatal, exception, messageFactory,
            argument);
    }

    #endregion

    #region Log(nuint)

    public void Fatal([Localizable(false)][StructuredMessageTemplate] string? message,
        nuint argument)
    {
        Log(LogLevel.Fatal, message,
            argument);
    }

    public void Fatal(Exception? exception, [Localizable(false)][StructuredMessageTemplate] string? message,
        nuint argument)
    {
        Log(LogLevel.Fatal, exception, message,
            argument);
    }

    public void Fatal(LogMessageFactory messageFactory,
        nuint argument)
    {
        Log(LogLevel.Fatal, messageFactory,
            argument);
    }

    public void Fatal(Exception? exception, LogMessageFactory messageFactory,
        nuint argument)
    {
        Log(LogLevel.Fatal, exception, messageFactory,
            argument);
    }

    #endregion

    #region Log(long)

    public void Fatal([Localizable(false)][StructuredMessageTemplate] string? message,
        long argument)
    {
        Log(LogLevel.Fatal, message,
            argument);
    }

    public void Fatal(Exception? exception, [Localizable(false)][StructuredMessageTemplate] string? message,
        long argument)
    {
        Log(LogLevel.Fatal, exception, message,
            argument);
    }

    public void Fatal(LogMessageFactory messageFactory,
        long argument)
    {
        Log(LogLevel.Fatal, messageFactory,
            argument);
    }

    public void Fatal(Exception? exception, LogMessageFactory messageFactory,
        long argument)
    {
        Log(LogLevel.Fatal, exception, messageFactory,
            argument);
    }

    #endregion

    #region Log(ulong)

    public void Fatal([Localizable(false)][StructuredMessageTemplate] string? message,
        ulong argument)
    {
        Log(LogLevel.Fatal, message,
            argument);
    }

    public void Fatal(Exception? exception, [Localizable(false)][StructuredMessageTemplate] string? message,
        ulong argument)
    {
        Log(LogLevel.Fatal, exception, message,
            argument);
    }

    public void Fatal(LogMessageFactory messageFactory,
        ulong argument)
    {
        Log(LogLevel.Fatal, messageFactory,
            argument);
    }

    public void Fatal(Exception? exception, LogMessageFactory messageFactory,
        ulong argument)
    {
        Log(LogLevel.Fatal, exception, messageFactory,
            argument);
    }

    #endregion

    #region Log(BigInteger)

    public void Fatal([Localizable(false)][StructuredMessageTemplate] string? message,
        BigInteger argument)
    {
        Log(LogLevel.Fatal, message,
            argument);
    }

    public void Fatal(Exception? exception, [Localizable(false)][StructuredMessageTemplate] string? message,
        BigInteger argument)
    {
        Log(LogLevel.Fatal, exception, message,
            argument);
    }

    public void Fatal(LogMessageFactory messageFactory,
        BigInteger argument)
    {
        Log(LogLevel.Fatal, messageFactory,
            argument);
    }

    public void Fatal(Exception? exception, LogMessageFactory messageFactory,
        BigInteger argument)
    {
        Log(LogLevel.Fatal, exception, messageFactory,
            argument);
    }

    #endregion

    #region Log(float)

    public void Fatal([Localizable(false)][StructuredMessageTemplate] string? message,
        float argument)
    {
        Log(LogLevel.Fatal, message,
            argument);
    }

    public void Fatal(Exception? exception, [Localizable(false)][StructuredMessageTemplate] string? message,
        float argument)
    {
        Log(LogLevel.Fatal, exception, message,
            argument);
    }

    public void Fatal(LogMessageFactory messageFactory,
        float argument)
    {
        Log(LogLevel.Fatal, messageFactory,
            argument);
    }

    public void Fatal(Exception? exception, LogMessageFactory messageFactory,
        float argument)
    {
        Log(LogLevel.Fatal, exception, messageFactory,
            argument);
    }

    #endregion

    #region Log(double)

    public void Fatal([Localizable(false)][StructuredMessageTemplate] string? message,
        double argument)
    {
        Log(LogLevel.Fatal, message,
            argument);
    }

    public void Fatal(Exception? exception, [Localizable(false)][StructuredMessageTemplate] string? message,
        double argument)
    {
        Log(LogLevel.Fatal, exception, message,
            argument);
    }

    public void Fatal(LogMessageFactory messageFactory,
        double argument)
    {
        Log(LogLevel.Fatal, messageFactory,
            argument);
    }

    public void Fatal(Exception? exception, LogMessageFactory messageFactory,
        double argument)
    {
        Log(LogLevel.Fatal, exception, messageFactory,
            argument);
    }

    #endregion

    #region Log(decimal)

    public void Fatal([Localizable(false)][StructuredMessageTemplate] string? message,
        decimal argument)
    {
        Log(LogLevel.Fatal, message,
            argument);
    }

    public void Fatal(Exception? exception, [Localizable(false)][StructuredMessageTemplate] string? message,
        decimal argument)
    {
        Log(LogLevel.Fatal, exception, message,
            argument);
    }

    public void Fatal(LogMessageFactory messageFactory,
        decimal argument)
    {
        Log(LogLevel.Fatal, messageFactory,
            argument);
    }

    public void Fatal(Exception? exception, LogMessageFactory messageFactory,
        decimal argument)
    {
        Log(LogLevel.Fatal, exception, messageFactory,
            argument);
    }

    #endregion

    #region Log(Guid)

    public void Fatal([Localizable(false)][StructuredMessageTemplate] string? message,
        Guid argument)
    {
        Log(LogLevel.Fatal, message,
            argument);
    }

    public void Fatal(Exception? exception, [Localizable(false)][StructuredMessageTemplate] string? message,
        Guid argument)
    {
        Log(LogLevel.Fatal, exception, message,
            argument);
    }

    public void Fatal(LogMessageFactory messageFactory,
        Guid argument)
    {
        Log(LogLevel.Fatal, messageFactory,
            argument);
    }

    public void Fatal(Exception? exception, LogMessageFactory messageFactory,
        Guid argument)
    {
        Log(LogLevel.Fatal, exception, messageFactory,
            argument);
    }

    #endregion

    #region Log(TimeSpan)

    public void Fatal([Localizable(false)][StructuredMessageTemplate] string? message,
        TimeSpan argument)
    {
        Log(LogLevel.Fatal, message,
            argument);
    }

    public void Fatal(Exception? exception, [Localizable(false)][StructuredMessageTemplate] string? message,
        TimeSpan argument)
    {
        Log(LogLevel.Fatal, exception, message,
            argument);
    }

    public void Fatal(LogMessageFactory messageFactory,
        TimeSpan argument)
    {
        Log(LogLevel.Fatal, messageFactory,
            argument);
    }

    public void Fatal(Exception? exception, LogMessageFactory messageFactory,
        TimeSpan argument)
    {
        Log(LogLevel.Fatal, exception, messageFactory,
            argument);
    }

    #endregion

    #region Log(TimeOnly)

    public void Fatal([Localizable(false)][StructuredMessageTemplate] string? message,
        TimeOnly argument)
    {
        Log(LogLevel.Fatal, message,
            argument);
    }

    public void Fatal(Exception? exception, [Localizable(false)][StructuredMessageTemplate] string? message,
        TimeOnly argument)
    {
        Log(LogLevel.Fatal, exception, message,
            argument);
    }

    public void Fatal(LogMessageFactory messageFactory,
        TimeOnly argument)
    {
        Log(LogLevel.Fatal, messageFactory,
            argument);
    }

    public void Fatal(Exception? exception, LogMessageFactory messageFactory,
        TimeOnly argument)
    {
        Log(LogLevel.Fatal, exception, messageFactory,
            argument);
    }

    #endregion

    #region Log(DateTime)

    public void Fatal([Localizable(false)][StructuredMessageTemplate] string? message,
        DateTime argument)
    {
        Log(LogLevel.Fatal, message,
            argument);
    }

    public void Fatal(Exception? exception, [Localizable(false)][StructuredMessageTemplate] string? message,
        DateTime argument)
    {
        Log(LogLevel.Fatal, exception, message,
            argument);
    }

    public void Fatal(LogMessageFactory messageFactory,
        DateTime argument)
    {
        Log(LogLevel.Fatal, messageFactory,
            argument);
    }

    public void Fatal(Exception? exception, LogMessageFactory messageFactory,
        DateTime argument)
    {
        Log(LogLevel.Fatal, exception, messageFactory,
            argument);
    }

    #endregion

    #region Log(DateTimeOffset)

    public void Fatal([Localizable(false)][StructuredMessageTemplate] string? message,
        DateTimeOffset argument)
    {
        Log(LogLevel.Fatal, message,
            argument);
    }

    public void Fatal(Exception? exception, [Localizable(false)][StructuredMessageTemplate] string? message,
        DateTimeOffset argument)
    {
        Log(LogLevel.Fatal, exception, message,
            argument);
    }

    public void Fatal(LogMessageFactory messageFactory,
        DateTimeOffset argument)
    {
        Log(LogLevel.Fatal, messageFactory,
            argument);
    }

    public void Fatal(Exception? exception, LogMessageFactory messageFactory,
        DateTimeOffset argument)
    {
        Log(LogLevel.Fatal, exception, messageFactory,
            argument);
    }

    #endregion

    #region Log(DateOnly)

    public void Fatal([Localizable(false)][StructuredMessageTemplate] string? message,
        DateOnly argument)
    {
        Log(LogLevel.Fatal, message,
            argument);
    }

    public void Fatal(Exception? exception, [Localizable(false)][StructuredMessageTemplate] string? message,
        DateOnly argument)
    {
        Log(LogLevel.Fatal, exception, message,
            argument);
    }

    public void Fatal(LogMessageFactory messageFactory,
        DateOnly argument)
    {
        Log(LogLevel.Fatal, messageFactory,
            argument);
    }

    public void Fatal(Exception? exception, LogMessageFactory messageFactory,
        DateOnly argument)
    {
        Log(LogLevel.Fatal, exception, messageFactory,
            argument);
    }

    #endregion

    #region Log(byte)

    public void Fatal([Localizable(false)][StructuredMessageTemplate] string? message,
        byte argument)
    {
        Log(LogLevel.Fatal, message,
            argument);
    }

    public void Fatal(Exception? exception, [Localizable(false)][StructuredMessageTemplate] string? message,
        byte argument)
    {
        Log(LogLevel.Fatal, exception, message,
            argument);
    }

    public void Fatal(LogMessageFactory messageFactory,
        byte argument)
    {
        Log(LogLevel.Fatal, messageFactory,
            argument);
    }

    public void Fatal(Exception? exception, LogMessageFactory messageFactory,
        byte argument)
    {
        Log(LogLevel.Fatal, exception, messageFactory,
            argument);
    }

    #endregion

    #region Log(sbyte)

    public void Fatal([Localizable(false)][StructuredMessageTemplate] string? message,
        sbyte argument)
    {
        Log(LogLevel.Fatal, message,
            argument);
    }

    public void Fatal(Exception? exception, [Localizable(false)][StructuredMessageTemplate] string? message,
        sbyte argument)
    {
        Log(LogLevel.Fatal, exception, message,
            argument);
    }

    public void Fatal(LogMessageFactory messageFactory,
        sbyte argument)
    {
        Log(LogLevel.Fatal, messageFactory,
            argument);
    }

    public void Fatal(Exception? exception, LogMessageFactory messageFactory,
        sbyte argument)
    {
        Log(LogLevel.Fatal, exception, messageFactory,
            argument);
    }

    #endregion

    #region Log(char)

    public void Fatal([Localizable(false)][StructuredMessageTemplate] string? message,
        char argument)
    {
        Log(LogLevel.Fatal, message,
            argument);
    }

    public void Fatal(Exception? exception, [Localizable(false)][StructuredMessageTemplate] string? message,
        char argument)
    {
        Log(LogLevel.Fatal, exception, message,
            argument);
    }

    public void Fatal(LogMessageFactory messageFactory,
        char argument)
    {
        Log(LogLevel.Fatal, messageFactory,
            argument);
    }

    public void Fatal(Exception? exception, LogMessageFactory messageFactory,
        char argument)
    {
        Log(LogLevel.Fatal, exception, messageFactory,
            argument);
    }

    #endregion

    #region Log(string)

    public void Fatal([Localizable(false)][StructuredMessageTemplate] string? message,
        string? argument)
    {
        Log(LogLevel.Fatal, message,
            argument);
    }

    public void Fatal(Exception? exception, [Localizable(false)][StructuredMessageTemplate] string? message,
        string? argument)
    {
        Log(LogLevel.Fatal, exception, message,
            argument);
    }

    public void Fatal(LogMessageFactory messageFactory,
        string? argument)
    {
        Log(LogLevel.Fatal, messageFactory,
            argument);
    }

    public void Fatal(Exception? exception, LogMessageFactory messageFactory,
        string? argument)
    {
        Log(LogLevel.Fatal, exception, messageFactory,
            argument);
    }

    #endregion

    #region Log(string, string)

    public void Fatal([Localizable(false)][StructuredMessageTemplate] string? message,
        string? argument1,
        string? argument2)
    {
        Log(LogLevel.Fatal, message,
            argument1,
            argument2);
    }

    public void Fatal(Exception? exception, [Localizable(false)][StructuredMessageTemplate] string? message,
        string? argument1,
        string? argument2)
    {
        Log(LogLevel.Fatal, exception, message,
            argument1,
            argument2);
    }

    public void Fatal(LogMessageFactory message,
        string? argument1,
        string? argument2)
    {
        Log(LogLevel.Fatal, message,
            argument1,
            argument2);
    }

    public void Fatal(Exception? exception, LogMessageFactory message,
        string? argument1,
        string? argument2)
    {
        Log(LogLevel.Fatal, exception, message,
            argument1,
            argument2);
    }

    #endregion

    #region Log(string, string, string)

    public void Fatal([Localizable(false)][StructuredMessageTemplate] string? message,
        string? argument1,
        string? argument2,
        string? argument3)
    {
        Log(LogLevel.Fatal, message,
            argument1,
            argument2,
            argument3);
    }

    public void Fatal(Exception? exception, [Localizable(false)][StructuredMessageTemplate] string? message,
        string? argument1,
        string? argument2,
        string? argument3)
    {
        Log(LogLevel.Fatal, exception, message,
            argument1,
            argument2,
            argument3);
    }

    public void Fatal(LogMessageFactory message,
        string? argument1,
        string? argument2,
        string? argument3)
    {
        Log(LogLevel.Fatal, message,
            argument1,
            argument2,
            argument3);
    }

    public void Fatal(Exception? exception, LogMessageFactory message,
        string? argument1,
        string? argument2,
        string? argument3)
    {
        Log(LogLevel.Fatal, exception, message,
            argument1,
            argument2,
            argument3);
    }

    #endregion

    #region Log(string, string, string, string)

    public void Fatal([Localizable(false)][StructuredMessageTemplate] string? message,
        string? argument1,
        string? argument2,
        string? argument3,
        string? argument4)
    {
        Log(LogLevel.Fatal, message,
            argument1,
            argument2,
            argument3,
            argument4);
    }

    public void Fatal(Exception? exception, [Localizable(false)][StructuredMessageTemplate] string? message,
        string? argument1,
        string? argument2,
        string? argument3,
        string? argument4)
    {
        Log(LogLevel.Fatal, exception, message,
            argument1,
            argument2,
            argument3,
            argument4);
    }

    public void Fatal(LogMessageFactory message,
        string? argument1,
        string? argument2,
        string? argument3,
        string? argument4)
    {
        Log(LogLevel.Fatal, message,
            argument1,
            argument2,
            argument3,
            argument4);
    }

    public void Fatal(Exception? exception, LogMessageFactory message,
        string? argument1,
        string? argument2,
        string? argument3,
        string? argument4)
    {
        Log(LogLevel.Fatal, exception, message,
            argument1,
            argument2,
            argument3,
            argument4);
    }

    #endregion

    #region Log(string, string, string, string)

    public void Fatal([Localizable(false)][StructuredMessageTemplate] string? message,
        string? argument1,
        string? argument2,
        string? argument3,
        string? argument4,
        string? argument5)
    {
        Log(LogLevel.Fatal, message,
            argument1,
            argument2,
            argument3,
            argument4,
            argument5);
    }

    public void Fatal(Exception? exception, [Localizable(false)][StructuredMessageTemplate] string? message,
        string? argument1,
        string? argument2,
        string? argument3,
        string? argument4,
        string? argument5)
    {
        Log(LogLevel.Fatal, exception, message,
            argument1,
            argument2,
            argument3,
            argument4,
            argument5);
    }

    public void Fatal(LogMessageFactory message,
        string? argument1,
        string? argument2,
        string? argument3,
        string? argument4,
        string? argument5)
    {
        Log(LogLevel.Fatal, message,
            argument1,
            argument2,
            argument3,
            argument4,
            argument5);
    }

    public void Fatal(Exception? exception, LogMessageFactory message,
        string? argument1,
        string? argument2,
        string? argument3,
        string? argument4,
        string? argument5)
    {
        Log(LogLevel.Fatal, exception, message,
            argument1,
            argument2,
            argument3,
            argument4,
            argument5);
    }

    #endregion

    #region Log(T)

    public void Fatal<T>([Localizable(false)][StructuredMessageTemplate] string? message,
        T argument)
    {
        Log(LogLevel.Fatal, message,
            argument);
    }

    public void Fatal<T>(Exception? exception, [Localizable(false)][StructuredMessageTemplate] string? message,
        T argument)
    {
        Log(LogLevel.Fatal, exception, message,
            argument);
    }

    public void Fatal<T>(LogMessageFactory messageFactory,
        T argument)
    {
        Log(LogLevel.Fatal, messageFactory,
            argument);
    }

    public void Fatal<T>(Exception? exception, LogMessageFactory messageFactory,
        T argument)
    {
        Log(LogLevel.Fatal, exception, messageFactory,
            argument);
    }

    #endregion

    #region Log(T, T)

    public void Fatal<T1, T2>([Localizable(false)][StructuredMessageTemplate] string? message,
        T1 argument1,
        T2 argument2)
    {
        Log(LogLevel.Fatal, message,
            argument1,
            argument2);
    }

    public void Fatal<T1, T2>(Exception? exception, [Localizable(false)][StructuredMessageTemplate] string? message,
        T1 argument1,
        T2 argument2)
    {
        Log(LogLevel.Fatal, exception, message,
            argument1,
            argument2);
    }

    public void Fatal<T1, T2>(LogMessageFactory message,
        T1 argument1,
        T2 argument2)
    {
        Log(LogLevel.Fatal, message,
            argument1,
            argument2);
    }

    public void Fatal<T1, T2>(Exception? exception, LogMessageFactory message,
        T1 argument1,
        T2 argument2)
    {
        Log(LogLevel.Fatal, exception, message,
            argument1,
            argument2);
    }

    #endregion

    #region Log(T, T, T)

    public void Fatal<T1, T2, T3>([Localizable(false)][StructuredMessageTemplate] string? message,
        T1 argument1,
        T2 argument2,
        T3 argument3)
    {
        Log(LogLevel.Fatal, message,
            argument1,
            argument2,
            argument3);
    }

    public void Fatal<T1, T2, T3>(Exception? exception, [Localizable(false)][StructuredMessageTemplate] string? message,
        T1 argument1,
        T2 argument2,
        T3 argument3)
    {
        Log(LogLevel.Fatal, exception, message,
            argument1,
            argument2,
            argument3);
    }

    public void Fatal<T1, T2, T3>(LogMessageFactory message,
        T1 argument1,
        T2 argument2,
        T3 argument3)
    {
        Log(LogLevel.Fatal, message,
            argument1,
            argument2,
            argument3);
    }

    public void Fatal<T1, T2, T3>(Exception? exception, LogMessageFactory message,
        T1 argument1,
        T2 argument2,
        T3 argument3)
    {
        Log(LogLevel.Fatal, exception, message,
            argument1,
            argument2,
            argument3);
    }

    #endregion

    #region Log(T, T, T, T)

    public void Fatal<T1, T2, T3, T4>([Localizable(false)][StructuredMessageTemplate] string? message,
        T1 argument1,
        T2 argument2,
        T3 argument3,
        T4 argument4)
    {
        Log(LogLevel.Fatal, message,
            argument1,
            argument2,
            argument3,
            argument4);
    }

    public void Fatal<T1, T2, T3, T4>(Exception? exception, [Localizable(false)][StructuredMessageTemplate] string? message,
        T1 argument1,
        T2 argument2,
        T3 argument3,
        T4 argument4)
    {
        Log(LogLevel.Fatal, exception, message,
            argument1,
            argument2,
            argument3,
            argument4);
    }

    public void Fatal<T1, T2, T3, T4>(LogMessageFactory message,
        T1 argument1,
        T2 argument2,
        T3 argument3,
        T4 argument4)
    {
        Log(LogLevel.Fatal, message,
            argument1,
            argument2,
            argument3,
            argument4);
    }

    public void Fatal<T1, T2, T3, T4>(Exception? exception, LogMessageFactory message,
        T1 argument1,
        T2 argument2,
        T3 argument3,
        T4 argument4)
    {
        Log(LogLevel.Fatal, exception, message,
            argument1,
            argument2,
            argument3,
            argument4);
    }

    #endregion

    #region Log(T, T, T, T, T)

    public void Fatal<T1, T2, T3, T4, T5>([Localizable(false)][StructuredMessageTemplate] string? message,
        T1 argument1,
        T2 argument2,
        T3 argument3,
        T4 argument4,
        T5 argument5)
    {
        Log(LogLevel.Fatal, message,
            argument1,
            argument2,
            argument3,
            argument4,
            argument5);
    }

    public void Fatal<T1, T2, T3, T4, T5>(Exception? exception, [Localizable(false)][StructuredMessageTemplate] string? message,
        T1 argument1,
        T2 argument2,
        T3 argument3,
        T4 argument4,
        T5 argument5)
    {
        Log(LogLevel.Fatal, exception, message,
            argument1,
            argument2,
            argument3,
            argument4,
            argument5);
    }

    public void Fatal<T1, T2, T3, T4, T5>(LogMessageFactory message,
        T1 argument1,
        T2 argument2,
        T3 argument3,
        T4 argument4,
        T5 argument5)
    {
        Log(LogLevel.Fatal, message,
            argument1,
            argument2,
            argument3,
            argument4,
            argument5);
    }

    public void Fatal<T1, T2, T3, T4, T5>(Exception? exception, LogMessageFactory message,
        T1 argument1,
        T2 argument2,
        T3 argument3,
        T4 argument4,
        T5 argument5)
    {
        Log(LogLevel.Fatal, exception, message,
            argument1,
            argument2,
            argument3,
            argument4,
            argument5);
    }

    #endregion

    #region Log(LogMessageArgumentFactory)

    public void Fatal([Localizable(false)][StructuredMessageTemplate] string? message,
        LogMessageArgumentFactory argumentFactory)
    {
        Log(LogLevel.Fatal, message,
            argumentFactory);
    }

    public void Fatal(Exception? exception, [Localizable(false)][StructuredMessageTemplate] string? message,
        LogMessageArgumentFactory argumentFactory)
    {
        Log(LogLevel.Fatal, exception, message,
            argumentFactory);
    }

    public void Fatal(LogMessageFactory messageFactory,
        LogMessageArgumentFactory argumentFactory)
    {
        Log(LogLevel.Fatal, messageFactory,
            argumentFactory);
    }

    public void Fatal(Exception? exception, LogMessageFactory messageFactory,
        LogMessageArgumentFactory argumentFactory)
    {
        Log(LogLevel.Fatal, exception, messageFactory,
            argumentFactory);
    }

    #endregion

    #region Log(LogMessageArgumentFactory, LogMessageArgumentFactory)

    public void Fatal([Localizable(false)][StructuredMessageTemplate] string? message,
        LogMessageArgumentFactory argumentFactory1,
        LogMessageArgumentFactory argumentFactory2)
    {
        Log(LogLevel.Fatal, message,
            argumentFactory1,
            argumentFactory2);
    }

    public void Fatal(Exception? exception, [Localizable(false)][StructuredMessageTemplate] string? message,
        LogMessageArgumentFactory argumentFactory1,
        LogMessageArgumentFactory argumentFactory2)
    {
        Log(LogLevel.Fatal, exception, message,
            argumentFactory1,
            argumentFactory2);
    }

    public void Fatal(LogMessageFactory message,
        LogMessageArgumentFactory argumentFactory1,
        LogMessageArgumentFactory argumentFactory2)
    {
        Log(LogLevel.Fatal, message,
            argumentFactory1,
            argumentFactory2);
    }

    public void Fatal(Exception? exception, LogMessageFactory message,
        LogMessageArgumentFactory argumentFactory1,
        LogMessageArgumentFactory argumentFactory2)
    {
        Log(LogLevel.Fatal, exception, message,
            argumentFactory1,
            argumentFactory2);
    }

    #endregion

    #region Log(LogMessageArgumentFactory, LogMessageArgumentFactory, LogMessageArgumentFactory)

    public void Fatal([Localizable(false)][StructuredMessageTemplate] string? message,
        LogMessageArgumentFactory argumentFactory1,
        LogMessageArgumentFactory argumentFactory2,
        LogMessageArgumentFactory argumentFactory3)
    {
        Log(LogLevel.Fatal, message,
            argumentFactory1,
            argumentFactory2,
            argumentFactory3);
    }

    public void Fatal(Exception? exception, [Localizable(false)][StructuredMessageTemplate] string? message,
        LogMessageArgumentFactory argumentFactory1,
        LogMessageArgumentFactory argumentFactory2,
        LogMessageArgumentFactory argumentFactory3)
    {
        Log(LogLevel.Fatal, exception, message,
            argumentFactory1,
            argumentFactory2,
            argumentFactory3);
    }

    public void Fatal(LogMessageFactory message,
        LogMessageArgumentFactory argumentFactory1,
        LogMessageArgumentFactory argumentFactory2,
        LogMessageArgumentFactory argumentFactory3)
    {
        Log(LogLevel.Fatal, message,
            argumentFactory1,
            argumentFactory2,
            argumentFactory3);
    }

    public void Fatal(Exception? exception, LogMessageFactory message,
        LogMessageArgumentFactory argumentFactory1,
        LogMessageArgumentFactory argumentFactory2,
        LogMessageArgumentFactory argumentFactory3)
    {
        Log(LogLevel.Fatal, exception, message,
            argumentFactory1,
            argumentFactory2,
            argumentFactory3);
    }

    #endregion

    #region Log(LogMessageArgumentFactory, LogMessageArgumentFactory, LogMessageArgumentFactory, LogMessageArgumentFactory)

    public void Fatal([Localizable(false)][StructuredMessageTemplate] string? message,
        LogMessageArgumentFactory argumentFactory1,
        LogMessageArgumentFactory argumentFactory2,
        LogMessageArgumentFactory argumentFactory3,
        LogMessageArgumentFactory argumentFactory4)
    {
        Log(LogLevel.Fatal, message,
            argumentFactory1,
            argumentFactory2,
            argumentFactory3,
            argumentFactory4);
    }

    public void Fatal(Exception? exception, [Localizable(false)][StructuredMessageTemplate] string? message,
        LogMessageArgumentFactory argumentFactory1,
        LogMessageArgumentFactory argumentFactory2,
        LogMessageArgumentFactory argumentFactory3,
        LogMessageArgumentFactory argumentFactory4)
    {
        Log(LogLevel.Fatal, exception, message,
            argumentFactory1,
            argumentFactory2,
            argumentFactory3,
            argumentFactory4);
    }

    public void Fatal(LogMessageFactory message,
        LogMessageArgumentFactory argumentFactory1,
        LogMessageArgumentFactory argumentFactory2,
        LogMessageArgumentFactory argumentFactory3,
        LogMessageArgumentFactory argumentFactory4)
    {
        Log(LogLevel.Fatal, message,
            argumentFactory1,
            argumentFactory2,
            argumentFactory3,
            argumentFactory4);
    }

    public void Fatal(Exception? exception, LogMessageFactory message,
        LogMessageArgumentFactory argumentFactory1,
        LogMessageArgumentFactory argumentFactory2,
        LogMessageArgumentFactory argumentFactory3,
        LogMessageArgumentFactory argumentFactory4)
    {
        Log(LogLevel.Fatal, exception, message,
            argumentFactory1,
            argumentFactory2,
            argumentFactory3,
            argumentFactory4);
    }

    #endregion

    #region Log(LogMessageArgumentFactory, LogMessageArgumentFactory, LogMessageArgumentFactory, LogMessageArgumentFactory)

    public void Fatal([Localizable(false)][StructuredMessageTemplate] string? message,
        LogMessageArgumentFactory argumentFactory1,
        LogMessageArgumentFactory argumentFactory2,
        LogMessageArgumentFactory argumentFactory3,
        LogMessageArgumentFactory argumentFactory4,
        LogMessageArgumentFactory argumentFactory5)
    {
        Log(LogLevel.Fatal, message,
            argumentFactory1,
            argumentFactory2,
            argumentFactory3,
            argumentFactory4,
            argumentFactory5);
    }

    public void Fatal(Exception? exception, [Localizable(false)][StructuredMessageTemplate] string? message,
        LogMessageArgumentFactory argumentFactory1,
        LogMessageArgumentFactory argumentFactory2,
        LogMessageArgumentFactory argumentFactory3,
        LogMessageArgumentFactory argumentFactory4,
        LogMessageArgumentFactory argumentFactory5)
    {
        Log(LogLevel.Fatal, exception, message,
            argumentFactory1,
            argumentFactory2,
            argumentFactory3,
            argumentFactory4,
            argumentFactory5);
    }

    public void Fatal(LogMessageFactory message,
        LogMessageArgumentFactory argumentFactory1,
        LogMessageArgumentFactory argumentFactory2,
        LogMessageArgumentFactory argumentFactory3,
        LogMessageArgumentFactory argumentFactory4,
        LogMessageArgumentFactory argumentFactory5)
    {
        Log(LogLevel.Fatal, message,
            argumentFactory1,
            argumentFactory2,
            argumentFactory3,
            argumentFactory4,
            argumentFactory5);
    }

    public void Fatal(Exception? exception, LogMessageFactory message,
        LogMessageArgumentFactory argumentFactory1,
        LogMessageArgumentFactory argumentFactory2,
        LogMessageArgumentFactory argumentFactory3,
        LogMessageArgumentFactory argumentFactory4,
        LogMessageArgumentFactory argumentFactory5)
    {
        Log(LogLevel.Fatal, exception, message,
            argumentFactory1,
            argumentFactory2,
            argumentFactory3,
            argumentFactory4,
            argumentFactory5);
    }

    #endregion
}
