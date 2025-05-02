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

### Performance without Rendering of Log String with Three Same Layouts

> BenchmarkDotNet v0.14.1-develop (2025-05-02), Linux Ubuntu 24.04.2 LTS (Noble Numbat)
> 
> AMD EPYC-Rome Processor, 1 CPU, 2 logical cores and 1 physical core
> 
> .NET SDK 10.0.100-preview.3.25201.16
> 
>   [Host]     : .NET 10.0.0 (10.0.25.17105), X64 RyuJIT AVX2
> 
>   Job-FJGJGD : .NET 10.0.0 (10.0.25.17105), X64 RyuJIT AVX2
> 
>   Job-BOSRAC : .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
> 
>   Job-HDAHYX : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2
> 
>   Job-YJZQKG : .NET 10.0.0-preview.3.25171.5, X64 NativeAOT AVX2
> 
>   Job-CWVCEM : .NET 9.0.3, X64 NativeAOT AVX2
> 
> RunStrategy=Throughput

| Method              | Runtime        | Mean      | Ratio | Allocated | Alloc Ratio |
|-------------------- |--------------- |----------:|------:|----------:|------------:|
| RenderZeroLoggerLog | .NET 10.0      |  6.537 us |  1.00 |   7.81 KB |        1.00 |
| RenderNLogLoggerLog | .NET 10.0      |  7.322 us |  1.12 |  17.19 KB |        2.20 |
|                     |                |           |       |           |             |
| RenderZeroLoggerLog | .NET 8.0       |  6.243 us |  1.00 |   7.81 KB |        1.00 |
| RenderNLogLoggerLog | .NET 8.0       |  7.103 us |  1.14 |  17.19 KB |        2.20 |
|                     |                |           |       |           |             |
| RenderZeroLoggerLog | .NET 9.0       |  6.828 us |  1.00 |   7.81 KB |        1.00 |
| RenderNLogLoggerLog | .NET 9.0       |  7.410 us |  1.09 |  17.19 KB |        2.20 |
|                     |                |           |       |           |             |
| RenderZeroLoggerLog | NativeAOT 10.0 |  5.950 us |  1.00 |   7.81 KB |        1.00 |
| RenderNLogLoggerLog | NativeAOT 10.0 | 11.151 us |  1.87 |  17.19 KB |        2.20 |
|                     |                |           |       |           |             |
| RenderZeroLoggerLog | NativeAOT 9.0  |  6.904 us |  1.00 |   7.81 KB |        1.00 |
| RenderNLogLoggerLog | NativeAOT 9.0  | 11.095 us |  1.61 |  17.19 KB |        2.20 |

### Performance with Rendering of Log String with Three Same Layouts

> BenchmarkDotNet v0.14.1-develop (2025-05-02), Linux Ubuntu 24.04.2 LTS (Noble Numbat)
> 
> AMD EPYC-Rome Processor, 1 CPU, 2 logical cores and 1 physical core
> 
> .NET SDK 10.0.100-preview.3.25201.16
> 
> [Host]     : .NET 10.0.0 (10.0.25.17105), X64 RyuJIT AVX2
> 
> Job-FJGJGD : .NET 10.0.0 (10.0.25.17105), X64 RyuJIT AVX2
> 
> Job-BOSRAC : .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
> 
> Job-HDAHYX : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2
> 
> Job-YJZQKG : .NET 10.0.0-preview.3.25171.5, X64 NativeAOT AVX2
> 
> Job-CWVCEM : .NET 9.0.3, X64 NativeAOT AVX2
>
> RunStrategy=Throughput

| Method              | Runtime        | Mean     | Ratio | Allocated | Alloc Ratio |
|-------------------- |--------------- |---------:|------:|----------:|------------:|
| RenderZeroLoggerLog | .NET 10.0      | 16.18 us |  1.00 |  26.48 KB |        1.00 |
| RenderNLogLoggerLog | .NET 10.0      | 45.91 us |  2.84 | 105.47 KB |        3.98 |
|                     |                |          |       |           |             |
| RenderZeroLoggerLog | .NET 8.0       | 18.39 us |  1.00 |  26.48 KB |        1.00 |
| RenderNLogLoggerLog | .NET 8.0       | 50.23 us |  2.73 | 105.47 KB |        3.98 |
|                     |                |          |       |           |             |
| RenderZeroLoggerLog | .NET 9.0       | 16.50 us |  1.00 |  26.48 KB |        1.00 |
| RenderNLogLoggerLog | .NET 9.0       | 44.83 us |  2.72 | 105.47 KB |        3.98 |
|                     |                |          |       |           |             |
| RenderZeroLoggerLog | NativeAOT 10.0 | 19.00 us |  1.00 |  26.48 KB |        1.00 |
| RenderNLogLoggerLog | NativeAOT 10.0 | 58.86 us |  3.10 | 105.47 KB |        3.98 |
|                     |                |          |       |           |             |
| RenderZeroLoggerLog | NativeAOT 9.0  | 20.51 us |  1.00 |  26.48 KB |        1.00 |
| RenderNLogLoggerLog | NativeAOT 9.0  | 59.64 us |  2.91 | 105.47 KB |        3.98 |

## License

This project is licensed under the [GNU General Public License v3.0](License.md).

**© 2025, Falko Team**
