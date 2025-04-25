using System.Runtime.CompilerServices;

namespace System.Logging.Providers;

internal abstract class PersistentLogMessageProvider : LogMessageProvider
{
    private bool _created;

    private string? _message;

    public override string? GetString()
    {
        if (_created) return _message;

        var message = CreateString();

        _message = message;
        _created = true;

        return message;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    protected abstract string? CreateString();
}
