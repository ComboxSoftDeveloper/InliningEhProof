```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.20348.5386)
Intel Xeon Silver 4314 CPU 2.40GHz, 2 CPU, 64 logical and 32 physical cores
.NET SDK 11.0.100-preview.5.26302.115
  [Host]    : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4
  .NET 10.0 : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4
  .NET 8.0  : .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4
  .NET 9.0  : .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4


```
| Method                 | Job       | Runtime   | Elements | Mean       | Error     | StdDev    | Ratio | Allocated | Alloc Ratio |
|----------------------- |---------- |---------- |--------- |-----------:|----------:|----------:|------:|----------:|------------:|
| **Element_Finally**        | **.NET 10.0** | **.NET 10.0** | **4**        |  **11.145 ns** | **0.0996 ns** | **0.0883 ns** |  **1.00** |         **-** |          **NA** |
| Element_Plain          | .NET 10.0 | .NET 10.0 | 4        |   8.517 ns | 0.0525 ns | 0.0465 ns |  0.76 |         - |          NA |
| Element_FinallyBlocked | .NET 10.0 | .NET 10.0 | 4        |   8.412 ns | 0.0470 ns | 0.0417 ns |  0.75 |         - |          NA |
| Element_PlainBlocked   | .NET 10.0 | .NET 10.0 | 4        |   8.600 ns | 0.0486 ns | 0.0431 ns |  0.77 |         - |          NA |
| Element_Finally        | .NET 8.0  | .NET 8.0  | 4        |   9.771 ns | 0.0931 ns | 0.0777 ns |  0.88 |         - |          NA |
| Element_Plain          | .NET 8.0  | .NET 8.0  | 4        |   8.715 ns | 0.0702 ns | 0.0622 ns |  0.78 |         - |          NA |
| Element_FinallyBlocked | .NET 8.0  | .NET 8.0  | 4        |   9.912 ns | 0.0786 ns | 0.0696 ns |  0.89 |         - |          NA |
| Element_PlainBlocked   | .NET 8.0  | .NET 8.0  | 4        |   8.186 ns | 0.0646 ns | 0.0604 ns |  0.73 |         - |          NA |
| Element_Finally        | .NET 9.0  | .NET 9.0  | 4        |  11.016 ns | 0.1510 ns | 0.1413 ns |  0.99 |         - |          NA |
| Element_Plain          | .NET 9.0  | .NET 9.0  | 4        |   8.641 ns | 0.0586 ns | 0.0548 ns |  0.78 |         - |          NA |
| Element_FinallyBlocked | .NET 9.0  | .NET 9.0  | 4        |  11.191 ns | 0.1408 ns | 0.1317 ns |  1.00 |         - |          NA |
| Element_PlainBlocked   | .NET 9.0  | .NET 9.0  | 4        |   8.324 ns | 0.0780 ns | 0.0730 ns |  0.75 |         - |          NA |
|                        |           |           |          |            |           |           |       |           |             |
| **Element_Finally**        | **.NET 10.0** | **.NET 10.0** | **16**       |  **41.330 ns** | **0.4036 ns** | **0.3776 ns** |  **1.00** |         **-** |          **NA** |
| Element_Plain          | .NET 10.0 | .NET 10.0 | 16       |  41.777 ns | 0.1216 ns | 0.1078 ns |  1.01 |         - |          NA |
| Element_FinallyBlocked | .NET 10.0 | .NET 10.0 | 16       |  42.421 ns | 0.1799 ns | 0.1595 ns |  1.03 |         - |          NA |
| Element_PlainBlocked   | .NET 10.0 | .NET 10.0 | 16       |  40.687 ns | 0.2790 ns | 0.2473 ns |  0.98 |         - |          NA |
| Element_Finally        | .NET 8.0  | .NET 8.0  | 16       |  36.784 ns | 0.2994 ns | 0.2801 ns |  0.89 |         - |          NA |
| Element_Plain          | .NET 8.0  | .NET 8.0  | 16       |  42.414 ns | 0.2085 ns | 0.1951 ns |  1.03 |         - |          NA |
| Element_FinallyBlocked | .NET 8.0  | .NET 8.0  | 16       |  36.556 ns | 0.1371 ns | 0.1145 ns |  0.88 |         - |          NA |
| Element_PlainBlocked   | .NET 8.0  | .NET 8.0  | 16       |  40.115 ns | 0.3258 ns | 0.3048 ns |  0.97 |         - |          NA |
| Element_Finally        | .NET 9.0  | .NET 9.0  | 16       |  40.807 ns | 0.2353 ns | 0.2201 ns |  0.99 |         - |          NA |
| Element_Plain          | .NET 9.0  | .NET 9.0  | 16       |  41.787 ns | 0.1290 ns | 0.1078 ns |  1.01 |         - |          NA |
| Element_FinallyBlocked | .NET 9.0  | .NET 9.0  | 16       |  41.246 ns | 0.3843 ns | 0.3595 ns |  1.00 |         - |          NA |
| Element_PlainBlocked   | .NET 9.0  | .NET 9.0  | 16       |  40.751 ns | 0.3200 ns | 0.2837 ns |  0.99 |         - |          NA |
|                        |           |           |          |            |           |           |       |           |             |
| **Element_Finally**        | **.NET 10.0** | **.NET 10.0** | **64**       | **148.132 ns** | **1.0411 ns** | **0.9738 ns** |  **1.00** |         **-** |          **NA** |
| Element_Plain          | .NET 10.0 | .NET 10.0 | 64       | 171.710 ns | 1.1683 ns | 1.0928 ns |  1.16 |         - |          NA |
| Element_FinallyBlocked | .NET 10.0 | .NET 10.0 | 64       | 165.930 ns | 0.7289 ns | 0.6461 ns |  1.12 |         - |          NA |
| Element_PlainBlocked   | .NET 10.0 | .NET 10.0 | 64       | 159.596 ns | 0.5902 ns | 0.4608 ns |  1.08 |         - |          NA |
| Element_Finally        | .NET 8.0  | .NET 8.0  | 64       | 144.836 ns | 0.7405 ns | 0.6927 ns |  0.98 |         - |          NA |
| Element_Plain          | .NET 8.0  | .NET 8.0  | 64       | 170.236 ns | 1.0902 ns | 1.0198 ns |  1.15 |         - |          NA |
| Element_FinallyBlocked | .NET 8.0  | .NET 8.0  | 64       | 148.400 ns | 1.2742 ns | 1.1919 ns |  1.00 |         - |          NA |
| Element_PlainBlocked   | .NET 8.0  | .NET 8.0  | 64       | 171.270 ns | 0.8722 ns | 0.8159 ns |  1.16 |         - |          NA |
| Element_Finally        | .NET 9.0  | .NET 9.0  | 64       | 169.033 ns | 1.2443 ns | 1.1639 ns |  1.14 |         - |          NA |
| Element_Plain          | .NET 9.0  | .NET 9.0  | 64       | 171.514 ns | 0.6979 ns | 0.6528 ns |  1.16 |         - |          NA |
| Element_FinallyBlocked | .NET 9.0  | .NET 9.0  | 64       | 146.111 ns | 0.7540 ns | 0.6684 ns |  0.99 |         - |          NA |
| Element_PlainBlocked   | .NET 9.0  | .NET 9.0  | 64       | 168.323 ns | 0.5747 ns | 0.5375 ns |  1.14 |         - |          NA |
