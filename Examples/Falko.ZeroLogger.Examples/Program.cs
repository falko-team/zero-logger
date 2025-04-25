using System.Logging.Builders;
using System.Logging.Factories;
using System.Logging.Interpolators;
using System.Logging.Logs;
using System.Logging.Runtimes;
using System.Logging.Targets;

LoggerRuntime.Initialize(new LoggerContextBuilder()
    .SetLevel(LogLevel.Trace)
    .AddTarget(SimpleLogInterpolator.Instance, new LoggerFileTarget("a", "./Logs"))
    .AddTarget(SimpleLogInterpolator.Instance, new LoggerFileTarget("b", "./Logs")));

var logger = LoggerFactory.CreateLoggerOfType<Program>();

var pi = Math.PI;

// good if inside argument
logger.Info(() => "PI is {0}", () => Math.PI.ToString("F"));

// good for outside argument
logger.Info(() => "PI is {0}", new LogMessageArgument<double>(pi, v => v.ToString("F")));

// bad for outside argument
logger.Info(() => "PI is {0}", () => pi.ToString("F"));

// for errors
logger.Error(new Exception(), () => "Error handled");

LoggerRuntime.Dispose();
