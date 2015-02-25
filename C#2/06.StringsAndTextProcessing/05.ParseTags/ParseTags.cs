/*Problem 5. Parse tags

You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to upper-case.
The tags cannot be nested.
Example: We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.

The expected result: We are living in a YELLOW SUBMARINE. We don't have ANYTHING else. */
namespace _05.ParseTags
{
    using System;
    using System.Text.RegularExpressions;

    public class ParseTags
    {
        public static void Main()
        {
            Console.WriteLine("Please enter the text: ");
            string text = Console.ReadLine();

            string parsedText = ParseUpcaseTag(text);
            Console.WriteLine(parsedText);
        }

        private static string ParseUpcaseTag(string text)
        {
            return Regex.Replace(text, "<upcase>(.*?)</upcase>", m => m.Groups[1].Value.ToUpper());
        }
    }
}
