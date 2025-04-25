using System.Buffers;
using System.Logging.Factories;
using System.Logging.Interpolators;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Logging.Providers;

internal sealed class ManyInstanceArgumentsMessageFactoryLogMessageProvider
(
    LogMessageFactory messageFactory,
    object?[] argumentObjects
) : PersistentLogMessageProvider
{
    protected override string? CreateString()
    {
        var argumentObjectsLength = argumentObjects.Length;

        var arrays = ArrayPool<string?>.Shared;
        var arguments = arrays.Rent(argumentObjectsLength);

        ref var argumentsRef = ref MemoryMarshal.GetArrayDataReference(arguments);
        ref var argumentFactoriesRef = ref MemoryMarshal.GetArrayDataReference(argumentObjects);

        for (var i = 0; i < argumentObjectsLength; i++)
        {
            Unsafe.Add(ref argumentsRef, i) = Unsafe.Add(ref argumentFactoriesRef, i)?.ToString();
        }

        var interpolatedMessage = LogMessageArgumentsInterpolator.Interpolate(messageFactory(),
            ref argumentsRef, argumentObjectsLength);

        arrays.Return(arguments);

        return interpolatedMessage;
    }
}
