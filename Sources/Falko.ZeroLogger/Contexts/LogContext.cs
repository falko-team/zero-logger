using System.Logging.Logs;
using System.Logging.Providers;

namespace System.Logging.Contexts;

public readonly ref struct LogContext(string source, LogLevel level, DateTimeOffset time, LogMessageProvider message)
{
    public string Source => source;

    public LogLevel Level => level;

    public DateTimeOffset Time => time;

    public LogMessageProvider Message => message;

    public Exception? Exception { get; init; }
}
