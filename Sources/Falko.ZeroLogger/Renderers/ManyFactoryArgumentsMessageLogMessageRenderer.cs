using System.Buffers;
using System.Logging.Factories;
using System.Logging.Utils;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Logging.Renderers;

internal sealed class ManyFactoryArgumentsMessageLogMessageRenderer
(
    string? message,
    LogMessageArgumentFactory[] argumentFactories
) : PersistentLogMessageRenderer
{
    protected override string RenderCore()
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

        var interpolatedMessage = LogMessageArgumentsInterpolationUtils.Interpolate(message,
            ref argumentsRef, argumentFactoriesLength);

        arrays.Return(arguments);

        return interpolatedMessage;
    }
}
