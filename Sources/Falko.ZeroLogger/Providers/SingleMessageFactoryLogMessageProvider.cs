using System.Logging.Factories;

namespace System.Logging.Providers;

internal sealed class SingleMessageFactoryLogMessageProvider(LogMessageFactory messageFactory) : PersistentLogMessageProvider
{
    protected override string? CreateString()
    {
        return messageFactory();
    }
}
