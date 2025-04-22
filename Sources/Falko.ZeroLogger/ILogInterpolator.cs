using System.Text;

namespace System.Logging;

public interface ILogInterpolator
{
    void Interpolate(in LogContext logContext, StringBuilder logBuilder);
}
