using System.Buffers;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Logging;

internal static class LogMessageArgumentsPool
{
    private static readonly ArrayPool<string?> Arrays = ArrayPool<string?>.Create(5, 1000);

    #region Reserve

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string?[] ReserveOne(string? argument)
    {
        var arguments = Arrays.Rent(1);

        arguments[0] = argument;

        return arguments;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string?[] ReserveTwo(string? argument1, string? argument2)
    {
        var arguments = Arrays.Rent(2);

        ref var argumentsRef = ref MemoryMarshal.GetArrayDataReference(arguments);

        Unsafe.Add(ref argumentsRef, 0) = argument1;
        Unsafe.Add(ref argumentsRef, 1) = argument2;

        return arguments;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string?[] ReserveThree(string? argument1, string? argument2, string? argument3)
    {
        var arguments = Arrays.Rent(3);

        ref var argumentsRef = ref MemoryMarshal.GetArrayDataReference(arguments);

        Unsafe.Add(ref argumentsRef, 0) = argument1;
        Unsafe.Add(ref argumentsRef, 1) = argument2;
        Unsafe.Add(ref argumentsRef, 2) = argument3;

        return arguments;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string?[] ReserveFour(string? argument1, string? argument2, string? argument3, string? argument4)
    {
        var arguments = Arrays.Rent(4);

        ref var argumentsRef = ref MemoryMarshal.GetArrayDataReference(arguments);

        Unsafe.Add(ref argumentsRef, 0) = argument1;
        Unsafe.Add(ref argumentsRef, 1) = argument2;
        Unsafe.Add(ref argumentsRef, 2) = argument3;
        Unsafe.Add(ref argumentsRef, 3) = argument4;

        return arguments;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string?[] ReserveFive(string? argument1, string? argument2, string? argument3, string? argument4, string? argument5)
    {
        var arguments = Arrays.Rent(5);

        ref var argumentsRef = ref MemoryMarshal.GetArrayDataReference(arguments);

        Unsafe.Add(ref argumentsRef, 0) = argument1;
        Unsafe.Add(ref argumentsRef, 1) = argument2;
        Unsafe.Add(ref argumentsRef, 2) = argument3;
        Unsafe.Add(ref argumentsRef, 3) = argument4;
        Unsafe.Add(ref argumentsRef, 4) = argument5;

        return arguments;
    }


    #endregion

    #region Return

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void ReturnOne(string?[] arguments)
    {
        arguments[0] = null;

        Arrays.Return(arguments);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void ReturnTwo(string?[] arguments)
    {
        ref var argumentsRef = ref MemoryMarshal.GetArrayDataReference(arguments);

        Unsafe.Add(ref argumentsRef, 0) = null;
        Unsafe.Add(ref argumentsRef, 1) = null;

        Arrays.Return(arguments);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void ReturnThree(string?[] arguments)
    {
        ref var argumentsRef = ref MemoryMarshal.GetArrayDataReference(arguments);

        Unsafe.Add(ref argumentsRef, 0) = null;
        Unsafe.Add(ref argumentsRef, 1) = null;
        Unsafe.Add(ref argumentsRef, 2) = null;

        Arrays.Return(arguments);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void ReturnFour(string?[] arguments)
    {
        ref var argumentsRef = ref MemoryMarshal.GetArrayDataReference(arguments);

        Unsafe.Add(ref argumentsRef, 0) = null;
        Unsafe.Add(ref argumentsRef, 1) = null;
        Unsafe.Add(ref argumentsRef, 2) = null;
        Unsafe.Add(ref argumentsRef, 3) = null;

        Arrays.Return(arguments);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void ReturnFive(string?[] arguments)
    {
        ref var argumentsRef = ref MemoryMarshal.GetArrayDataReference(arguments);

        Unsafe.Add(ref argumentsRef, 0) = null;
        Unsafe.Add(ref argumentsRef, 1) = null;
        Unsafe.Add(ref argumentsRef, 2) = null;
        Unsafe.Add(ref argumentsRef, 3) = null;
        Unsafe.Add(ref argumentsRef, 4) = null;

        Arrays.Return(arguments);
    }

    #endregion
}
