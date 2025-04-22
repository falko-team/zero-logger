using System.Logging;

var fileTarget = new LoggerFileTarget(SimpleLogInterpolator.Instance, "falko", "./Logs");

LoggerRuntime.Initialize(fileTarget);

var logger = LoggerFactory.CreateLoggerOfType<Program>();

logger.Info(static () => "Hello, {0}", static () => Environment.UserName);
logger.Trace(static () => "System is {0}", static () => Environment.OSVersion);

LoggerRuntime.Dispose();
