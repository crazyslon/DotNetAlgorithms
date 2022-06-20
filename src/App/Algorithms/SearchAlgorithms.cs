using App.Extensions;

namespace App.Algorithms;

public static class SearchAlgorithms
{
    private const int ElementNotFound = -1;

    /// <summary>
    /// Binary search algorithm
    /// Binary search can be implemented only on a sorted list of items.
    /// If the elements are not sorted already, we need to sort them first.
    /// Time Complexities:
    /// Best case complexity: O(1)
    /// Average case complexity: O(log n)
    /// Worst case complexity: O(log n)
    /// </summary>
    /// <param name="arr">incoming array</param>
    /// <param name="value">searching value</param>
    /// <typeparam name="T">type of array</typeparam>
    /// <returns>index of searching element or -1 in case of element doesn't exist in array</returns>
    public static int BinarySearch<T>(IList<T> arr, T value) where T : IComparable<T>
    {
        return IterativeBinarySearch(arr, value, 0, arr.Count - 1);
        //return RecursiveBinarySearch(arr, value, 0, arr.Length - 1);
    }

    public static int RecursiveBinarySearch<T>(IList<T> arr, T value) where T : IComparable<T>
    {
        return RecursiveBinarySearch(arr, value, 0, arr.Count - 1);
    }

    private static int IterativeBinarySearch<T>(
        IList<T> arr, T value,
        int lowPos, int highPos) where T : IComparable<T>
    {
        while (lowPos <= highPos)
        {
            var middlePos = lowPos + (highPos - lowPos) / 2;

            var middle = arr[middlePos];

            if (middle.Equal(value))
                return middlePos;

            if (middle.GreaterThan(value))
            {
                highPos = middlePos - 1;
            }
            else
            {
                lowPos = middlePos + 1;
            }
        }

        return ElementNotFound;
    }

    private static int RecursiveBinarySearch<T>(
        IList<T> arr, T value,
        int lowPos, int highPos) where T : IComparable<T>
    {
        if (arr.Count == 0)
            return ElementNotFound;

        var middlePos = lowPos + (highPos - lowPos) / 2;

        var middle = arr[middlePos];

        if (middle.Equal(value))
            return middlePos;

        if (lowPos.GreaterThan(highPos))
            return ElementNotFound;

        if (middle.GreaterThan(value))
            return RecursiveBinarySearch(arr, value, lowPos, middlePos - 1);


        return RecursiveBinarySearch(arr, value, middlePos + 1, highPos);
    }


    /// <summary>
    /// Linear Search Algorithm
    /// Linear search is a sequential searching algorithm where
    /// we start from one end and check every element of the list until the desired element is found.
    /// It is the simplest searching algorithm.
    ///
    /// Linear Search Complexities
    /// Time Complexity: O(n)
    /// </summary>
    /// <param name="arr">incoming array</param>
    /// <param name="value">searching value</param>
    /// <typeparam name="T">type of array</typeparam>
    /// <returns>index of searching element or -1 in case of element doesn't exist in array</returns>
    public static int LinearSearch<T>(IList<T> arr, T value) where T : IComparable<T>
    {
        for (var i = 0; i < arr.Count; i++)
        {
            if (arr[i].Equal(value))
                return i;
        }

        return ElementNotFound;
    }
}