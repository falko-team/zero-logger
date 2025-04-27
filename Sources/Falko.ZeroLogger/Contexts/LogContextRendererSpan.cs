using System.Logging.Renderers;

namespace System.Logging.Contexts;

internal readonly struct LogContextRendererSpan(ILogContextRenderer renderer, int count)
{
    public readonly ILogContextRenderer Renderer = renderer;

    public readonly int Count = count;
}
