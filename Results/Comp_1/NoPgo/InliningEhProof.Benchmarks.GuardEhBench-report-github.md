```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.17763.3165/1809/October2018Update/Redstone5)
AMD Ryzen 9 5950X 3.39GHz, 1 CPU, 32 logical and 16 physical cores
.NET SDK 11.0.100-preview.5.26302.115
  [Host]    : .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3
  .NET 10.0 : .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3
  .NET 8.0  : .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3
  .NET 9.0  : .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3


```
| Method               | Job       | Runtime   | Elements | Mean       | Error     | StdDev    | Ratio | Allocated | Alloc Ratio |
|--------------------- |---------- |---------- |--------- |-----------:|----------:|----------:|------:|----------:|------------:|
| **Guard_Finally**        | **.NET 10.0** | **.NET 10.0** | **4**        |   **6.543 ns** | **0.0222 ns** | **0.0208 ns** |  **1.00** |         **-** |          **NA** |
| Guard_Plain          | .NET 10.0 | .NET 10.0 | 4        |   4.710 ns | 0.0224 ns | 0.0209 ns |  0.72 |         - |          NA |
| Guard_FinallyBlocked | .NET 10.0 | .NET 10.0 | 4        |   6.531 ns | 0.0333 ns | 0.0312 ns |  1.00 |         - |          NA |
| Guard_PlainBlocked   | .NET 10.0 | .NET 10.0 | 4        |   4.728 ns | 0.0447 ns | 0.0396 ns |  0.72 |         - |          NA |
| Guard_Finally        | .NET 8.0  | .NET 8.0  | 4        |   6.434 ns | 0.0307 ns | 0.0272 ns |  0.98 |         - |          NA |
| Guard_Plain          | .NET 8.0  | .NET 8.0  | 4        |   5.614 ns | 0.0340 ns | 0.0318 ns |  0.86 |         - |          NA |
| Guard_FinallyBlocked | .NET 8.0  | .NET 8.0  | 4        |   6.542 ns | 0.0297 ns | 0.0263 ns |  1.00 |         - |          NA |
| Guard_PlainBlocked   | .NET 8.0  | .NET 8.0  | 4        |   5.617 ns | 0.0248 ns | 0.0232 ns |  0.86 |         - |          NA |
| Guard_Finally        | .NET 9.0  | .NET 9.0  | 4        |   7.436 ns | 0.0307 ns | 0.0272 ns |  1.14 |         - |          NA |
| Guard_Plain          | .NET 9.0  | .NET 9.0  | 4        |   6.537 ns | 0.0352 ns | 0.0329 ns |  1.00 |         - |          NA |
| Guard_FinallyBlocked | .NET 9.0  | .NET 9.0  | 4        |   7.428 ns | 0.0297 ns | 0.0278 ns |  1.14 |         - |          NA |
| Guard_PlainBlocked   | .NET 9.0  | .NET 9.0  | 4        |   6.514 ns | 0.0242 ns | 0.0227 ns |  1.00 |         - |          NA |
|                      |           |           |          |            |           |           |       |           |             |
| **Guard_Finally**        | **.NET 10.0** | **.NET 10.0** | **16**       |  **26.075 ns** | **0.1136 ns** | **0.0949 ns** |  **1.00** |         **-** |          **NA** |
| Guard_Plain          | .NET 10.0 | .NET 10.0 | 16       |  19.157 ns | 0.0417 ns | 0.0325 ns |  0.73 |         - |          NA |
| Guard_FinallyBlocked | .NET 10.0 | .NET 10.0 | 16       |  26.105 ns | 0.1502 ns | 0.1405 ns |  1.00 |         - |          NA |
| Guard_PlainBlocked   | .NET 10.0 | .NET 10.0 | 16       |  19.187 ns | 0.0510 ns | 0.0477 ns |  0.74 |         - |          NA |
| Guard_Finally        | .NET 8.0  | .NET 8.0  | 16       |  26.214 ns | 0.2058 ns | 0.1824 ns |  1.01 |         - |          NA |
| Guard_Plain          | .NET 8.0  | .NET 8.0  | 16       |  22.279 ns | 0.0623 ns | 0.0583 ns |  0.85 |         - |          NA |
| Guard_FinallyBlocked | .NET 8.0  | .NET 8.0  | 16       |  26.122 ns | 0.1639 ns | 0.1369 ns |  1.00 |         - |          NA |
| Guard_PlainBlocked   | .NET 8.0  | .NET 8.0  | 16       |  22.231 ns | 0.0483 ns | 0.0452 ns |  0.85 |         - |          NA |
| Guard_Finally        | .NET 9.0  | .NET 9.0  | 16       |  29.645 ns | 0.2086 ns | 0.1951 ns |  1.14 |         - |          NA |
| Guard_Plain          | .NET 9.0  | .NET 9.0  | 16       |  25.967 ns | 0.1977 ns | 0.1850 ns |  1.00 |         - |          NA |
| Guard_FinallyBlocked | .NET 9.0  | .NET 9.0  | 16       |  29.187 ns | 0.2495 ns | 0.2333 ns |  1.12 |         - |          NA |
| Guard_PlainBlocked   | .NET 9.0  | .NET 9.0  | 16       |  25.752 ns | 0.0745 ns | 0.0697 ns |  0.99 |         - |          NA |
|                      |           |           |          |            |           |           |       |           |             |
| **Guard_Finally**        | **.NET 10.0** | **.NET 10.0** | **64**       | **102.882 ns** | **0.2276 ns** | **0.1777 ns** |  **1.00** |         **-** |          **NA** |
| Guard_Plain          | .NET 10.0 | .NET 10.0 | 64       |  73.785 ns | 0.2572 ns | 0.2406 ns |  0.72 |         - |          NA |
| Guard_FinallyBlocked | .NET 10.0 | .NET 10.0 | 64       | 103.306 ns | 1.1367 ns | 0.9492 ns |  1.00 |         - |          NA |
| Guard_PlainBlocked   | .NET 10.0 | .NET 10.0 | 64       |  73.555 ns | 0.1630 ns | 0.1525 ns |  0.71 |         - |          NA |
| Guard_Finally        | .NET 8.0  | .NET 8.0  | 64       | 103.267 ns | 0.7005 ns | 0.5849 ns |  1.00 |         - |          NA |
| Guard_Plain          | .NET 8.0  | .NET 8.0  | 64       |  87.880 ns | 0.2005 ns | 0.1674 ns |  0.85 |         - |          NA |
| Guard_FinallyBlocked | .NET 8.0  | .NET 8.0  | 64       | 103.309 ns | 0.4015 ns | 0.3134 ns |  1.00 |         - |          NA |
| Guard_PlainBlocked   | .NET 8.0  | .NET 8.0  | 64       |  87.890 ns | 0.3143 ns | 0.2624 ns |  0.85 |         - |          NA |
| Guard_Finally        | .NET 9.0  | .NET 9.0  | 64       | 116.780 ns | 0.3236 ns | 0.2527 ns |  1.14 |         - |          NA |
| Guard_Plain          | .NET 9.0  | .NET 9.0  | 64       | 104.118 ns | 1.2924 ns | 1.2089 ns |  1.01 |         - |          NA |
| Guard_FinallyBlocked | .NET 9.0  | .NET 9.0  | 64       | 117.251 ns | 0.5404 ns | 0.4790 ns |  1.14 |         - |          NA |
| Guard_PlainBlocked   | .NET 9.0  | .NET 9.0  | 64       | 103.552 ns | 1.3140 ns | 1.2291 ns |  1.01 |         - |          NA |
