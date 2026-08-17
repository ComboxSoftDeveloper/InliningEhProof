```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.17763.3165/1809/October2018Update/Redstone5)
AMD Ryzen 9 5950X 3.39GHz, 1 CPU, 32 logical and 16 physical cores
.NET SDK 11.0.100-preview.5.26302.115
  [Host]    : .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3
  .NET 10.0 : .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3
  .NET 8.0  : .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3
  .NET 9.0  : .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3


```
| Method                 | Job       | Runtime   | Elements | Mean       | Error     | StdDev    | Ratio | RatioSD | Allocated | Alloc Ratio |
|----------------------- |---------- |---------- |--------- |-----------:|----------:|----------:|------:|--------:|----------:|------------:|
| **Element_Finally**        | **.NET 10.0** | **.NET 10.0** | **4**        |   **1.306 ns** | **0.0130 ns** | **0.0108 ns** |  **1.00** |    **0.01** |         **-** |          **NA** |
| Element_Plain          | .NET 10.0 | .NET 10.0 | 4        |   1.247 ns | 0.0184 ns | 0.0144 ns |  0.96 |    0.01 |         - |          NA |
| Element_FinallyBlocked | .NET 10.0 | .NET 10.0 | 4        |   5.941 ns | 0.0157 ns | 0.0131 ns |  4.55 |    0.04 |         - |          NA |
| Element_PlainBlocked   | .NET 10.0 | .NET 10.0 | 4        |   5.590 ns | 0.0265 ns | 0.0235 ns |  4.28 |    0.04 |         - |          NA |
| Element_Finally        | .NET 8.0  | .NET 8.0  | 4        |   7.401 ns | 0.0369 ns | 0.0308 ns |  5.67 |    0.05 |         - |          NA |
| Element_Plain          | .NET 8.0  | .NET 8.0  | 4        |   1.147 ns | 0.0436 ns | 0.0386 ns |  0.88 |    0.03 |         - |          NA |
| Element_FinallyBlocked | .NET 8.0  | .NET 8.0  | 4        |   7.377 ns | 0.0279 ns | 0.0261 ns |  5.65 |    0.05 |         - |          NA |
| Element_PlainBlocked   | .NET 8.0  | .NET 8.0  | 4        |   5.028 ns | 0.0190 ns | 0.0159 ns |  3.85 |    0.03 |         - |          NA |
| Element_Finally        | .NET 9.0  | .NET 9.0  | 4        |   6.534 ns | 0.0246 ns | 0.0218 ns |  5.00 |    0.04 |         - |          NA |
| Element_Plain          | .NET 9.0  | .NET 9.0  | 4        |   1.225 ns | 0.0341 ns | 0.0285 ns |  0.94 |    0.02 |         - |          NA |
| Element_FinallyBlocked | .NET 9.0  | .NET 9.0  | 4        |   6.530 ns | 0.0187 ns | 0.0175 ns |  5.00 |    0.04 |         - |          NA |
| Element_PlainBlocked   | .NET 9.0  | .NET 9.0  | 4        |   5.647 ns | 0.0883 ns | 0.0826 ns |  4.32 |    0.07 |         - |          NA |
|                        |           |           |          |            |           |           |       |         |           |             |
| **Element_Finally**        | **.NET 10.0** | **.NET 10.0** | **16**       |   **5.838 ns** | **0.1187 ns** | **0.0991 ns** |  **1.00** |    **0.02** |         **-** |          **NA** |
| Element_Plain          | .NET 10.0 | .NET 10.0 | 16       |   6.459 ns | 0.1285 ns | 0.1004 ns |  1.11 |    0.02 |         - |          NA |
| Element_FinallyBlocked | .NET 10.0 | .NET 10.0 | 16       |  22.891 ns | 0.0836 ns | 0.0782 ns |  3.92 |    0.06 |         - |          NA |
| Element_PlainBlocked   | .NET 10.0 | .NET 10.0 | 16       |  22.462 ns | 0.1714 ns | 0.1338 ns |  3.85 |    0.07 |         - |          NA |
| Element_Finally        | .NET 8.0  | .NET 8.0  | 16       |  30.088 ns | 0.2294 ns | 0.2145 ns |  5.16 |    0.09 |         - |          NA |
| Element_Plain          | .NET 8.0  | .NET 8.0  | 16       |   5.001 ns | 0.0465 ns | 0.0388 ns |  0.86 |    0.02 |         - |          NA |
| Element_FinallyBlocked | .NET 8.0  | .NET 8.0  | 16       |  29.355 ns | 0.2043 ns | 0.1911 ns |  5.03 |    0.09 |         - |          NA |
| Element_PlainBlocked   | .NET 8.0  | .NET 8.0  | 16       |  19.294 ns | 0.0812 ns | 0.0678 ns |  3.31 |    0.05 |         - |          NA |
| Element_Finally        | .NET 9.0  | .NET 9.0  | 16       |  26.419 ns | 0.2121 ns | 0.1984 ns |  4.53 |    0.08 |         - |          NA |
| Element_Plain          | .NET 9.0  | .NET 9.0  | 16       |   6.342 ns | 0.0629 ns | 0.0525 ns |  1.09 |    0.02 |         - |          NA |
| Element_FinallyBlocked | .NET 9.0  | .NET 9.0  | 16       |  26.178 ns | 0.0813 ns | 0.0760 ns |  4.49 |    0.07 |         - |          NA |
| Element_PlainBlocked   | .NET 9.0  | .NET 9.0  | 16       |  22.460 ns | 0.1708 ns | 0.1426 ns |  3.85 |    0.07 |         - |          NA |
|                        |           |           |          |            |           |           |       |         |           |             |
| **Element_Finally**        | **.NET 10.0** | **.NET 10.0** | **64**       |  **18.080 ns** | **0.1829 ns** | **0.1621 ns** |  **1.00** |    **0.01** |         **-** |          **NA** |
| Element_Plain          | .NET 10.0 | .NET 10.0 | 64       |  21.488 ns | 0.1446 ns | 0.1282 ns |  1.19 |    0.01 |         - |          NA |
| Element_FinallyBlocked | .NET 10.0 | .NET 10.0 | 64       |  91.051 ns | 0.9835 ns | 0.8719 ns |  5.04 |    0.06 |         - |          NA |
| Element_PlainBlocked   | .NET 10.0 | .NET 10.0 | 64       |  88.659 ns | 0.3113 ns | 0.2760 ns |  4.90 |    0.04 |         - |          NA |
| Element_Finally        | .NET 8.0  | .NET 8.0  | 64       | 119.142 ns | 1.4145 ns | 1.3231 ns |  6.59 |    0.09 |         - |          NA |
| Element_Plain          | .NET 8.0  | .NET 8.0  | 64       |  20.632 ns | 0.4342 ns | 0.5944 ns |  1.14 |    0.03 |         - |          NA |
| Element_FinallyBlocked | .NET 8.0  | .NET 8.0  | 64       | 117.647 ns | 0.3579 ns | 0.2989 ns |  6.51 |    0.06 |         - |          NA |
| Element_PlainBlocked   | .NET 8.0  | .NET 8.0  | 64       |  74.673 ns | 0.3408 ns | 0.3188 ns |  4.13 |    0.04 |         - |          NA |
| Element_Finally        | .NET 9.0  | .NET 9.0  | 64       | 105.128 ns | 1.0823 ns | 0.9595 ns |  5.81 |    0.07 |         - |          NA |
| Element_Plain          | .NET 9.0  | .NET 9.0  | 64       |  21.513 ns | 0.4562 ns | 0.6687 ns |  1.19 |    0.04 |         - |          NA |
| Element_FinallyBlocked | .NET 9.0  | .NET 9.0  | 64       | 106.282 ns | 1.9915 ns | 3.2159 ns |  5.88 |    0.18 |         - |          NA |
| Element_PlainBlocked   | .NET 9.0  | .NET 9.0  | 64       |  89.718 ns | 1.6893 ns | 1.9454 ns |  4.96 |    0.11 |         - |          NA |
