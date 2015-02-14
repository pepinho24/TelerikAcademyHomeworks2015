/*
 Problem 4. Binary search

 Write a program, that reads from the console an array of N integers and an integer K, 
 sorts the array and 
 using the method Array.BinSearch() 
 finds the largest number in the array which is ≤ K.
 */
namespace _04.BinarySearch
{
    using System;

    public class BinarySearch
    {
        public static void Main()
        {
            Console.Write("Enter N: ");
            int n = Int32.Parse(Console.ReadLine());

            Console.Write("Enter K: ");
            int k = Int32.Parse(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter integer {0}: ", i + 1);
                arr[i] = Int32.Parse(Console.ReadLine());
            }

            Array.Sort(arr);
            int index = Array.BinarySearch(arr, k);

            if (index < 0)
            {
                // If the index is negative, it represents the bitwise 
                // complement of the next larger element in the array. 
                index = ~index;

                if (index == 0)
                {
                    Console.WriteLine("There is no element smaller or equal to {0}", k);
                }
                else
                {
                    Console.WriteLine("The biggest element smaller of {0} is {1}", k, arr[index - 1]);
                }
            }
            else
            {
                Console.WriteLine("The biggest element smaller or equal to {0} is {1}", k, arr[index]);
            }
        }
    }
}
