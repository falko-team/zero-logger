namespace System.Logging.Providers;

public abstract class LogMessageProvider
{
    public abstract string? GetString();

    public override string? ToString() => GetString();
}
