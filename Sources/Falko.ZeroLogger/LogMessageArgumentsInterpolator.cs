using System.Runtime.CompilerServices;

namespace System.Logging;

internal static class LogMessageArgumentsInterpolator
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string? Interpolate(string? message,
        string? argument)
    {
        return message is not null
            ? string.Format(message, argument)
            : null;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string? Interpolate(string? message,
        string? argument1,
        string? argument2)
    {
        return message is not null
            ? string.Format(message, argument1, argument2)
            : null;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string? Interpolate(string? message,
        string? argument1,
        string? argument2,
        string? argument3)
    {
        return message is not null
            ? string.Format(message, argument1, argument2, argument3)
            : null;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string? Interpolate(string? message,
        string? argument1,
        string? argument2,
        string? argument3,
        string? argument4)
    {
        return message is not null
            ? string.Format(message, argument1, argument2, argument3, argument4)
            : null;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string? Interpolate(string? message,
        string? argument1,
        string? argument2,
        string? argument3,
        string? argument4,
        string? argument5)
    {
        return message is not null
            ? string.Format(message, argument1, argument2, argument3, argument4, argument5)
            : null;
    }
}
