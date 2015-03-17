/*Problem 2. IEnumerable extensions

Implement a set of extension methods for IEnumerable<T> that implement the following group functions: sum, product, min, max, average.*/
namespace _02.IEnumerableExtensions
{
    using System;
    using System.Collections.Generic;

    public class IEnumerableExtensions
    {
        public static void Main()
        {
            var list = new List<double>() { 1,2,2,5};

            Console.WriteLine(list.SumCustom());
            Console.WriteLine(list.ProductCustom());
            Console.WriteLine(list.AverageCustom());
            Console.WriteLine(list.MinCustom());
            Console.WriteLine(list.MaxCustom());
        }
    }
}
