//Problem 5. Maximal increasing sequence

//Write a program that finds the maximal increasing sequence in an array.
//Example:

//input 3, 2, 3, 4, 2, 2, 4	
//result 2, 3, 4
namespace _05.MaximalIncreasingSequence
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MaximalIncreasingSequence
    {
        public static void Main()
        {
            //int[] array = { 3, 2, 2, 2, 1, 3, 3, 3, 3, 3, 3, 3, 1, 5, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7 };
            Console.Write("Please enter an array of integers separated by space: ");
            int[] array = ReadArray();

            int[] start = new int[array.Length];
            List<int> best = new List<int>();
            int bestLen = 1;
            int startLen = 1;

            for (int i = 0, n = 0; i < array.Length; i++, n++)
            {
                if (i == 0)
                {
                    start[n] = array[i];
                }
                else
                {
                    if (array[i] == array[i - 1] + 1)
                    {
                        start[n] = array[i];
                        startLen++;
                    }
                    else
                    {
                        n = 0;
                        start[n] = array[i];
                        startLen = 1;
                    }

                    if (startLen > bestLen)
                    {
                        bestLen = startLen;
                        best = new List<int>();

                        for (int m = 0; m < bestLen; m++)
                        {
                            best.Add(start[m]);
                        }
                    }
                }
            }

            PrintArray(best);
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
            Console.WriteLine("The maximal sequence of equal elements in the given array is: {0}", string.Join(", ", array.ToArray()));
        }
    }
}
