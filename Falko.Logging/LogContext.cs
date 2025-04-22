namespace Falko.Logging;

public readonly ref struct LogContext(string name, LogLevel level, DateTimeOffset time)
{
    public string Name => name;

    public LogLevel Level => level;

    public DateTimeOffset Time => time;

    public string? Message { get; init; }

    public string?[] Arguments { get; init; } = [];

    public Exception? Exception { get; init; }
}
