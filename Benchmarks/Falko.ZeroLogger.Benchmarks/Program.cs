using System.Logging.Utils;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Engines;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Running;

BenchmarkRunner.Run<LogIgnoringBenchmark>();
BenchmarkRunner.Run<SingleArgumentLogRenderingBenchmark>();
BenchmarkRunner.Run<TwoArgumentsLogRenderingBenchmark>();
BenchmarkRunner.Run<DateTimeOffsetBenchmark>();

[MemoryDiagnoser]
[SimpleJob(RunStrategy.Throughput, RuntimeMoniker.Net90)]
[MinColumn, Q1Column, MeanColumn, MedianColumn, Q3Column, MaxColumn]
public class DateTimeOffsetBenchmark
{
    private const int Iterations = 100;

    [GlobalSetup]
    public void Setup()
    {
        LoggerConfigurer.Configure();
    }

    [Benchmark(Baseline = true)]
    public void ProvidedTIme()
    {
        for (var iteration = 0; iteration < Iterations; iteration++)
        {
            _ = DateTimeOffsetProvider.Now;
        }
    }

    [Benchmark]
    public void CreatedTime()
    {
        for (var iteration = 0; iteration < Iterations; iteration++)
        {
            _ = DateTimeOffset.Now;
        }
    }
}

[RPlotExporter]
[SimpleJob(RunStrategy.Throughput, RuntimeMoniker.Net90)]
[SimpleJob(RunStrategy.Throughput, RuntimeMoniker.NativeAot90)]
[SimpleJob(RunStrategy.Throughput, RuntimeMoniker.Net80)]
[SimpleJob(RunStrategy.Throughput, RuntimeMoniker.NativeAot80)]
[MinColumn, Q1Column, MeanColumn, MedianColumn, Q3Column, MaxColumn]
public class LogIgnoringBenchmark
{
    private static readonly System.Logging.Loggers.Logger ZeroLogger = System.Logging.Factories.LoggerFactory
        .CreateLoggerOfType<LogIgnoringBenchmark>();

    private static readonly NLog.Logger NLogLogger = NLog.LogManager
        .GetCurrentClassLogger();

    private const int Iterations = 100;

    [GlobalSetup]
    public void Setup()
    {
        LoggerConfigurer.Configure();
    }

    [Benchmark(Baseline = true)]
    public void IgnoreZeroLoggerLog()
    {
        for (var iteration = 0; iteration < Iterations; iteration++)
        {
            ZeroLogger.Trace(static () => "Iteration {IterationNumber}", iteration);
        }
    }

    [Benchmark]
    public void IgnoreNLogLoggerLog()
    {
        for (var iteration = 0; iteration < Iterations; iteration++)
        {
            NLogLogger.Trace("Iteration {IterationNumber}", iteration);
        }
    }
}

[RPlotExporter]
[MemoryDiagnoser]
[SimpleJob(RunStrategy.Throughput, RuntimeMoniker.Net90)]
[SimpleJob(RunStrategy.Throughput, RuntimeMoniker.NativeAot90)]
[SimpleJob(RunStrategy.Throughput, RuntimeMoniker.Net80)]
[SimpleJob(RunStrategy.Throughput, RuntimeMoniker.NativeAot80)]
[MinColumn, Q1Column, MeanColumn, MedianColumn, Q3Column, MaxColumn]
public class SingleArgumentLogRenderingBenchmark
{
    private static readonly System.Logging.Loggers.Logger ZeroLogger = System.Logging.Factories.LoggerFactory
        .CreateLoggerOfType<SingleArgumentLogRenderingBenchmark>();

    private static readonly NLog.Logger NLogLogger = NLog.LogManager
        .GetCurrentClassLogger();

    private const int Iterations = 100;

    [GlobalSetup]
    public void Setup()
    {
        LoggerConfigurer.Configure();
    }

    [Benchmark(Baseline = true)]
    public void RenderZeroLoggerLog()
    {
        for (var iteration = 0; iteration < Iterations; iteration++)
        {
            ZeroLogger.Info("Iteration {IterationNumber}", iteration);
        }
    }

    [Benchmark]
    public void RenderNLogLoggerLog()
    {
        for (var iteration = 0; iteration < Iterations; iteration++)
        {
            NLogLogger.Info("Iteration {IterationNumber}", iteration);
        }
    }
}

