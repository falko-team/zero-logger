using System.Logging.Builders;
using System.Logging.Contexts;
using System.Logging.Logs;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace System.Logging.Renderers;

public sealed class SimpleLogContextRenderer : ILogContextRenderer
{
    public static readonly SimpleLogContextRenderer Instance = new();

    private static readonly string[] LevelShortNames =
    [
        "Trc",
        "Dbg",
        "Inf",
        "Wrn",
        "Err",
        "Ftl"
    ];

    private static readonly string NewLine = Environment.NewLine;
    private static readonly int NewLineLength = NewLine.Length;

    private const string UnknownException = "UnknownException";

    private const string ExceptionTypeBlockName = "Exception: ";
    private static readonly int ExceptionTypeBlockNameLength = ExceptionTypeBlockName.Length;

    private const string ExceptionMessageBlockName = "Message: ";
    private static readonly int ExceptionMessageBlockNameLength = ExceptionMessageBlockName.Length;

    private static readonly string ExceptionStackTraceBlockName = $"Trace:{NewLine}";
    private static readonly int ExceptionStackTraceBlockNameLength = ExceptionStackTraceBlockName.Length;

    private const int ExceptionBlockPadding = 2;

    private const int BlockMinimumLength = 3;

    private SimpleLogContextRenderer() { }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string Render(in LogContext logContext)
    {
        var dateText = logContext.Time.DateTime.ToShortTimeString();

        var levelText = FormatLevel(logContext.Level);
        const int levelTextBlockLength = 3 + BlockMinimumLength;

        var sourceText = logContext.Source;

        var messageText = logContext.Message.Render();

        var messageLength = messageText.Length
            + GetHeaderBlockLength(dateText)
            + levelTextBlockLength
            + GetHeaderBlockLength(sourceText)
            + NewLineLength;

        var exception = logContext.Exception;

        if (exception is null)
        {
            scoped var messageBuilder = messageLength > 256
                ? new ValueStringBuilder(messageLength)
                : new ValueStringBuilder(stackalloc char[messageLength]);

            try
            {
                RenderHeader(ref messageBuilder, dateText, levelText, sourceText, messageText);

                return messageBuilder.ToString();
            }
            finally
            {
                messageBuilder.Dispose();
            }
        }
        else
        {
            var exceptionTypeName = exception.GetType().FullName ?? UnknownException;

            var exceptionMessage = exception.Message;

            var exceptionStackTrace = exception.StackTrace;
            var exceptionStackTraceBlockLength = exceptionStackTrace is not null
                ? GetExceptionBlockLength(ExceptionStackTraceBlockNameLength, exceptionStackTrace)
                : 0;

            messageLength = messageLength
                + GetExceptionBlockLength(ExceptionTypeBlockNameLength, exceptionTypeName)
                + GetExceptionBlockLength(ExceptionMessageBlockNameLength, exceptionMessage)
                + exceptionStackTraceBlockLength
                + NewLineLength;

            scoped var messageBuilder = messageLength > 256
                ? new ValueStringBuilder(messageLength)
                : new ValueStringBuilder(stackalloc char[messageLength]);

            try
            {
                RenderHeader(ref messageBuilder, dateText, levelText, sourceText, messageText);

                RenderExceptionBlock(ref messageBuilder, ExceptionTypeBlockName, exceptionTypeName);
                RenderExceptionBlock(ref messageBuilder, ExceptionMessageBlockName, exceptionMessage);

                if (exceptionStackTraceBlockLength is not 0)
                {
                    RenderExceptionBlock(ref messageBuilder, ExceptionStackTraceBlockName, exceptionStackTrace!);
                }

                messageBuilder.Append(NewLine);

                return messageBuilder.ToString();
            }
            finally
            {
                messageBuilder.Dispose();
            }
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static void RenderHeader(scoped ref ValueStringBuilder messageBuilder,
        string dateText,
        string levelText,
        string sourceText,
        string messageText)
    {
        RenderHeaderBlock(ref messageBuilder, dateText);
        RenderHeaderBlock(ref messageBuilder, levelText);
        RenderHeaderBlock(ref messageBuilder, sourceText);

        messageBuilder.Append(messageText);

        messageBuilder.Append(NewLine);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static int GetHeaderBlockLength(string blockText)
    {
        return blockText.Length + BlockMinimumLength;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static void RenderHeaderBlock(scoped ref ValueStringBuilder messageBuilder,
        string blockText)
    {
        messageBuilder.Append('[');
        messageBuilder.Append(blockText);
        messageBuilder.Append(']');
        messageBuilder.Append(' ');
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static int GetExceptionBlockLength(int blockNameLength, string blockText)
    {
        return ExceptionBlockPadding + blockNameLength + blockText.Length + NewLineLength;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static void RenderExceptionBlock(scoped ref ValueStringBuilder messageBuilder,
        string blockName,
        string blockText)
    {
        messageBuilder.Append(' ', ExceptionBlockPadding);
        messageBuilder.Append(blockName);
        messageBuilder.Append(blockText);
        messageBuilder.Append(NewLine);
    }

    private static string FormatLevel(LogLevel level)
    {
        var index = BitOperations.TrailingZeroCount((int)level);

        return LevelShortNames[index];
    }
}
