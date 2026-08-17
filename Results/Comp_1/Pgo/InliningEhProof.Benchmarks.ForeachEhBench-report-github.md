```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.17763.3165/1809/October2018Update/Redstone5)
AMD Ryzen 9 5950X 3.39GHz, 1 CPU, 32 logical and 16 physical cores
.NET SDK 11.0.100-preview.5.26302.115
  [Host]    : .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3
  .NET 10.0 : .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3
  .NET 8.0  : .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3
  .NET 9.0  : .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3


```
| Method                  | Job       | Runtime   | Elements | Mean       | Error    | StdDev    | Ratio | RatioSD | Allocated | Alloc Ratio |
|------------------------ |---------- |---------- |--------- |-----------:|---------:|----------:|------:|--------:|----------:|------------:|
| **Foreach_Compiler**        | **.NET 10.0** | **.NET 10.0** | **4**        |   **196.6 ns** |  **1.41 ns** |   **1.18 ns** |  **1.00** |    **0.01** |         **-** |          **NA** |
| Foreach_Manual          | .NET 10.0 | .NET 10.0 | 4        |   165.2 ns |  0.91 ns |   0.85 ns |  0.84 |    0.01 |         - |          NA |
| Foreach_CompilerBlocked | .NET 10.0 | .NET 10.0 | 4        |   211.1 ns |  0.95 ns |   0.84 ns |  1.07 |    0.01 |         - |          NA |
| Foreach_ManualBlocked   | .NET 10.0 | .NET 10.0 | 4        |   211.0 ns |  1.13 ns |   1.00 ns |  1.07 |    0.01 |         - |          NA |
| Foreach_Compiler        | .NET 8.0  | .NET 8.0  | 4        |   224.9 ns |  1.36 ns |   1.20 ns |  1.14 |    0.01 |         - |          NA |
| Foreach_Manual          | .NET 8.0  | .NET 8.0  | 4        |   165.6 ns |  0.67 ns |   0.56 ns |  0.84 |    0.01 |         - |          NA |
| Foreach_CompilerBlocked | .NET 8.0  | .NET 8.0  | 4        |   225.7 ns |  1.25 ns |   1.17 ns |  1.15 |    0.01 |         - |          NA |
| Foreach_ManualBlocked   | .NET 8.0  | .NET 8.0  | 4        |   195.6 ns |  0.78 ns |   0.69 ns |  1.00 |    0.01 |         - |          NA |
| Foreach_Compiler        | .NET 9.0  | .NET 9.0  | 4        |   209.2 ns |  0.81 ns |   0.75 ns |  1.06 |    0.01 |         - |          NA |
| Foreach_Manual          | .NET 9.0  | .NET 9.0  | 4        |   161.5 ns |  1.00 ns |   0.84 ns |  0.82 |    0.01 |         - |          NA |
| Foreach_CompilerBlocked | .NET 9.0  | .NET 9.0  | 4        |   194.4 ns |  0.40 ns |   0.38 ns |  0.99 |    0.01 |         - |          NA |
| Foreach_ManualBlocked   | .NET 9.0  | .NET 9.0  | 4        |   194.8 ns |  1.18 ns |   0.92 ns |  0.99 |    0.01 |         - |          NA |
|                         |           |           |          |            |          |           |       |         |           |             |
| **Foreach_Compiler**        | **.NET 10.0** | **.NET 10.0** | **16**       |   **542.6 ns** |  **1.70 ns** |   **1.42 ns** |  **1.00** |    **0.00** |         **-** |          **NA** |
| Foreach_Manual          | .NET 10.0 | .NET 10.0 | 16       |   516.0 ns |  3.22 ns |   3.02 ns |  0.95 |    0.01 |         - |          NA |
| Foreach_CompilerBlocked | .NET 10.0 | .NET 10.0 | 16       |   565.0 ns |  6.39 ns |   5.34 ns |  1.04 |    0.01 |         - |          NA |
| Foreach_ManualBlocked   | .NET 10.0 | .NET 10.0 | 16       |   578.3 ns | 11.44 ns |  17.12 ns |  1.07 |    0.03 |         - |          NA |
| Foreach_Compiler        | .NET 8.0  | .NET 8.0  | 16       |   543.3 ns |  2.29 ns |   2.03 ns |  1.00 |    0.00 |         - |          NA |
| Foreach_Manual          | .NET 8.0  | .NET 8.0  | 16       |   545.0 ns | 10.87 ns |  18.45 ns |  1.00 |    0.03 |         - |          NA |
| Foreach_CompilerBlocked | .NET 8.0  | .NET 8.0  | 16       |   581.3 ns |  6.95 ns |   6.16 ns |  1.07 |    0.01 |         - |          NA |
| Foreach_ManualBlocked   | .NET 8.0  | .NET 8.0  | 16       |   542.5 ns |  1.47 ns |   1.30 ns |  1.00 |    0.00 |         - |          NA |
| Foreach_Compiler        | .NET 9.0  | .NET 9.0  | 16       |   541.9 ns |  2.06 ns |   1.83 ns |  1.00 |    0.00 |         - |          NA |
| Foreach_Manual          | .NET 9.0  | .NET 9.0  | 16       |   509.6 ns |  1.27 ns |   1.12 ns |  0.94 |    0.00 |         - |          NA |
| Foreach_CompilerBlocked | .NET 9.0  | .NET 9.0  | 16       |   543.0 ns |  1.56 ns |   1.22 ns |  1.00 |    0.00 |         - |          NA |
| Foreach_ManualBlocked   | .NET 9.0  | .NET 9.0  | 16       |   563.2 ns |  4.67 ns |   3.90 ns |  1.04 |    0.01 |         - |          NA |
|                         |           |           |          |            |          |           |       |         |           |             |
| **Foreach_Compiler**        | **.NET 10.0** | **.NET 10.0** | **64**       | **2,063.2 ns** | **41.15 ns** | **114.04 ns** |  **1.00** |    **0.08** |         **-** |          **NA** |
| Foreach_Manual          | .NET 10.0 | .NET 10.0 | 64       | 2,004.1 ns | 39.40 ns |  67.97 ns |  0.97 |    0.06 |         - |          NA |
| Foreach_CompilerBlocked | .NET 10.0 | .NET 10.0 | 64       | 2,345.7 ns | 14.65 ns |  13.70 ns |  1.14 |    0.06 |         - |          NA |
| Foreach_ManualBlocked   | .NET 10.0 | .NET 10.0 | 64       | 2,344.3 ns | 29.95 ns |  26.55 ns |  1.14 |    0.06 |         - |          NA |
| Foreach_Compiler        | .NET 8.0  | .NET 8.0  | 64       | 1,953.2 ns |  9.23 ns |   7.71 ns |  0.95 |    0.05 |         - |          NA |
| Foreach_Manual          | .NET 8.0  | .NET 8.0  | 64       | 1,925.0 ns | 13.09 ns |  12.24 ns |  0.94 |    0.05 |         - |          NA |
| Foreach_CompilerBlocked | .NET 8.0  | .NET 8.0  | 64       | 1,952.2 ns | 12.04 ns |   9.40 ns |  0.95 |    0.05 |         - |          NA |
| Foreach_ManualBlocked   | .NET 8.0  | .NET 8.0  | 64       | 1,952.7 ns | 11.75 ns |  10.42 ns |  0.95 |    0.05 |         - |          NA |
| Foreach_Compiler        | .NET 9.0  | .NET 9.0  | 64       | 2,106.0 ns | 42.10 ns | 118.07 ns |  1.02 |    0.08 |         - |          NA |
| Foreach_Manual          | .NET 9.0  | .NET 9.0  | 64       | 2,054.9 ns | 41.11 ns |  96.10 ns |  1.00 |    0.07 |         - |          NA |
| Foreach_CompilerBlocked | .NET 9.0  | .NET 9.0  | 64       | 2,353.6 ns | 20.06 ns |  18.77 ns |  1.14 |    0.06 |         - |          NA |
| Foreach_ManualBlocked   | .NET 9.0  | .NET 9.0  | 64       | 2,365.9 ns | 27.96 ns |  23.35 ns |  1.15 |    0.06 |         - |          NA |
