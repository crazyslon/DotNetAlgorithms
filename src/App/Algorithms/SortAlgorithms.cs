using App.Extensions;

namespace App.Algorithms;

public static class SortAlgorithms
{
    /// <summary>
    /// Bubble Sort Algorithm
    /// Time Complexity O(n2):	 
    /// Bubble sort is used if:
    /// 1) complexity does not matter
    /// 2) short and simple code is preferred
    /// </summary>
    /// <param name="arr">incoming array</param>
    /// <typeparam name="T">type should implement IComparable interface</typeparam>
    public static void BubbleSort<T>(IList<T> arr) where T : struct, IComparable<T>
    {
        for (var i = 0; i < arr.Count; i++)
        {
            var swapped = false;

            for (var j = 0; j < arr.Count - 1 - i; j++)
            {
                if (arr[j].LessThanOrEqual(arr[j + 1])) continue;

                (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);

                swapped = true;
            }

            if (!swapped)
                return;
        }
    }

    /// <summary>
    /// Selection Sort Algorithm
    /// Time Complexity O(n2):	 
    /// The selection sort is used when:
    /// 1) a small list is to be sorted
    /// 2) cost of swapping does not matter
    /// 3) checking of all the elements is compulsory
    /// 4) cost of writing to a memory matters like in flash memory (number of writes/swaps is O(n) as compared to O(n2) of bubble sort)
    /// </summary>
    /// <param name="arr">incoming array</param>
    /// <typeparam name="T">type should implement IComparable interface</typeparam>
    public static void SelectionSort<T>(IList<T> arr) where T : IComparable<T>
    {
        for (var i = 0; i < arr.Count; i++)
        {
            // position of our minimal element
            var minPos = i;

            for (var j = i + 1; j < arr.Count; j++)
            {
                if (arr[j].LessThan(arr[minPos]))
                {
                    minPos = j;
                }
            }

            if (i != minPos)
            {
                (arr[i], arr[minPos]) = (arr[minPos], arr[i]);
            }
        }
    }

    /// <summary>
    /// Insertion Sort Algorithm
    /// Time Complexity O(n2):	 
    /// The insertion sort is used when:
    /// 1) the array is has a small number of elements
    /// 2) there are only a few elements left to be sorted
    /// </summary>
    /// <param name="arr">incoming array</param>
    /// <typeparam name="T">type should implement IComparable interface</typeparam>
    public static void InsertionSort<T>(IList<T> arr) where T : IComparable<T>
    {
        for (var i = 1; i < arr.Count; i++)
        {
            for (var j = i; j > 0; j--)
            {
                if (arr[j].LessThan(arr[j - 1]))
                {
                    (arr[j], arr[j - 1]) = (arr[j - 1], arr[j]);
                }
            }
        }
    }


    /// <summary>
    /// Counting Sort Algorithm
    /// Overall complexity = O(max)+O(size)+O(max)+O(size) = O(max+size)
    /// Counting sort is used when:
    /// 1) there are smaller integers with multiple counts.
    /// 2) linear complexity is the need.
    /// </summary>
    /// <param name="arr">incoming array</param>
    public static void CountingSort(IList<int> arr)
    {
        if (arr.Count == 0)
            return;

        // 1) Find out the maximum element (let it be max) from the given array
        // O(size)
        var max = arr.Max();

        // 2) Initialize an array of length max+1 with all elements 0.
        // This array is used for storing the count of the elements in the array.
        var countArr = new int[max + 1];

        // 3) Store the count of each element at their respective index in count array
        // O(size)
        foreach (var t in arr)
        {
            countArr[t]++;
        }

        // 4) Store cumulative sum of the elements of the count array.
        // It helps in placing the elements into the correct index of the sorted array.
        // O(max)
        for (var i = 1; i < countArr.Length; i++)
        {
            countArr[i] += countArr[i - 1];
        }

        var outputArr = new int[arr.Count];

        // 5) Find the index of each element of the original array in the count array.
        // This gives the cumulative count.
        // Place the element at the index calculated as shown in figure below.

        // 6) After placing each element at its correct position, decrease its count by one.
        // O(size)
        for (var i = 0; i < arr.Count; i++)
        {
            var outputIndex = --countArr[arr[i]];
            outputArr[outputIndex] = arr[i];
        }


        // O(size)
        for (var i = 0; i < outputArr.Length; i++)
        {
            arr[i] = outputArr[i];
        }
    }


