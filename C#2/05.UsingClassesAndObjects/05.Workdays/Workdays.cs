/*Problem 5. Workdays

Write a method that calculates the number of workdays between today and given date, passed as parameter.
Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array. */
namespace _05.Workdays
{
    using System;

    public class Workdays
    {
        private static DateTime[] holidays =
        {
            new DateTime(2015, 1, 1),
            new DateTime(2015, 3, 3),
            new DateTime(2015, 5, 1),
            new DateTime(2015, 5, 2),
            new DateTime(2015, 5, 3),
            new DateTime(2015, 5, 4),
            new DateTime(2015, 5, 5),
            new DateTime(2015, 5, 6),
            new DateTime(2015, 5, 24),
            new DateTime(2015, 9, 6),
            new DateTime(2015, 9, 22),
            new DateTime(2015, 12, 24),
            new DateTime(2015, 12, 25),
            new DateTime(2015, 12, 26),
        };

        public static void Main()
        {
            Console.Write("Enter a date in DD/MM/YYYY format: ");
            string[] endDateStr = Console.ReadLine().Split('/');

            int day = int.Parse(endDateStr[0]);
            int month = int.Parse(endDateStr[1]);
            int year = int.Parse(endDateStr[2]);

            DateTime startDay = DateTime.Today;
            DateTime endDay = new DateTime(year, month, day);

            int workdayCounter = CountWorkdays(ref startDay, ref endDay);
            // there could be a problem when printing cyrilic on the console, 
            //if that bothers you, please check in google how to enable cyrilic on your console :)
            Console.WriteLine("The workdays between {0} and {1} are {2}! ", startDay.ToShortDateString(), endDay.ToShortDateString(), workdayCounter);
        }

        private static int CountWorkdays(ref DateTime startDay, ref DateTime endDay)
        {
            int workDayCounter = 0;
            bool isHoliday = false;

            int timeLen = Math.Abs((endDay - startDay).Days);

            if (startDay > endDay)
            {
                var temp = startDay;
                startDay = endDay;
                endDay = temp;
            }

            var startDayOriginal = startDay;

            for (int i = 0; i < timeLen; i++)
            {
                startDay = startDay.AddDays(1);
                if (startDay.DayOfWeek != DayOfWeek.Sunday && startDay.DayOfWeek != DayOfWeek.Saturday)
                {
                    for (int j = 0; j < holidays.Length; j++)
                    {
                        if (startDay.DayOfYear == holidays[j].DayOfYear)
                        {
                            isHoliday = true;
                            break;
                        }
                    }

                    if (!isHoliday)
                    {
                        workDayCounter++;
                    }

                    isHoliday = false;
                }
            }

            startDay = startDayOriginal;
            
            return workDayCounter;
        }
    }
}
