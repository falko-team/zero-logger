using System.Logging;

var fileTarget = new LoggerFileTarget(SimpleLogInterpolator.Instance, "falko", "./Logs");

LoggerRuntime.Initialize(fileTarget);

var logger = LoggerFactory.CreateLoggerOfType<Program>();

logger.Info(static () => "Hello, {MachineName}", static () => Environment.MachineName);
logger.Trace(static () => "System is {OSVersion}", static () => Environment.OSVersion);

LoggerRuntime.Dispose();
