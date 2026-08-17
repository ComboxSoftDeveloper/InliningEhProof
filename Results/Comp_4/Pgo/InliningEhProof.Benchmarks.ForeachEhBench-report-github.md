```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.20348.5139)
Intel Xeon W-2255 CPU 3.70GHz, 1 CPU, 20 logical and 10 physical cores
.NET SDK 11.0.100-preview.6.26359.118
  [Host]    : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4
  .NET 10.0 : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4
  .NET 8.0  : .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4
  .NET 9.0  : .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4


```
| Method                  | Job       | Runtime   | Elements | Mean       | Error    | StdDev   | Ratio | RatioSD | Allocated | Alloc Ratio |
|------------------------ |---------- |---------- |--------- |-----------:|---------:|---------:|------:|--------:|----------:|------------:|
| **Foreach_Compiler**        | **.NET 10.0** | **.NET 10.0** | **4**        |   **259.3 ns** |  **2.49 ns** |  **1.94 ns** |  **1.00** |    **0.01** |         **-** |          **NA** |
| Foreach_Manual          | .NET 10.0 | .NET 10.0 | 4        |   164.1 ns |  3.28 ns |  4.81 ns |  0.63 |    0.02 |         - |          NA |
| Foreach_CompilerBlocked | .NET 10.0 | .NET 10.0 | 4        |   250.1 ns |  2.03 ns |  1.69 ns |  0.96 |    0.01 |         - |          NA |
| Foreach_ManualBlocked   | .NET 10.0 | .NET 10.0 | 4        |   255.3 ns |  5.01 ns |  6.51 ns |  0.98 |    0.03 |         - |          NA |
| Foreach_Compiler        | .NET 8.0  | .NET 8.0  | 4        |   324.1 ns |  6.45 ns | 12.12 ns |  1.25 |    0.05 |         - |          NA |
| Foreach_Manual          | .NET 8.0  | .NET 8.0  | 4        |   299.7 ns |  3.34 ns |  2.96 ns |  1.16 |    0.01 |         - |          NA |
| Foreach_CompilerBlocked | .NET 8.0  | .NET 8.0  | 4        |   313.1 ns |  3.68 ns |  3.26 ns |  1.21 |    0.01 |         - |          NA |
| Foreach_ManualBlocked   | .NET 8.0  | .NET 8.0  | 4        |   320.3 ns |  5.06 ns |  4.22 ns |  1.24 |    0.02 |         - |          NA |
| Foreach_Compiler        | .NET 9.0  | .NET 9.0  | 4        |   325.1 ns |  5.01 ns |  4.69 ns |  1.25 |    0.02 |         - |          NA |
| Foreach_Manual          | .NET 9.0  | .NET 9.0  | 4        |   164.9 ns |  3.08 ns |  2.73 ns |  0.64 |    0.01 |         - |          NA |
| Foreach_CompilerBlocked | .NET 9.0  | .NET 9.0  | 4        |   323.9 ns |  4.01 ns |  3.35 ns |  1.25 |    0.02 |         - |          NA |
| Foreach_ManualBlocked   | .NET 9.0  | .NET 9.0  | 4        |   323.4 ns |  3.68 ns |  3.45 ns |  1.25 |    0.02 |         - |          NA |
|                         |           |           |          |            |          |          |       |         |           |             |
| **Foreach_Compiler**        | **.NET 10.0** | **.NET 10.0** | **16**       |   **541.5 ns** |  **8.35 ns** |  **7.81 ns** |  **1.00** |    **0.02** |         **-** |          **NA** |
| Foreach_Manual          | .NET 10.0 | .NET 10.0 | 16       |   529.9 ns | 10.04 ns |  9.86 ns |  0.98 |    0.02 |         - |          NA |
| Foreach_CompilerBlocked | .NET 10.0 | .NET 10.0 | 16       |   545.3 ns | 10.30 ns | 10.12 ns |  1.01 |    0.02 |         - |          NA |
| Foreach_ManualBlocked   | .NET 10.0 | .NET 10.0 | 16       |   539.4 ns |  7.44 ns |  6.59 ns |  1.00 |    0.02 |         - |          NA |
| Foreach_Compiler        | .NET 8.0  | .NET 8.0  | 16       | 1,049.0 ns | 16.54 ns | 16.99 ns |  1.94 |    0.04 |         - |          NA |
| Foreach_Manual          | .NET 8.0  | .NET 8.0  | 16       | 1,043.4 ns | 16.52 ns | 15.46 ns |  1.93 |    0.04 |         - |          NA |
| Foreach_CompilerBlocked | .NET 8.0  | .NET 8.0  | 16       | 1,078.2 ns | 21.36 ns | 30.64 ns |  1.99 |    0.06 |         - |          NA |
| Foreach_ManualBlocked   | .NET 8.0  | .NET 8.0  | 16       | 1,058.7 ns | 19.02 ns | 16.86 ns |  1.96 |    0.04 |         - |          NA |
| Foreach_Compiler        | .NET 9.0  | .NET 9.0  | 16       |   664.4 ns |  7.49 ns |  6.25 ns |  1.23 |    0.02 |         - |          NA |
| Foreach_Manual          | .NET 9.0  | .NET 9.0  | 16       |   518.5 ns |  8.32 ns |  7.38 ns |  0.96 |    0.02 |         - |          NA |
| Foreach_CompilerBlocked | .NET 9.0  | .NET 9.0  | 16       |   679.3 ns | 13.19 ns | 16.68 ns |  1.25 |    0.03 |         - |          NA |
| Foreach_ManualBlocked   | .NET 9.0  | .NET 9.0  | 16       |   548.6 ns | 10.46 ns | 11.19 ns |  1.01 |    0.02 |         - |          NA |
|                         |           |           |          |            |          |          |       |         |           |             |
| **Foreach_Compiler**        | **.NET 10.0** | **.NET 10.0** | **64**       | **2,026.5 ns** | **31.20 ns** | **26.06 ns** |  **1.00** |    **0.02** |         **-** |          **NA** |
| Foreach_Manual          | .NET 10.0 | .NET 10.0 | 64       | 2,007.2 ns | 23.53 ns | 19.65 ns |  0.99 |    0.02 |         - |          NA |
| Foreach_CompilerBlocked | .NET 10.0 | .NET 10.0 | 64       | 2,034.8 ns | 33.18 ns | 31.04 ns |  1.00 |    0.02 |         - |          NA |
| Foreach_ManualBlocked   | .NET 10.0 | .NET 10.0 | 64       | 2,047.2 ns | 40.83 ns | 47.02 ns |  1.01 |    0.03 |         - |          NA |
| Foreach_Compiler        | .NET 8.0  | .NET 8.0  | 64       | 4,069.8 ns | 78.92 ns | 90.88 ns |  2.01 |    0.05 |         - |          NA |
| Foreach_Manual          | .NET 8.0  | .NET 8.0  | 64       | 4,097.9 ns | 78.86 ns | 73.77 ns |  2.02 |    0.04 |         - |          NA |
| Foreach_CompilerBlocked | .NET 8.0  | .NET 8.0  | 64       | 3,966.0 ns | 46.17 ns | 38.55 ns |  1.96 |    0.03 |         - |          NA |
| Foreach_ManualBlocked   | .NET 8.0  | .NET 8.0  | 64       | 4,005.4 ns | 47.99 ns | 42.54 ns |  1.98 |    0.03 |         - |          NA |
| Foreach_Compiler        | .NET 9.0  | .NET 9.0  | 64       | 2,058.6 ns | 40.90 ns | 61.21 ns |  1.02 |    0.03 |         - |          NA |
| Foreach_Manual          | .NET 9.0  | .NET 9.0  | 64       | 2,032.2 ns | 34.46 ns | 30.55 ns |  1.00 |    0.02 |         - |          NA |
| Foreach_CompilerBlocked | .NET 9.0  | .NET 9.0  | 64       | 2,144.0 ns | 31.07 ns | 27.54 ns |  1.06 |    0.02 |         - |          NA |
| Foreach_ManualBlocked   | .NET 9.0  | .NET 9.0  | 64       | 2,004.2 ns | 22.49 ns | 19.94 ns |  0.99 |    0.02 |         - |          NA |
