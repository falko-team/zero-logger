using System.Logging.Factories;
using System.Logging.Interpolators;
using System.Runtime.InteropServices;

namespace System.Logging.Providers;

internal sealed class ManyStringArgumentsMessageFactoryLogMessageProvider
(
    LogMessageFactory messageFactory,
    string?[] arguments
) : PersistentLogMessageProvider
{
    protected override string? CreateString()
    {
        return LogMessageArgumentsInterpolator.Interpolate(messageFactory(),
            ref MemoryMarshal.GetArrayDataReference(arguments), arguments.Length);
    }
}
