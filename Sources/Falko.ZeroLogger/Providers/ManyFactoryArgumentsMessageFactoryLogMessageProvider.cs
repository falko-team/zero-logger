using System.Buffers;
using System.Logging.Factories;
using System.Logging.Interpolators;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Logging.Providers;

internal sealed class ManyFactoryArgumentsMessageFactoryLogMessageProvider
(
    LogMessageFactory messageFactory,
    LogMessageArgumentFactory[] argumentFactories
) : PersistentLogMessageProvider
{
    protected override string? CreateString()
    {
        var argumentFactoriesLength = argumentFactories.Length;

        var arrays = ArrayPool<string?>.Shared;
        var arguments = arrays.Rent(argumentFactoriesLength);

        ref var argumentsRef = ref MemoryMarshal.GetArrayDataReference(arguments);
        ref var argumentFactoriesRef = ref MemoryMarshal.GetArrayDataReference(argumentFactories);

        for (var i = 0; i < argumentFactoriesLength; i++)
        {
            Unsafe.Add(ref argumentsRef, i) = Unsafe.Add(ref argumentFactoriesRef, i)();
        }

        var interpolatedMessage = LogMessageArgumentsInterpolator.Interpolate(messageFactory(),
            ref argumentsRef, argumentFactoriesLength);

        arrays.Return(arguments);

        return interpolatedMessage;
    }
}