    /// <summary>
    /// Merge Sort Algorithm
    /// Merge Sort is one of the most popular sorting algorithms that
    /// is based on the principle of Divide and Conquer Algorithm.
    /// Time Complexity: O(n*log n)
    /// Merge Sort Algorithm applications:
    /// 1) Inversion count problem
    /// 2) External sorting
    /// 3) E-commerce applications
    /// </summary>
    /// <param name="arr">incoming array</param>
    /// <typeparam name="T">type should implement IComparable interface</typeparam>
    public static void MergeSort<T>(IList<T> arr) where T : IComparable<T>
    {
        RecursiveMergeSort(arr, 0, arr.Count - 1);
    }

    private static void RecursiveMergeSort<T>(IList<T> arr, int lowPos, int highPos) where T : IComparable<T>
    {
        if (lowPos >= highPos)
            return;

        var middlePos = (highPos + lowPos) / 2;

        RecursiveMergeSort(arr, lowPos, middlePos);
        RecursiveMergeSort(arr, middlePos + 1, highPos);

        Merge(arr, lowPos, middlePos, highPos);
    }

    private static void Merge<T>(IList<T> arr, int lowPos, int middlePos, int highPos) where T : IComparable<T>
    {
        var leftCount = middlePos - lowPos + 1;
        var rightCount = highPos - middlePos;

        var leftArr = new T[leftCount];
        var rightArr = new T[rightCount];

        for (var i = 0; i < leftCount; i++)
            leftArr[i] = arr[lowPos + i];

        for (var j = 0; j < rightCount; j++)
            rightArr[j] = arr[middlePos + 1 + j];

        var leftArrIndex = 0;
        var rightArrIndex = 0;
        var arrIndex = lowPos;

        while (leftArrIndex < leftCount && rightArrIndex < rightCount)
        {
            if (leftArr[leftArrIndex].LessThanOrEqual(rightArr[rightArrIndex]))
            {
                arr[arrIndex] = leftArr[leftArrIndex];
                leftArrIndex++;
            }
            else
            {
                arr[arrIndex] = rightArr[rightArrIndex];
                rightArrIndex++;
            }

            arrIndex++;
        }

        while (rightArrIndex < rightCount)
        {
            arr[arrIndex] = rightArr[rightArrIndex];
            rightArrIndex++;
            arrIndex++;
        }

        while (leftArrIndex < leftCount)
        {
            arr[arrIndex] = leftArr[leftArrIndex];
            leftArrIndex++;
            arrIndex++;
        }
    }


    /// <summary>
    /// Quick Sort Algorithm
    /// Quicksort is a sorting algorithm based on the divide and conquer approach
    /// Time Complexity: O(n2)
    /// It occurs when the pivot element picked is either the greatest or the smallest element.
    /// Best Case Complexity O(n*log n)
    /// Quicksort algorithm is used when:
    /// 1) the programming language is good for recursion
    /// 2) time complexity matters
    /// 3) space complexity matters
    /// </summary>
    /// <param name="arr">incoming array</param>
    /// <typeparam name="T">type should implement IComparable interface</typeparam>
    public static void QuickSort<T>(IList<T> arr) where T : IComparable<T>
    {
        QuickSort(arr, 0, arr.Count - 1);
    }

    private static void QuickSort<T>(IList<T> arr, int lowPos, int highPos) where T : IComparable<T>
    {
        if (lowPos >= highPos)
            return;

        var pivotPos = highPos;
        var pointerPos = lowPos - 1;

        for (var i = lowPos; i <= highPos; i++)
        {
            if (arr[i].GreaterThan(arr[pivotPos]))
                continue;

            pointerPos++;

            if (pointerPos == i)
                continue;

            (arr[pointerPos], arr[i]) = (arr[i], arr[pointerPos]);

            if (i != pivotPos) continue;
            pivotPos = pointerPos;
            break;
        }

        QuickSort(arr, lowPos, pivotPos - 1);
        QuickSort(arr, pivotPos + 1, highPos);
    }
}