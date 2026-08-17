```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.17763.3165/1809/October2018Update/Redstone5)
AMD Ryzen 9 5950X 3.39GHz, 1 CPU, 32 logical and 16 physical cores
.NET SDK 11.0.100-preview.5.26302.115
  [Host]    : .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3
  .NET 10.0 : .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3
  .NET 8.0  : .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3
  .NET 9.0  : .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3


```
| Method               | Job       | Runtime   | Elements | Mean       | Error     | StdDev    | Ratio | RatioSD | Allocated | Alloc Ratio |
|--------------------- |---------- |---------- |--------- |-----------:|----------:|----------:|------:|--------:|----------:|------------:|
| **Guard_Finally**        | **.NET 10.0** | **.NET 10.0** | **4**        |   **4.164 ns** | **0.0212 ns** | **0.0177 ns** |  **1.00** |    **0.01** |         **-** |          **NA** |
| Guard_Plain          | .NET 10.0 | .NET 10.0 | 4        |   1.257 ns | 0.0127 ns | 0.0106 ns |  0.30 |    0.00 |         - |          NA |
| Guard_FinallyBlocked | .NET 10.0 | .NET 10.0 | 4        |   6.520 ns | 0.0257 ns | 0.0228 ns |  1.57 |    0.01 |         - |          NA |
| Guard_PlainBlocked   | .NET 10.0 | .NET 10.0 | 4        |   6.420 ns | 0.0297 ns | 0.0248 ns |  1.54 |    0.01 |         - |          NA |
| Guard_Finally        | .NET 8.0  | .NET 8.0  | 4        |   6.240 ns | 0.0430 ns | 0.0381 ns |  1.50 |    0.01 |         - |          NA |
| Guard_Plain          | .NET 8.0  | .NET 8.0  | 4        |   1.303 ns | 0.0174 ns | 0.0145 ns |  0.31 |    0.00 |         - |          NA |
| Guard_FinallyBlocked | .NET 8.0  | .NET 8.0  | 4        |   6.167 ns | 0.1087 ns | 0.1017 ns |  1.48 |    0.02 |         - |          NA |
| Guard_PlainBlocked   | .NET 8.0  | .NET 8.0  | 4        |   5.645 ns | 0.0410 ns | 0.0364 ns |  1.36 |    0.01 |         - |          NA |
| Guard_Finally        | .NET 9.0  | .NET 9.0  | 4        |   6.554 ns | 0.0576 ns | 0.0449 ns |  1.57 |    0.01 |         - |          NA |
| Guard_Plain          | .NET 9.0  | .NET 9.0  | 4        |   1.575 ns | 0.0528 ns | 0.0468 ns |  0.38 |    0.01 |         - |          NA |
| Guard_FinallyBlocked | .NET 9.0  | .NET 9.0  | 4        |   6.770 ns | 0.1431 ns | 0.1339 ns |  1.63 |    0.03 |         - |          NA |
| Guard_PlainBlocked   | .NET 9.0  | .NET 9.0  | 4        |   5.137 ns | 0.1019 ns | 0.0953 ns |  1.23 |    0.02 |         - |          NA |
|                      |           |           |          |            |           |           |       |         |           |             |
| **Guard_Finally**        | **.NET 10.0** | **.NET 10.0** | **16**       |  **21.342 ns** | **0.0622 ns** | **0.0551 ns** |  **1.00** |    **0.00** |         **-** |          **NA** |
| Guard_Plain          | .NET 10.0 | .NET 10.0 | 16       |   4.578 ns | 0.0940 ns | 0.0879 ns |  0.21 |    0.00 |         - |          NA |
| Guard_FinallyBlocked | .NET 10.0 | .NET 10.0 | 16       |  26.137 ns | 0.1765 ns | 0.1651 ns |  1.22 |    0.01 |         - |          NA |
| Guard_PlainBlocked   | .NET 10.0 | .NET 10.0 | 16       |  25.625 ns | 0.0584 ns | 0.0517 ns |  1.20 |    0.00 |         - |          NA |
| Guard_Finally        | .NET 8.0  | .NET 8.0  | 16       |  23.058 ns | 0.1219 ns | 0.1080 ns |  1.08 |    0.01 |         - |          NA |
| Guard_Plain          | .NET 8.0  | .NET 8.0  | 16       |   4.469 ns | 0.0551 ns | 0.0460 ns |  0.21 |    0.00 |         - |          NA |
| Guard_FinallyBlocked | .NET 8.0  | .NET 8.0  | 16       |  23.073 ns | 0.0712 ns | 0.0666 ns |  1.08 |    0.00 |         - |          NA |
| Guard_PlainBlocked   | .NET 8.0  | .NET 8.0  | 16       |  22.433 ns | 0.1511 ns | 0.1179 ns |  1.05 |    0.01 |         - |          NA |
| Guard_Finally        | .NET 9.0  | .NET 9.0  | 16       |  26.186 ns | 0.1465 ns | 0.1299 ns |  1.23 |    0.01 |         - |          NA |
| Guard_Plain          | .NET 9.0  | .NET 9.0  | 16       |   4.497 ns | 0.1131 ns | 0.1210 ns |  0.21 |    0.01 |         - |          NA |
| Guard_FinallyBlocked | .NET 9.0  | .NET 9.0  | 16       |  26.269 ns | 0.2448 ns | 0.2290 ns |  1.23 |    0.01 |         - |          NA |
| Guard_PlainBlocked   | .NET 9.0  | .NET 9.0  | 16       |  19.505 ns | 0.0814 ns | 0.0680 ns |  0.91 |    0.00 |         - |          NA |
|                      |           |           |          |            |           |           |       |         |           |             |
| **Guard_Finally**        | **.NET 10.0** | **.NET 10.0** | **64**       |  **55.105 ns** | **0.2810 ns** | **0.2491 ns** |  **1.00** |    **0.01** |         **-** |          **NA** |
| Guard_Plain          | .NET 10.0 | .NET 10.0 | 64       |  16.198 ns | 0.1116 ns | 0.0989 ns |  0.29 |    0.00 |         - |          NA |
| Guard_FinallyBlocked | .NET 10.0 | .NET 10.0 | 64       | 103.721 ns | 0.5272 ns | 0.4931 ns |  1.88 |    0.01 |         - |          NA |
| Guard_PlainBlocked   | .NET 10.0 | .NET 10.0 | 64       | 102.183 ns | 0.2068 ns | 0.1935 ns |  1.85 |    0.01 |         - |          NA |
| Guard_Finally        | .NET 8.0  | .NET 8.0  | 64       |  89.534 ns | 0.1688 ns | 0.1410 ns |  1.62 |    0.01 |         - |          NA |
| Guard_Plain          | .NET 8.0  | .NET 8.0  | 64       |  15.947 ns | 0.1503 ns | 0.1332 ns |  0.29 |    0.00 |         - |          NA |
| Guard_FinallyBlocked | .NET 8.0  | .NET 8.0  | 64       |  90.250 ns | 0.7370 ns | 0.6154 ns |  1.64 |    0.01 |         - |          NA |
| Guard_PlainBlocked   | .NET 8.0  | .NET 8.0  | 64       |  88.486 ns | 0.3227 ns | 0.2861 ns |  1.61 |    0.01 |         - |          NA |
| Guard_Finally        | .NET 9.0  | .NET 9.0  | 64       | 103.991 ns | 0.5929 ns | 0.5256 ns |  1.89 |    0.01 |         - |          NA |
| Guard_Plain          | .NET 9.0  | .NET 9.0  | 64       |  16.092 ns | 0.1144 ns | 0.1070 ns |  0.29 |    0.00 |         - |          NA |
| Guard_FinallyBlocked | .NET 9.0  | .NET 9.0  | 64       | 104.808 ns | 1.3105 ns | 1.2258 ns |  1.90 |    0.02 |         - |          NA |
| Guard_PlainBlocked   | .NET 9.0  | .NET 9.0  | 64       |  87.884 ns | 0.8488 ns | 0.7940 ns |  1.59 |    0.02 |         - |          NA |
