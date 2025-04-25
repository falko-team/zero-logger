using System.Logging.Interpolators;
using System.Runtime.InteropServices;

namespace System.Logging.Providers;

internal sealed class ManyStringArgumentsMessageLogMessageProvider
(
    string? message,
    string?[] arguments
) : PersistentLogMessageProvider
{
    protected override string? CreateString()
    {
        return LogMessageArgumentsInterpolator.Interpolate(message,
            ref MemoryMarshal.GetArrayDataReference(arguments), arguments.Length);
    }
}
