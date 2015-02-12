//Problem 3. Compare char arrays

//Write a program that compares two char arrays lexicographically (letter by letter).
namespace _03.CompareCharArrays
{
    using System;

    public class CompareCharArrays
    {
        private const string DIFFERENT_ARRAYS_MESSAGE = "The arrays are different!";
        private const string EQUAL_ARRAYS_MESSAGE = "The arrays are equal!";

        public static void Main()
        {
            Console.Write("Enter the first array of chars as string: ");
            char[] firstArray = Console.ReadLine().ToCharArray();

            Console.Write("Enter the first array of chars as string: ");
            char[] secondArray = Console.ReadLine().ToCharArray();

            CompareTwoArrays(firstArray, secondArray);
        }

        private static void CompareTwoArrays(char[] firstArray, char[] secondArray) 
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
    }
}
