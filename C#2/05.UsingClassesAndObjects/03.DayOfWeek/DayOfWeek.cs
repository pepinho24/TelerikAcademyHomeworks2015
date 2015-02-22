/*Problem 3. Day of week

Write a program that prints to the console which day of the week is today.
Use System.DateTime.*/
namespace _03.DayOfWeek
{
    using System;

    public class DayOfWeek
    {
        public static void Main()
        {
            Console.WriteLine("Today is {0}!", DateTime.Today.DayOfWeek);
        }
    }
}
