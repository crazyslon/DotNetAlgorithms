using App.Algorithms;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace App;

[MemoryDiagnoser]
[Orderer(SummaryOrderPolicy.FastestToSlowest)]
[RankColumn]
public class SortBenchmarks
{
    private static readonly int[] ArrayToSort = { 8, 7, 4, 6, 1, 0, 9, 2 };

    [Benchmark]
    public void Net6_0_Sort()
    {
        Array.Sort(ArrayToSort);
    }

    [Benchmark]
    public void BubbleSort()
    {
        SortAlgorithms.BubbleSort(ArrayToSort);
    }

    [Benchmark]
    public void SelectionSort()
    {
        SortAlgorithms.SelectionSort(ArrayToSort);
    }

    [Benchmark]
    public void InsertionSort()
    {
        SortAlgorithms.InsertionSort(ArrayToSort);
    }

    [Benchmark]
    public void MergeSort()
    {
        SortAlgorithms.MergeSort(ArrayToSort);
    }

    [Benchmark]
    public void QuickSort()
    {
        SortAlgorithms.QuickSort(ArrayToSort);
    }

    [Benchmark]
    public void CountingSort()
    {
        SortAlgorithms.CountingSort(ArrayToSort);
    }
}