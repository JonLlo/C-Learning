```

BenchmarkDotNet v0.15.2, macOS Sequoia 15.4.1 (24E263) [Darwin 24.4.0]
Intel Core i5-1030NG7 CPU 1.10GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.304
  [Host]     : .NET 9.0.8 (9.0.825.36511), X64 RyuJIT AVX2
  DefaultJob : .NET 9.0.8 (9.0.825.36511), X64 RyuJIT AVX2


```
| Method    | Mean        | Error      | StdDev    | Median      | Gen0     | Allocated  |
|---------- |------------:|-----------:|----------:|------------:|---------:|-----------:|
| SlowTool  | 2,048.19 μs | 338.841 μs | 983.04 μs | 1,883.44 μs | 898.4375 | 2773.88 KB |
| QuickTool |    30.53 μs |   4.387 μs |  12.80 μs |    26.82 μs |   2.8381 |     8.7 KB |
