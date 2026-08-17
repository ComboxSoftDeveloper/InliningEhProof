```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.6466/22H2/2022Update)
Intel Core i9-10900KF CPU 3.70GHz, 1 CPU, 20 logical and 10 physical cores
.NET SDK 11.0.100-preview.5.26302.115
  [Host]    : .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3
  .NET 10.0 : .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3
  .NET 8.0  : .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3
  .NET 9.0  : .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3


```
| Method                  | Job       | Runtime   | Elements | Mean       | Error    | StdDev   | Ratio | RatioSD | Allocated | Alloc Ratio |
|------------------------ |---------- |---------- |--------- |-----------:|---------:|---------:|------:|--------:|----------:|------------:|
| **Foreach_Compiler**        | **.NET 10.0** | **.NET 10.0** | **4**        |   **205.9 ns** |  **1.92 ns** |  **1.80 ns** |  **1.00** |    **0.01** |         **-** |          **NA** |
| Foreach_Manual          | .NET 10.0 | .NET 10.0 | 4        |   211.3 ns |  0.83 ns |  0.78 ns |  1.03 |    0.01 |         - |          NA |
| Foreach_CompilerBlocked | .NET 10.0 | .NET 10.0 | 4        |   207.8 ns |  0.83 ns |  0.74 ns |  1.01 |    0.01 |         - |          NA |
| Foreach_ManualBlocked   | .NET 10.0 | .NET 10.0 | 4        |   207.3 ns |  0.98 ns |  0.87 ns |  1.01 |    0.01 |         - |          NA |
| Foreach_Compiler        | .NET 8.0  | .NET 8.0  | 4        |   223.0 ns |  0.83 ns |  0.74 ns |  1.08 |    0.01 |         - |          NA |
| Foreach_Manual          | .NET 8.0  | .NET 8.0  | 4        |   224.7 ns |  0.90 ns |  0.84 ns |  1.09 |    0.01 |         - |          NA |
| Foreach_CompilerBlocked | .NET 8.0  | .NET 8.0  | 4        |   222.4 ns |  0.51 ns |  0.45 ns |  1.08 |    0.01 |         - |          NA |
| Foreach_ManualBlocked   | .NET 8.0  | .NET 8.0  | 4        |   226.0 ns |  0.71 ns |  0.63 ns |  1.10 |    0.01 |         - |          NA |
| Foreach_Compiler        | .NET 9.0  | .NET 9.0  | 4        |   206.8 ns |  0.67 ns |  0.59 ns |  1.00 |    0.01 |         - |          NA |
| Foreach_Manual          | .NET 9.0  | .NET 9.0  | 4        |   199.6 ns |  2.87 ns |  2.69 ns |  0.97 |    0.02 |         - |          NA |
| Foreach_CompilerBlocked | .NET 9.0  | .NET 9.0  | 4        |   201.5 ns |  2.75 ns |  2.57 ns |  0.98 |    0.01 |         - |          NA |
| Foreach_ManualBlocked   | .NET 9.0  | .NET 9.0  | 4        |   199.9 ns |  2.95 ns |  2.76 ns |  0.97 |    0.02 |         - |          NA |
|                         |           |           |          |            |          |          |       |         |           |             |
| **Foreach_Compiler**        | **.NET 10.0** | **.NET 10.0** | **16**       |   **455.9 ns** |  **1.29 ns** |  **1.08 ns** |  **1.00** |    **0.00** |         **-** |          **NA** |
| Foreach_Manual          | .NET 10.0 | .NET 10.0 | 16       |   454.8 ns |  1.05 ns |  0.93 ns |  1.00 |    0.00 |         - |          NA |
| Foreach_CompilerBlocked | .NET 10.0 | .NET 10.0 | 16       |   451.5 ns |  1.80 ns |  1.60 ns |  0.99 |    0.00 |         - |          NA |
| Foreach_ManualBlocked   | .NET 10.0 | .NET 10.0 | 16       |   453.6 ns |  1.21 ns |  1.07 ns |  0.99 |    0.00 |         - |          NA |
| Foreach_Compiler        | .NET 8.0  | .NET 8.0  | 16       |   536.8 ns |  1.71 ns |  1.60 ns |  1.18 |    0.00 |         - |          NA |
| Foreach_Manual          | .NET 8.0  | .NET 8.0  | 16       |   541.0 ns |  2.01 ns |  1.88 ns |  1.19 |    0.00 |         - |          NA |
| Foreach_CompilerBlocked | .NET 8.0  | .NET 8.0  | 16       |   539.5 ns |  1.77 ns |  1.66 ns |  1.18 |    0.00 |         - |          NA |
| Foreach_ManualBlocked   | .NET 8.0  | .NET 8.0  | 16       |   539.4 ns |  2.25 ns |  1.76 ns |  1.18 |    0.00 |         - |          NA |
| Foreach_Compiler        | .NET 9.0  | .NET 9.0  | 16       |   452.8 ns |  1.65 ns |  1.55 ns |  0.99 |    0.00 |         - |          NA |
| Foreach_Manual          | .NET 9.0  | .NET 9.0  | 16       |   456.1 ns |  4.69 ns |  4.39 ns |  1.00 |    0.01 |         - |          NA |
| Foreach_CompilerBlocked | .NET 9.0  | .NET 9.0  | 16       |   458.0 ns |  3.72 ns |  3.48 ns |  1.00 |    0.01 |         - |          NA |
| Foreach_ManualBlocked   | .NET 9.0  | .NET 9.0  | 16       |   454.0 ns |  2.52 ns |  2.36 ns |  1.00 |    0.01 |         - |          NA |
|                         |           |           |          |            |          |          |       |         |           |             |
| **Foreach_Compiler**        | **.NET 10.0** | **.NET 10.0** | **64**       | **2,054.5 ns** | **10.12 ns** |  **8.97 ns** |  **1.00** |    **0.01** |         **-** |          **NA** |
| Foreach_Manual          | .NET 10.0 | .NET 10.0 | 64       | 2,049.5 ns |  8.83 ns |  8.26 ns |  1.00 |    0.01 |         - |          NA |
| Foreach_CompilerBlocked | .NET 10.0 | .NET 10.0 | 64       | 2,052.1 ns |  8.70 ns |  8.14 ns |  1.00 |    0.01 |         - |          NA |
| Foreach_ManualBlocked   | .NET 10.0 | .NET 10.0 | 64       | 2,048.7 ns | 12.75 ns | 11.93 ns |  1.00 |    0.01 |         - |          NA |
| Foreach_Compiler        | .NET 8.0  | .NET 8.0  | 64       | 2,377.3 ns |  8.03 ns |  7.52 ns |  1.16 |    0.01 |         - |          NA |
| Foreach_Manual          | .NET 8.0  | .NET 8.0  | 64       | 2,360.7 ns |  5.86 ns |  5.19 ns |  1.15 |    0.01 |         - |          NA |
| Foreach_CompilerBlocked | .NET 8.0  | .NET 8.0  | 64       | 2,381.7 ns |  9.04 ns |  8.46 ns |  1.16 |    0.01 |         - |          NA |
| Foreach_ManualBlocked   | .NET 8.0  | .NET 8.0  | 64       | 2,370.1 ns | 14.56 ns | 13.62 ns |  1.15 |    0.01 |         - |          NA |
| Foreach_Compiler        | .NET 9.0  | .NET 9.0  | 64       | 2,040.1 ns |  6.38 ns |  5.65 ns |  0.99 |    0.00 |         - |          NA |
| Foreach_Manual          | .NET 9.0  | .NET 9.0  | 64       | 2,039.6 ns |  3.63 ns |  3.39 ns |  0.99 |    0.00 |         - |          NA |
| Foreach_CompilerBlocked | .NET 9.0  | .NET 9.0  | 64       | 2,030.6 ns |  6.82 ns |  5.32 ns |  0.99 |    0.00 |         - |          NA |
| Foreach_ManualBlocked   | .NET 9.0  | .NET 9.0  | 64       | 2,028.1 ns | 10.82 ns | 10.12 ns |  0.99 |    0.01 |         - |          NA |
