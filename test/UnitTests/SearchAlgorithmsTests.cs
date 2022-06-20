using App.Algorithms;
using FluentAssertions;

namespace UnitTests;

public class SearchAlgorithmsTests
{
    [Theory]
    [InlineData(new int[0], 3, -1)]
    [InlineData(new[] { 3 }, 3, 0)]
    [InlineData(new[] { 3, 4, 5, 6, 7, 8, 9 }, 7, 4)]
    [InlineData(new[] { 3, 4, 5, 6, 7, 8, 9 }, 2, -1)]
    public void BinarySearch(int[] arr, int valueToSearch, int expectedIndexResult)
    {
        var result = SearchAlgorithms.BinarySearch(arr, valueToSearch);

        result.Should().Be(expectedIndexResult);
    }
    
    [Theory]
    [InlineData(new int[0], 3, -1)]
    [InlineData(new[] { 3 }, 3, 0)]
    [InlineData(new[] { 3, 4, 5, 6, 7, 8, 9 }, 7, 4)]
    [InlineData(new[] { 3, 4, 5, 6, 7, 8, 9 }, 2, -1)]
    public void RecursiveBinarySearch(int[] arr, int valueToSearch, int expectedIndexResult)
    {
        var result = SearchAlgorithms.RecursiveBinarySearch(arr, valueToSearch);

        result.Should().Be(expectedIndexResult);
    }
    
    [Theory]
    [InlineData(new int[0], 3, -1)]
    [InlineData(new[] { 3 }, 3, 0)]
    [InlineData(new[] { 3, 4, 5, 6, 7, 8, 9 }, 7, 4)]
    [InlineData(new[] { 3, 4, 5, 6, 7, 8, 9 }, 2, -1)]
    public void LinearSearch(int[] arr, int valueToSearch, int expectedIndexResult)
    {
        var result = SearchAlgorithms.LinearSearch(arr, valueToSearch);

        result.Should().Be(expectedIndexResult);
    }
}