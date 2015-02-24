/*Problem 2. Reverse string

Write a program that reads a string, reverses it and prints the result at the console.
Example:

input	output
sample	elpmas*/
namespace _02.ReverseStrings
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ReverseStrings
    {
        public static void Main()
        {
            Console.Write("Enter a string to be reversed: ");
            var originalString = Console.ReadLine();
            string reversedString = string.Join("", originalString.Reverse().ToArray());
            Console.WriteLine("Reversed string is : " + reversedString);
        }
    }
}
