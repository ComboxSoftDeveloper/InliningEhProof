```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.6466/22H2/2022Update)
Intel Core i9-10900KF CPU 3.70GHz, 1 CPU, 20 logical and 10 physical cores
.NET SDK 11.0.100-preview.5.26302.115
  [Host]    : .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3
  .NET 10.0 : .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3
  .NET 8.0  : .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3
  .NET 9.0  : .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3


```
| Method                 | Job       | Runtime   | Elements | Mean       | Error     | StdDev    | Ratio | RatioSD | Allocated | Alloc Ratio |
|----------------------- |---------- |---------- |--------- |-----------:|----------:|----------:|------:|--------:|----------:|------------:|
| **Element_Finally**        | **.NET 10.0** | **.NET 10.0** | **4**        |   **2.997 ns** | **0.0081 ns** | **0.0072 ns** |  **1.00** |    **0.00** |         **-** |          **NA** |
| Element_Plain          | .NET 10.0 | .NET 10.0 | 4        |   2.625 ns | 0.0318 ns | 0.0266 ns |  0.88 |    0.01 |         - |          NA |
| Element_FinallyBlocked | .NET 10.0 | .NET 10.0 | 4        |   6.783 ns | 0.1564 ns | 0.1536 ns |  2.26 |    0.05 |         - |          NA |
| Element_PlainBlocked   | .NET 10.0 | .NET 10.0 | 4        |   5.173 ns | 0.0355 ns | 0.0332 ns |  1.73 |    0.01 |         - |          NA |
| Element_Finally        | .NET 8.0  | .NET 8.0  | 4        |   6.238 ns | 0.0581 ns | 0.0544 ns |  2.08 |    0.02 |         - |          NA |
| Element_Plain          | .NET 8.0  | .NET 8.0  | 4        |   2.577 ns | 0.0511 ns | 0.0478 ns |  0.86 |    0.02 |         - |          NA |
| Element_FinallyBlocked | .NET 8.0  | .NET 8.0  | 4        |   6.964 ns | 0.1221 ns | 0.1142 ns |  2.32 |    0.04 |         - |          NA |
| Element_PlainBlocked   | .NET 8.0  | .NET 8.0  | 4        |   4.453 ns | 0.0942 ns | 0.0881 ns |  1.49 |    0.03 |         - |          NA |
| Element_Finally        | .NET 9.0  | .NET 9.0  | 4        |   6.170 ns | 0.0534 ns | 0.0474 ns |  2.06 |    0.02 |         - |          NA |
| Element_Plain          | .NET 9.0  | .NET 9.0  | 4        |   2.659 ns | 0.0201 ns | 0.0188 ns |  0.89 |    0.01 |         - |          NA |
| Element_FinallyBlocked | .NET 9.0  | .NET 9.0  | 4        |   6.228 ns | 0.1398 ns | 0.1373 ns |  2.08 |    0.04 |         - |          NA |
| Element_PlainBlocked   | .NET 9.0  | .NET 9.0  | 4        |   5.289 ns | 0.0807 ns | 0.0755 ns |  1.76 |    0.02 |         - |          NA |
|                        |           |           |          |            |           |           |       |         |           |             |
| **Element_Finally**        | **.NET 10.0** | **.NET 10.0** | **16**       |  **15.933 ns** | **0.1807 ns** | **0.1690 ns** |  **1.00** |    **0.01** |         **-** |          **NA** |
| Element_Plain          | .NET 10.0 | .NET 10.0 | 16       |  15.590 ns | 0.1932 ns | 0.1807 ns |  0.98 |    0.01 |         - |          NA |
| Element_FinallyBlocked | .NET 10.0 | .NET 10.0 | 16       |  22.756 ns | 0.1483 ns | 0.1238 ns |  1.43 |    0.02 |         - |          NA |
| Element_PlainBlocked   | .NET 10.0 | .NET 10.0 | 16       |  20.210 ns | 0.1995 ns | 0.1866 ns |  1.27 |    0.02 |         - |          NA |
| Element_Finally        | .NET 8.0  | .NET 8.0  | 16       |  26.037 ns | 0.1365 ns | 0.1210 ns |  1.63 |    0.02 |         - |          NA |
| Element_Plain          | .NET 8.0  | .NET 8.0  | 16       |  15.495 ns | 0.0942 ns | 0.0835 ns |  0.97 |    0.01 |         - |          NA |
| Element_FinallyBlocked | .NET 8.0  | .NET 8.0  | 16       |  26.004 ns | 0.1736 ns | 0.1623 ns |  1.63 |    0.02 |         - |          NA |
| Element_PlainBlocked   | .NET 8.0  | .NET 8.0  | 16       |  16.313 ns | 0.0672 ns | 0.0595 ns |  1.02 |    0.01 |         - |          NA |
| Element_Finally        | .NET 9.0  | .NET 9.0  | 16       |  24.190 ns | 0.2197 ns | 0.2055 ns |  1.52 |    0.02 |         - |          NA |
| Element_Plain          | .NET 9.0  | .NET 9.0  | 16       |  15.327 ns | 0.0276 ns | 0.0230 ns |  0.96 |    0.01 |         - |          NA |
| Element_FinallyBlocked | .NET 9.0  | .NET 9.0  | 16       |  24.039 ns | 0.1959 ns | 0.1832 ns |  1.51 |    0.02 |         - |          NA |
| Element_PlainBlocked   | .NET 9.0  | .NET 9.0  | 16       |  20.240 ns | 0.3080 ns | 0.2881 ns |  1.27 |    0.02 |         - |          NA |
|                        |           |           |          |            |           |           |       |         |           |             |
| **Element_Finally**        | **.NET 10.0** | **.NET 10.0** | **64**       |  **67.113 ns** | **0.7608 ns** | **0.7117 ns** |  **1.00** |    **0.01** |         **-** |          **NA** |
| Element_Plain          | .NET 10.0 | .NET 10.0 | 64       |  67.569 ns | 0.8901 ns | 0.8326 ns |  1.01 |    0.02 |         - |          NA |
| Element_FinallyBlocked | .NET 10.0 | .NET 10.0 | 64       |  94.597 ns | 0.1629 ns | 0.1524 ns |  1.41 |    0.01 |         - |          NA |
| Element_PlainBlocked   | .NET 10.0 | .NET 10.0 | 64       |  81.390 ns | 0.7247 ns | 0.6779 ns |  1.21 |    0.02 |         - |          NA |
| Element_Finally        | .NET 8.0  | .NET 8.0  | 64       | 108.955 ns | 0.4661 ns | 0.4360 ns |  1.62 |    0.02 |         - |          NA |
| Element_Plain          | .NET 8.0  | .NET 8.0  | 64       |  68.961 ns | 0.2550 ns | 0.2386 ns |  1.03 |    0.01 |         - |          NA |
| Element_FinallyBlocked | .NET 8.0  | .NET 8.0  | 64       | 109.291 ns | 0.6776 ns | 0.6338 ns |  1.63 |    0.02 |         - |          NA |
| Element_PlainBlocked   | .NET 8.0  | .NET 8.0  | 64       |  67.348 ns | 0.2142 ns | 0.2003 ns |  1.00 |    0.01 |         - |          NA |
| Element_Finally        | .NET 9.0  | .NET 9.0  | 64       |  98.011 ns | 0.6130 ns | 0.5734 ns |  1.46 |    0.02 |         - |          NA |
| Element_Plain          | .NET 9.0  | .NET 9.0  | 64       |  68.105 ns | 0.4826 ns | 0.4514 ns |  1.01 |    0.01 |         - |          NA |
| Element_FinallyBlocked | .NET 9.0  | .NET 9.0  | 64       |  99.454 ns | 0.5185 ns | 0.4597 ns |  1.48 |    0.02 |         - |          NA |
| Element_PlainBlocked   | .NET 9.0  | .NET 9.0  | 64       |  82.129 ns | 0.7274 ns | 0.6448 ns |  1.22 |    0.02 |         - |          NA |
