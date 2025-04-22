using System.Runtime.CompilerServices;

namespace System.Logging;

public static class LoggerFactory
{
    public static Logger CreateLoggerOfName(string name)
    {
        ArgumentNullException.ThrowIfNull(name);

        return new Logger(name);
    }

    public static Logger CreateLoggerOfType<T>() where T : notnull
    {
        var name = typeof(T).FullName;

        ArgumentNullException.ThrowIfNull(name);

        return new Logger(name);
    }

    public static Logger CreateLoggerOfType(Type type)
    {
        ArgumentNullException.ThrowIfNull(type);

        var name = type.FullName;

        ArgumentNullException.ThrowIfNull(name);

        return new Logger(name);
    }

    public static Logger CreateLoggerOfObject()
    {
        throw new NotImplementedException();
    }

    public static Logger CreateLoggerOfMethod<T>([CallerMemberName] string member = null!) where T : notnull
    {
        ArgumentNullException.ThrowIfNull(member);

        var name = typeof(T).FullName;

        ArgumentNullException.ThrowIfNull(name);

        return new Logger($"{name}.{member}");
    }

    public static Logger CreateLoggerOfMethod(Type type, [CallerMemberName] string member = null!)
    {
        ArgumentNullException.ThrowIfNull(type);
        ArgumentNullException.ThrowIfNull(member);

        var name = type.FullName;

        ArgumentNullException.ThrowIfNull(name);

        return new Logger($"{name}.{member}");
    }

    public static Logger CreateLoggerOfMethod([CallerMemberName] string member = null!)
    {
        ArgumentNullException.ThrowIfNull(member);

        throw new NotImplementedException();
    }
}
