using System.Logging.Contexts;
using System.Text;

namespace System.Logging.Interpolators;

public sealed class SimpleLogInterpolator : ILogInterpolator
{
    public static readonly SimpleLogInterpolator Instance = new();

    private SimpleLogInterpolator() { }

    public void Interpolate(in LogContext logContext, StringBuilder logBuilder)
    {
        AppendBlock(logBuilder, logContext.Time.DateTime.ToShortTimeString());
        AppendBlock(logBuilder, logContext.Level.ToString());

        AppendBlock(logBuilder, logContext.Source);

        logBuilder.Append(logContext.Message.GetString());

        TryAppendError(logBuilder, logContext.Exception);
    }

    private static void TryAppendError(StringBuilder logBuilder, Exception? exception)
    {
        if (exception is null) return;

        logBuilder.AppendLine();

        AppendTrace(logBuilder, "Type", exception.GetType().FullName);
        logBuilder.AppendLine();
        AppendTrace(logBuilder, "Message", exception.Message);
        logBuilder.AppendLine();
        AppendTrace(logBuilder, "StackTrace", " ");
        if (exception.StackTrace is not null)
        {
            logBuilder.AppendLine();
            logBuilder.Append(exception.StackTrace);
        }
    }

    private static void AppendBlock(StringBuilder logBuilder, string text)
    {
        if (string.IsNullOrEmpty(text)) return;

        logBuilder.Append('[');
        logBuilder.Append(text);
        logBuilder.Append(']');
        logBuilder.Append(' ');
    }

    private static void AppendTrace(StringBuilder logBuilder, string name, string? text)
    {
        if (string.IsNullOrEmpty(text)) return;

        logBuilder.Append("  ");
        logBuilder.Append(name);
        logBuilder.Append(": ");
        logBuilder.Append(text);
    }
}
