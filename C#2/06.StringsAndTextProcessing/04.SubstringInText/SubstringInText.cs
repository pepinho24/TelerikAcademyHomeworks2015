/*Problem 4. Sub-string in text

Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).
Example:

The target sub-string is in

The text is as follows: We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.

The result is: 9 */
namespace _04.SubstringInText
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;

    public class SubstringInText
    {
        public static void Main()
        {
            Console.WriteLine("Please enter the text: ");
            // string str = "We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            string str = Console.ReadLine();

            Console.Write("Enter the substring: ");
            // string subStr = "in";
            string subStr = Console.ReadLine();

            int counter = CountSubstringInText(str, subStr);

            Console.WriteLine("\"{0}\" is in the text {1} times!", subStr, counter);
        }

        private static int CountSubstringInText(string text, string subString)
        {
            return Regex.Matches(text, subString, RegexOptions.IgnoreCase).Count;
        }
    }
}
