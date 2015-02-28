/*Problem 16. Date difference

Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.
Example:

Enter the first date: 27.02.2006
Enter the second date: 3.03.2006
Distance: 4 days */
namespace _16.DateDifference
{
    using System;
    using System.Globalization;

    public class DateDifference
    {
        public static void Main()
        {
           // Console.Write("Please enter a date in the format: day.month.year: ");
            string start = "27.02.2006";
           // start = Console.ReadLine();

           // Console.Write("Please enter a date in the format: day.month.year: ");
            string end = "3.03.2006";
           // end = Console.ReadLine();

            DateTime startDate = DateTime.ParseExact(start, "d.MM.yyyy", CultureInfo.InvariantCulture);
            DateTime endDate = DateTime.ParseExact(end, "d.MM.yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine("Distance: {0} days!",(endDate - startDate).TotalDays);
        }
    }
}
