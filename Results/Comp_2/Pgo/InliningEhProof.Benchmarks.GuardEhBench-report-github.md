```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.6466/22H2/2022Update)
Intel Core i9-10900KF CPU 3.70GHz, 1 CPU, 20 logical and 10 physical cores
.NET SDK 11.0.100-preview.5.26302.115
  [Host]    : .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3
  .NET 10.0 : .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3
  .NET 8.0  : .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3
  .NET 9.0  : .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3


```
| Method               | Job       | Runtime   | Elements | Mean       | Error     | StdDev    | Ratio | RatioSD | Allocated | Alloc Ratio |
|--------------------- |---------- |---------- |--------- |-----------:|----------:|----------:|------:|--------:|----------:|------------:|
| **Guard_Finally**        | **.NET 10.0** | **.NET 10.0** | **4**        |   **3.481 ns** | **0.0244 ns** | **0.0229 ns** |  **1.00** |    **0.01** |         **-** |          **NA** |
| Guard_Plain          | .NET 10.0 | .NET 10.0 | 4        |   1.686 ns | 0.0456 ns | 0.0404 ns |  0.48 |    0.01 |         - |          NA |
| Guard_FinallyBlocked | .NET 10.0 | .NET 10.0 | 4        |   6.210 ns | 0.0284 ns | 0.0266 ns |  1.78 |    0.01 |         - |          NA |
| Guard_PlainBlocked   | .NET 10.0 | .NET 10.0 | 4        |   6.095 ns | 0.0813 ns | 0.0721 ns |  1.75 |    0.02 |         - |          NA |
| Guard_Finally        | .NET 8.0  | .NET 8.0  | 4        |   6.240 ns | 0.0183 ns | 0.0171 ns |  1.79 |    0.01 |         - |          NA |
| Guard_Plain          | .NET 8.0  | .NET 8.0  | 4        |   1.646 ns | 0.0076 ns | 0.0063 ns |  0.47 |    0.00 |         - |          NA |
| Guard_FinallyBlocked | .NET 8.0  | .NET 8.0  | 4        |   5.413 ns | 0.0195 ns | 0.0173 ns |  1.55 |    0.01 |         - |          NA |
| Guard_PlainBlocked   | .NET 8.0  | .NET 8.0  | 4        |   5.261 ns | 0.0181 ns | 0.0161 ns |  1.51 |    0.01 |         - |          NA |
| Guard_Finally        | .NET 9.0  | .NET 9.0  | 4        |   7.305 ns | 0.1661 ns | 0.1846 ns |  2.10 |    0.05 |         - |          NA |
| Guard_Plain          | .NET 9.0  | .NET 9.0  | 4        |   1.137 ns | 0.0228 ns | 0.0213 ns |  0.33 |    0.01 |         - |          NA |
| Guard_FinallyBlocked | .NET 9.0  | .NET 9.0  | 4        |   6.858 ns | 0.0966 ns | 0.0903 ns |  1.97 |    0.03 |         - |          NA |
| Guard_PlainBlocked   | .NET 9.0  | .NET 9.0  | 4        |   4.441 ns | 0.0760 ns | 0.0711 ns |  1.28 |    0.02 |         - |          NA |
|                      |           |           |          |            |           |           |       |         |           |             |
| **Guard_Finally**        | **.NET 10.0** | **.NET 10.0** | **16**       |  **19.746 ns** | **0.2849 ns** | **0.2665 ns** |  **1.00** |    **0.02** |         **-** |          **NA** |
| Guard_Plain          | .NET 10.0 | .NET 10.0 | 16       |   4.512 ns | 0.1152 ns | 0.2648 ns |  0.23 |    0.01 |         - |          NA |
| Guard_FinallyBlocked | .NET 10.0 | .NET 10.0 | 16       |  24.031 ns | 0.3286 ns | 0.3074 ns |  1.22 |    0.02 |         - |          NA |
| Guard_PlainBlocked   | .NET 10.0 | .NET 10.0 | 16       |  23.311 ns | 0.3313 ns | 0.3099 ns |  1.18 |    0.02 |         - |          NA |
| Guard_Finally        | .NET 8.0  | .NET 8.0  | 16       |  20.635 ns | 0.2774 ns | 0.2594 ns |  1.05 |    0.02 |         - |          NA |
| Guard_Plain          | .NET 8.0  | .NET 8.0  | 16       |   4.858 ns | 0.0699 ns | 0.0654 ns |  0.25 |    0.00 |         - |          NA |
| Guard_FinallyBlocked | .NET 8.0  | .NET 8.0  | 16       |  20.269 ns | 0.0550 ns | 0.0460 ns |  1.03 |    0.01 |         - |          NA |
| Guard_PlainBlocked   | .NET 8.0  | .NET 8.0  | 16       |  20.355 ns | 0.2912 ns | 0.2724 ns |  1.03 |    0.02 |         - |          NA |
| Guard_Finally        | .NET 9.0  | .NET 9.0  | 16       |  26.132 ns | 0.1882 ns | 0.1760 ns |  1.32 |    0.02 |         - |          NA |
| Guard_Plain          | .NET 9.0  | .NET 9.0  | 16       |   4.043 ns | 0.0572 ns | 0.0535 ns |  0.20 |    0.00 |         - |          NA |
| Guard_FinallyBlocked | .NET 9.0  | .NET 9.0  | 16       |  26.567 ns | 0.4004 ns | 0.3745 ns |  1.35 |    0.03 |         - |          NA |
| Guard_PlainBlocked   | .NET 9.0  | .NET 9.0  | 16       |  16.589 ns | 0.1987 ns | 0.1858 ns |  0.84 |    0.01 |         - |          NA |
|                      |           |           |          |            |           |           |       |         |           |             |
| **Guard_Finally**        | **.NET 10.0** | **.NET 10.0** | **64**       |  **99.705 ns** | **1.2285 ns** | **1.1491 ns** |  **1.00** |    **0.02** |         **-** |          **NA** |
| Guard_Plain          | .NET 10.0 | .NET 10.0 | 64       |  24.219 ns | 0.4353 ns | 0.3859 ns |  0.24 |    0.00 |         - |          NA |
| Guard_FinallyBlocked | .NET 10.0 | .NET 10.0 | 64       |  83.790 ns | 0.9786 ns | 0.9154 ns |  0.84 |    0.01 |         - |          NA |
| Guard_PlainBlocked   | .NET 10.0 | .NET 10.0 | 64       |  80.918 ns | 1.3500 ns | 1.2628 ns |  0.81 |    0.02 |         - |          NA |
| Guard_Finally        | .NET 8.0  | .NET 8.0  | 64       |  84.111 ns | 1.0743 ns | 1.0049 ns |  0.84 |    0.01 |         - |          NA |
| Guard_Plain          | .NET 8.0  | .NET 8.0  | 64       |  25.205 ns | 0.2521 ns | 0.2106 ns |  0.25 |    0.00 |         - |          NA |
| Guard_FinallyBlocked | .NET 8.0  | .NET 8.0  | 64       |  84.883 ns | 0.7708 ns | 0.7210 ns |  0.85 |    0.01 |         - |          NA |
| Guard_PlainBlocked   | .NET 8.0  | .NET 8.0  | 64       |  81.946 ns | 0.9153 ns | 0.8562 ns |  0.82 |    0.01 |         - |          NA |
| Guard_Finally        | .NET 9.0  | .NET 9.0  | 64       | 107.492 ns | 0.5817 ns | 0.5442 ns |  1.08 |    0.01 |         - |          NA |
| Guard_Plain          | .NET 9.0  | .NET 9.0  | 64       |  23.980 ns | 0.2129 ns | 0.1991 ns |  0.24 |    0.00 |         - |          NA |
| Guard_FinallyBlocked | .NET 9.0  | .NET 9.0  | 64       | 109.011 ns | 0.4845 ns | 0.4532 ns |  1.09 |    0.01 |         - |          NA |
| Guard_PlainBlocked   | .NET 9.0  | .NET 9.0  | 64       |  68.201 ns | 0.7453 ns | 0.6223 ns |  0.68 |    0.01 |         - |          NA |
