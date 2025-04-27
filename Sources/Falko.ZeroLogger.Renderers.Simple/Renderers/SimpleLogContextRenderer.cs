using System.Logging.Builders;
using System.Logging.Contexts;
using System.Logging.Logs;
using System.Numerics;

namespace System.Logging.Renderers;

public sealed class SimpleLogContextRenderer : ILogContextRenderer
{
    public static readonly SimpleLogContextRenderer Instance = new();

    private static readonly string[] Levels =
    [
        "Trc",
        "Dbg",
        "Inf",
        "Wrn",
        "Err",
        "Ftl"
    ];

    private SimpleLogContextRenderer() { }

    public string Render(in LogContext logContext)
    {
        var dateText = logContext.Time.DateTime.ToShortTimeString();
        var dateBlockLength = dateText.Length + 3;

        var levelText = FormatLevel(logContext.Level);
        const int levelBlockLength = 6;

        var sourceText = logContext.Source;
        var sourceBlockLength = sourceText.Length + 3;

        var messageText = logContext.Message.Render();

        var newLineText = Environment.NewLine;
        var newLineTextLength = newLineText.Length;

        var messageLength = messageText.Length + dateBlockLength + levelBlockLength + sourceBlockLength + newLineTextLength;

        var exception = logContext.Exception;

        if (exception is null)
        {
            using scoped var messageBuilder = messageLength > 256
                ? new ValueStringBuilder(messageLength)
                : new ValueStringBuilder(stackalloc char[messageLength]);

            messageBuilder.Append('[');
            messageBuilder.Append(dateText);
            messageBuilder.Append(']');
            messageBuilder.Append(' ');

            messageBuilder.Append('[');
            messageBuilder.Append(levelText);
            messageBuilder.Append(']');
            messageBuilder.Append(' ');

            messageBuilder.Append('[');
            messageBuilder.Append(sourceText);
            messageBuilder.Append(']');
            messageBuilder.Append(' ');

            messageBuilder.Append(messageText);

            messageBuilder.Append(newLineText);

            return messageBuilder.ToString();
        }
        else
        {
            var exceptionTypeName = exception.GetType().FullName;
            var exceptionTypeBlockName = "  Exception: ";
            var exceptionTypeBlockLength = exceptionTypeName is null
                ? 0
                : exceptionTypeName.Length + exceptionTypeBlockName.Length + newLineTextLength;

            var exceptionMessage = exception.Message;
            var exceptionMessageBlockName = "  Message: ";
            var exceptionMessageBlockLength = string.IsNullOrEmpty(exceptionMessage)
                ? 0
                : exceptionMessage.Length + exceptionMessageBlockName.Length + newLineTextLength;

            var exceptionStackTrace = exception.StackTrace;
            var exceptionStackTraceBlockName = "  Trace:";
            var exceptionStackTraceBlockLength = exceptionStackTrace is null
                ? 0
                : exceptionStackTrace.Length + exceptionStackTraceBlockName.Length + newLineTextLength * 2;

            messageLength += exceptionStackTraceBlockLength + exceptionMessageBlockLength + exceptionStackTraceBlockLength;

            using scoped var messageBuilder = messageLength > 256
                ? new ValueStringBuilder(messageLength)
                : new ValueStringBuilder(stackalloc char[messageLength]);

            messageBuilder.Append('[');
            messageBuilder.Append(dateText);
            messageBuilder.Append(']');
            messageBuilder.Append(' ');

            messageBuilder.Append('[');
            messageBuilder.Append(levelText);
            messageBuilder.Append(']');
            messageBuilder.Append(' ');

            messageBuilder.Append('[');
            messageBuilder.Append(sourceText);
            messageBuilder.Append(']');
            messageBuilder.Append(' ');

            messageBuilder.Append(messageText);

            messageBuilder.Append(newLineText);

            if (exceptionTypeBlockLength is not 0)
            {
                messageBuilder.Append(exceptionTypeBlockName);
                messageBuilder.Append(exceptionTypeName);
                messageBuilder.Append(newLineText);
            }

            if (exceptionMessageBlockLength is not 0)
            {
                messageBuilder.Append(exceptionMessageBlockName);
                messageBuilder.Append(exceptionMessage);
                messageBuilder.Append(newLineText);
            }

            if (exceptionStackTraceBlockLength is not 0)
            {
                messageBuilder.Append(exceptionStackTraceBlockName);
                messageBuilder.Append(newLineText);
                messageBuilder.Append(exceptionStackTrace);
                messageBuilder.Append(newLineText);
            }

            return messageBuilder.ToString();
        }
    }

    public static string FormatLevel(LogLevel level)
    {
        var index = BitOperations.TrailingZeroCount((int)level);

        return (uint)index < Levels.Length ? Levels[index] : "???";
    }
}
