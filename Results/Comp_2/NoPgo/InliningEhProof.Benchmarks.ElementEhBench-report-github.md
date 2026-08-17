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
| **Element_Finally**        | **.NET 10.0** | **.NET 10.0** | **4**        |   **5.668 ns** | **0.0572 ns** | **0.0535 ns** |  **1.00** |    **0.01** |         **-** |          **NA** |
| Element_Plain          | .NET 10.0 | .NET 10.0 | 4        |   2.704 ns | 0.0069 ns | 0.0065 ns |  0.48 |    0.00 |         - |          NA |
| Element_FinallyBlocked | .NET 10.0 | .NET 10.0 | 4        |   7.585 ns | 0.0150 ns | 0.0126 ns |  1.34 |    0.01 |         - |          NA |
| Element_PlainBlocked   | .NET 10.0 | .NET 10.0 | 4        |   5.248 ns | 0.0065 ns | 0.0054 ns |  0.93 |    0.01 |         - |          NA |
| Element_Finally        | .NET 8.0  | .NET 8.0  | 4        |   6.261 ns | 0.0555 ns | 0.0519 ns |  1.10 |    0.01 |         - |          NA |
| Element_Plain          | .NET 8.0  | .NET 8.0  | 4        |   2.598 ns | 0.0721 ns | 0.0674 ns |  0.46 |    0.01 |         - |          NA |
| Element_FinallyBlocked | .NET 8.0  | .NET 8.0  | 4        |   5.476 ns | 0.1194 ns | 0.1117 ns |  0.97 |    0.02 |         - |          NA |
| Element_PlainBlocked   | .NET 8.0  | .NET 8.0  | 4        |   4.411 ns | 0.0847 ns | 0.0792 ns |  0.78 |    0.02 |         - |          NA |
| Element_Finally        | .NET 9.0  | .NET 9.0  | 4        |   6.207 ns | 0.0873 ns | 0.0817 ns |  1.10 |    0.02 |         - |          NA |
| Element_Plain          | .NET 9.0  | .NET 9.0  | 4        |   2.651 ns | 0.0134 ns | 0.0126 ns |  0.47 |    0.00 |         - |          NA |
| Element_FinallyBlocked | .NET 9.0  | .NET 9.0  | 4        |   7.001 ns | 0.0595 ns | 0.0557 ns |  1.24 |    0.01 |         - |          NA |
| Element_PlainBlocked   | .NET 9.0  | .NET 9.0  | 4        |   5.247 ns | 0.0498 ns | 0.0466 ns |  0.93 |    0.01 |         - |          NA |
|                        |           |           |          |            |           |           |       |         |           |             |
| **Element_Finally**        | **.NET 10.0** | **.NET 10.0** | **16**       |  **29.589 ns** | **0.3978 ns** | **0.3721 ns** |  **1.00** |    **0.02** |         **-** |          **NA** |
| Element_Plain          | .NET 10.0 | .NET 10.0 | 16       |  15.522 ns | 0.0948 ns | 0.0840 ns |  0.52 |    0.01 |         - |          NA |
| Element_FinallyBlocked | .NET 10.0 | .NET 10.0 | 16       |  29.427 ns | 0.3254 ns | 0.3043 ns |  0.99 |    0.02 |         - |          NA |
| Element_PlainBlocked   | .NET 10.0 | .NET 10.0 | 16       |  19.724 ns | 0.2223 ns | 0.2079 ns |  0.67 |    0.01 |         - |          NA |
| Element_Finally        | .NET 8.0  | .NET 8.0  | 16       |  21.539 ns | 0.4164 ns | 0.3895 ns |  0.73 |    0.02 |         - |          NA |
| Element_Plain          | .NET 8.0  | .NET 8.0  | 16       |  15.790 ns | 0.1758 ns | 0.1645 ns |  0.53 |    0.01 |         - |          NA |
| Element_FinallyBlocked | .NET 8.0  | .NET 8.0  | 16       |  20.753 ns | 0.2361 ns | 0.2209 ns |  0.70 |    0.01 |         - |          NA |
| Element_PlainBlocked   | .NET 8.0  | .NET 8.0  | 16       |  16.993 ns | 0.2787 ns | 0.2607 ns |  0.57 |    0.01 |         - |          NA |
| Element_Finally        | .NET 9.0  | .NET 9.0  | 16       |  26.303 ns | 0.2636 ns | 0.2466 ns |  0.89 |    0.01 |         - |          NA |
| Element_Plain          | .NET 9.0  | .NET 9.0  | 16       |  15.572 ns | 0.0763 ns | 0.0714 ns |  0.53 |    0.01 |         - |          NA |
| Element_FinallyBlocked | .NET 9.0  | .NET 9.0  | 16       |  26.266 ns | 0.1029 ns | 0.0963 ns |  0.89 |    0.01 |         - |          NA |
| Element_PlainBlocked   | .NET 9.0  | .NET 9.0  | 16       |  20.431 ns | 0.0628 ns | 0.0587 ns |  0.69 |    0.01 |         - |          NA |
|                        |           |           |          |            |           |           |       |         |           |             |
| **Element_Finally**        | **.NET 10.0** | **.NET 10.0** | **64**       | **120.289 ns** | **0.6272 ns** | **0.5560 ns** |  **1.00** |    **0.01** |         **-** |          **NA** |
| Element_Plain          | .NET 10.0 | .NET 10.0 | 64       |  67.416 ns | 0.1797 ns | 0.1681 ns |  0.56 |    0.00 |         - |          NA |
| Element_FinallyBlocked | .NET 10.0 | .NET 10.0 | 64       | 119.959 ns | 0.3256 ns | 0.2886 ns |  1.00 |    0.00 |         - |          NA |
| Element_PlainBlocked   | .NET 10.0 | .NET 10.0 | 64       |  80.445 ns | 0.2418 ns | 0.2144 ns |  0.67 |    0.00 |         - |          NA |
| Element_Finally        | .NET 8.0  | .NET 8.0  | 64       |  83.507 ns | 0.2684 ns | 0.2379 ns |  0.69 |    0.00 |         - |          NA |
| Element_Plain          | .NET 8.0  | .NET 8.0  | 64       |  68.220 ns | 0.4477 ns | 0.4188 ns |  0.57 |    0.00 |         - |          NA |
| Element_FinallyBlocked | .NET 8.0  | .NET 8.0  | 64       |  83.512 ns | 0.2660 ns | 0.2358 ns |  0.69 |    0.00 |         - |          NA |
| Element_PlainBlocked   | .NET 8.0  | .NET 8.0  | 64       |  67.711 ns | 0.3018 ns | 0.2675 ns |  0.56 |    0.00 |         - |          NA |
| Element_Finally        | .NET 9.0  | .NET 9.0  | 64       | 108.822 ns | 0.6532 ns | 0.6110 ns |  0.90 |    0.01 |         - |          NA |
| Element_Plain          | .NET 9.0  | .NET 9.0  | 64       |  68.100 ns | 0.4720 ns | 0.4415 ns |  0.57 |    0.00 |         - |          NA |
| Element_FinallyBlocked | .NET 9.0  | .NET 9.0  | 64       | 108.681 ns | 0.3528 ns | 0.3128 ns |  0.90 |    0.00 |         - |          NA |
| Element_PlainBlocked   | .NET 9.0  | .NET 9.0  | 64       |  82.051 ns | 0.1773 ns | 0.1572 ns |  0.68 |    0.00 |         - |          NA |
