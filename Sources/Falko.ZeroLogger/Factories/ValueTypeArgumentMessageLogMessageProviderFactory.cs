using System.Logging.Logs;
using System.Logging.Renderers;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace System.Logging.Factories;

internal static class ValueTypeArgumentMessageLogMessageProviderFactory
{
    #region CreateMessageProvider(short)

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ILogMessageRenderer CreateMessageProvider(string? message, short argument)
    {
        return new SingleArgumentMessageLogMessageRenderer<short>(message,
            new LogMessageArgument<short>(argument, static x => x.ToString()));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ILogMessageRenderer CreateMessageProvider(LogMessageFactory messageFactory, short argument)
    {
        return new SingleArgumentMessageFactoryLogMessageRenderer<short>(messageFactory,
            new LogMessageArgument<short>(argument, static x => x.ToString()));
    }

    #endregion

    #region CreateMessageProvider(ushort)

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ILogMessageRenderer CreateMessageProvider(string? message, ushort argument)
    {
        return new SingleArgumentMessageLogMessageRenderer<ushort>(message,
            new LogMessageArgument<ushort>(argument, static x => x.ToString()));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ILogMessageRenderer CreateMessageProvider(LogMessageFactory messageFactory, ushort argument)
    {
        return new SingleArgumentMessageFactoryLogMessageRenderer<ushort>(messageFactory,
            new LogMessageArgument<ushort>(argument, static x => x.ToString()));
    }

    #endregion

    #region CreateMessageProvider(int)

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ILogMessageRenderer CreateMessageProvider(string? message, int argument)
    {
        return new SingleArgumentMessageLogMessageRenderer<int>(message,
            new LogMessageArgument<int>(argument, static x => x.ToString()));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ILogMessageRenderer CreateMessageProvider(LogMessageFactory messageFactory, int argument)
    {
        return new SingleArgumentMessageFactoryLogMessageRenderer<int>(messageFactory,
            new LogMessageArgument<int>(argument, static x => x.ToString()));
    }

    #endregion

    #region CreateMessageProvider(nint)

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ILogMessageRenderer CreateMessageProvider(string? message, nint argument)
    {
        return new SingleArgumentMessageLogMessageRenderer<nint>(message,
            new LogMessageArgument<nint>(argument, static x => x.ToString()));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ILogMessageRenderer CreateMessageProvider(LogMessageFactory messageFactory, nint argument)
    {
        return new SingleArgumentMessageFactoryLogMessageRenderer<nint>(messageFactory,
            new LogMessageArgument<nint>(argument, static x => x.ToString()));
    }

    #endregion

    #region CreateMessageProvider(uint)

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ILogMessageRenderer CreateMessageProvider(string? message, uint argument)
    {
        return new SingleArgumentMessageLogMessageRenderer<uint>(message,
            new LogMessageArgument<uint>(argument, static x => x.ToString()));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ILogMessageRenderer CreateMessageProvider(LogMessageFactory messageFactory, uint argument)
    {
        return new SingleArgumentMessageFactoryLogMessageRenderer<uint>(messageFactory,
            new LogMessageArgument<uint>(argument, static x => x.ToString()));
    }

    #endregion

    #region CreateMessageProvider(nuint)

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ILogMessageRenderer CreateMessageProvider(string? message, nuint argument)
    {
        return new SingleArgumentMessageLogMessageRenderer<nuint>(message,
            new LogMessageArgument<nuint>(argument, static x => x.ToString()));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ILogMessageRenderer CreateMessageProvider(LogMessageFactory messageFactory, nuint argument)
    {
        return new SingleArgumentMessageFactoryLogMessageRenderer<nuint>(messageFactory,
            new LogMessageArgument<nuint>(argument, static x => x.ToString()));
    }

    #endregion

    #region CreateMessageProvider(long)

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ILogMessageRenderer CreateMessageProvider(string? message, long argument)
    {
        return new SingleArgumentMessageLogMessageRenderer<long>(message,
            new LogMessageArgument<long>(argument, static x => x.ToString()));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ILogMessageRenderer CreateMessageProvider(LogMessageFactory messageFactory, long argument)
    {
        return new SingleArgumentMessageFactoryLogMessageRenderer<long>(messageFactory,
            new LogMessageArgument<long>(argument, static x => x.ToString()));
    }

    #endregion

    #region CreateMessageProvider(ulong)

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ILogMessageRenderer CreateMessageProvider(string? message, ulong argument)
    {
        return new SingleArgumentMessageLogMessageRenderer<ulong>(message,
            new LogMessageArgument<ulong>(argument, static x => x.ToString()));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ILogMessageRenderer CreateMessageProvider(LogMessageFactory messageFactory, ulong argument)
    {
        return new SingleArgumentMessageFactoryLogMessageRenderer<ulong>(messageFactory,
            new LogMessageArgument<ulong>(argument, static x => x.ToString()));
    }

    #endregion

    #region CreateMessageProvider(BigInteger)

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ILogMessageRenderer CreateMessageProvider(string? message, BigInteger argument)
    {
        return new SingleArgumentMessageLogMessageRenderer<BigInteger>(message,
            new LogMessageArgument<BigInteger>(argument, static x => x.ToString()));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ILogMessageRenderer CreateMessageProvider(LogMessageFactory messageFactory, BigInteger argument)
    {
        return new SingleArgumentMessageFactoryLogMessageRenderer<BigInteger>(messageFactory,
            new LogMessageArgument<BigInteger>(argument, static x => x.ToString()));
    }

    #endregion

    #region CreateMessageProvider(float)

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ILogMessageRenderer CreateMessageProvider(string? message, float argument)
    {
        // ReSharper disable once SpecifyACultureInStringConversionExplicitly
        return new SingleArgumentMessageLogMessageRenderer<float>(message,
            new LogMessageArgument<float>(argument, static x => x.ToString()));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ILogMessageRenderer CreateMessageProvider(LogMessageFactory messageFactory, float argument)
    {
        // ReSharper disable once SpecifyACultureInStringConversionExplicitly
        return new SingleArgumentMessageFactoryLogMessageRenderer<float>(messageFactory,
            new LogMessageArgument<float>(argument, static x => x.ToString()));
    }

    #endregion

    #region CreateMessageProvider(double)

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ILogMessageRenderer CreateMessageProvider(string? message, double argument)
    {
        // ReSharper disable once SpecifyACultureInStringConversionExplicitly
        return new SingleArgumentMessageLogMessageRenderer<double>(message,
            new LogMessageArgument<double>(argument, static x => x.ToString()));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ILogMessageRenderer CreateMessageProvider(LogMessageFactory messageFactory, double argument)
    {
        // ReSharper disable once SpecifyACultureInStringConversionExplicitly
        return new SingleArgumentMessageFactoryLogMessageRenderer<double>(messageFactory,
            new LogMessageArgument<double>(argument, static x => x.ToString()));
    }

    #endregion

    #region CreateMessageProvider(decimal)

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ILogMessageRenderer CreateMessageProvider(string? message, decimal argument)
    {
        // ReSharper disable once SpecifyACultureInStringConversionExplicitly
        return new SingleArgumentMessageLogMessageRenderer<decimal>(message,
            new LogMessageArgument<decimal>(argument, static x => x.ToString()));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ILogMessageRenderer CreateMessageProvider(LogMessageFactory messageFactory, decimal argument)
    {
        // ReSharper disable once SpecifyACultureInStringConversionExplicitly
        return new SingleArgumentMessageFactoryLogMessageRenderer<decimal>(messageFactory,
            new LogMessageArgument<decimal>(argument, static x => x.ToString()));
    }

    #endregion

    #region CreateMessageProvider(Guid)

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ILogMessageRenderer CreateMessageProvider(string? message, Guid argument)
    {
        return new SingleArgumentMessageLogMessageRenderer<Guid>(message,
            new LogMessageArgument<Guid>(argument, static x => x.ToString()));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ILogMessageRenderer CreateMessageProvider(LogMessageFactory messageFactory, Guid argument)
    {
        return new SingleArgumentMessageFactoryLogMessageRenderer<Guid>(messageFactory,
            new LogMessageArgument<Guid>(argument, static x => x.ToString()));
    }

    #endregion

    #region CreateMessageProvider(TimeSpan)

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ILogMessageRenderer CreateMessageProvider(string? message, TimeSpan argument)
    {
        return new SingleArgumentMessageLogMessageRenderer<TimeSpan>(message,
            new LogMessageArgument<TimeSpan>(argument, static x => x.ToString()));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ILogMessageRenderer CreateMessageProvider(LogMessageFactory messageFactory, TimeSpan argument)
    {
        return new SingleArgumentMessageFactoryLogMessageRenderer<TimeSpan>(messageFactory,
            new LogMessageArgument<TimeSpan>(argument, static x => x.ToString()));
    }

    #endregion

    #region CreateMessageProvider(TimeOnly)

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ILogMessageRenderer CreateMessageProvider(string? message, TimeOnly argument)
    {
        return new SingleArgumentMessageLogMessageRenderer<TimeOnly>(message,
            new LogMessageArgument<TimeOnly>(argument, static x => x.ToString()));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ILogMessageRenderer CreateMessageProvider(LogMessageFactory messageFactory, TimeOnly argument)
    {
        return new SingleArgumentMessageFactoryLogMessageRenderer<TimeOnly>(messageFactory,
            new LogMessageArgument<TimeOnly>(argument, static x => x.ToString()));
    }

    #endregion

    #region CreateMessageProvider(DateTime)

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ILogMessageRenderer CreateMessageProvider(string? message, DateTime argument)
    {
        // ReSharper disable once SpecifyACultureInStringConversionExplicitly
        return new SingleArgumentMessageLogMessageRenderer<DateTime>(message,
            new LogMessageArgument<DateTime>(argument, static x => x.ToString()));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ILogMessageRenderer CreateMessageProvider(LogMessageFactory messageFactory, DateTime argument)
    {
        // ReSharper disable once SpecifyACultureInStringConversionExplicitly
        return new SingleArgumentMessageFactoryLogMessageRenderer<DateTime>(messageFactory,
            new LogMessageArgument<DateTime>(argument, static x => x.ToString()));
    }

    #endregion

    #region CreateMessageProvider(DateTimeOffset)

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ILogMessageRenderer CreateMessageProvider(string? message, DateTimeOffset argument)
    {
        return new SingleArgumentMessageLogMessageRenderer<DateTimeOffset>(message,
            new LogMessageArgument<DateTimeOffset>(argument, static x => x.ToString()));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ILogMessageRenderer CreateMessageProvider(LogMessageFactory messageFactory, DateTimeOffset argument)
    {
        return new SingleArgumentMessageFactoryLogMessageRenderer<DateTimeOffset>(messageFactory,
            new LogMessageArgument<DateTimeOffset>(argument, static x => x.ToString()));
    }

    #endregion

    #region CreateMessageProvider(DateOnly)

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ILogMessageRenderer CreateMessageProvider(string? message, DateOnly argument)
    {
        return new SingleArgumentMessageLogMessageRenderer<DateOnly>(message,
            new LogMessageArgument<DateOnly>(argument, static x => x.ToString()));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ILogMessageRenderer CreateMessageProvider(LogMessageFactory messageFactory, DateOnly argument)
    {
        return new SingleArgumentMessageFactoryLogMessageRenderer<DateOnly>(messageFactory,
            new LogMessageArgument<DateOnly>(argument, static x => x.ToString()));
    }

    #endregion

    #region CreateMessageProvider(byte)

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ILogMessageRenderer CreateMessageProvider(string? message, byte argument)
    {
        return new SingleArgumentMessageLogMessageRenderer<byte>(message,
            new LogMessageArgument<byte>(argument, static x => x.ToString()));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ILogMessageRenderer CreateMessageProvider(LogMessageFactory messageFactory, byte argument)
    {
        return new SingleArgumentMessageFactoryLogMessageRenderer<byte>(messageFactory,
            new LogMessageArgument<byte>(argument, static x => x.ToString()));
    }

    #endregion

    #region CreateMessageProvider(sbyte)

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ILogMessageRenderer CreateMessageProvider(string? message, sbyte argument)
    {
        return new SingleArgumentMessageLogMessageRenderer<sbyte>(message,
            new LogMessageArgument<sbyte>(argument, static x => x.ToString()));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ILogMessageRenderer CreateMessageProvider(LogMessageFactory messageFactory, sbyte argument)
    {
        return new SingleArgumentMessageFactoryLogMessageRenderer<sbyte>(messageFactory,
            new LogMessageArgument<sbyte>(argument, static x => x.ToString()));
    }

    #endregion

    #region CreateMessageProvider(char)

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ILogMessageRenderer CreateMessageProvider(string? message, char argument)
    {
        return new SingleArgumentMessageLogMessageRenderer<char>(message,
            new LogMessageArgument<char>(argument, static x => x.ToString()));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ILogMessageRenderer CreateMessageProvider(LogMessageFactory messageFactory, char argument)
    {
        return new SingleArgumentMessageFactoryLogMessageRenderer<char>(messageFactory,
            new LogMessageArgument<char>(argument, static x => x.ToString()));
    }

    #endregion
}
