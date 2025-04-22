using System.ComponentModel;
using JetBrains.Annotations;

namespace Falko.Logging;

public readonly partial struct Logger
{
    public void Debug(string? message) => Log(LogLevel.Debug, message);

    public void Debug(Exception? exception, string? message) => Log(LogLevel.Debug, exception, message);

    public void Debug(LogMessageFactory messageFactory) => Log(LogLevel.Debug, messageFactory);

    public void Debug(Exception? exception, LogMessageFactory messageFactory) => Log(LogLevel.Debug, exception, messageFactory);

    public void Debug([Localizable(false)][StructuredMessageTemplate] string? message, string? argument)
    {
        Log(LogLevel.Debug, message, argument);
    }

    public void Debug(Exception? exception, [Localizable(false)][StructuredMessageTemplate] string? message, string? argument)
    {
        Log(LogLevel.Debug, exception, message, argument);
    }

    public void Debug([Localizable(false)][StructuredMessageTemplate] string? message, short argument)
    {
        Log(LogLevel.Debug, message, argument);
    }

    public void Debug(Exception? exception, [Localizable(false)][StructuredMessageTemplate] string? message, short argument)
    {
        Log(LogLevel.Debug, exception, message, argument);
    }

    public void Debug([Localizable(false)][StructuredMessageTemplate] string? message, int argument)
    {
        Log(LogLevel.Debug, message, argument);
    }

    public void Debug(Exception? exception, [Localizable(false)][StructuredMessageTemplate] string? message, int argument)
    {
        Log(LogLevel.Debug, exception, message, argument);
    }

    public void Debug([Localizable(false)][StructuredMessageTemplate] string? message, long argument)
    {
        Log(LogLevel.Debug, message, argument);
    }

    public void Debug(Exception? exception, [Localizable(false)][StructuredMessageTemplate] string? message, long argument)
    {
        Log(LogLevel.Debug, exception, message, argument);
    }

    public void Debug([Localizable(false)][StructuredMessageTemplate] string? message, float argument)
    {
        Log(LogLevel.Debug, message, argument);
    }

    public void Debug(Exception? exception, [Localizable(false)][StructuredMessageTemplate] string? message, float argument)
    {
        Log(LogLevel.Debug, exception, message, argument);
    }

    public void Debug([Localizable(false)][StructuredMessageTemplate] string? message, double argument)
    {
        Log(LogLevel.Debug, message, argument);
    }

    public void Debug(Exception? exception, [Localizable(false)][StructuredMessageTemplate] string? message, double argument)
    {
        Log(LogLevel.Debug, exception, message, argument);
    }

    public void Debug([Localizable(false)][StructuredMessageTemplate] string? message, decimal argument)
    {
        Log(LogLevel.Debug, message, argument);
    }

    public void Debug(Exception? exception, [Localizable(false)][StructuredMessageTemplate] string? message, decimal argument)
    {
        Log(LogLevel.Debug, exception, message, argument);
    }

    public void Debug([Localizable(false)][StructuredMessageTemplate] string? message, DateTime argument)
    {
        Log(LogLevel.Debug, message, argument);
    }

    public void Debug(Exception? exception, [Localizable(false)][StructuredMessageTemplate] string? message, DateTime argument)
    {
        Log(LogLevel.Debug, exception, message, argument);
    }

    public void Debug([Localizable(false)][StructuredMessageTemplate] string? message, DateTimeOffset argument)
    {
        Log(LogLevel.Debug, message, argument);
    }

    public void Debug(Exception? exception, [Localizable(false)][StructuredMessageTemplate] string? message, DateTimeOffset argument)
    {
        Log(LogLevel.Debug, exception, message, argument);
    }

    public void Debug([Localizable(false)][StructuredMessageTemplate] string? message, DateOnly argument)
    {
        Log(LogLevel.Debug, message, argument);
    }

    public void Debug(Exception? exception, [Localizable(false)][StructuredMessageTemplate] string? message, DateOnly argument)
    {
        Log(LogLevel.Debug, exception, message, argument);
    }

    public void Debug([Localizable(false)][StructuredMessageTemplate] string? message, TimeSpan argument)
    {
        Log(LogLevel.Debug, message, argument);
    }

    public void Debug(Exception? exception, [Localizable(false)][StructuredMessageTemplate] string? message, TimeSpan argument)
    {
        Log(LogLevel.Debug, exception, message, argument);
    }

    public void Debug([Localizable(false)][StructuredMessageTemplate] string? message, TimeOnly argument)
    {
        Log(LogLevel.Debug, message, argument);
    }

    public void Debug(Exception? exception, [Localizable(false)][StructuredMessageTemplate] string? message, TimeOnly argument)
    {
        Log(LogLevel.Debug, exception, message, argument);
    }

    public void Debug([Localizable(false)][StructuredMessageTemplate] string? message, Guid argument)
    {
        Log(LogLevel.Debug, message, argument);
    }

    public void Debug(Exception? exception, [Localizable(false)][StructuredMessageTemplate] string? message, Guid argument)
    {
        Log(LogLevel.Debug, exception, message, argument);
    }

    public void Debug([Localizable(false)][StructuredMessageTemplate] string? message, bool argument)
    {
        Log(LogLevel.Debug, message, argument);
    }

    public void Debug(Exception? exception, [Localizable(false)][StructuredMessageTemplate] string? message, bool argument)
    {
        Log(LogLevel.Debug, exception, message, argument);
    }

    public void Debug([Localizable(false)][StructuredMessageTemplate] string? message, char argument)
    {
        Log(LogLevel.Debug, message, argument);
    }

    public void Debug(Exception? exception, [Localizable(false)][StructuredMessageTemplate] string? message, char argument)
    {
        Log(LogLevel.Debug, exception, message, argument);
    }

    public void Debug([Localizable(false)][StructuredMessageTemplate] string? message, ushort argument)
    {
        Log(LogLevel.Debug, message, argument);
    }

    public void Debug(Exception? exception, [Localizable(false)][StructuredMessageTemplate] string? message, ushort argument)
    {
        Log(LogLevel.Debug, exception, message, argument);
    }

    public void Debug([Localizable(false)][StructuredMessageTemplate] string? message, uint argument)
    {
        Log(LogLevel.Debug, message, argument);
    }

    public void Debug(Exception? exception, [Localizable(false)][StructuredMessageTemplate] string? message, uint argument)
    {
        Log(LogLevel.Debug, exception, message, argument);
    }

    public void Debug([Localizable(false)][StructuredMessageTemplate] string? message, ulong argument)
    {
        Log(LogLevel.Debug, message, argument);
    }

    public void Debug(Exception? exception, [Localizable(false)][StructuredMessageTemplate] string? message, ulong argument)
    {
        Log(LogLevel.Debug, exception, message, argument);
    }

    public void Debug([Localizable(false)][StructuredMessageTemplate] string? message, byte argument)
    {
        Log(LogLevel.Debug, message, argument);
    }

    public void Debug(Exception? exception, [Localizable(false)][StructuredMessageTemplate] string? message, byte argument)
    {
        Log(LogLevel.Debug, exception, message, argument);
    }

    public void Debug([Localizable(false)][StructuredMessageTemplate] string? message, sbyte argument)
    {
        Log(LogLevel.Debug, message, argument);
    }

    public void Debug(Exception? exception, [Localizable(false)][StructuredMessageTemplate] string? message, sbyte argument)
    {
        Log(LogLevel.Debug, exception, message, argument);
    }

    public void Debug<T1>([Localizable(false)][StructuredMessageTemplate] string? message, T1 argument)
    {
        Log(LogLevel.Debug, message, argument);
    }

    public void Debug<T1>(Exception? exception, [Localizable(false)][StructuredMessageTemplate] string? message, T1 argument)
    {
        Log(LogLevel.Debug, exception, message, argument);
    }

    public void Debug<T1, T2>([Localizable(false)][StructuredMessageTemplate] string? message, T1 argument1, T2 argument2)
    {
        Log(LogLevel.Debug, message, argument1, argument2);
    }

    public void Debug<T1, T2>(Exception? exception, [Localizable(false)][StructuredMessageTemplate] string? message, T1 argument1, T2 argument2)
    {
        Log(LogLevel.Debug, exception, message, argument1, argument2);
    }

    public void Debug<T1, T2, T3>([Localizable(false)][StructuredMessageTemplate] string? message, T1 argument1, T2 argument2, T3 argument3)
    {
        Log(LogLevel.Debug, message, argument1, argument2, argument3);
    }

    public void Debug<T1, T2, T3>(Exception? exception, [Localizable(false)][StructuredMessageTemplate] string? message, T1 argument1, T2 argument2, T3 argument3)
    {
        Log(LogLevel.Debug, exception, message, argument1, argument2, argument3);
    }

    public void Debug<T1, T2, T3, T4>([Localizable(false)][StructuredMessageTemplate] string? message, T1 argument1, T2 argument2, T3 argument3, T4 argument4)
    {
        Log(LogLevel.Debug, message, argument1, argument2, argument3, argument4);
    }

    public void Debug<T1, T2, T3, T4>(Exception? exception, [Localizable(false)][StructuredMessageTemplate] string? message, T1 argument1, T2 argument2, T3 argument3, T4 argument4)
    {
        Log(LogLevel.Debug, exception, message, argument1, argument2, argument3, argument4);
    }

    public void Debug<T1, T2, T3, T4, T5>([Localizable(false)][StructuredMessageTemplate] string? message, T1 argument1, T2 argument2, T3 argument3, T4 argument4, T5 argument5)
    {
        Log(LogLevel.Debug, message, argument1, argument2, argument3, argument4, argument5);
    }

    public void Debug<T1, T2, T3, T4, T5>(Exception? exception, [Localizable(false)][StructuredMessageTemplate] string? message, T1 argument1, T2 argument2, T3 argument3, T4 argument4, T5 argument5)
    {
        Log(LogLevel.Debug, exception, message, argument1, argument2, argument3, argument4, argument5);
    }

    public void Debug<T1, T2, T3, T4, T5, T6>([Localizable(false)][StructuredMessageTemplate] string? message, T1 argument1, T2 argument2, T3 argument3, T4 argument4, T5 argument5, T6 argument6)
    {
        Log(LogLevel.Debug, message, argument1, argument2, argument3, argument4, argument5, argument6);
    }

    public void Debug<T1, T2, T3, T4, T5, T6>(Exception? exception, [Localizable(false)][StructuredMessageTemplate] string? message, T1 argument1, T2 argument2, T3 argument3, T4 argument4, T5 argument5, T6 argument6)
    {
        Log(LogLevel.Debug, exception, message, argument1, argument2, argument3, argument4, argument5, argument6);
    }
}
