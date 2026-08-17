```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.20348.5386)
Intel Xeon Silver 4314 CPU 2.40GHz, 2 CPU, 64 logical and 32 physical cores
.NET SDK 11.0.100-preview.5.26302.115
  [Host]    : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4
  .NET 10.0 : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4
  .NET 8.0  : .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4
  .NET 9.0  : .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4


```
| Method                 | Job       | Runtime   | Elements | Mean       | Error     | StdDev    | Ratio | RatioSD | Allocated | Alloc Ratio |
|----------------------- |---------- |---------- |--------- |-----------:|----------:|----------:|------:|--------:|----------:|------------:|
| **Element_Finally**        | **.NET 10.0** | **.NET 10.0** | **4**        |   **9.348 ns** | **0.0613 ns** | **0.0574 ns** |  **1.00** |    **0.01** |         **-** |          **NA** |
| Element_Plain          | .NET 10.0 | .NET 10.0 | 4        |   8.666 ns | 0.0378 ns | 0.0353 ns |  0.93 |    0.01 |         - |          NA |
| Element_FinallyBlocked | .NET 10.0 | .NET 10.0 | 4        |   8.494 ns | 0.1034 ns | 0.0863 ns |  0.91 |    0.01 |         - |          NA |
| Element_PlainBlocked   | .NET 10.0 | .NET 10.0 | 4        |   8.718 ns | 0.0392 ns | 0.0347 ns |  0.93 |    0.01 |         - |          NA |
| Element_Finally        | .NET 8.0  | .NET 8.0  | 4        |  10.051 ns | 0.0428 ns | 0.0380 ns |  1.08 |    0.01 |         - |          NA |
| Element_Plain          | .NET 8.0  | .NET 8.0  | 4        |   8.678 ns | 0.0557 ns | 0.0494 ns |  0.93 |    0.01 |         - |          NA |
| Element_FinallyBlocked | .NET 8.0  | .NET 8.0  | 4        |   9.919 ns | 0.0742 ns | 0.0694 ns |  1.06 |    0.01 |         - |          NA |
| Element_PlainBlocked   | .NET 8.0  | .NET 8.0  | 4        |   8.230 ns | 0.0622 ns | 0.0582 ns |  0.88 |    0.01 |         - |          NA |
| Element_Finally        | .NET 9.0  | .NET 9.0  | 4        |  10.977 ns | 0.0785 ns | 0.0734 ns |  1.17 |    0.01 |         - |          NA |
| Element_Plain          | .NET 9.0  | .NET 9.0  | 4        |   8.583 ns | 0.0289 ns | 0.0242 ns |  0.92 |    0.01 |         - |          NA |
| Element_FinallyBlocked | .NET 9.0  | .NET 9.0  | 4        |  11.036 ns | 0.1017 ns | 0.0902 ns |  1.18 |    0.01 |         - |          NA |
| Element_PlainBlocked   | .NET 9.0  | .NET 9.0  | 4        |   8.813 ns | 0.0906 ns | 0.0848 ns |  0.94 |    0.01 |         - |          NA |
|                        |           |           |          |            |           |           |       |         |           |             |
| **Element_Finally**        | **.NET 10.0** | **.NET 10.0** | **16**       |  **40.125 ns** | **0.4648 ns** | **0.4348 ns** |  **1.00** |    **0.01** |         **-** |          **NA** |
| Element_Plain          | .NET 10.0 | .NET 10.0 | 16       |  42.287 ns | 0.2265 ns | 0.2118 ns |  1.05 |    0.01 |         - |          NA |
| Element_FinallyBlocked | .NET 10.0 | .NET 10.0 | 16       |  42.425 ns | 0.3235 ns | 0.3026 ns |  1.06 |    0.01 |         - |          NA |
| Element_PlainBlocked   | .NET 10.0 | .NET 10.0 | 16       |  40.402 ns | 0.2180 ns | 0.1932 ns |  1.01 |    0.01 |         - |          NA |
| Element_Finally        | .NET 8.0  | .NET 8.0  | 16       |  36.671 ns | 0.4465 ns | 0.4177 ns |  0.91 |    0.01 |         - |          NA |
| Element_Plain          | .NET 8.0  | .NET 8.0  | 16       |  42.593 ns | 0.2922 ns | 0.2590 ns |  1.06 |    0.01 |         - |          NA |
| Element_FinallyBlocked | .NET 8.0  | .NET 8.0  | 16       |  36.555 ns | 0.3180 ns | 0.2974 ns |  0.91 |    0.01 |         - |          NA |
| Element_PlainBlocked   | .NET 8.0  | .NET 8.0  | 16       |  40.567 ns | 0.5462 ns | 0.5109 ns |  1.01 |    0.02 |         - |          NA |
| Element_Finally        | .NET 9.0  | .NET 9.0  | 16       |  40.731 ns | 0.2723 ns | 0.2414 ns |  1.02 |    0.01 |         - |          NA |
| Element_Plain          | .NET 9.0  | .NET 9.0  | 16       |  41.883 ns | 0.2814 ns | 0.2350 ns |  1.04 |    0.01 |         - |          NA |
| Element_FinallyBlocked | .NET 9.0  | .NET 9.0  | 16       |  40.664 ns | 0.2850 ns | 0.2380 ns |  1.01 |    0.01 |         - |          NA |
| Element_PlainBlocked   | .NET 9.0  | .NET 9.0  | 16       |  40.762 ns | 0.3511 ns | 0.3284 ns |  1.02 |    0.01 |         - |          NA |
|                        |           |           |          |            |           |           |       |         |           |             |
| **Element_Finally**        | **.NET 10.0** | **.NET 10.0** | **64**       | **170.503 ns** | **1.3945 ns** | **1.3044 ns** |  **1.00** |    **0.01** |         **-** |          **NA** |
| Element_Plain          | .NET 10.0 | .NET 10.0 | 64       | 170.869 ns | 0.7275 ns | 0.6449 ns |  1.00 |    0.01 |         - |          NA |
| Element_FinallyBlocked | .NET 10.0 | .NET 10.0 | 64       | 144.462 ns | 0.8623 ns | 0.8066 ns |  0.85 |    0.01 |         - |          NA |
| Element_PlainBlocked   | .NET 10.0 | .NET 10.0 | 64       | 168.166 ns | 0.4781 ns | 0.4472 ns |  0.99 |    0.01 |         - |          NA |
| Element_Finally        | .NET 8.0  | .NET 8.0  | 64       | 143.960 ns | 0.8565 ns | 0.7152 ns |  0.84 |    0.01 |         - |          NA |
| Element_Plain          | .NET 8.0  | .NET 8.0  | 64       | 174.483 ns | 0.7358 ns | 0.6883 ns |  1.02 |    0.01 |         - |          NA |
| Element_FinallyBlocked | .NET 8.0  | .NET 8.0  | 64       | 146.197 ns | 1.3142 ns | 1.2293 ns |  0.86 |    0.01 |         - |          NA |
| Element_PlainBlocked   | .NET 8.0  | .NET 8.0  | 64       | 171.383 ns | 1.0971 ns | 0.9725 ns |  1.01 |    0.01 |         - |          NA |
| Element_Finally        | .NET 9.0  | .NET 9.0  | 64       | 169.854 ns | 2.0927 ns | 1.9575 ns |  1.00 |    0.01 |         - |          NA |
| Element_Plain          | .NET 9.0  | .NET 9.0  | 64       | 170.334 ns | 0.9869 ns | 0.9232 ns |  1.00 |    0.01 |         - |          NA |
| Element_FinallyBlocked | .NET 9.0  | .NET 9.0  | 64       | 167.391 ns | 1.3140 ns | 1.2291 ns |  0.98 |    0.01 |         - |          NA |
| Element_PlainBlocked   | .NET 9.0  | .NET 9.0  | 64       | 168.488 ns | 0.8169 ns | 0.7641 ns |  0.99 |    0.01 |         - |          NA |
