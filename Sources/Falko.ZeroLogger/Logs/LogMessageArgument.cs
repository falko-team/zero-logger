using System.Logging.Factories;

namespace System.Logging.Logs;

public readonly struct LogMessageArgument<T>(T value, LogMessageArgumentFactory<T> factory)
{
    public readonly T Value = value;

    public readonly LogMessageArgumentFactory<T> Factory = factory;
}
