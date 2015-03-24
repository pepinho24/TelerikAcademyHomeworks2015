using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.StudentsAndWorkers
{
    public static class Extensions
    {
        public static void PrintList<T>(this IEnumerable<T> iEnum)
        {
            Console.WriteLine(string.Join(string.Format("{0}{0}",Environment.NewLine), iEnum));
        }
    }
}
