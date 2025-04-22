namespace System.Logging;

public readonly ref struct LogContext(string source, LogLevel level, DateTimeOffset time, string? message)
{
    public string Source => source;

    public LogLevel Level => level;

    public DateTimeOffset Time => time;

    public string? Message => message;

    public Exception? Exception { get; init; }
}
