/*Problem 2. Enter numbers

Write a method ReadNumber(int start, int end) that enters an integer number in a given range [start…end].
If an invalid number or non-number text is entered, the method should throw an exception.
Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100*/
namespace _02.EnterNumbers
{
    using System;

    public class EnterNumbers
    {
        static int ReadNumber(int start, int end)
        {
            int n; 
            bool isValid = int.TryParse(Console.ReadLine(), out n);

            if (!(start <= n && n <= end) || !isValid) throw new ArgumentOutOfRangeException("The number is not in the given range or does not meet the requirements!");

            return n;
        }

        static void Main()
        {
            int min = 1;
            int max = 100;

            Console.WriteLine("Please enter 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100 : ");

            for (int i = 0; i < 10; i++)
            {
                min = ReadNumber(min, max);
            }
        }
    }
}
