using System.Logging.Factories;
using System.Logging.Utils;

namespace System.Logging.Renderers;

internal sealed class ThreeFactoryArgumentsMessageFactoryLogMessageRenderer
(
    LogMessageFactory messageFactory,
    LogMessageArgumentFactory argumentFactory1,
    LogMessageArgumentFactory argumentFactory2,
    LogMessageArgumentFactory argumentFactory3
) : PersistentLogMessageRenderer
{
    protected override string RenderCore()
    {
        return LogMessageArgumentsInterpolationUtils.Interpolate(messageFactory(),
            argumentFactory1(),
            argumentFactory2(),
            argumentFactory3());
    }
}
