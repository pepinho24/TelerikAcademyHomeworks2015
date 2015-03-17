/* Problem 1. StringBuilder.Substring

Implement an extension method Substring(int index, int length) for the class StringBuilder that returns new StringBuilder 
and has the same functionality as Substring in the class String.*/
namespace _01.StringBuilderSubstring
{
    using System;
    using System.Text;

    public class StringBuilderSubstring
    {
        public static void Main()
        {
            var str = new StringBuilder("0123456");

            Console.WriteLine(str.Substring(1, 2));
        }
    }
}
