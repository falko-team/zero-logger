using System.Buffers;
using System.Logging.Factories;
using System.Logging.Utils;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Logging.Renderers;

internal sealed class ManyInstanceArgumentsMessageFactoryLogMessageRenderer
(
    LogMessageFactory messageFactory,
    object?[] argumentObjects
) : PersistentLogMessageRenderer
{
    protected override string RenderCore()
    {
        var argumentObjectsLength = argumentObjects.Length;

        var arrays = ArrayPool<string?>.Shared;
        var arguments = arrays.Rent(argumentObjectsLength);

        scoped ref var argumentsRef = ref MemoryMarshal.GetArrayDataReference(arguments);
        scoped ref var argumentFactoriesRef = ref MemoryMarshal.GetArrayDataReference(argumentObjects);

        for (var i = 0; i < argumentObjectsLength; i++)
        {
            Unsafe.Add(ref argumentsRef, i) = Unsafe.Add(ref argumentFactoriesRef, i)?.ToString();
        }

        var interpolatedMessage = LogMessageArgumentsInterpolationUtils.Interpolate(messageFactory(),
            ref argumentsRef, argumentObjectsLength);

        arrays.Return(arguments);

        return interpolatedMessage;
    }
}
