﻿/*Problem 6. Divisible by 7 and 3

Write a program that prints from given array of integers all numbers that are divisible by 7 and 3.
 * Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.*/
namespace _06.DivisibleBySevenAndThree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class DivisibleBySevenAndThree
    {
        public static void Main()
        {
            var numbers = new List<int>() { 1, 2, 3, 21, 42, 5, 7, 543, 2562, 2345, 324, 2345, 2345, 76, 456, 3524, 423, 132 };
            var divisibleBy7and3 = numbers.Where(n => n % 21 == 0).ToList();
            var divisibleBy7And3Linq = (from num in numbers
                                       where num%21 == 0
                                       select num).ToList();

            Console.WriteLine("With extension methods: ");
            foreach (var item in divisibleBy7and3)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("With linq: ");
            foreach (var item in divisibleBy7And3Linq)
            {
                Console.WriteLine(item);
            }
        }
    }
}
