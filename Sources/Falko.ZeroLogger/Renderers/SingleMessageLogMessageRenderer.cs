namespace System.Logging.Renderers;

internal sealed class SingleMessageLogMessageRenderer(string? message) : ILogMessageRenderer
{
    public string Render()
    {
        return message ?? string.Empty;
    }
}
