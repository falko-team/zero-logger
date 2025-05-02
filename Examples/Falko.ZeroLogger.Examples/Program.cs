using System.Logging.Builders;
using System.Logging.Factories;
using System.Logging.Logs;
using System.Logging.Renderers;
using System.Logging.Runtimes;
using System.Logging.Targets;

var builder = new LoggerContextBuilder();

builder.SetLevel(LogLevels.InfoAndAbove);

builder.AddTarget(SimpleLogContextRenderer.Instance, LoggerConsoleTarget.Instance);
builder.AddTarget(SimpleLogContextRenderer.Instance, new LoggerFileTarget("program", "./Logs"));

LoggerRuntime.Global.Initialize(builder);

var logger = LoggerFactory.Global.CreateLoggerOfType<Program>();

logger.Info(static () => "App started");
logger.Error(new Exception(), static () => "Error occurred");
logger.Debug(static () => "CurrentTime: {CurrentTime}", static () => DateTime.Now);

LoggerRuntime.Global.Dispose();
