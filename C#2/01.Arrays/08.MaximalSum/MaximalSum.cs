//Write a program that finds the sequence of maximal sum in given array.
//Example:

//input	2, 3, -6, -1, 2, -1, 6, 4, -8, 8
//result	2, -1, 6, 4
//Can you do it with only one loop (with single scan through the elements of the array)?
namespace _08.MaximalSum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MaximalSum
    {
        public static void Main()
        {
            int[] numbers = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8};
            //Console.Write("Please enter an array of integers separated by space: ");
            //int[] numbers = ReadArray();

            // Initialize variables here
            int maxSoFar = numbers[0];
            int maxEndingHere = numbers[0];
            int begin = 0;
            int beginTemp = 0;
            int end = 0;
            int count = 0;
            int maxCount = 0;

            // Find sequence by looping through
            for (int i = 1; i < numbers.Length; i++)
            {
                // calculate maxEndingHere
                if (maxEndingHere < 0)
                {
                    maxEndingHere = numbers[i];

                    beginTemp = i;
                    count = 0;
                }
                else
                {
                    maxEndingHere += numbers[i];
                    count++;
                }

                // calculate maxSoFar
                if (maxEndingHere >= maxSoFar)
                {
                    maxSoFar = maxEndingHere;

                    begin = beginTemp;
                    end = i;
                    maxCount = count;
                }
            }

            for (int beg = begin; beg <= begin + maxCount; beg++)
            {   
                Console.Write(numbers[beg]);

                if (beg != begin+ maxCount)
                {
                    Console.Write(", ");
                }
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(maxSoFar); 
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
