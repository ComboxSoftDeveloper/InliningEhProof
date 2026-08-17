```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.20348.5386)
Intel Xeon Silver 4314 CPU 2.40GHz, 2 CPU, 64 logical and 32 physical cores
.NET SDK 11.0.100-preview.5.26302.115
  [Host]    : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4
  .NET 10.0 : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4
  .NET 8.0  : .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4
  .NET 9.0  : .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4


```
| Method               | Job       | Runtime   | Elements | Mean       | Error     | StdDev    | Ratio | Allocated | Alloc Ratio |
|--------------------- |---------- |---------- |--------- |-----------:|----------:|----------:|------:|----------:|------------:|
| **Guard_Finally**        | **.NET 10.0** | **.NET 10.0** | **4**        |   **6.098 ns** | **0.0249 ns** | **0.0220 ns** |  **1.00** |         **-** |          **NA** |
| Guard_Plain          | .NET 10.0 | .NET 10.0 | 4        |   4.266 ns | 0.0381 ns | 0.0357 ns |  0.70 |         - |          NA |
| Guard_FinallyBlocked | .NET 10.0 | .NET 10.0 | 4        |  10.950 ns | 0.0846 ns | 0.0791 ns |  1.80 |         - |          NA |
| Guard_PlainBlocked   | .NET 10.0 | .NET 10.0 | 4        |   8.120 ns | 0.0317 ns | 0.0297 ns |  1.33 |         - |          NA |
| Guard_Finally        | .NET 8.0  | .NET 8.0  | 4        |   8.866 ns | 0.0727 ns | 0.0645 ns |  1.45 |         - |          NA |
| Guard_Plain          | .NET 8.0  | .NET 8.0  | 4        |   4.234 ns | 0.0392 ns | 0.0367 ns |  0.69 |         - |          NA |
| Guard_FinallyBlocked | .NET 8.0  | .NET 8.0  | 4        |   9.017 ns | 0.0861 ns | 0.0763 ns |  1.48 |         - |          NA |
| Guard_PlainBlocked   | .NET 8.0  | .NET 8.0  | 4        |   9.527 ns | 0.0682 ns | 0.0638 ns |  1.56 |         - |          NA |
| Guard_Finally        | .NET 9.0  | .NET 9.0  | 4        |   8.970 ns | 0.0629 ns | 0.0589 ns |  1.47 |         - |          NA |
| Guard_Plain          | .NET 9.0  | .NET 9.0  | 4        |   4.191 ns | 0.0416 ns | 0.0369 ns |  0.69 |         - |          NA |
| Guard_FinallyBlocked | .NET 9.0  | .NET 9.0  | 4        |   9.010 ns | 0.0736 ns | 0.0688 ns |  1.48 |         - |          NA |
| Guard_PlainBlocked   | .NET 9.0  | .NET 9.0  | 4        |   8.294 ns | 0.0830 ns | 0.0777 ns |  1.36 |         - |          NA |
|                      |           |           |          |            |           |           |       |           |             |
| **Guard_Finally**        | **.NET 10.0** | **.NET 10.0** | **16**       |  **37.248 ns** | **0.2651 ns** | **0.2350 ns** |  **1.00** |         **-** |          **NA** |
| Guard_Plain          | .NET 10.0 | .NET 10.0 | 16       |   7.132 ns | 0.0685 ns | 0.0640 ns |  0.19 |         - |          NA |
| Guard_FinallyBlocked | .NET 10.0 | .NET 10.0 | 16       |  40.851 ns | 0.2599 ns | 0.2431 ns |  1.10 |         - |          NA |
| Guard_PlainBlocked   | .NET 10.0 | .NET 10.0 | 16       |  29.219 ns | 0.1432 ns | 0.1196 ns |  0.78 |         - |          NA |
| Guard_Finally        | .NET 8.0  | .NET 8.0  | 16       |  30.566 ns | 0.3761 ns | 0.3518 ns |  0.82 |         - |          NA |
| Guard_Plain          | .NET 8.0  | .NET 8.0  | 16       |   7.214 ns | 0.0930 ns | 0.0870 ns |  0.19 |         - |          NA |
| Guard_FinallyBlocked | .NET 8.0  | .NET 8.0  | 16       |  30.780 ns | 0.2396 ns | 0.2124 ns |  0.83 |         - |          NA |
| Guard_PlainBlocked   | .NET 8.0  | .NET 8.0  | 16       |  35.528 ns | 0.2088 ns | 0.1851 ns |  0.95 |         - |          NA |
| Guard_Finally        | .NET 9.0  | .NET 9.0  | 16       |  30.072 ns | 0.2391 ns | 0.2120 ns |  0.81 |         - |          NA |
| Guard_Plain          | .NET 9.0  | .NET 9.0  | 16       |   7.076 ns | 0.0641 ns | 0.0600 ns |  0.19 |         - |          NA |
| Guard_FinallyBlocked | .NET 9.0  | .NET 9.0  | 16       |  30.198 ns | 0.2326 ns | 0.2062 ns |  0.81 |         - |          NA |
| Guard_PlainBlocked   | .NET 9.0  | .NET 9.0  | 16       |  29.272 ns | 0.1686 ns | 0.1407 ns |  0.79 |         - |          NA |
|                      |           |           |          |            |           |           |       |           |             |
| **Guard_Finally**        | **.NET 10.0** | **.NET 10.0** | **64**       | **177.150 ns** | **0.7076 ns** | **0.6272 ns** |  **1.00** |         **-** |          **NA** |
| Guard_Plain          | .NET 10.0 | .NET 10.0 | 64       |  33.686 ns | 0.3330 ns | 0.3115 ns |  0.19 |         - |          NA |
| Guard_FinallyBlocked | .NET 10.0 | .NET 10.0 | 64       | 170.278 ns | 1.7340 ns | 1.6219 ns |  0.96 |         - |          NA |
| Guard_PlainBlocked   | .NET 10.0 | .NET 10.0 | 64       | 113.529 ns | 0.3659 ns | 0.3244 ns |  0.64 |         - |          NA |
| Guard_Finally        | .NET 8.0  | .NET 8.0  | 64       | 129.428 ns | 1.1097 ns | 1.0380 ns |  0.73 |         - |          NA |
| Guard_Plain          | .NET 8.0  | .NET 8.0  | 64       |  32.407 ns | 0.2528 ns | 0.2365 ns |  0.18 |         - |          NA |
| Guard_FinallyBlocked | .NET 8.0  | .NET 8.0  | 64       | 129.562 ns | 0.5829 ns | 0.5167 ns |  0.73 |         - |          NA |
| Guard_PlainBlocked   | .NET 8.0  | .NET 8.0  | 64       | 139.059 ns | 0.8572 ns | 0.8018 ns |  0.78 |         - |          NA |
| Guard_Finally        | .NET 9.0  | .NET 9.0  | 64       | 130.872 ns | 0.8747 ns | 0.8182 ns |  0.74 |         - |          NA |
| Guard_Plain          | .NET 9.0  | .NET 9.0  | 64       |  33.795 ns | 0.3651 ns | 0.3415 ns |  0.19 |         - |          NA |
| Guard_FinallyBlocked | .NET 9.0  | .NET 9.0  | 64       | 143.949 ns | 0.8034 ns | 0.7515 ns |  0.81 |         - |          NA |
| Guard_PlainBlocked   | .NET 9.0  | .NET 9.0  | 64       | 114.027 ns | 0.5686 ns | 0.5040 ns |  0.64 |         - |          NA |
