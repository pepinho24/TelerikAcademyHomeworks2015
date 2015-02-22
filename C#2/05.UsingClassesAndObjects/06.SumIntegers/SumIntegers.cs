/*Problem 6. Sum integers

You are given a sequence of positive integer values written into a string, separated by spaces.
Write a function that reads these values from given string and calculates their sum.
Example:

input "43 68 9 23 318"	
output 461*/
namespace _06.SumIntegers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SumIntegers
    {
        public static void Main()
        {
            Console.Write("Please enter positive integer numbers separated by space: ");
            var numbers = Console.ReadLine()
                            .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                            .Select(x=>int.Parse(x));

            double sum = SumIntegersFromArray(numbers);

            Console.WriteLine("The sum of the numbers is {0}!", sum);
        }

        private static double SumIntegersFromArray(IEnumerable<int> numbers)
        {
            double sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }

            return sum;
        }
    }
}
