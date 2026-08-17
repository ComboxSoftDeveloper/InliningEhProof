```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.20348.5139)
Intel Xeon W-2255 CPU 3.70GHz, 1 CPU, 20 logical and 10 physical cores
.NET SDK 11.0.100-preview.6.26359.118
  [Host]    : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4
  .NET 10.0 : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4
  .NET 8.0  : .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4
  .NET 9.0  : .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4


```
| Method                  | Job       | Runtime   | Elements | Mean       | Error    | StdDev    | Ratio | RatioSD | Allocated | Alloc Ratio |
|------------------------ |---------- |---------- |--------- |-----------:|---------:|----------:|------:|--------:|----------:|------------:|
| **Foreach_Compiler**        | **.NET 10.0** | **.NET 10.0** | **4**        |   **282.6 ns** |  **4.37 ns** |   **3.88 ns** |  **1.00** |    **0.02** |         **-** |          **NA** |
| Foreach_Manual          | .NET 10.0 | .NET 10.0 | 4        |   326.6 ns |  3.80 ns |   3.37 ns |  1.16 |    0.02 |         - |          NA |
| Foreach_CompilerBlocked | .NET 10.0 | .NET 10.0 | 4        |   324.5 ns |  3.77 ns |   2.94 ns |  1.15 |    0.02 |         - |          NA |
| Foreach_ManualBlocked   | .NET 10.0 | .NET 10.0 | 4        |   327.9 ns |  4.71 ns |   4.41 ns |  1.16 |    0.02 |         - |          NA |
| Foreach_Compiler        | .NET 8.0  | .NET 8.0  | 4        |   316.4 ns |  3.94 ns |   3.49 ns |  1.12 |    0.02 |         - |          NA |
| Foreach_Manual          | .NET 8.0  | .NET 8.0  | 4        |   339.3 ns |  5.95 ns |   5.57 ns |  1.20 |    0.02 |         - |          NA |
| Foreach_CompilerBlocked | .NET 8.0  | .NET 8.0  | 4        |   315.4 ns |  3.21 ns |   2.68 ns |  1.12 |    0.02 |         - |          NA |
| Foreach_ManualBlocked   | .NET 8.0  | .NET 8.0  | 4        |   320.4 ns |  3.09 ns |   2.58 ns |  1.13 |    0.02 |         - |          NA |
| Foreach_Compiler        | .NET 9.0  | .NET 9.0  | 4        |   281.9 ns |  3.13 ns |   2.92 ns |  1.00 |    0.02 |         - |          NA |
| Foreach_Manual          | .NET 9.0  | .NET 9.0  | 4        |   327.5 ns |  6.47 ns |   6.92 ns |  1.16 |    0.03 |         - |          NA |
| Foreach_CompilerBlocked | .NET 9.0  | .NET 9.0  | 4        |   327.0 ns |  6.17 ns |   5.77 ns |  1.16 |    0.02 |         - |          NA |
| Foreach_ManualBlocked   | .NET 9.0  | .NET 9.0  | 4        |   323.8 ns |  3.68 ns |   3.26 ns |  1.15 |    0.02 |         - |          NA |
|                         |           |           |          |            |          |           |       |         |           |             |
| **Foreach_Compiler**        | **.NET 10.0** | **.NET 10.0** | **16**       |   **664.1 ns** |  **6.27 ns** |   **5.24 ns** |  **1.00** |    **0.01** |         **-** |          **NA** |
| Foreach_Manual          | .NET 10.0 | .NET 10.0 | 16       |   680.5 ns | 13.02 ns |  14.99 ns |  1.02 |    0.02 |         - |          NA |
| Foreach_CompilerBlocked | .NET 10.0 | .NET 10.0 | 16       |   666.9 ns |  5.82 ns |   5.16 ns |  1.00 |    0.01 |         - |          NA |
| Foreach_ManualBlocked   | .NET 10.0 | .NET 10.0 | 16       |   667.8 ns |  7.05 ns |   6.25 ns |  1.01 |    0.01 |         - |          NA |
| Foreach_Compiler        | .NET 8.0  | .NET 8.0  | 16       | 1,049.9 ns | 18.52 ns |  17.32 ns |  1.58 |    0.03 |         - |          NA |
| Foreach_Manual          | .NET 8.0  | .NET 8.0  | 16       | 1,056.0 ns | 18.47 ns |  16.38 ns |  1.59 |    0.03 |         - |          NA |
| Foreach_CompilerBlocked | .NET 8.0  | .NET 8.0  | 16       | 1,059.3 ns | 18.92 ns |  16.77 ns |  1.60 |    0.03 |         - |          NA |
| Foreach_ManualBlocked   | .NET 8.0  | .NET 8.0  | 16       | 1,073.4 ns | 21.48 ns |  20.09 ns |  1.62 |    0.03 |         - |          NA |
| Foreach_Compiler        | .NET 9.0  | .NET 9.0  | 16       |   667.8 ns |  9.68 ns |   8.58 ns |  1.01 |    0.01 |         - |          NA |
| Foreach_Manual          | .NET 9.0  | .NET 9.0  | 16       |   670.3 ns | 10.03 ns |   8.89 ns |  1.01 |    0.02 |         - |          NA |
| Foreach_CompilerBlocked | .NET 9.0  | .NET 9.0  | 16       |   664.3 ns |  8.76 ns |   7.76 ns |  1.00 |    0.01 |         - |          NA |
| Foreach_ManualBlocked   | .NET 9.0  | .NET 9.0  | 16       |   677.1 ns | 13.40 ns |  12.53 ns |  1.02 |    0.02 |         - |          NA |
|                         |           |           |          |            |          |           |       |         |           |             |
| **Foreach_Compiler**        | **.NET 10.0** | **.NET 10.0** | **64**       | **2,117.1 ns** | **41.40 ns** |  **36.70 ns** |  **1.00** |    **0.02** |         **-** |          **NA** |
| Foreach_Manual          | .NET 10.0 | .NET 10.0 | 64       | 2,140.2 ns | 34.61 ns |  32.38 ns |  1.01 |    0.02 |         - |          NA |
| Foreach_CompilerBlocked | .NET 10.0 | .NET 10.0 | 64       | 2,147.2 ns | 42.91 ns |  42.14 ns |  1.01 |    0.03 |         - |          NA |
| Foreach_ManualBlocked   | .NET 10.0 | .NET 10.0 | 64       | 2,169.0 ns | 41.66 ns |  40.92 ns |  1.02 |    0.03 |         - |          NA |
| Foreach_Compiler        | .NET 8.0  | .NET 8.0  | 64       | 4,116.6 ns | 80.23 ns | 104.32 ns |  1.95 |    0.06 |         - |          NA |
| Foreach_Manual          | .NET 8.0  | .NET 8.0  | 64       | 4,012.0 ns | 42.88 ns |  40.11 ns |  1.90 |    0.04 |         - |          NA |
| Foreach_CompilerBlocked | .NET 8.0  | .NET 8.0  | 64       | 4,001.1 ns | 64.68 ns |  57.34 ns |  1.89 |    0.04 |         - |          NA |
| Foreach_ManualBlocked   | .NET 8.0  | .NET 8.0  | 64       | 4,025.5 ns | 67.60 ns |  59.93 ns |  1.90 |    0.04 |         - |          NA |
| Foreach_Compiler        | .NET 9.0  | .NET 9.0  | 64       | 2,165.6 ns | 42.83 ns |  58.63 ns |  1.02 |    0.03 |         - |          NA |
| Foreach_Manual          | .NET 9.0  | .NET 9.0  | 64       | 2,210.1 ns | 43.24 ns |  48.06 ns |  1.04 |    0.03 |         - |          NA |
| Foreach_CompilerBlocked | .NET 9.0  | .NET 9.0  | 64       | 2,150.6 ns | 41.69 ns |  36.96 ns |  1.02 |    0.02 |         - |          NA |
| Foreach_ManualBlocked   | .NET 9.0  | .NET 9.0  | 64       | 2,147.5 ns | 38.37 ns |  34.01 ns |  1.01 |    0.02 |         - |          NA |
