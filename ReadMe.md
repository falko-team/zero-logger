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

### Performance Test **without** Rendering of Log String with Three Same Layouts

> BenchmarkDotNet v0.14.1-develop (2025-05-02), Linux Ubuntu 24.04.2 LTS (Noble Numbat)
> AMD EPYC-Rome Processor, 1 CPU, 2 logical cores and 1 physical core
> .NET SDK 10.0.100-preview.3.25201.16
>   [Host]     : .NET 10.0.0 (10.0.25.17105), X64 RyuJIT AVX2
>   Job-FJGJGD : .NET 10.0.0 (10.0.25.17105), X64 RyuJIT AVX2
>   Job-BOSRAC : .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
>   Job-HDAHYX : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2
>   Job-YJZQKG : .NET 10.0.0-preview.3.25171.5, X64 NativeAOT AVX2
>   Job-CWVCEM : .NET 9.0.3, X64 NativeAOT AVX2

> RunStrategy=Throughput

| Method              | Runtime        | Mean      | Error     | StdDev    | Min       | Max       | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|-------------------- |--------------- |----------:|----------:|----------:|----------:|----------:|------:|--------:|-------:|----------:|------------:|
| RenderZeroLoggerLog | .NET 10.0      |  6.537 us | 0.0435 us | 0.0363 us |  6.431 us |  6.574 us |  1.00 |    0.01 | 0.9537 |   7.81 KB |        1.00 |
| RenderNLogLoggerLog | .NET 10.0      |  7.322 us | 0.0359 us | 0.0318 us |  7.282 us |  7.396 us |  1.12 |    0.01 | 2.0981 |  17.19 KB |        2.20 |
|                     |                |           |           |           |           |           |       |         |        |           |             |
| RenderZeroLoggerLog | .NET 8.0       |  6.243 us | 0.0323 us | 0.0270 us |  6.203 us |  6.302 us |  1.00 |    0.01 | 0.9537 |   7.81 KB |        1.00 |
| RenderNLogLoggerLog | .NET 8.0       |  7.103 us | 0.0435 us | 0.0385 us |  7.047 us |  7.174 us |  1.14 |    0.01 | 2.0981 |  17.19 KB |        2.20 |
|                     |                |           |           |           |           |           |       |         |        |           |             |
| RenderZeroLoggerLog | .NET 9.0       |  6.828 us | 0.0980 us | 0.0917 us |  6.719 us |  7.001 us |  1.00 |    0.02 | 0.9537 |   7.81 KB |        1.00 |
| RenderNLogLoggerLog | .NET 9.0       |  7.410 us | 0.0564 us | 0.0527 us |  7.302 us |  7.495 us |  1.09 |    0.02 | 2.0981 |  17.19 KB |        2.20 |
|                     |                |           |           |           |           |           |       |         |        |           |             |
| RenderZeroLoggerLog | NativeAOT 10.0 |  5.950 us | 0.0321 us | 0.0284 us |  5.906 us |  6.001 us |  1.00 |    0.01 | 0.9537 |   7.81 KB |        1.00 |
| RenderNLogLoggerLog | NativeAOT 10.0 | 11.151 us | 0.0432 us | 0.0337 us | 11.096 us | 11.203 us |  1.87 |    0.01 | 2.0905 |  17.19 KB |        2.20 |
|                     |                |           |           |           |           |           |       |         |        |           |             |
| RenderZeroLoggerLog | NativeAOT 8.0  |        NA |        NA |        NA |        NA |        NA |     ? |       ? |     NA |        NA |           ? |
| RenderNLogLoggerLog | NativeAOT 8.0  |        NA |        NA |        NA |        NA |        NA |     ? |       ? |     NA |        NA |           ? |
|                     |                |           |           |           |           |           |       |         |        |           |             |
| RenderZeroLoggerLog | NativeAOT 9.0  |  6.904 us | 0.0240 us | 0.0212 us |  6.863 us |  6.940 us |  1.00 |    0.00 | 0.9537 |   7.81 KB |        1.00 |
| RenderNLogLoggerLog | NativeAOT 9.0  | 11.095 us | 0.0549 us | 0.0513 us | 11.014 us | 11.182 us |  1.61 |    0.01 | 2.0905 |  17.19 KB |        2.20 |

