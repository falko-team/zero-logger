using System.Buffers;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Logging.Interpolators;

internal static class LogMessageArgumentsInterpolator
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string? Interpolate(string? message,
        string? argument)
    {
        if (message is null) return null;

        const int argumentCount = 1;

        var arrays = ArrayPool<string?>.Shared;

        var arguments = arrays.Rent(argumentCount);

        ref var argumentsRef = ref MemoryMarshal.GetArrayDataReference(arguments);

        Unsafe.Add(ref argumentsRef, 0) = argument;

        message = Interpolate(message, ref argumentsRef, argumentCount);
        message = InterpolateCore(message, ref argumentsRef, argumentCount);

        Unsafe.Add(ref argumentsRef, 0) = null;

        arrays.Return(arguments);

        return message;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string? Interpolate(string? message,
        string? argument1,
        string? argument2)
    {
        if (message is null) return null;

        const int argumentCount = 2;

        var arrays = ArrayPool<string?>.Shared;

        var arguments = arrays.Rent(argumentCount);

        ref var argumentsRef = ref MemoryMarshal.GetArrayDataReference(arguments);

        Unsafe.Add(ref argumentsRef, 0) = argument1;
        Unsafe.Add(ref argumentsRef, 1) = argument2;

        message = InterpolateCore(message, ref argumentsRef, argumentCount);

        Unsafe.Add(ref argumentsRef, 0) = null;
        Unsafe.Add(ref argumentsRef, 1) = null;

        arrays.Return(arguments);

        return message;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string? Interpolate(string? message,
        string? argument1,
        string? argument2,
        string? argument3)
    {
        if (message is null) return null;

        const int argumentCount = 3;

        var arrays = ArrayPool<string?>.Shared;

        var arguments = arrays.Rent(argumentCount);

        ref var argumentsRef = ref MemoryMarshal.GetArrayDataReference(arguments);

        Unsafe.Add(ref argumentsRef, 0) = argument1;
        Unsafe.Add(ref argumentsRef, 1) = argument2;
        Unsafe.Add(ref argumentsRef, 2) = argument3;

        message = InterpolateCore(message, ref argumentsRef, argumentCount);

        Unsafe.Add(ref argumentsRef, 0) = null;
        Unsafe.Add(ref argumentsRef, 1) = null;
        Unsafe.Add(ref argumentsRef, 2) = null;

        arrays.Return(arguments);

        return message;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string? Interpolate(string? message,
        string? argument1,
        string? argument2,
        string? argument3,
        string? argument4)
    {
        if (message is null) return null;

        const int argumentCount = 4;

        var arrays = ArrayPool<string?>.Shared;

        var arguments = arrays.Rent(argumentCount);

        ref var argumentsRef = ref MemoryMarshal.GetArrayDataReference(arguments);

        Unsafe.Add(ref argumentsRef, 0) = argument1;
        Unsafe.Add(ref argumentsRef, 1) = argument2;
        Unsafe.Add(ref argumentsRef, 2) = argument3;
        Unsafe.Add(ref argumentsRef, 3) = argument4;

        message = InterpolateCore(message, ref argumentsRef, argumentCount);

        Unsafe.Add(ref argumentsRef, 0) = null;
        Unsafe.Add(ref argumentsRef, 1) = null;
        Unsafe.Add(ref argumentsRef, 2) = null;
        Unsafe.Add(ref argumentsRef, 3) = null;
        Unsafe.Add(ref argumentsRef, 4) = null;

        arrays.Return(arguments);

        return message;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string? Interpolate(string? message, ref string? arguments, int count)
    {
        if (message is null) return null;

        return InterpolateCore(message, ref arguments, count);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string? InterpolateCore(string message, ref string? arguments, int count)
    {
        return message;
    }
}
