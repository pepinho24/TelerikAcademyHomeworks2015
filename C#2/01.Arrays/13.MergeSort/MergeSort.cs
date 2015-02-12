//Problem 13.* Merge sort

//Write a program that sorts an array of integers using the Merge sort algorithm.

// For the MergeSortWithLists I used the pseudo code from Wikipedia for "Top-down implementation using lists"
// TopDownMergeSort method uses the C code from wikipedia adapted into C#
namespace _13.MergeSort
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MergeSort
    {
        public static void Main()
        {

            int[] array = { 4, 3, 1, 4, 2, 5, 8 };
            // int[] array = { 3, 2, 2, 2, 7, 7, 7, 7, 7, 1, 3, 3, 3, 3, 3, 3, 3, 1, 4, 4, 4, 4, 4, 4, 4, 7, 7, 7, 7, 7, 7, 7, 5, 4, 4, 4, 4, 4, 4, 4, 7, 7, 7, 7, 7, 7, 7, 7, 7 };
            // int[] array = ReadArray();
            int[] sortedWithLists = MergeSortUsingLists(array.ToList()).ToArray();
            Console.Write("Sorted with lists: ");
            PrintArray(sortedWithLists);

            int[] B = new int[array.Length]; // array B[] is a work array
            int[] sortedWithArrays = new int[array.Length];

            array.CopyTo(sortedWithArrays, 0);
            TopDownMergeSort(ref sortedWithArrays, ref B, array.Length);

            Console.Write("Sorted with arrays: ");
            PrintArray(sortedWithArrays);
        }

        private static void TopDownMergeSort(ref int[] A, ref int[] B, int n)
        {
            TopDownSplitMerge(ref A, 0, n, ref B);
        }

        // iBegin is inclusive; iEnd is exclusive (A[iEnd] is not in the set)
        private static void TopDownSplitMerge(ref int[] A, int iBegin, int iEnd, ref int[] B)
        {
            if (iEnd - iBegin < 2)
            {                       // if run size == 1
                return;             //   consider it sorted
            }

            // recursively split runs into two halves until run size == 1,
            // then merge them and return back up the call chain
            int iMiddle = (iEnd + iBegin) / 2;

            TopDownSplitMerge(ref A, iBegin, iMiddle, ref B);  // split / merge left  half
            TopDownSplitMerge(ref A, iMiddle, iEnd, ref B);  // split / merge right half
            TopDownMerge(ref A, iBegin, iMiddle, iEnd, ref B);  // merge the two half runs
            CopyArray(ref B, iBegin, iEnd, ref A);              // copy the merged runs back to A
        }

        private static void CopyArray(ref int[] B, int iBegin, int iEnd, ref int[] A)
        {
            for (int k = iBegin; k < iEnd; k++)
            {
                A[k] = B[k];
            }
        }

        private static void TopDownMerge(ref int[] A, int iBegin, int iMiddle, int iEnd, ref int[] B)
        {
            int i0 = iBegin;
            int i1 = iMiddle;

            // While there are elements in the left or right runs
            for (int j = iBegin; j < iEnd; j++)
            {
                // If left run head exists and is <= existing right run head.
                if (i0 < iMiddle && (i1 >= iEnd || A[i0] <= A[i1]))
                {
                    B[j] = A[i0];
                    i0 = i0 + 1;
                }
                else
                {
                    B[j] = A[i1];
                    i1 = i1 + 1;
                }
            }
        }

        private static List<int> MergeSortUsingLists(List<int> array)
        {
            // Base case. A list of zero or one elements is sorted, by definition.
            if (array.Count <= 1)
            {
                return array;
            }

            // Recursive case. First, *divide* the list into equal-sized sublists.
            List<int> left = new List<int>();
            List<int> right = new List<int>();
            int middle = array.Count / 2;

            for (int i = 0; i < array.Count; i++)
            {
                if (i < middle)
                {
                    left.Add(array[i]);
                }
                else
                {
                    right.Add(array[i]);
                }
            }
            // Recursively sort both sublists.
            left = MergeSortUsingLists(left);
            right = MergeSortUsingLists(right);
            // *Conquer*: merge the now-sorted sublists.
            return Merge(left, right);
        }

        private static List<int> Merge(List<int> left, List<int> right)
        {
            var result = new List<int>();

            while (left.Count > 0 && right.Count > 0)
            {
                if (left.FirstOrDefault() <= right.FirstOrDefault())
                {
                    result.Add(left.FirstOrDefault());
                    left.RemoveAt(0);
                }
                else
                {
                    result.Add(right.FirstOrDefault());
                    right.RemoveAt(0);
                }
            }

            while (left.Count > 0)
            {
                result.Add(left.FirstOrDefault());
                left.RemoveAt(0);
            }

            while (right.Count > 0)
            {
                result.Add(right.FirstOrDefault());
                right.RemoveAt(0);
            }

            return result;
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

        private static void PrintArray(IList<int> array)
        {
            Console.WriteLine("The sorted array is: {0}", string.Join(", ", array.ToArray()));
        }
    }
}
