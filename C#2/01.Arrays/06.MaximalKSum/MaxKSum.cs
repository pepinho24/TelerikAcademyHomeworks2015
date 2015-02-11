//Problem 6. Maximal K sum

//Write a program that reads two integer numbers N and K and an array of N elements from the console.
//Find in the array those K elements that have maximal sum.
namespace _06.MaximalKSum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MaxKSum
    {
        public static void Main()
        {
            Console.Write("Please enter N: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Please enter K: ");
            int k = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter an array of integers separated by space(only the first {0} elements will be taken): ",n);
            int[] array = ReadArray(k);

            FindMaximumSum(array, k);
        }

        private static void FindMaximumSum(int[] array, int k)
        {
            Array.Sort(array);
            int len = array.Length;
            Console.Write("The {0} elements with highest sum are: ", k);
            for (int i = 0; i < k; i++)
            {
                if (i != 0)
                {
                    Console.Write(", ");
                }
                Console.Write(array[len - 1]);
                len--;
            }
            Console.WriteLine("!");
        }

        private static int[] ReadArray(int k)
        {
            string arrayAsString = Console.ReadLine();
            string[] arrayOfStrings = arrayAsString.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] arrayOfIntegers = new int[k];

            for (int i = 0; i < arrayOfIntegers.Length; i++)
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
