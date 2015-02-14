/*
 Problem 5. Sort by string length

You are given an array of strings. 
Write a method that sorts the array by the length of its elements (the number of characters composing them).
 */
namespace _05.SortByStringLength
{
    using System;
    using System.Linq;

    public class SortingByStringLength
    {
        public static void Main()
        {
            Console.Write("Enter the number of strings: ");
            int count = int.Parse(Console.ReadLine());

            int[] arrayLengths = new int[count];
            string[] array = new string[count];

            for (int i = 0; i < count; i++)
            {
                Console.Write("String number {0}: ",i+1);
                array[i] = Console.ReadLine();
            }

            var sortedWords = array.OrderBy(w=> w.Length);

            Console.WriteLine("The sorted array is {0}!", string.Join(", ",sortedWords));
        }
    }
}
