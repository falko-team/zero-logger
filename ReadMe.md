# Zero Logger - Static Logger with Minimal Allocations

> The project is under active development. The underlying C# libraries are subject to change.

High-Performance Static Structured Logger with Minimal Allocations.

```C#
LoggerRuntime.Initialize(new LoggerContextBuilder()
    .SetLevel(LogLevels.InfoAndAbove)
    .AddTarget(SimpleLogContextRenderer.Instance, new LoggerFileTarget("program", "./Logs")));

var logger = LoggerFactory.CreateLoggerOfType<Program>();

logger.Info(static () => "PI is {PI}", static () => Math.PI.ToString("F"));

LoggerRuntime.Dispose();
```

## Performance

Compare the performance of the Zero Logger with the NLog library.

### Performance with Rendering of Log String with Three Same Layouts

```bash
BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC-Rome Processor, 1 CPU, 2 logical cores and 1 physical core
.NET SDK 9.0.203
  [Host]     : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2
  Job-SNMXOO : .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
  Job-MBMBBG : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2
RunStrategy=Throughput
```

| Method              | Runtime       | Mean     | Ratio | Allocated | Alloc Ratio |
|-------------------- |-------------- |---------:|------:|----------:|------------:|
| RenderZeroLoggerLog | .NET 9.0      | 16.80 us |  1.00 |  26.48 KB |        1.00 |
| RenderNLogLoggerLog | .NET 9.0      | 46.16 us |  2.75 | 105.47 KB |        3.98 |
|                     |               |          |       |           |             |
| RenderZeroLoggerLog | .NET 8.0      | 18.75 us |  1.00 |  26.48 KB |        1.00 |
| RenderNLogLoggerLog | .NET 8.0      | 46.96 us |  2.51 | 105.47 KB |        3.98 |

## License

This project is licensed under the [GNU General Public License v3.0](License.md).

**© 2025, Falko Team**