[RPlotExporter]
[MemoryDiagnoser]
[SimpleJob(RunStrategy.Throughput, RuntimeMoniker.Net90)]
[SimpleJob(RunStrategy.Throughput, RuntimeMoniker.NativeAot90)]
[SimpleJob(RunStrategy.Throughput, RuntimeMoniker.Net80)]
[SimpleJob(RunStrategy.Throughput, RuntimeMoniker.NativeAot80)]
[MinColumn, Q1Column, MeanColumn, MedianColumn, Q3Column, MaxColumn]
public class TwoArgumentsLogRenderingBenchmark
{
    private static readonly System.Logging.Loggers.Logger ZeroLogger = System.Logging.Factories.LoggerFactory
        .CreateLoggerOfType<TwoArgumentsLogRenderingBenchmark>();

    private static readonly NLog.Logger NLogLogger = NLog.LogManager
        .GetCurrentClassLogger();

    private const int Iterations = 100;

    [GlobalSetup]
    public void Setup()
    {
        LoggerConfigurer.Configure();
    }

    [Benchmark(Baseline = true)]
    public void RenderZeroLoggerLog()
    {
        for (var iteration = 0; iteration < Iterations; iteration++)
        {
            ZeroLogger.Info("Iteration {IterationNumber1} {IterationNumber2}", iteration, iteration);
        }
    }

    [Benchmark]
    public void RenderNLogLoggerLog()
    {
        for (var iteration = 0; iteration < Iterations; iteration++)
        {
            NLogLogger.Info("Iteration {IterationNumber1} {IterationNumber2}", iteration, iteration);
        }
    }
}

file static class LoggerConfigurer
{
    public static void Configure()
    {
        ConfigureZeroLogger();
        ConfigureNLogLogger();
    }

    private static void ConfigureZeroLogger()
    {
        System.Logging.Runtimes.LoggerRuntime
            .Initialize(new System.Logging.Builders.LoggerContextBuilder()
                .SetLevel(System.Logging.Logs.LogLevels.InfoAndAbove)
                .AddTarget(System.Logging.Renderers.SimpleLogContextRenderer.Instance,
                    EmptyZeroLoggerTarget.Instance)
                .AddTarget(System.Logging.Renderers.SimpleLogContextRenderer.Instance,
                    EmptyZeroLoggerTarget.Instance)
                .AddTarget(System.Logging.Renderers.SimpleLogContextRenderer.Instance,
                    EmptyZeroLoggerTarget.Instance));
    }

    private static void ConfigureNLogLogger()
    {
        var configuration = new NLog.Config.LoggingConfiguration();

        configuration.AddRule(NLog.LogLevel.Info, NLog.LogLevel.Fatal,
            EmptyNLogLoggerTarget.Instance);
        configuration.AddRule(NLog.LogLevel.Info, NLog.LogLevel.Fatal,
            EmptyNLogLoggerTarget.Instance);
        configuration.AddRule(NLog.LogLevel.Info, NLog.LogLevel.Fatal,
            EmptyNLogLoggerTarget.Instance);

        NLog.LogManager.Configuration = configuration;
    }
}

file sealed class EmptyZeroLoggerTarget : System.Logging.Targets.LoggerTarget
{
    public static readonly EmptyZeroLoggerTarget Instance = new();

    private EmptyZeroLoggerTarget() { }

    public override void Initialize(CancellationToken cancellationToken) { }

    public override void Publish(in System.Logging.Contexts.LogContext context,
        System.Logging.Renderers.ILogContextRenderer renderer,
        CancellationToken cancellationToken)
    {
        _ = renderer.Render(context);
    }

    public override void Dispose(CancellationToken cancellationToken) { }
}

file sealed class EmptyNLogLoggerTarget : NLog.Targets.TargetWithLayout
{
    public static readonly EmptyNLogLoggerTarget Instance = new()
    {
        Layout = "[${time}] [${level:uppercase=true}] [${logger}] ${message}",
    };

    private EmptyNLogLoggerTarget() { }

    protected override void Write(NLog.LogEventInfo logEvent)
    {
        _ = Layout.Render(logEvent);
    }
}