### Performance Test **with** Rendering of Log String with Three Same Layouts

> BenchmarkDotNet v0.14.1-develop (2025-05-02), Linux Ubuntu 24.04.2 LTS (Noble Numbat)
> AMD EPYC-Rome Processor, 1 CPU, 2 logical cores and 1 physical core
> .NET SDK 10.0.100-preview.3.25201.16
> [Host]     : .NET 10.0.0 (10.0.25.17105), X64 RyuJIT AVX2
> Job-FJGJGD : .NET 10.0.0 (10.0.25.17105), X64 RyuJIT AVX2
> Job-BOSRAC : .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
> Job-HDAHYX : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2
> Job-YJZQKG : .NET 10.0.0-preview.3.25171.5, X64 NativeAOT AVX2
> Job-CWVCEM : .NET 9.0.3, X64 NativeAOT AVX2

RunStrategy=Throughput

| Method              | Runtime        | Mean     | Error    | StdDev   | Min      | Max      | Ratio | RatioSD | Gen0    | Allocated | Alloc Ratio |
|-------------------- |--------------- |---------:|---------:|---------:|---------:|---------:|------:|--------:|--------:|----------:|------------:|
| RenderZeroLoggerLog | .NET 10.0      | 16.18 us | 0.174 us | 0.145 us | 15.95 us | 16.49 us |  1.00 |    0.01 |  3.2349 |  26.48 KB |        1.00 |
| RenderNLogLoggerLog | .NET 10.0      | 45.91 us | 0.321 us | 0.285 us | 45.57 us | 46.54 us |  2.84 |    0.03 | 12.8784 | 105.47 KB |        3.98 |
|                     |                |          |          |          |          |          |       |         |         |           |             |
| RenderZeroLoggerLog | .NET 8.0       | 18.39 us | 0.153 us | 0.128 us | 18.23 us | 18.68 us |  1.00 |    0.01 |  3.2349 |  26.48 KB |        1.00 |
| RenderNLogLoggerLog | .NET 8.0       | 50.23 us | 0.864 us | 0.808 us | 49.07 us | 52.02 us |  2.73 |    0.05 | 12.8784 | 105.47 KB |        3.98 |
|                     |                |          |          |          |          |          |       |         |         |           |             |
| RenderZeroLoggerLog | .NET 9.0       | 16.50 us | 0.185 us | 0.164 us | 16.27 us | 16.77 us |  1.00 |    0.01 |  3.2349 |  26.48 KB |        1.00 |
| RenderNLogLoggerLog | .NET 9.0       | 44.83 us | 0.431 us | 0.382 us | 44.18 us | 45.43 us |  2.72 |    0.03 | 12.8784 | 105.47 KB |        3.98 |
|                     |                |          |          |          |          |          |       |         |         |           |             |
| RenderZeroLoggerLog | NativeAOT 10.0 | 19.00 us | 0.107 us | 0.100 us | 18.84 us | 19.15 us |  1.00 |    0.01 |  3.2349 |  26.48 KB |        1.00 |
| RenderNLogLoggerLog | NativeAOT 10.0 | 58.86 us | 1.025 us | 0.959 us | 57.56 us | 60.63 us |  3.10 |    0.05 | 12.8784 | 105.47 KB |        3.98 |
|                     |                |          |          |          |          |          |       |         |         |           |             |
| RenderZeroLoggerLog | NativeAOT 9.0  | 20.51 us | 0.062 us | 0.055 us | 20.44 us | 20.59 us |  1.00 |    0.00 |  3.2349 |  26.48 KB |        1.00 |
| RenderNLogLoggerLog | NativeAOT 9.0  | 59.64 us | 0.362 us | 0.339 us | 59.13 us | 60.18 us |  2.91 |    0.02 | 12.8784 | 105.47 KB |        3.98 |

## License

This project is licensed under the [GNU General Public License v3.0](License.md).

**© 2025, Falko Team**
