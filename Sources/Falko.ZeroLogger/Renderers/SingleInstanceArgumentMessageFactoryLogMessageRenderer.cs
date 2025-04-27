using System.Logging.Factories;
using System.Logging.Utils;

namespace System.Logging.Renderers;

internal sealed class SingleInstanceArgumentMessageFactoryLogMessageRenderer<T>
(
    LogMessageFactory messageFactory,
    T argument
) : PersistentLogMessageRenderer
{
    protected override string RenderCore()
    {
        return LogMessageArgumentsInterpolationUtils.Interpolate(messageFactory(),
            argument?.ToString());
    }
}
