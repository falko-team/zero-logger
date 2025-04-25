using System.Logging.Logs;
using System.Logging.Providers;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace System.Logging.Factories;

internal static class ValueTypeArgumentMessageLogMessageProviderFactory
{
    #region CreateMessageProvider(short)

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static LogMessageProvider CreateMessageProvider(string? message, short argument)
    {
        return new SingleArgumentMessageLogMessageProvider<short>(message,
            new LogMessageArgument<short>(argument, static x => x.ToString()));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static LogMessageProvider CreateMessageProvider(LogMessageFactory messageFactory, short argument)
    {
        return new SingleArgumentMessageFactoryLogMessageProvider<short>(messageFactory,
            new LogMessageArgument<short>(argument, static x => x.ToString()));
    }

    #endregion

    #region CreateMessageProvider(ushort)

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static LogMessageProvider CreateMessageProvider(string? message, ushort argument)
    {
        return new SingleArgumentMessageLogMessageProvider<ushort>(message,
            new LogMessageArgument<ushort>(argument, static x => x.ToString()));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static LogMessageProvider CreateMessageProvider(LogMessageFactory messageFactory, ushort argument)
    {
        return new SingleArgumentMessageFactoryLogMessageProvider<ushort>(messageFactory,
            new LogMessageArgument<ushort>(argument, static x => x.ToString()));
    }

    #endregion

    #region CreateMessageProvider(int)

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static LogMessageProvider CreateMessageProvider(string? message, int argument)
    {
        return new SingleArgumentMessageLogMessageProvider<int>(message,
            new LogMessageArgument<int>(argument, static x => x.ToString()));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static LogMessageProvider CreateMessageProvider(LogMessageFactory messageFactory, int argument)
    {
        return new SingleArgumentMessageFactoryLogMessageProvider<int>(messageFactory,
            new LogMessageArgument<int>(argument, static x => x.ToString()));
    }

    #endregion

    #region CreateMessageProvider(nint)

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static LogMessageProvider CreateMessageProvider(string? message, nint argument)
    {
        return new SingleArgumentMessageLogMessageProvider<nint>(message,
            new LogMessageArgument<nint>(argument, static x => x.ToString()));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static LogMessageProvider CreateMessageProvider(LogMessageFactory messageFactory, nint argument)
    {
        return new SingleArgumentMessageFactoryLogMessageProvider<nint>(messageFactory,
            new LogMessageArgument<nint>(argument, static x => x.ToString()));
    }

    #endregion

    #region CreateMessageProvider(uint)

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static LogMessageProvider CreateMessageProvider(string? message, uint argument)
    {
        return new SingleArgumentMessageLogMessageProvider<uint>(message,
            new LogMessageArgument<uint>(argument, static x => x.ToString()));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static LogMessageProvider CreateMessageProvider(LogMessageFactory messageFactory, uint argument)
    {
        return new SingleArgumentMessageFactoryLogMessageProvider<uint>(messageFactory,
            new LogMessageArgument<uint>(argument, static x => x.ToString()));
    }

    #endregion

    #region CreateMessageProvider(nuint)

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static LogMessageProvider CreateMessageProvider(string? message, nuint argument)
    {
        return new SingleArgumentMessageLogMessageProvider<nuint>(message,
            new LogMessageArgument<nuint>(argument, static x => x.ToString()));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static LogMessageProvider CreateMessageProvider(LogMessageFactory messageFactory, nuint argument)
    {
        return new SingleArgumentMessageFactoryLogMessageProvider<nuint>(messageFactory,
            new LogMessageArgument<nuint>(argument, static x => x.ToString()));
    }

    #endregion

    #region CreateMessageProvider(long)

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static LogMessageProvider CreateMessageProvider(string? message, long argument)
    {
        return new SingleArgumentMessageLogMessageProvider<long>(message,
            new LogMessageArgument<long>(argument, static x => x.ToString()));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static LogMessageProvider CreateMessageProvider(LogMessageFactory messageFactory, long argument)
    {
        return new SingleArgumentMessageFactoryLogMessageProvider<long>(messageFactory,
            new LogMessageArgument<long>(argument, static x => x.ToString()));
    }

    #endregion

    #region CreateMessageProvider(ulong)

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static LogMessageProvider CreateMessageProvider(string? message, ulong argument)
    {
        return new SingleArgumentMessageLogMessageProvider<ulong>(message,
            new LogMessageArgument<ulong>(argument, static x => x.ToString()));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static LogMessageProvider CreateMessageProvider(LogMessageFactory messageFactory, ulong argument)
    {
        return new SingleArgumentMessageFactoryLogMessageProvider<ulong>(messageFactory,
            new LogMessageArgument<ulong>(argument, static x => x.ToString()));
    }

    #endregion

    #region CreateMessageProvider(BigInteger)

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static LogMessageProvider CreateMessageProvider(string? message, BigInteger argument)
    {
        return new SingleArgumentMessageLogMessageProvider<BigInteger>(message,
            new LogMessageArgument<BigInteger>(argument, static x => x.ToString()));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static LogMessageProvider CreateMessageProvider(LogMessageFactory messageFactory, BigInteger argument)
    {
        return new SingleArgumentMessageFactoryLogMessageProvider<BigInteger>(messageFactory,
            new LogMessageArgument<BigInteger>(argument, static x => x.ToString()));
    }

    #endregion

    #region CreateMessageProvider(float)

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static LogMessageProvider CreateMessageProvider(string? message, float argument)
    {
        // ReSharper disable once SpecifyACultureInStringConversionExplicitly
        return new SingleArgumentMessageLogMessageProvider<float>(message,
            new LogMessageArgument<float>(argument, static x => x.ToString()));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static LogMessageProvider CreateMessageProvider(LogMessageFactory messageFactory, float argument)
    {
        // ReSharper disable once SpecifyACultureInStringConversionExplicitly
        return new SingleArgumentMessageFactoryLogMessageProvider<float>(messageFactory,
            new LogMessageArgument<float>(argument, static x => x.ToString()));
    }

    #endregion

    #region CreateMessageProvider(double)

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static LogMessageProvider CreateMessageProvider(string? message, double argument)
    {
        // ReSharper disable once SpecifyACultureInStringConversionExplicitly
        return new SingleArgumentMessageLogMessageProvider<double>(message,
            new LogMessageArgument<double>(argument, static x => x.ToString()));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static LogMessageProvider CreateMessageProvider(LogMessageFactory messageFactory, double argument)
    {
        // ReSharper disable once SpecifyACultureInStringConversionExplicitly
        return new SingleArgumentMessageFactoryLogMessageProvider<double>(messageFactory,
            new LogMessageArgument<double>(argument, static x => x.ToString()));
    }

    #endregion

    #region CreateMessageProvider(decimal)

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static LogMessageProvider CreateMessageProvider(string? message, decimal argument)
    {
        // ReSharper disable once SpecifyACultureInStringConversionExplicitly
        return new SingleArgumentMessageLogMessageProvider<decimal>(message,
            new LogMessageArgument<decimal>(argument, static x => x.ToString()));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static LogMessageProvider CreateMessageProvider(LogMessageFactory messageFactory, decimal argument)
    {
        // ReSharper disable once SpecifyACultureInStringConversionExplicitly
        return new SingleArgumentMessageFactoryLogMessageProvider<decimal>(messageFactory,
            new LogMessageArgument<decimal>(argument, static x => x.ToString()));
    }

    #endregion

    #region CreateMessageProvider(Guid)

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static LogMessageProvider CreateMessageProvider(string? message, Guid argument)
    {
        return new SingleArgumentMessageLogMessageProvider<Guid>(message,
            new LogMessageArgument<Guid>(argument, static x => x.ToString()));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static LogMessageProvider CreateMessageProvider(LogMessageFactory messageFactory, Guid argument)
    {
        return new SingleArgumentMessageFactoryLogMessageProvider<Guid>(messageFactory,
            new LogMessageArgument<Guid>(argument, static x => x.ToString()));
    }

    #endregion

    #region CreateMessageProvider(TimeSpan)

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static LogMessageProvider CreateMessageProvider(string? message, TimeSpan argument)
    {
        return new SingleArgumentMessageLogMessageProvider<TimeSpan>(message,
            new LogMessageArgument<TimeSpan>(argument, static x => x.ToString()));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static LogMessageProvider CreateMessageProvider(LogMessageFactory messageFactory, TimeSpan argument)
    {
        return new SingleArgumentMessageFactoryLogMessageProvider<TimeSpan>(messageFactory,
            new LogMessageArgument<TimeSpan>(argument, static x => x.ToString()));
    }

    #endregion

    #region CreateMessageProvider(TimeOnly)

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static LogMessageProvider CreateMessageProvider(string? message, TimeOnly argument)
    {
        return new SingleArgumentMessageLogMessageProvider<TimeOnly>(message,
            new LogMessageArgument<TimeOnly>(argument, static x => x.ToString()));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static LogMessageProvider CreateMessageProvider(LogMessageFactory messageFactory, TimeOnly argument)
    {
        return new SingleArgumentMessageFactoryLogMessageProvider<TimeOnly>(messageFactory,
            new LogMessageArgument<TimeOnly>(argument, static x => x.ToString()));
    }

    #endregion

    #region CreateMessageProvider(DateTime)

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static LogMessageProvider CreateMessageProvider(string? message, DateTime argument)
    {
        // ReSharper disable once SpecifyACultureInStringConversionExplicitly
        return new SingleArgumentMessageLogMessageProvider<DateTime>(message,
            new LogMessageArgument<DateTime>(argument, static x => x.ToString()));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static LogMessageProvider CreateMessageProvider(LogMessageFactory messageFactory, DateTime argument)
    {
        // ReSharper disable once SpecifyACultureInStringConversionExplicitly
        return new SingleArgumentMessageFactoryLogMessageProvider<DateTime>(messageFactory,
            new LogMessageArgument<DateTime>(argument, static x => x.ToString()));
    }

    #endregion

    #region CreateMessageProvider(DateTimeOffset)

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static LogMessageProvider CreateMessageProvider(string? message, DateTimeOffset argument)
    {
        return new SingleArgumentMessageLogMessageProvider<DateTimeOffset>(message,
            new LogMessageArgument<DateTimeOffset>(argument, static x => x.ToString()));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static LogMessageProvider CreateMessageProvider(LogMessageFactory messageFactory, DateTimeOffset argument)
    {
        return new SingleArgumentMessageFactoryLogMessageProvider<DateTimeOffset>(messageFactory,
            new LogMessageArgument<DateTimeOffset>(argument, static x => x.ToString()));
    }

    #endregion

    #region CreateMessageProvider(DateOnly)

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static LogMessageProvider CreateMessageProvider(string? message, DateOnly argument)
    {
        return new SingleArgumentMessageLogMessageProvider<DateOnly>(message,
            new LogMessageArgument<DateOnly>(argument, static x => x.ToString()));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static LogMessageProvider CreateMessageProvider(LogMessageFactory messageFactory, DateOnly argument)
    {
        return new SingleArgumentMessageFactoryLogMessageProvider<DateOnly>(messageFactory,
            new LogMessageArgument<DateOnly>(argument, static x => x.ToString()));
    }

    #endregion

    #region CreateMessageProvider(byte)

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static LogMessageProvider CreateMessageProvider(string? message, byte argument)
    {
        return new SingleArgumentMessageLogMessageProvider<byte>(message,
            new LogMessageArgument<byte>(argument, static x => x.ToString()));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static LogMessageProvider CreateMessageProvider(LogMessageFactory messageFactory, byte argument)
    {
        return new SingleArgumentMessageFactoryLogMessageProvider<byte>(messageFactory,
            new LogMessageArgument<byte>(argument, static x => x.ToString()));
    }

    #endregion

    #region CreateMessageProvider(sbyte)

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static LogMessageProvider CreateMessageProvider(string? message, sbyte argument)
    {
        return new SingleArgumentMessageLogMessageProvider<sbyte>(message,
            new LogMessageArgument<sbyte>(argument, static x => x.ToString()));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static LogMessageProvider CreateMessageProvider(LogMessageFactory messageFactory, sbyte argument)
    {
        return new SingleArgumentMessageFactoryLogMessageProvider<sbyte>(messageFactory,
            new LogMessageArgument<sbyte>(argument, static x => x.ToString()));
    }

    #endregion

    #region CreateMessageProvider(char)

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static LogMessageProvider CreateMessageProvider(string? message, char argument)
    {
        return new SingleArgumentMessageLogMessageProvider<char>(message,
            new LogMessageArgument<char>(argument, static x => x.ToString()));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static LogMessageProvider CreateMessageProvider(LogMessageFactory messageFactory, char argument)
    {
        return new SingleArgumentMessageFactoryLogMessageProvider<char>(messageFactory,
            new LogMessageArgument<char>(argument, static x => x.ToString()));
    }

    #endregion
}
