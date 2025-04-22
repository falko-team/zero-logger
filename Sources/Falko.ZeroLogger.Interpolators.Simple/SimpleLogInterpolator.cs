using System.Text;

namespace System.Logging;

public sealed class SimpleLogInterpolator : ILogInterpolator
{
    public static readonly SimpleLogInterpolator Instance = new();

    private SimpleLogInterpolator() { }

    public void Interpolate(in LogContext logContext, StringBuilder logBuilder)
    {
        AppendBlock(logBuilder, logContext.Time.DateTime.ToShortTimeString());
        AppendBlock(logBuilder, logContext.Level.ToString());

        var source = logContext.Source.AsSpan();

        var dotIndex = source.LastIndexOf('.');

        if (dotIndex != -1) source = source[(dotIndex + 1)..];

        AppendBlock(logBuilder, new string(source));

        logBuilder.Append(logContext.Message);

        TryAppendError(logBuilder, logContext.Exception);
    }

    private static void TryAppendError(StringBuilder logBuilder, Exception? exception)
    {
        if (exception is null) return;

        logBuilder.AppendLine();

        AppendTrace(logBuilder, "Type", exception.GetType().FullName);
        AppendTrace(logBuilder, "Message", exception.Message);
        AppendTrace(logBuilder, "Source", exception.Source);
        AppendTrace(logBuilder, "StackTrace", exception.StackTrace);
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
        logBuilder.AppendLine();
    }
}
