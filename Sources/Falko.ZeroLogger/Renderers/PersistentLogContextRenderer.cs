using System.Logging.Contexts;

namespace System.Logging.Renderers;

internal sealed class PersistentLogContextRenderer(ILogContextRenderer renderer) : ILogContextRenderer
{
    private string? _message;

    public string Render(in LogContext logContext)
    {
        if (_message is not null) return _message;

        var message = renderer.Render(logContext);
        _message = message;
        return message;
    }
}
