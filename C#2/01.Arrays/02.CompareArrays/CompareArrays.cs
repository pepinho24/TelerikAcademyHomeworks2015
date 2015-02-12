//Problem 2. Compare arrays

//Write a program that reads two integer arrays from the console and compares them element by element.
namespace _02.CompareArrays
{
    using System;

    public class CompareArrays
    {
        private const string DIFFERENT_ARRAYS_MESSAGE = "The arrays are different!";
        private const string EQUAL_ARRAYS_MESSAGE = "The arrays are equal!";

        public static void Main()
        {
            Console.Write("Please enter the elements of the first array separated by space: ");
            int[] firstArray = ReadArray();

            Console.Write("Please enter the elements of the second array separated by space: ");
            int[] secondArray = ReadArray();

            CompareTwoArrays(firstArray, secondArray);
        }

        private static void CompareTwoArrays(int[] firstArray, int[] secondArray)
        {
            if (firstArray.Length != secondArray.Length)
            {
                Console.WriteLine(DIFFERENT_ARRAYS_MESSAGE);
            }
            else
            {
                for (int i = 0; i < firstArray.Length; i++)
                {
                    if (firstArray[i] != secondArray[i])
                    {
                        Console.WriteLine(DIFFERENT_ARRAYS_MESSAGE);
                        return;
                    }
                }

                Console.WriteLine(EQUAL_ARRAYS_MESSAGE);
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

        private static void PrintArray(int[] array)
        {
            Console.WriteLine(string.Join(", ", array));
        }
    }
}
