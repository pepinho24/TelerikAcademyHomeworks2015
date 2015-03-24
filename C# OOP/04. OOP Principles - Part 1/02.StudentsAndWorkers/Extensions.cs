namespace _02.StudentsAndWorkers
{
    using System;
    using System.Collections.Generic;

    public static class Extensions
    {
        public static void PrintList<T>(this IEnumerable<T> iEnum)
        {
            Console.WriteLine(string.Join(string.Format("{0}{0}", Environment.NewLine), iEnum));
        }
    }
}
