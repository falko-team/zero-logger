using System.Logging.Builders;
using System.Logging.Debugs;
using System.Logging.Factories;
using System.Logging.Logs;
using System.Logging.Renderers;
using System.Logging.Runtimes;
using System.Logging.Targets;

DebugEventLogger.AddHandler(static (message, exception) => Console
    .WriteLine($"Logger Internal Event: {message} {exception}"));

LoggerRuntime.Initialize(new LoggerContextBuilder()
    .SetLevel(LogLevel.Trace)
    .AddTarget(SimpleLogContextRenderer.Instance, new LoggerFileTarget("a", "./Logs"))
    .AddTarget(SimpleLogContextRenderer.Instance, new LoggerFileTarget("b", "./Logs")));

var logger = LoggerFactory.CreateLoggerOfType<Program>();

// good for values with the lazy default to-string invocation for created before values
// except custom structures, cause for them, need to use the LogMessageArgument<T> factory to avoid boxing
logger.Info(static () => "PI is {0}", Math.PI);

// good for custom structures or values with the lazy custom to-string invocation
logger.Info(static () => "PI is {0}", new LogMessageArgument<double>(Math.PI, static v => v.ToString("F")));

// good for values that are creating lazy in the message factory to string
logger.Info(static () => "PI is {0}", static () => Math.PI.ToString("F"));

// good for string that is created before
logger.Info(static () => "PI is {0}", "3.14");

// good for string that doesn't create before
logger.Info(static () => "PI is {0}", static () => "3.14");

try
{
    throw new Exception();
}
catch (Exception exception)
{
    // for errors
    logger.Error(exception, () => "Error handled");
}

LoggerRuntime.Dispose();
