using App.Algorithms;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace App;

[MemoryDiagnoser]
[Orderer(SummaryOrderPolicy.FastestToSlowest)]
[RankColumn]
public class SearchBenchmarks
{
    private static readonly int[] ArrayToSearch = { 3, 4, 5, 6, 7, 8, 9, 23, 45, 56, 123, 1024 };

    [Benchmark]
    public void Net6_0_BinarySearch_LastElement()
    {
        Array.BinarySearch(ArrayToSearch, 1024);
    }

    [Benchmark]
    public void Net6_0_BinarySearch_MiddleElement()
    {
        Array.BinarySearch(ArrayToSearch, 23);
    }

    [Benchmark]
    public void LinearSearch_LastElement()
    {
        SearchAlgorithms.LinearSearch(ArrayToSearch, 1024);
    }

    [Benchmark]
    public void LinearSearch_MiddleElement()
    {
        SearchAlgorithms.LinearSearch(ArrayToSearch, 23);
    }

    [Benchmark]
    public void RecursiveBinarySearch_MiddleElement()
    {
        SearchAlgorithms.RecursiveBinarySearch(ArrayToSearch, 23);
    }

    [Benchmark]
    public void RecursiveBinarySearch_LastElement()
    {
        SearchAlgorithms.RecursiveBinarySearch(ArrayToSearch, 1024);
    }


    [Benchmark]
    public void BinarySearch_MiddleElement()
    {
        SearchAlgorithms.BinarySearch(ArrayToSearch, 23);
    }

    [Benchmark]
    public void BinarySearch_LastElement()
    {
        SearchAlgorithms.BinarySearch(ArrayToSearch, 1024);
    }
}