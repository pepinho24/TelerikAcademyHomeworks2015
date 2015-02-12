//Problem 9. Frequent number

//Write a program that finds the most frequent number in an array.
//Example:

//input	4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3
//result	4 (5 times)
namespace _09.FrequentNumber
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public class FrequentNumber
    {
        public static void Main(string[] args)
        {
            int[] array = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
            // int[] array = ReadArray();
            Array.Sort(array);
            int count = 1;
            int maxCount = 0;
            int num = array[0];
            int mostFrequent = num;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] == array[i - 1])
                {
                    num = array[i];
                    count++;
                }
                else
                {
                    if (count > maxCount)
                    {
                        maxCount = count;
                        mostFrequent = num;
                    }
                    count = 1;
                    num = array[i];
                }
            }

            Console.WriteLine("Most frequent number is {0} ({1} times)!", mostFrequent, maxCount);
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
