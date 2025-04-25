using System.Logging.Factories;
using System.Logging.Loggers;

namespace Falko.Examples;

public static class Application
{
    private static readonly Logger Logger = LoggerFactory.CreateLoggerOfObject();

    static Application()
    {
        Logger.Info(static () => "Application started");
    }
}
