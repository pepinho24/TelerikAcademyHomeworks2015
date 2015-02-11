//Problem 4. Maximal sequence

//Write a program that finds the maximal sequence of equal elements in an array.
//Example:

//input	2, 1, 1, 2, 3, 3, 2, 2, 2, 1	
//result 2, 2, 2
namespace _04.MaximalSequence
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MaximalSequence
    {
        public static void Main()
        {
            //int[] arr = { 3, 2, 2, 2, 1, 3, 3, 3, 3, 3, 3, 3, 1, 5, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7 };
            Console.Write("Please enter an array of integers separated by space: ");
            int[] arr = ReadArray();
            int[] start = new int[arr.Length];
            List<int> best = new List<int>();
            int bestLen = 1;
            int startLen = 1;

            for (int i = 0, n = 0; i < arr.Length; i++, n++)
            {
                if (i == 0)
                {
                    start[n] = arr[i];
                }
                else
                {
                    if (arr[i] == arr[i - 1])
                    {
                        start[n] = arr[i];
                        startLen++;
                    }
                    else
                    {
                        n = 0;
                        start[n] = arr[i];
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
            string[] arrayOfStrings = arrayAsString.Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries);
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
            Console.WriteLine("The maximal sequence of equal elements in the given arrayis: {0}", string.Join(", ", array.ToArray()));
        }
    }
}
