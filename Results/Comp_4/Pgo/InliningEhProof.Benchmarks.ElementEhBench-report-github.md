```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.20348.5139)
Intel Xeon W-2255 CPU 3.70GHz, 1 CPU, 20 logical and 10 physical cores
.NET SDK 11.0.100-preview.6.26359.118
  [Host]    : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4
  .NET 10.0 : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4
  .NET 8.0  : .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4
  .NET 9.0  : .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4


```
| Method                 | Job       | Runtime   | Elements | Mean       | Error     | StdDev    | Ratio | RatioSD | Allocated | Alloc Ratio |
|----------------------- |---------- |---------- |--------- |-----------:|----------:|----------:|------:|--------:|----------:|------------:|
| **Element_Finally**        | **.NET 10.0** | **.NET 10.0** | **4**        |   **3.483 ns** | **0.0576 ns** | **0.0539 ns** |  **1.00** |    **0.02** |         **-** |          **NA** |
| Element_Plain          | .NET 10.0 | .NET 10.0 | 4        |   3.156 ns | 0.0685 ns | 0.0640 ns |  0.91 |    0.02 |         - |          NA |
| Element_FinallyBlocked | .NET 10.0 | .NET 10.0 | 4        |   9.012 ns | 0.1420 ns | 0.1328 ns |  2.59 |    0.05 |         - |          NA |
| Element_PlainBlocked   | .NET 10.0 | .NET 10.0 | 4        |   7.416 ns | 0.1684 ns | 0.1492 ns |  2.13 |    0.05 |         - |          NA |
| Element_Finally        | .NET 8.0  | .NET 8.0  | 4        |   9.995 ns | 0.0947 ns | 0.0840 ns |  2.87 |    0.05 |         - |          NA |
| Element_Plain          | .NET 8.0  | .NET 8.0  | 4        |   3.581 ns | 0.0622 ns | 0.0581 ns |  1.03 |    0.02 |         - |          NA |
| Element_FinallyBlocked | .NET 8.0  | .NET 8.0  | 4        |  10.074 ns | 0.2204 ns | 0.2061 ns |  2.89 |    0.07 |         - |          NA |
| Element_PlainBlocked   | .NET 8.0  | .NET 8.0  | 4        |   7.234 ns | 0.1595 ns | 0.1492 ns |  2.08 |    0.05 |         - |          NA |
| Element_Finally        | .NET 9.0  | .NET 9.0  | 4        |  10.400 ns | 0.1486 ns | 0.1390 ns |  2.99 |    0.06 |         - |          NA |
| Element_Plain          | .NET 9.0  | .NET 9.0  | 4        |   3.224 ns | 0.0839 ns | 0.0785 ns |  0.93 |    0.03 |         - |          NA |
| Element_FinallyBlocked | .NET 9.0  | .NET 9.0  | 4        |  10.228 ns | 0.1384 ns | 0.1227 ns |  2.94 |    0.06 |         - |          NA |
| Element_PlainBlocked   | .NET 9.0  | .NET 9.0  | 4        |   7.316 ns | 0.1422 ns | 0.1330 ns |  2.10 |    0.05 |         - |          NA |
|                        |           |           |          |            |           |           |       |         |           |             |
| **Element_Finally**        | **.NET 10.0** | **.NET 10.0** | **16**       |  **18.745 ns** | **0.2723 ns** | **0.2547 ns** |  **1.00** |    **0.02** |         **-** |          **NA** |
| Element_Plain          | .NET 10.0 | .NET 10.0 | 16       |  18.432 ns | 0.3606 ns | 0.3196 ns |  0.98 |    0.02 |         - |          NA |
| Element_FinallyBlocked | .NET 10.0 | .NET 10.0 | 16       |  34.556 ns | 0.3431 ns | 0.2865 ns |  1.84 |    0.03 |         - |          NA |
| Element_PlainBlocked   | .NET 10.0 | .NET 10.0 | 16       |  28.815 ns | 0.3959 ns | 0.3510 ns |  1.54 |    0.03 |         - |          NA |
| Element_Finally        | .NET 8.0  | .NET 8.0  | 16       |  35.685 ns | 0.5027 ns | 0.4198 ns |  1.90 |    0.03 |         - |          NA |
| Element_Plain          | .NET 8.0  | .NET 8.0  | 16       |  18.214 ns | 0.2644 ns | 0.2344 ns |  0.97 |    0.02 |         - |          NA |
| Element_FinallyBlocked | .NET 8.0  | .NET 8.0  | 16       |  34.985 ns | 0.3716 ns | 0.3103 ns |  1.87 |    0.03 |         - |          NA |
| Element_PlainBlocked   | .NET 8.0  | .NET 8.0  | 16       |  27.863 ns | 0.4510 ns | 0.4219 ns |  1.49 |    0.03 |         - |          NA |
| Element_Finally        | .NET 9.0  | .NET 9.0  | 16       |  41.836 ns | 0.8541 ns | 1.6860 ns |  2.23 |    0.09 |         - |          NA |
| Element_Plain          | .NET 9.0  | .NET 9.0  | 16       |  18.413 ns | 0.3923 ns | 0.4198 ns |  0.98 |    0.03 |         - |          NA |
| Element_FinallyBlocked | .NET 9.0  | .NET 9.0  | 16       |  39.661 ns | 0.7019 ns | 0.6565 ns |  2.12 |    0.04 |         - |          NA |
| Element_PlainBlocked   | .NET 9.0  | .NET 9.0  | 16       |  27.787 ns | 0.4692 ns | 0.4159 ns |  1.48 |    0.03 |         - |          NA |
|                        |           |           |          |            |           |           |       |         |           |             |
| **Element_Finally**        | **.NET 10.0** | **.NET 10.0** | **64**       |  **80.368 ns** | **1.2871 ns** | **1.0748 ns** |  **1.00** |    **0.02** |         **-** |          **NA** |
| Element_Plain          | .NET 10.0 | .NET 10.0 | 64       |  80.731 ns | 0.8960 ns | 0.8381 ns |  1.00 |    0.02 |         - |          NA |
| Element_FinallyBlocked | .NET 10.0 | .NET 10.0 | 64       | 132.486 ns | 2.0053 ns | 1.7776 ns |  1.65 |    0.03 |         - |          NA |
| Element_PlainBlocked   | .NET 10.0 | .NET 10.0 | 64       | 118.016 ns | 2.3964 ns | 2.5641 ns |  1.47 |    0.04 |         - |          NA |
| Element_Finally        | .NET 8.0  | .NET 8.0  | 64       | 148.656 ns | 2.9271 ns | 2.8748 ns |  1.85 |    0.04 |         - |          NA |
| Element_Plain          | .NET 8.0  | .NET 8.0  | 64       |  80.972 ns | 1.3881 ns | 1.2305 ns |  1.01 |    0.02 |         - |          NA |
| Element_FinallyBlocked | .NET 8.0  | .NET 8.0  | 64       | 146.373 ns | 2.0223 ns | 1.7928 ns |  1.82 |    0.03 |         - |          NA |
| Element_PlainBlocked   | .NET 8.0  | .NET 8.0  | 64       | 114.436 ns | 1.5279 ns | 1.3545 ns |  1.42 |    0.02 |         - |          NA |
| Element_Finally        | .NET 9.0  | .NET 9.0  | 64       | 160.963 ns | 2.5715 ns | 2.2796 ns |  2.00 |    0.04 |         - |          NA |
| Element_Plain          | .NET 9.0  | .NET 9.0  | 64       |  80.391 ns | 1.2942 ns | 1.1473 ns |  1.00 |    0.02 |         - |          NA |
| Element_FinallyBlocked | .NET 9.0  | .NET 9.0  | 64       | 160.861 ns | 2.0858 ns | 1.9510 ns |  2.00 |    0.03 |         - |          NA |
| Element_PlainBlocked   | .NET 9.0  | .NET 9.0  | 64       | 113.065 ns | 1.2282 ns | 0.9589 ns |  1.41 |    0.02 |         - |          NA |
