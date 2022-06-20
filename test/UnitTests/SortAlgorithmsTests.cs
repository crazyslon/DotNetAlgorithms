using App.Algorithms;
using FluentAssertions;

namespace UnitTests;

public class SortAlgorithmsTests
{
    [Theory]
    [InlineData(new int[0])]
    [InlineData(new[] { 2 })]
    [InlineData(new[] { 8, 7, 4, 6, 1, 0, 9, 2 })]
    public void BubbleSort(int[] arr)
    {
        SortAlgorithms.BubbleSort(arr);

        arr.Should().BeInAscendingOrder();
    }
    
    [Theory]
    [InlineData(new int[0])]
    [InlineData(new[] { 2 })]
    [InlineData(new[] { 8, 7, 4, 6, 1, 0, 9, 2 })]
    public void SelectionSort(int[] arr)
    {
        SortAlgorithms.SelectionSort(arr);

        arr.Should().BeInAscendingOrder();
    }
    
    [Theory]
    [InlineData(new int[0])]
    [InlineData(new[] { 2 })]
    [InlineData(new[] { 8, 7, 4, 6, 1, 0, 9, 2 })]
    public void InsertionSort(int[] arr)
    {
        SortAlgorithms.InsertionSort(arr);

        arr.Should().BeInAscendingOrder();
    }
    
    [Theory]
    [InlineData(new int[0])]
    [InlineData(new[] { 2 })]
    [InlineData(new[] { 8, 7, 4, 6, 1, 0, 9, 2 })]
    public void MergeSort(int[] arr)
    {
        SortAlgorithms.MergeSort(arr);

        arr.Should().BeInAscendingOrder();
    }
    
    [Theory]
    [InlineData(new int[0])]
    [InlineData(new[] { 2 })]
    [InlineData(new[] { 8, 7, 4, 6, 1, 0, 9, 2 })]
    public void QuickSort(int[] arr)
    {
        SortAlgorithms.QuickSort(arr);

        arr.Should().BeInAscendingOrder();
    }
    
    [Theory]
    [InlineData(new int[0])]
    [InlineData(new[] { 2 })]
    [InlineData(new[] { 8, 7, 4, 6, 1, 0, 9, 2 })]
    public void CountingSort(int[] arr)
    {
        SortAlgorithms.CountingSort(arr);

        arr.Should().BeInAscendingOrder();
    }
}