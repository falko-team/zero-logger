# Zero Logger - Static Logger with Minimal Allocations

> The project is under active development. The underlying C# libraries are subject to change.

High-Performance Static Structured Logger with Minimal Allocations.

```C#
LoggerRuntime.Initialize(new LoggerContextBuilder()
    .SetLevel(LogLevel.Info)
    .AddTarget(SimpleLogInterpolator.Instance, new LoggerFileTarget("program", "./Logs")));

var logger = LoggerFactory.CreateLoggerOfType<Program>();

logger.Info(static () => "PI is {PI}", static () => Math.PI.ToString("F"));

LoggerRuntime.Dispose();
```

## License

This project is licensed under the [BSD 2-Clause License](License.md).

**© 2025, Falko Team**
