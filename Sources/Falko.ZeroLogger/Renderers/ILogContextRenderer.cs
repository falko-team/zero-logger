using System.Logging.Contexts;

namespace System.Logging.Renderers;

public interface ILogContextRenderer
{
    string Render(in LogContext logContext);
}
