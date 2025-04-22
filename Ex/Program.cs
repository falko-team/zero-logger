using System.Globalization;
using System.Text;
using Falko.Logging;

DebugEventLogger.Event += (exception, message) =>
{
    if (exception is not null)
    {
        Console.WriteLine($"Exception: {exception.Message}");
        Console.WriteLine($"StackTrace: {exception.StackTrace}");
    }

    if (message is not null)
    {
        Console.WriteLine($"Message: {message}");
    }
};

LoggerRuntime.Initialize(new ConsoleLoggerTarget());

try
{
    var logger = LoggerFactory.CreateLoggerOfType<Program>();

    logger.Info(static () => "Hello, !");
    logger.Trace("Hello, {0}!", "World");
    logger.Info("Hello, {0}!", "World", 12);
    logger.Info("Hello, {0}!", "World", "!", "!!");
    logger.Warn("Hello, {0}!", "World", '!', "!!", "!");

    try
    {
        throw new Exception("Test exception");
    }
    catch (Exception e)
    {
        logger.Fatal(e, "Hello, {0}!", "World");
    }
}
catch (Exception ex)
{
    DebugEventLogger.Notify(ex);
}
finally
{
    LoggerRuntime.Dispose();
}

file sealed class ConsoleLoggerTarget : LoggerTarget
{
    private readonly Lock _locker = new();

    private readonly StringBuilder _builder = new();

    public override void Initialize(CancellationToken cancellationToken) { }

    public override void Publish(in LogContext context, CancellationToken cancellationToken)
    {
        lock (_locker)
        {
            var exception = context.Exception;

            var message = context.Message;

            if (message is null && exception is null) return;

            _builder.Clear();

            _builder.Append('[');
            _builder.Append(context.Time.LocalDateTime.ToString(DateTimeFormatInfo.InvariantInfo));
            _builder.Append("] [");
            _builder.Append(context.Level.ToString());
            _builder.Append("] [");
            _builder.Append(context.Name);
            _builder.Append("] ");

            var argumentIndex = 0;
            var isSymbol = false;

            foreach (var symbol in message)
            {
                if (isSymbol)
                {
                    if (symbol is '}') isSymbol = false;

                    continue;
                }

                if (symbol is '{')
                {
                    _builder.Append(context.Arguments[argumentIndex++]);
                    isSymbol = true;
                }
                else
                {
                    _builder.Append(symbol);
                }
            }

            if (exception is not null)
            {
                _builder.AppendLine();
                _builder.Append("    ");
                _builder.Append(exception.Message);
                _builder.AppendLine();
                _builder.Append("        ");
                _builder.Append(exception.StackTrace);
            }

            Console.WriteLine(_builder.ToString());
        }
    }

    public override void Dispose(CancellationToken cancellationToken) { }
}
