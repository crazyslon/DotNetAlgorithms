# DotNetAlgorithms


## Search Algorithms

``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19044.1766 (21H2)
Intel Core i5-4440 CPU 3.10GHz (Haswell), 1 CPU, 4 logical and 4 physical cores
.NET SDK=6.0.300
  [Host]     : .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
  DefaultJob : .NET 6.0.5 (6.0.522.21309), X64 RyuJIT


```
|                              Method |     Mean |    Error |   StdDev | Rank | Allocated |
|------------------------------------ |---------:|---------:|---------:|-----:|----------:|
|     Net6_0_BinarySearch_LastElement | 13.55 ns | 0.046 ns | 0.043 ns |    1 |         - |
|   Net6_0_BinarySearch_MiddleElement | 15.15 ns | 0.231 ns | 0.216 ns |    2 |         - |
|          BinarySearch_MiddleElement | 19.92 ns | 0.024 ns | 0.019 ns |    3 |         - |
|            BinarySearch_LastElement | 20.60 ns | 0.058 ns | 0.054 ns |    4 |         - |
|   RecursiveBinarySearch_LastElement | 35.83 ns | 0.063 ns | 0.059 ns |    5 |         - |
| RecursiveBinarySearch_MiddleElement | 37.35 ns | 0.110 ns | 0.103 ns |    6 |         - |
|          LinearSearch_MiddleElement | 42.91 ns | 0.116 ns | 0.103 ns |    7 |         - |
|            LinearSearch_LastElement | 73.89 ns | 0.099 ns | 0.092 ns |    8 |         - |


## Sort Algorithms

``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19044.1766 (21H2)
Intel Core i5-4440 CPU 3.10GHz (Haswell), 1 CPU, 4 logical and 4 physical cores
.NET SDK=6.0.300
  [Host]     : .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
  DefaultJob : .NET 6.0.5 (6.0.522.21309), X64 RyuJIT


```
|        Method |      Mean |    Error |   StdDev | Rank |  Gen 0 | Allocated |
|-------------- |----------:|---------:|---------:|-----:|-------:|----------:|
|   Net6_0_Sort |  18.39 ns | 0.030 ns | 0.027 ns |    1 |      - |         - |
|    BubbleSort |  70.74 ns | 0.180 ns | 0.168 ns |    2 |      - |         - |
| InsertionSort | 211.83 ns | 0.441 ns | 0.412 ns |    3 |      - |         - |
|  CountingSort | 240.49 ns | 2.828 ns | 2.208 ns |    4 | 0.0587 |     184 B |
|     MergeSort | 289.62 ns | 0.800 ns | 0.709 ns |    5 | 0.1478 |     464 B |
|     QuickSort | 313.49 ns | 6.290 ns | 7.725 ns |    6 |      - |         - |
| SelectionSort | 322.92 ns | 0.460 ns | 0.408 ns |    7 |      - |         - |