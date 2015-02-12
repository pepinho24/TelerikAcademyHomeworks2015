//Problem 10. Find sum in array

//Write a program that finds in given array of integers a sequence of given sum S (if present).
//Example:

//array	4, 3, 1, 4, 2, 5, 8 
//S 11
//result 4, 2, 5
namespace _10.FindSumInArray
{
    using System;

    public class FindSumInArray
    {
        public static void Main()
        {
            int[] array = { 4, 3, 1, 4, 2, 5, 8 };
            // int[] array = ReadArray();

            Console.Write("Enter the sum: ");
            int s = Int32.Parse(Console.ReadLine());

            int sum = array[0];
            int begin = 0;
            int end = 0;

            for (int i = 0; i < array.Length; i++)
            {
                begin = i;
                sum = array[i];

                for (int m = i + 1; m < array.Length; m++)
                {
                    if ((array[m] + sum) <= s)
                    {
                        sum += array[m];
                    }
                    else
                    {
                        break;
                    }

                    if (sum == s)
                    {
                        end = m;
                        break;
                    }
                }

                if (s == sum)
                {
                    break;
                }
            }

            if (end == 0)
            {
                Console.WriteLine("There are no sequence numbers which sum is {0}!", s);
            }
            else
            {
                Console.Write("The numbers which sum is {0} are: ", s);
                for (int i = begin; i <= end; i++)
                {

                    if (i == begin)
                    {
                        Console.Write(array[i]);
                    }
                    else if (i == end)
                    {
                        Console.Write(" and ");
                        Console.Write(array[i]);
                        Console.WriteLine("!");
                    }
                    else
                    {
                        Console.Write(", ");
                        Console.Write(array[i]);
                    }
                }
            }
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
