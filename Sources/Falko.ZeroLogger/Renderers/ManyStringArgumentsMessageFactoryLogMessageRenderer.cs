using System.Logging.Factories;
using System.Logging.Utils;
using System.Runtime.InteropServices;

namespace System.Logging.Renderers;

internal sealed class ManyStringArgumentsMessageFactoryLogMessageRenderer
(
    LogMessageFactory messageFactory,
    string?[] arguments
) : PersistentLogMessageRenderer
{
    protected override string RenderCore()
    {
        return MessageArgumentsInterpolationUtils.Interpolate(messageFactory(),
            ref MemoryMarshal.GetArrayDataReference(arguments), arguments.Length);
    }
}
