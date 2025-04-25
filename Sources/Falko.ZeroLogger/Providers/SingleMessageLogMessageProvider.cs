namespace System.Logging.Providers;

internal sealed class SingleMessageLogMessageProvider(string? message) : LogMessageProvider
{
    public override string? GetString()
    {
        return message;
    }
}
