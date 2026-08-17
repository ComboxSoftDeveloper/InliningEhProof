```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.20348.5386)
Intel Xeon Silver 4314 CPU 2.40GHz, 2 CPU, 64 logical and 32 physical cores
.NET SDK 11.0.100-preview.5.26302.115
  [Host]    : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4
  .NET 10.0 : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4
  .NET 8.0  : .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4
  .NET 9.0  : .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4


```
| Method                  | Job       | Runtime   | Elements | Mean       | Error    | StdDev   | Ratio | RatioSD | Allocated | Alloc Ratio |
|------------------------ |---------- |---------- |--------- |-----------:|---------:|---------:|------:|--------:|----------:|------------:|
| **Foreach_Compiler**        | **.NET 10.0** | **.NET 10.0** | **4**        |   **436.8 ns** |  **5.41 ns** |  **4.80 ns** |  **1.00** |    **0.01** |         **-** |          **NA** |
| Foreach_Manual          | .NET 10.0 | .NET 10.0 | 4        |   259.7 ns |  2.69 ns |  2.52 ns |  0.59 |    0.01 |         - |          NA |
| Foreach_CompilerBlocked | .NET 10.0 | .NET 10.0 | 4        |   439.1 ns |  3.31 ns |  2.94 ns |  1.01 |    0.01 |         - |          NA |
| Foreach_ManualBlocked   | .NET 10.0 | .NET 10.0 | 4        |   439.4 ns |  6.85 ns |  6.07 ns |  1.01 |    0.02 |         - |          NA |
| Foreach_Compiler        | .NET 8.0  | .NET 8.0  | 4        |   352.5 ns |  1.55 ns |  1.45 ns |  0.81 |    0.01 |         - |          NA |
| Foreach_Manual          | .NET 8.0  | .NET 8.0  | 4        |   341.8 ns |  1.12 ns |  0.88 ns |  0.78 |    0.01 |         - |          NA |
| Foreach_CompilerBlocked | .NET 8.0  | .NET 8.0  | 4        |   397.5 ns |  1.38 ns |  1.15 ns |  0.91 |    0.01 |         - |          NA |
| Foreach_ManualBlocked   | .NET 8.0  | .NET 8.0  | 4        |   401.7 ns |  3.63 ns |  3.22 ns |  0.92 |    0.01 |         - |          NA |
| Foreach_Compiler        | .NET 9.0  | .NET 9.0  | 4        |   394.1 ns |  3.11 ns |  2.75 ns |  0.90 |    0.01 |         - |          NA |
| Foreach_Manual          | .NET 9.0  | .NET 9.0  | 4        |   242.7 ns |  2.27 ns |  2.01 ns |  0.56 |    0.01 |         - |          NA |
| Foreach_CompilerBlocked | .NET 9.0  | .NET 9.0  | 4        |   436.2 ns |  3.50 ns |  3.27 ns |  1.00 |    0.01 |         - |          NA |
| Foreach_ManualBlocked   | .NET 9.0  | .NET 9.0  | 4        |   436.4 ns |  3.63 ns |  3.22 ns |  1.00 |    0.01 |         - |          NA |
|                         |           |           |          |            |          |          |       |         |           |             |
| **Foreach_Compiler**        | **.NET 10.0** | **.NET 10.0** | **16**       |   **902.1 ns** |  **7.25 ns** |  **6.78 ns** |  **1.00** |    **0.01** |         **-** |          **NA** |
| Foreach_Manual          | .NET 10.0 | .NET 10.0 | 16       |   817.8 ns |  8.39 ns |  7.85 ns |  0.91 |    0.01 |         - |          NA |
| Foreach_CompilerBlocked | .NET 10.0 | .NET 10.0 | 16       |   906.0 ns |  8.37 ns |  7.42 ns |  1.00 |    0.01 |         - |          NA |
| Foreach_ManualBlocked   | .NET 10.0 | .NET 10.0 | 16       |   895.3 ns |  6.56 ns |  6.14 ns |  0.99 |    0.01 |         - |          NA |
| Foreach_Compiler        | .NET 8.0  | .NET 8.0  | 16       |   846.9 ns |  3.15 ns |  2.94 ns |  0.94 |    0.01 |         - |          NA |
| Foreach_Manual          | .NET 8.0  | .NET 8.0  | 16       |   870.6 ns |  4.96 ns |  4.64 ns |  0.97 |    0.01 |         - |          NA |
| Foreach_CompilerBlocked | .NET 8.0  | .NET 8.0  | 16       |   859.1 ns |  5.34 ns |  4.99 ns |  0.95 |    0.01 |         - |          NA |
| Foreach_ManualBlocked   | .NET 8.0  | .NET 8.0  | 16       |   929.4 ns |  7.89 ns |  6.59 ns |  1.03 |    0.01 |         - |          NA |
| Foreach_Compiler        | .NET 9.0  | .NET 9.0  | 16       |   894.4 ns |  7.77 ns |  7.27 ns |  0.99 |    0.01 |         - |          NA |
| Foreach_Manual          | .NET 9.0  | .NET 9.0  | 16       |   763.7 ns |  3.70 ns |  3.28 ns |  0.85 |    0.01 |         - |          NA |
| Foreach_CompilerBlocked | .NET 9.0  | .NET 9.0  | 16       |   894.9 ns |  5.81 ns |  5.44 ns |  0.99 |    0.01 |         - |          NA |
| Foreach_ManualBlocked   | .NET 9.0  | .NET 9.0  | 16       |   803.0 ns |  7.63 ns |  7.14 ns |  0.89 |    0.01 |         - |          NA |
|                         |           |           |          |            |          |          |       |         |           |             |
| **Foreach_Compiler**        | **.NET 10.0** | **.NET 10.0** | **64**       | **3,102.5 ns** | **18.63 ns** | **16.51 ns** |  **1.00** |    **0.01** |         **-** |          **NA** |
| Foreach_Manual          | .NET 10.0 | .NET 10.0 | 64       | 3,031.8 ns | 23.56 ns | 22.04 ns |  0.98 |    0.01 |         - |          NA |
| Foreach_CompilerBlocked | .NET 10.0 | .NET 10.0 | 64       | 3,062.4 ns | 14.18 ns | 11.84 ns |  0.99 |    0.01 |         - |          NA |
| Foreach_ManualBlocked   | .NET 10.0 | .NET 10.0 | 64       | 3,064.2 ns | 21.71 ns | 19.24 ns |  0.99 |    0.01 |         - |          NA |
| Foreach_Compiler        | .NET 8.0  | .NET 8.0  | 64       | 3,020.9 ns | 12.32 ns | 10.29 ns |  0.97 |    0.01 |         - |          NA |
| Foreach_Manual          | .NET 8.0  | .NET 8.0  | 64       | 3,097.9 ns | 23.39 ns | 21.88 ns |  1.00 |    0.01 |         - |          NA |
| Foreach_CompilerBlocked | .NET 8.0  | .NET 8.0  | 64       | 3,076.0 ns | 19.39 ns | 18.13 ns |  0.99 |    0.01 |         - |          NA |
| Foreach_ManualBlocked   | .NET 8.0  | .NET 8.0  | 64       | 3,174.1 ns | 33.73 ns | 31.55 ns |  1.02 |    0.01 |         - |          NA |
| Foreach_Compiler        | .NET 9.0  | .NET 9.0  | 64       | 3,072.5 ns | 15.13 ns | 14.15 ns |  0.99 |    0.01 |         - |          NA |
| Foreach_Manual          | .NET 9.0  | .NET 9.0  | 64       | 2,923.4 ns |  9.32 ns |  8.71 ns |  0.94 |    0.01 |         - |          NA |
| Foreach_CompilerBlocked | .NET 9.0  | .NET 9.0  | 64       | 3,064.9 ns | 13.62 ns | 12.08 ns |  0.99 |    0.01 |         - |          NA |
| Foreach_ManualBlocked   | .NET 9.0  | .NET 9.0  | 64       | 2,970.8 ns |  7.81 ns |  6.93 ns |  0.96 |    0.01 |         - |          NA |
