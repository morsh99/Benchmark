```

BenchmarkDotNet v0.13.10, Windows 11 (10.0.22621.2506/22H2/2022Update/SunValley2)
Intel Core i7-7500U CPU 2.70GHz (Kaby Lake), 1 CPU, 4 logical and 2 physical cores
.NET SDK 7.0.304
  [Host]     : .NET 7.0.7 (7.0.723.27404), X64 RyuJIT AVX2 [AttachedDebugger]
  DefaultJob : .NET 7.0.7 (7.0.723.27404), X64 RyuJIT AVX2


```
| Method            | Mean     | Error    | StdDev   |
|------------------ |---------:|---------:|---------:|
| CheclListFor      | 98.16 ns | 0.456 ns | 0.356 ns |
| CheclListForeEach | 70.20 ns | 0.553 ns | 0.462 ns |
