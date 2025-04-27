using System.Logging.Factories;
using System.Logging.Utils;

namespace System.Logging.Renderers;

internal sealed class TwoInstanceArgumentsMessageFactoryLogMessageRenderer<T1, T2>
(
    LogMessageFactory messageFactory,
    T1 argument1,
    T2 argument2
) : PersistentLogMessageRenderer
{
    protected override string RenderCore()
    {
        return LogMessageArgumentsInterpolationUtils.Interpolate(messageFactory(),
            argument1?.ToString(),
            argument2?.ToString());
    }
}
