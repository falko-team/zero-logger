using System.Logging.Contexts;
using System.Text;

namespace System.Logging.Interpolators;

public interface ILogInterpolator
{
    void Interpolate(in LogContext logContext, StringBuilder logBuilder);
}
