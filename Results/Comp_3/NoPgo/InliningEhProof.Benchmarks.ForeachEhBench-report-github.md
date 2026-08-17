```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.20348.5386)
Intel Xeon Silver 4314 CPU 2.40GHz, 2 CPU, 64 logical and 32 physical cores
.NET SDK 11.0.100-preview.5.26302.115
  [Host]    : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4
  .NET 10.0 : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4
  .NET 8.0  : .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4
  .NET 9.0  : .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4


```
| Method                  | Job       | Runtime   | Elements | Mean       | Error    | StdDev   | Ratio | Allocated | Alloc Ratio |
|------------------------ |---------- |---------- |--------- |-----------:|---------:|---------:|------:|----------:|------------:|
| **Foreach_Compiler**        | **.NET 10.0** | **.NET 10.0** | **4**        |   **390.1 ns** |  **1.90 ns** |  **1.48 ns** |  **1.00** |         **-** |          **NA** |
| Foreach_Manual          | .NET 10.0 | .NET 10.0 | 4        |   396.0 ns |  3.80 ns |  3.56 ns |  1.01 |         - |          NA |
| Foreach_CompilerBlocked | .NET 10.0 | .NET 10.0 | 4        |   394.2 ns |  4.18 ns |  3.71 ns |  1.01 |         - |          NA |
| Foreach_ManualBlocked   | .NET 10.0 | .NET 10.0 | 4        |   401.0 ns |  2.86 ns |  2.68 ns |  1.03 |         - |          NA |
| Foreach_Compiler        | .NET 8.0  | .NET 8.0  | 4        |   360.8 ns |  2.30 ns |  2.15 ns |  0.92 |         - |          NA |
| Foreach_Manual          | .NET 8.0  | .NET 8.0  | 4        |   398.2 ns |  2.49 ns |  2.33 ns |  1.02 |         - |          NA |
| Foreach_CompilerBlocked | .NET 8.0  | .NET 8.0  | 4        |   399.4 ns |  1.22 ns |  1.08 ns |  1.02 |         - |          NA |
| Foreach_ManualBlocked   | .NET 8.0  | .NET 8.0  | 4        |   397.6 ns |  1.55 ns |  1.37 ns |  1.02 |         - |          NA |
| Foreach_Compiler        | .NET 9.0  | .NET 9.0  | 4        |   396.0 ns |  3.69 ns |  3.27 ns |  1.02 |         - |          NA |
| Foreach_Manual          | .NET 9.0  | .NET 9.0  | 4        |   397.5 ns |  5.53 ns |  5.17 ns |  1.02 |         - |          NA |
| Foreach_CompilerBlocked | .NET 9.0  | .NET 9.0  | 4        |   399.9 ns |  5.86 ns |  5.19 ns |  1.02 |         - |          NA |
| Foreach_ManualBlocked   | .NET 9.0  | .NET 9.0  | 4        |   389.9 ns |  1.30 ns |  1.08 ns |  1.00 |         - |          NA |
|                         |           |           |          |            |          |          |       |           |             |
| **Foreach_Compiler**        | **.NET 10.0** | **.NET 10.0** | **16**       |   **788.6 ns** |  **3.34 ns** |  **3.12 ns** |  **1.00** |         **-** |          **NA** |
| Foreach_Manual          | .NET 10.0 | .NET 10.0 | 16       |   792.7 ns |  6.50 ns |  6.08 ns |  1.01 |         - |          NA |
| Foreach_CompilerBlocked | .NET 10.0 | .NET 10.0 | 16       |   795.5 ns |  3.95 ns |  3.70 ns |  1.01 |         - |          NA |
| Foreach_ManualBlocked   | .NET 10.0 | .NET 10.0 | 16       |   799.8 ns |  4.07 ns |  3.81 ns |  1.01 |         - |          NA |
| Foreach_Compiler        | .NET 8.0  | .NET 8.0  | 16       |   849.2 ns |  4.53 ns |  4.24 ns |  1.08 |         - |          NA |
| Foreach_Manual          | .NET 8.0  | .NET 8.0  | 16       |   915.6 ns |  4.15 ns |  3.68 ns |  1.16 |         - |          NA |
| Foreach_CompilerBlocked | .NET 8.0  | .NET 8.0  | 16       |   921.5 ns |  8.90 ns |  8.33 ns |  1.17 |         - |          NA |
| Foreach_ManualBlocked   | .NET 8.0  | .NET 8.0  | 16       |   937.7 ns | 10.24 ns |  9.58 ns |  1.19 |         - |          NA |
| Foreach_Compiler        | .NET 9.0  | .NET 9.0  | 16       |   802.2 ns |  5.45 ns |  4.83 ns |  1.02 |         - |          NA |
| Foreach_Manual          | .NET 9.0  | .NET 9.0  | 16       |   792.4 ns |  6.89 ns |  6.11 ns |  1.00 |         - |          NA |
| Foreach_CompilerBlocked | .NET 9.0  | .NET 9.0  | 16       |   791.0 ns |  4.36 ns |  3.87 ns |  1.00 |         - |          NA |
| Foreach_ManualBlocked   | .NET 9.0  | .NET 9.0  | 16       |   788.0 ns |  3.45 ns |  3.23 ns |  1.00 |         - |          NA |
|                         |           |           |          |            |          |          |       |           |             |
| **Foreach_Compiler**        | **.NET 10.0** | **.NET 10.0** | **64**       | **2,964.6 ns** | **17.72 ns** | **15.70 ns** |  **1.00** |         **-** |          **NA** |
| Foreach_Manual          | .NET 10.0 | .NET 10.0 | 64       | 3,079.9 ns | 20.29 ns | 17.99 ns |  1.04 |         - |          NA |
| Foreach_CompilerBlocked | .NET 10.0 | .NET 10.0 | 64       | 2,991.7 ns | 17.39 ns | 15.42 ns |  1.01 |         - |          NA |
| Foreach_ManualBlocked   | .NET 10.0 | .NET 10.0 | 64       | 2,955.9 ns | 18.99 ns | 17.76 ns |  1.00 |         - |          NA |
| Foreach_Compiler        | .NET 8.0  | .NET 8.0  | 64       | 3,024.9 ns | 18.68 ns | 17.48 ns |  1.02 |         - |          NA |
| Foreach_Manual          | .NET 8.0  | .NET 8.0  | 64       | 3,131.4 ns | 39.36 ns | 36.82 ns |  1.06 |         - |          NA |
| Foreach_CompilerBlocked | .NET 8.0  | .NET 8.0  | 64       | 3,131.4 ns | 21.03 ns | 18.64 ns |  1.06 |         - |          NA |
| Foreach_ManualBlocked   | .NET 8.0  | .NET 8.0  | 64       | 3,122.8 ns | 11.25 ns |  9.39 ns |  1.05 |         - |          NA |
| Foreach_Compiler        | .NET 9.0  | .NET 9.0  | 64       | 3,011.2 ns | 27.32 ns | 25.56 ns |  1.02 |         - |          NA |
| Foreach_Manual          | .NET 9.0  | .NET 9.0  | 64       | 2,944.0 ns | 13.09 ns | 10.93 ns |  0.99 |         - |          NA |
| Foreach_CompilerBlocked | .NET 9.0  | .NET 9.0  | 64       | 2,947.4 ns | 11.81 ns |  9.86 ns |  0.99 |         - |          NA |
| Foreach_ManualBlocked   | .NET 9.0  | .NET 9.0  | 64       | 2,957.7 ns | 21.18 ns | 19.81 ns |  1.00 |         - |          NA |
