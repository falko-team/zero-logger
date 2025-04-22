using System.Logging;

LoggerRuntime.Initialize(new LoggerFileTarget(SimpleLogInterpolator.Instance, "falko", "./Logs"));

var logger = LoggerFactory.CreateLoggerOfType<Program>();

logger.Info(static () => "Hello, {MachineName}", static () => Environment.MachineName);

LoggerRuntime.Dispose();
