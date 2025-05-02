using System.Logging.Loggers;
using System.Logging.Runtimes;
using System.Runtime.CompilerServices;

namespace System.Logging.Factories;

public sealed class LoggerFactory(LoggerRuntime loggerRuntime)
{
    public static readonly LoggerFactory Global = new(LoggerRuntime.Global);

    public Logger CreateLoggerOfName(string name)
    {
        ArgumentNullException.ThrowIfNull(name);

        return new Logger(loggerRuntime, name);
    }

    public Logger CreateLoggerOfType<T>() where T : notnull
    {
        var name = typeof(T).FullName;

        ArgumentNullException.ThrowIfNull(name);

        return new Logger(loggerRuntime, name);
    }

    public Logger CreateLoggerOfType(Type type)
    {
        ArgumentNullException.ThrowIfNull(type);

        var name = type.FullName;

        ArgumentNullException.ThrowIfNull(name);

        return new Logger(loggerRuntime, name);
    }

    public Logger CreateLoggerOfObject()
    {
        throw new NotImplementedException();
    }

    public Logger CreateLoggerOfMethod<T>([CallerMemberName] string member = null!) where T : notnull
    {
        ArgumentNullException.ThrowIfNull(member);

        var name = typeof(T).FullName;

        ArgumentNullException.ThrowIfNull(name);

        return new Logger(loggerRuntime, $"{name}.{member}");
    }

    public Logger CreateLoggerOfMethod(Type type, [CallerMemberName] string member = null!)
    {
        ArgumentNullException.ThrowIfNull(type);
        ArgumentNullException.ThrowIfNull(member);

        var name = type.FullName;

        ArgumentNullException.ThrowIfNull(name);

        return new Logger(loggerRuntime, $"{name}.{member}");
    }

    public static Logger CreateLoggerOfMethod([CallerMemberName] string member = null!)
    {
        ArgumentNullException.ThrowIfNull(member);

        throw new NotImplementedException();
    }
}
