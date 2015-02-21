/*Problem 9. Sorting array

Write a method that return the maximal element in a portion of array of integers starting at given index.
Using it write another method that sorts an array in ascending / descending order.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class SortingArray
{
    static int[] SortArrayAscending(int[] array)
    {
        int[] sorted = SortArrayDescending(array);
        sorted = sorted.Reverse().ToArray();

        return sorted;
    }

    static int[] SortArrayDescending(int[] array)
    {
        int maxElementIndex = 0;
        for (int i = 0; i < array.Length; i++)
        {
            maxElementIndex = GetMaximalElement(array, i);
            int swap = array[maxElementIndex];
            array[maxElementIndex] = array[i];
            array[i] = swap;
        }

        return array;
    }

    static int GetMaximalElement(int[] array, int startIndex)
    {
        int maxElement = startIndex;
        for (int i = startIndex; i < array.Length; i++)
        {
            if (array[maxElement] < array[i])
            {
                maxElement = i;
            }
        }

        return maxElement;
    }

    static void PrintArray(int[] array)
    {
        Console.WriteLine("{0} ", string.Join(", ", array));
    }

    static void Main()
    {
        int[] array = { 5, 62, 37, 44, 77, 9, 11, 102, 13, 22, 36, 17 };
        Console.WriteLine("The array: ");
        PrintArray(array);
        PrintSeparatorLine();

        Console.WriteLine("Max element: " + array[GetMaximalElement(array, 0)]);
        PrintSeparatorLine();

        int[] sortedArray = SortArrayAscending(array);
        Console.WriteLine("Array sorted ascending: ");
        PrintArray(sortedArray);
        PrintSeparatorLine();

        Console.WriteLine("Array sorted descending: ");
        sortedArray = SortArrayDescending(array);
        PrintArray(sortedArray);
    }

    private static void PrintSeparatorLine()
    {
        Console.WriteLine();
        Console.WriteLine(new String('=', Console.WindowWidth));
        Console.WriteLine();
    }
}