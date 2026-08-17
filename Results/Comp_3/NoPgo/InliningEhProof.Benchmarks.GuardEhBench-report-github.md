```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.20348.5386)
Intel Xeon Silver 4314 CPU 2.40GHz, 2 CPU, 64 logical and 32 physical cores
.NET SDK 11.0.100-preview.5.26302.115
  [Host]    : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4
  .NET 10.0 : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4
  .NET 8.0  : .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4
  .NET 9.0  : .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4


```
| Method               | Job       | Runtime   | Elements | Mean       | Error     | StdDev    | Ratio | RatioSD | Allocated | Alloc Ratio |
|--------------------- |---------- |---------- |--------- |-----------:|----------:|----------:|------:|--------:|----------:|------------:|
| **Guard_Finally**        | **.NET 10.0** | **.NET 10.0** | **4**        |   **8.724 ns** | **0.0556 ns** | **0.0493 ns** |  **1.00** |    **0.01** |         **-** |          **NA** |
| Guard_Plain          | .NET 10.0 | .NET 10.0 | 4        |   8.282 ns | 0.0689 ns | 0.0644 ns |  0.95 |    0.01 |         - |          NA |
| Guard_FinallyBlocked | .NET 10.0 | .NET 10.0 | 4        |   8.863 ns | 0.0770 ns | 0.0720 ns |  1.02 |    0.01 |         - |          NA |
| Guard_PlainBlocked   | .NET 10.0 | .NET 10.0 | 4        |   8.072 ns | 0.0330 ns | 0.0293 ns |  0.93 |    0.01 |         - |          NA |
| Guard_Finally        | .NET 8.0  | .NET 8.0  | 4        |   8.861 ns | 0.0635 ns | 0.0563 ns |  1.02 |    0.01 |         - |          NA |
| Guard_Plain          | .NET 8.0  | .NET 8.0  | 4        |   7.234 ns | 0.0637 ns | 0.0596 ns |  0.83 |    0.01 |         - |          NA |
| Guard_FinallyBlocked | .NET 8.0  | .NET 8.0  | 4        |   8.924 ns | 0.0566 ns | 0.0502 ns |  1.02 |    0.01 |         - |          NA |
| Guard_PlainBlocked   | .NET 8.0  | .NET 8.0  | 4        |   7.419 ns | 0.0837 ns | 0.0783 ns |  0.85 |    0.01 |         - |          NA |
| Guard_Finally        | .NET 9.0  | .NET 9.0  | 4        |   8.692 ns | 0.0822 ns | 0.0729 ns |  1.00 |    0.01 |         - |          NA |
| Guard_Plain          | .NET 9.0  | .NET 9.0  | 4        |   7.194 ns | 0.0419 ns | 0.0372 ns |  0.82 |    0.01 |         - |          NA |
| Guard_FinallyBlocked | .NET 9.0  | .NET 9.0  | 4        |   8.593 ns | 0.0802 ns | 0.0711 ns |  0.98 |    0.01 |         - |          NA |
| Guard_PlainBlocked   | .NET 9.0  | .NET 9.0  | 4        |   7.249 ns | 0.0631 ns | 0.0590 ns |  0.83 |    0.01 |         - |          NA |
|                      |           |           |          |            |           |           |       |         |           |             |
| **Guard_Finally**        | **.NET 10.0** | **.NET 10.0** | **16**       |  **30.495 ns** | **0.2907 ns** | **0.2577 ns** |  **1.00** |    **0.01** |         **-** |          **NA** |
| Guard_Plain          | .NET 10.0 | .NET 10.0 | 16       |  29.846 ns | 0.2394 ns | 0.1999 ns |  0.98 |    0.01 |         - |          NA |
| Guard_FinallyBlocked | .NET 10.0 | .NET 10.0 | 16       |  37.663 ns | 0.2012 ns | 0.1784 ns |  1.24 |    0.01 |         - |          NA |
| Guard_PlainBlocked   | .NET 10.0 | .NET 10.0 | 16       |  29.925 ns | 0.2197 ns | 0.2055 ns |  0.98 |    0.01 |         - |          NA |
| Guard_Finally        | .NET 8.0  | .NET 8.0  | 16       |  30.877 ns | 0.2399 ns | 0.2244 ns |  1.01 |    0.01 |         - |          NA |
| Guard_Plain          | .NET 8.0  | .NET 8.0  | 16       |  24.611 ns | 0.1296 ns | 0.1212 ns |  0.81 |    0.01 |         - |          NA |
| Guard_FinallyBlocked | .NET 8.0  | .NET 8.0  | 16       |  30.185 ns | 0.1992 ns | 0.1766 ns |  0.99 |    0.01 |         - |          NA |
| Guard_PlainBlocked   | .NET 8.0  | .NET 8.0  | 16       |  24.861 ns | 0.2778 ns | 0.2462 ns |  0.82 |    0.01 |         - |          NA |
| Guard_Finally        | .NET 9.0  | .NET 9.0  | 16       |  30.677 ns | 0.2610 ns | 0.2180 ns |  1.01 |    0.01 |         - |          NA |
| Guard_Plain          | .NET 9.0  | .NET 9.0  | 16       |  25.179 ns | 0.1197 ns | 0.1061 ns |  0.83 |    0.01 |         - |          NA |
| Guard_FinallyBlocked | .NET 9.0  | .NET 9.0  | 16       |  30.748 ns | 0.2108 ns | 0.1869 ns |  1.01 |    0.01 |         - |          NA |
| Guard_PlainBlocked   | .NET 9.0  | .NET 9.0  | 16       |  24.776 ns | 0.1348 ns | 0.1126 ns |  0.81 |    0.01 |         - |          NA |
|                      |           |           |          |            |           |           |       |         |           |             |
| **Guard_Finally**        | **.NET 10.0** | **.NET 10.0** | **64**       | **145.091 ns** | **1.1118 ns** | **1.0399 ns** |  **1.00** |    **0.01** |         **-** |          **NA** |
| Guard_Plain          | .NET 10.0 | .NET 10.0 | 64       | 113.328 ns | 0.4372 ns | 0.3875 ns |  0.78 |    0.01 |         - |          NA |
| Guard_FinallyBlocked | .NET 10.0 | .NET 10.0 | 64       | 125.763 ns | 1.1882 ns | 1.0533 ns |  0.87 |    0.01 |         - |          NA |
| Guard_PlainBlocked   | .NET 10.0 | .NET 10.0 | 64       | 115.351 ns | 0.7481 ns | 0.6998 ns |  0.80 |    0.01 |         - |          NA |
| Guard_Finally        | .NET 8.0  | .NET 8.0  | 64       | 128.716 ns | 1.2969 ns | 1.1497 ns |  0.89 |    0.01 |         - |          NA |
| Guard_Plain          | .NET 8.0  | .NET 8.0  | 64       | 105.100 ns | 0.5501 ns | 0.5146 ns |  0.72 |    0.01 |         - |          NA |
| Guard_FinallyBlocked | .NET 8.0  | .NET 8.0  | 64       | 126.577 ns | 0.3748 ns | 0.3323 ns |  0.87 |    0.01 |         - |          NA |
| Guard_PlainBlocked   | .NET 8.0  | .NET 8.0  | 64       | 105.903 ns | 0.6469 ns | 0.5734 ns |  0.73 |    0.01 |         - |          NA |
| Guard_Finally        | .NET 9.0  | .NET 9.0  | 64       | 127.049 ns | 0.5710 ns | 0.4768 ns |  0.88 |    0.01 |         - |          NA |
| Guard_Plain          | .NET 9.0  | .NET 9.0  | 64       | 106.181 ns | 0.5968 ns | 0.5582 ns |  0.73 |    0.01 |         - |          NA |
| Guard_FinallyBlocked | .NET 9.0  | .NET 9.0  | 64       | 130.839 ns | 2.5347 ns | 2.3710 ns |  0.90 |    0.02 |         - |          NA |
| Guard_PlainBlocked   | .NET 9.0  | .NET 9.0  | 64       | 106.507 ns | 1.2189 ns | 1.1401 ns |  0.73 |    0.01 |         - |          NA |
