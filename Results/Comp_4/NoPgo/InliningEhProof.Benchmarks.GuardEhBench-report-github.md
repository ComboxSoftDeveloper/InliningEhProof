```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.20348.5139)
Intel Xeon W-2255 CPU 3.70GHz, 1 CPU, 20 logical and 10 physical cores
.NET SDK 11.0.100-preview.6.26359.118
  [Host]    : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4
  .NET 10.0 : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4
  .NET 8.0  : .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4
  .NET 9.0  : .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4


```
| Method               | Job       | Runtime   | Elements | Mean       | Error     | StdDev    | Median     | Ratio | RatioSD | Allocated | Alloc Ratio |
|--------------------- |---------- |---------- |--------- |-----------:|----------:|----------:|-----------:|------:|--------:|----------:|------------:|
| **Guard_Finally**        | **.NET 10.0** | **.NET 10.0** | **4**        |   **7.913 ns** | **0.1617 ns** | **0.1351 ns** |   **7.882 ns** |  **1.00** |    **0.02** |         **-** |          **NA** |
| Guard_Plain          | .NET 10.0 | .NET 10.0 | 4        |   5.590 ns | 0.0828 ns | 0.0775 ns |   5.563 ns |  0.71 |    0.01 |         - |          NA |
| Guard_FinallyBlocked | .NET 10.0 | .NET 10.0 | 4        |   8.105 ns | 0.1906 ns | 0.1782 ns |   8.131 ns |  1.02 |    0.03 |         - |          NA |
| Guard_PlainBlocked   | .NET 10.0 | .NET 10.0 | 4        |   5.512 ns | 0.1016 ns | 0.0901 ns |   5.490 ns |  0.70 |    0.02 |         - |          NA |
| Guard_Finally        | .NET 8.0  | .NET 8.0  | 4        |   8.190 ns | 0.1279 ns | 0.1134 ns |   8.190 ns |  1.04 |    0.02 |         - |          NA |
| Guard_Plain          | .NET 8.0  | .NET 8.0  | 4        |   6.499 ns | 0.1221 ns | 0.1020 ns |   6.532 ns |  0.82 |    0.02 |         - |          NA |
| Guard_FinallyBlocked | .NET 8.0  | .NET 8.0  | 4        |   8.323 ns | 0.1645 ns | 0.2306 ns |   8.291 ns |  1.05 |    0.03 |         - |          NA |
| Guard_PlainBlocked   | .NET 8.0  | .NET 8.0  | 4        |   6.653 ns | 0.1545 ns | 0.1653 ns |   6.645 ns |  0.84 |    0.02 |         - |          NA |
| Guard_Finally        | .NET 9.0  | .NET 9.0  | 4        |   9.265 ns | 0.1188 ns | 0.0992 ns |   9.246 ns |  1.17 |    0.02 |         - |          NA |
| Guard_Plain          | .NET 9.0  | .NET 9.0  | 4        |   7.338 ns | 0.1585 ns | 0.1628 ns |   7.267 ns |  0.93 |    0.03 |         - |          NA |
| Guard_FinallyBlocked | .NET 9.0  | .NET 9.0  | 4        |   9.468 ns | 0.2191 ns | 0.3071 ns |   9.426 ns |  1.20 |    0.04 |         - |          NA |
| Guard_PlainBlocked   | .NET 9.0  | .NET 9.0  | 4        |   6.470 ns | 0.1123 ns | 0.1050 ns |   6.450 ns |  0.82 |    0.02 |         - |          NA |
|                      |           |           |          |            |           |           |            |       |         |           |             |
| **Guard_Finally**        | **.NET 10.0** | **.NET 10.0** | **16**       |  **28.499 ns** | **0.5779 ns** | **0.6183 ns** |  **28.278 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| Guard_Plain          | .NET 10.0 | .NET 10.0 | 16       |  20.878 ns | 0.4387 ns | 0.6430 ns |  20.753 ns |  0.73 |    0.03 |         - |          NA |
| Guard_FinallyBlocked | .NET 10.0 | .NET 10.0 | 16       |  30.906 ns | 0.9796 ns | 2.8263 ns |  29.872 ns |  1.08 |    0.10 |         - |          NA |
| Guard_PlainBlocked   | .NET 10.0 | .NET 10.0 | 16       |  20.786 ns | 0.4474 ns | 0.6965 ns |  20.760 ns |  0.73 |    0.03 |         - |          NA |
| Guard_Finally        | .NET 8.0  | .NET 8.0  | 16       |  31.902 ns | 0.6672 ns | 0.7684 ns |  31.909 ns |  1.12 |    0.04 |         - |          NA |
| Guard_Plain          | .NET 8.0  | .NET 8.0  | 16       |  24.716 ns | 0.3796 ns | 0.3551 ns |  24.680 ns |  0.87 |    0.02 |         - |          NA |
| Guard_FinallyBlocked | .NET 8.0  | .NET 8.0  | 16       |  33.618 ns | 0.7057 ns | 0.6601 ns |  33.589 ns |  1.18 |    0.03 |         - |          NA |
| Guard_PlainBlocked   | .NET 8.0  | .NET 8.0  | 16       |  24.802 ns | 0.5122 ns | 0.5031 ns |  24.794 ns |  0.87 |    0.02 |         - |          NA |
| Guard_Finally        | .NET 9.0  | .NET 9.0  | 16       |  36.154 ns | 0.6878 ns | 0.7920 ns |  36.192 ns |  1.27 |    0.04 |         - |          NA |
| Guard_Plain          | .NET 9.0  | .NET 9.0  | 16       |  27.735 ns | 0.3590 ns | 0.2998 ns |  27.733 ns |  0.97 |    0.02 |         - |          NA |
| Guard_FinallyBlocked | .NET 9.0  | .NET 9.0  | 16       |  36.088 ns | 0.7546 ns | 0.8074 ns |  35.843 ns |  1.27 |    0.04 |         - |          NA |
| Guard_PlainBlocked   | .NET 9.0  | .NET 9.0  | 16       |  23.876 ns | 0.3350 ns | 0.3134 ns |  23.780 ns |  0.84 |    0.02 |         - |          NA |
|                      |           |           |          |            |           |           |            |       |         |           |             |
| **Guard_Finally**        | **.NET 10.0** | **.NET 10.0** | **64**       | **115.331 ns** | **1.4746 ns** | **1.3072 ns** | **115.125 ns** |  **1.00** |    **0.02** |         **-** |          **NA** |
| Guard_Plain          | .NET 10.0 | .NET 10.0 | 64       |  86.612 ns | 1.7654 ns | 2.2327 ns |  86.683 ns |  0.75 |    0.02 |         - |          NA |
| Guard_FinallyBlocked | .NET 10.0 | .NET 10.0 | 64       | 114.627 ns | 1.6360 ns | 1.4502 ns | 114.213 ns |  0.99 |    0.02 |         - |          NA |
| Guard_PlainBlocked   | .NET 10.0 | .NET 10.0 | 64       |  83.391 ns | 1.2983 ns | 1.2144 ns |  82.903 ns |  0.72 |    0.01 |         - |          NA |
| Guard_Finally        | .NET 8.0  | .NET 8.0  | 64       | 128.001 ns | 1.2977 ns | 1.1503 ns | 127.995 ns |  1.11 |    0.02 |         - |          NA |
| Guard_Plain          | .NET 8.0  | .NET 8.0  | 64       | 101.602 ns | 1.9837 ns | 2.0371 ns | 101.526 ns |  0.88 |    0.02 |         - |          NA |
| Guard_FinallyBlocked | .NET 8.0  | .NET 8.0  | 64       | 131.432 ns | 2.6393 ns | 3.8686 ns | 129.857 ns |  1.14 |    0.04 |         - |          NA |
| Guard_PlainBlocked   | .NET 8.0  | .NET 8.0  | 64       |  99.901 ns | 1.0158 ns | 0.7931 ns |  99.951 ns |  0.87 |    0.01 |         - |          NA |
| Guard_Finally        | .NET 9.0  | .NET 9.0  | 64       | 146.064 ns | 2.5330 ns | 2.4878 ns | 145.388 ns |  1.27 |    0.03 |         - |          NA |
| Guard_Plain          | .NET 9.0  | .NET 9.0  | 64       | 112.664 ns | 1.5725 ns | 1.4709 ns | 112.783 ns |  0.98 |    0.02 |         - |          NA |
| Guard_FinallyBlocked | .NET 9.0  | .NET 9.0  | 64       | 145.724 ns | 2.1631 ns | 1.9175 ns | 144.975 ns |  1.26 |    0.02 |         - |          NA |
| Guard_PlainBlocked   | .NET 9.0  | .NET 9.0  | 64       | 100.326 ns | 2.0241 ns | 1.8933 ns |  99.880 ns |  0.87 |    0.02 |         - |          NA |
