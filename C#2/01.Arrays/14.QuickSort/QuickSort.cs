//Problem 14. Quick sort

//Write a program that sorts an array of integers using the Quick sort algorithm.
namespace _14.QuickSort
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class QuickSort
    {
        // Divides a given array into two partitions (with smallest and with biggest elements)
        private static int partition(int[] array, int leftIndex, int rightIndex, int pivotIndex)
        {
            // leftIndex is the index of the leftmost element in the array
            // rightIndex is the index of the rightmost element in the array
            // pivotIndex is the index of a random element in the array
            int pivotValue = array[pivotIndex];

            // Swap array[pivotIndex] and array[rightIndex] (move pivot to end)
            int temp = pivotValue;
            array[pivotIndex] = array[rightIndex];
            array[rightIndex] = temp;

            int storeIndex = leftIndex; // Helper index for the partition

            for (int i = leftIndex; i < rightIndex; i++)
            {
                if (array[i] < pivotValue)
                {
                    // Swap array[i] and array[storeIndex]
                    temp = array[i];
                    array[i] = array[storeIndex];
                    array[storeIndex] = temp;
                    storeIndex++;
                }
            }

            // Swap array[storeIndex] and array[rightIndex]
            // (move pivot to it's final place - between the less and the greater elements)
            temp = array[storeIndex];
            array[storeIndex] = array[rightIndex];
            array[rightIndex] = temp;

            return storeIndex; // return the index of the pivots position
        }

        // Inner quickSort algorithm function
        private static void quickSort(int[] array, int leftIndex, int rightIndex)
        {
            if (rightIndex - leftIndex >= 1) // If there are 2 or more elements in the array
            {
                Random randomIndex = new Random();
                // pivotIndex = [leftIndex, rightIndex]
                int pivotIndex = randomIndex.Next(rightIndex - leftIndex + 1) + leftIndex;

                // Get the left and right subarrays
                int pivotNextIndex = partition(array, leftIndex, rightIndex, pivotIndex);

                // Recursively sort elements smaller than the pivot (left of the pivot)
                quickSort(array, leftIndex, pivotNextIndex - 1);

                // Recursively sort elements bigger than the pivot (right of the pivot)
                quickSort(array, pivotNextIndex + 1, rightIndex);
            }
        }

        // Public quickSort function that calls the inner quickSort function
        // There are two separate functions, because that way it's easier for the user to use quickSort
        public static void quickSort(int[] array)
        {
            quickSort(array, 0, array.Length - 1);
        }

       public  static void Main()
        {
            Console.Write("Please enter the array elements separated by space: ");
            int[] array = ReadArray();
            
            quickSort(array);

            PrintArray(array);
        }

       private static void PrintArray(IList<int> array)
       {
           Console.WriteLine("The sorted array is: {0}", string.Join(", ", array.ToArray()));
       }

       private static int[] ReadArray()
       {
           string arrayAsString = Console.ReadLine();
           string[] arrayOfStrings = arrayAsString.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
           int[] arrayOfIntegers = new int[arrayOfStrings.Length];

           for (int i = 0; i < arrayOfStrings.Length; i++)
           {
               try
               {
                   arrayOfIntegers[i] = int.Parse(arrayOfStrings[i]);
               }
               catch (FormatException)
               {
                   throw new FormatException("Input string was not in the correct format!");
               }
           }

           return arrayOfIntegers;
       }
    }
}
