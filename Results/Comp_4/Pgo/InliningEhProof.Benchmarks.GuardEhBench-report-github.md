```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.20348.5139)
Intel Xeon W-2255 CPU 3.70GHz, 1 CPU, 20 logical and 10 physical cores
.NET SDK 11.0.100-preview.6.26359.118
  [Host]    : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4
  .NET 10.0 : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4
  .NET 8.0  : .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4
  .NET 9.0  : .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4


```
| Method               | Job       | Runtime   | Elements | Mean       | Error     | StdDev    | Ratio | RatioSD | Allocated | Alloc Ratio |
|--------------------- |---------- |---------- |--------- |-----------:|----------:|----------:|------:|--------:|----------:|------------:|
| **Guard_Finally**        | **.NET 10.0** | **.NET 10.0** | **4**        |   **4.102 ns** | **0.0694 ns** | **0.0649 ns** |  **1.00** |    **0.02** |         **-** |          **NA** |
| Guard_Plain          | .NET 10.0 | .NET 10.0 | 4        |   1.692 ns | 0.0314 ns | 0.0245 ns |  0.41 |    0.01 |         - |          NA |
| Guard_FinallyBlocked | .NET 10.0 | .NET 10.0 | 4        |   8.512 ns | 0.1910 ns | 0.1876 ns |  2.08 |    0.05 |         - |          NA |
| Guard_PlainBlocked   | .NET 10.0 | .NET 10.0 | 4        |   5.580 ns | 0.1288 ns | 0.1378 ns |  1.36 |    0.04 |         - |          NA |
| Guard_Finally        | .NET 8.0  | .NET 8.0  | 4        |   7.532 ns | 0.1640 ns | 0.1454 ns |  1.84 |    0.04 |         - |          NA |
| Guard_Plain          | .NET 8.0  | .NET 8.0  | 4        |   2.428 ns | 0.0790 ns | 0.0812 ns |  0.59 |    0.02 |         - |          NA |
| Guard_FinallyBlocked | .NET 8.0  | .NET 8.0  | 4        |   7.782 ns | 0.1836 ns | 0.1803 ns |  1.90 |    0.05 |         - |          NA |
| Guard_PlainBlocked   | .NET 8.0  | .NET 8.0  | 4        |   6.349 ns | 0.0965 ns | 0.0806 ns |  1.55 |    0.03 |         - |          NA |
| Guard_Finally        | .NET 9.0  | .NET 9.0  | 4        |   7.533 ns | 0.1074 ns | 0.1005 ns |  1.84 |    0.04 |         - |          NA |
| Guard_Plain          | .NET 9.0  | .NET 9.0  | 4        |   2.038 ns | 0.0687 ns | 0.0894 ns |  0.50 |    0.02 |         - |          NA |
| Guard_FinallyBlocked | .NET 9.0  | .NET 9.0  | 4        |   7.477 ns | 0.0663 ns | 0.0518 ns |  1.82 |    0.03 |         - |          NA |
| Guard_PlainBlocked   | .NET 9.0  | .NET 9.0  | 4        |   6.489 ns | 0.1304 ns | 0.1220 ns |  1.58 |    0.04 |         - |          NA |
|                      |           |           |          |            |           |           |       |         |           |             |
| **Guard_Finally**        | **.NET 10.0** | **.NET 10.0** | **16**       |  **23.528 ns** | **0.3599 ns** | **0.3005 ns** |  **1.00** |    **0.02** |         **-** |          **NA** |
| Guard_Plain          | .NET 10.0 | .NET 10.0 | 16       |   4.914 ns | 0.1249 ns | 0.1579 ns |  0.21 |    0.01 |         - |          NA |
| Guard_FinallyBlocked | .NET 10.0 | .NET 10.0 | 16       |  31.593 ns | 0.5266 ns | 0.5171 ns |  1.34 |    0.03 |         - |          NA |
| Guard_PlainBlocked   | .NET 10.0 | .NET 10.0 | 16       |  20.474 ns | 0.3456 ns | 0.3232 ns |  0.87 |    0.02 |         - |          NA |
| Guard_Finally        | .NET 8.0  | .NET 8.0  | 16       |  28.948 ns | 0.4491 ns | 0.4201 ns |  1.23 |    0.02 |         - |          NA |
| Guard_Plain          | .NET 8.0  | .NET 8.0  | 16       |   5.809 ns | 0.1458 ns | 0.1560 ns |  0.25 |    0.01 |         - |          NA |
| Guard_FinallyBlocked | .NET 8.0  | .NET 8.0  | 16       |  28.647 ns | 0.5926 ns | 0.7054 ns |  1.22 |    0.03 |         - |          NA |
| Guard_PlainBlocked   | .NET 8.0  | .NET 8.0  | 16       |  24.674 ns | 0.3101 ns | 0.2901 ns |  1.05 |    0.02 |         - |          NA |
| Guard_Finally        | .NET 9.0  | .NET 9.0  | 16       |  28.946 ns | 0.6032 ns | 0.6454 ns |  1.23 |    0.03 |         - |          NA |
| Guard_Plain          | .NET 9.0  | .NET 9.0  | 16       |   5.046 ns | 0.0833 ns | 0.0779 ns |  0.21 |    0.00 |         - |          NA |
| Guard_FinallyBlocked | .NET 9.0  | .NET 9.0  | 16       |  28.021 ns | 0.4527 ns | 0.4234 ns |  1.19 |    0.02 |         - |          NA |
| Guard_PlainBlocked   | .NET 9.0  | .NET 9.0  | 16       |  24.593 ns | 0.5025 ns | 0.5160 ns |  1.05 |    0.02 |         - |          NA |
|                      |           |           |          |            |           |           |       |         |           |             |
| **Guard_Finally**        | **.NET 10.0** | **.NET 10.0** | **64**       | **108.271 ns** | **1.8750 ns** | **1.6621 ns** |  **1.00** |    **0.02** |         **-** |          **NA** |
| Guard_Plain          | .NET 10.0 | .NET 10.0 | 64       |  21.511 ns | 0.4091 ns | 0.3827 ns |  0.20 |    0.00 |         - |          NA |
| Guard_FinallyBlocked | .NET 10.0 | .NET 10.0 | 64       | 130.868 ns | 2.5175 ns | 2.2317 ns |  1.21 |    0.03 |         - |          NA |
| Guard_PlainBlocked   | .NET 10.0 | .NET 10.0 | 64       |  85.987 ns | 1.7541 ns | 2.2184 ns |  0.79 |    0.02 |         - |          NA |
| Guard_Finally        | .NET 8.0  | .NET 8.0  | 64       | 116.667 ns | 2.1642 ns | 2.0244 ns |  1.08 |    0.02 |         - |          NA |
| Guard_Plain          | .NET 8.0  | .NET 8.0  | 64       |  23.101 ns | 0.2946 ns | 0.2612 ns |  0.21 |    0.00 |         - |          NA |
| Guard_FinallyBlocked | .NET 8.0  | .NET 8.0  | 64       | 116.613 ns | 1.9696 ns | 1.7460 ns |  1.08 |    0.02 |         - |          NA |
| Guard_PlainBlocked   | .NET 8.0  | .NET 8.0  | 64       | 100.175 ns | 2.0155 ns | 2.1566 ns |  0.93 |    0.02 |         - |          NA |
| Guard_Finally        | .NET 9.0  | .NET 9.0  | 64       | 114.375 ns | 1.2001 ns | 1.0638 ns |  1.06 |    0.02 |         - |          NA |
| Guard_Plain          | .NET 9.0  | .NET 9.0  | 64       |  21.863 ns | 0.2292 ns | 0.1914 ns |  0.20 |    0.00 |         - |          NA |
| Guard_FinallyBlocked | .NET 9.0  | .NET 9.0  | 64       | 119.059 ns | 2.4221 ns | 3.1495 ns |  1.10 |    0.03 |         - |          NA |
| Guard_PlainBlocked   | .NET 9.0  | .NET 9.0  | 64       |  99.190 ns | 1.5012 ns | 1.4043 ns |  0.92 |    0.02 |         - |          NA |
