namespace _02.IEnumerableExtensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class Extensions
    {
        public static dynamic SumCustom<T>(this IEnumerable<T> iEnum)
        {
            dynamic sum = 0;
            foreach (var item in iEnum)
            {
                sum += item;
            }

            return sum;
        }

        public static dynamic ProductCustom<T>(this IEnumerable<T> iEnum)
        {
            dynamic product = 1;
            foreach (var item in iEnum)
            {
                product *= item;
            }

            return product;
        }

        public static dynamic AverageCustom<T>(this IEnumerable<T> iEnum)
        {
            return (dynamic)(iEnum.SumCustom() / iEnum.Count());
        }

        public static T MinCustom<T>(this IEnumerable<T> iEnum)
            where T : IComparable
        {
            T min = iEnum.First();

            foreach (var item in iEnum)
            {
                if (item.CompareTo(min) < 0)
                {
                    min = item;
                }
            }

            return min;
        }

        public static T MaxCustom<T>(this IEnumerable<T> iEnum)
            where T : IComparable
        {
            T max = iEnum.First();

            foreach (var item in iEnum)
            {
                if (item.CompareTo(max) > 0)
                {
                    max = item;
                }
            }

            return max;
        }
    }
}
