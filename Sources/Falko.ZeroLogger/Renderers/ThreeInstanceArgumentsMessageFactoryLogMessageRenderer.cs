using System.Logging.Factories;
using System.Logging.Utils;

namespace System.Logging.Renderers;

internal sealed class ThreeInstanceArgumentsMessageFactoryLogMessageRenderer<T1, T2, T3>
(
    LogMessageFactory messageFactory,
    T1 argument1,
    T2 argument2,
    T3 argument3
) : PersistentLogMessageRenderer
{
    protected override string RenderCore()
    {
        return MessageArgumentsInterpolationUtils.Interpolate(messageFactory(),
            argument1?.ToString(),
            argument2?.ToString(),
            argument3?.ToString());
    }
}
