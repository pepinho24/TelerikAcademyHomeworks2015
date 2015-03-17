/* Problem 1. StringBuilder.Substring

Implement an extension method Substring(int index, int length) for the class StringBuilder that returns new StringBuilder 
and has the same functionality as Substring in the class String.*/
namespace _01.StringBuilderSubstring
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public static class Extensions
    {
        public static StringBuilder Substring(this StringBuilder str, int index, int length)
        {
            var sb = new StringBuilder();

            for (int i = index; i < index + length && i < str.Length; i++)
            {
                sb.Append(str[i]);
            }

            return sb;
        }
    }

    public class StringBuilderSubstring
    {
        public static void Main()
        {
            var str = new StringBuilder("0123456");

            Console.WriteLine(str.Substring(1, 2));
        }
    }
}
