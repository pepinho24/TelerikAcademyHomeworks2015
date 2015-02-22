/*Problem 1. Leap year

Write a program that reads a year from the console and checks whether it is a leap one.
Use System.DateTime.*/
namespace _01.LeapYear
{
    using System;

    public class LeapYear
    {
        public static void Main()
        {
            Console.Write("Enter a year to check if it is leap: ");

            int year = Int32.Parse(Console.ReadLine());
            bool isLeap = DateTime.IsLeapYear(year);

            Console.WriteLine("Year {0} {1} leap!", year, isLeap? "is": "is not");
        }
    }
}
