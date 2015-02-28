/*Problem 19. Dates from text in Canada

Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
Display them in the standard date format for Canada. */
namespace _19.DatesFromTextInCanada
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class DatesFromTextInCanada
    {
        public static void Main()
        {
            string str = "date 1 12.10.2012,  date 2 50.13.2012";
            var dates = new List<DateTime>();
            DateTime date;

            foreach (Match item in Regex.Matches(str, @"\b\d{2}.\d{2}.\d{4}\b"))
            {
                if (DateTime.TryParseExact(item.Value, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
                {
                    dates.Add(date);
                }
            }

            Console.WriteLine("All the dates are: {0}", string.Join(", ", dates.Select(d => d.ToString(CultureInfo.GetCultureInfo("en-CA").DateTimeFormat.ShortDatePattern))));
        }
    }
}
