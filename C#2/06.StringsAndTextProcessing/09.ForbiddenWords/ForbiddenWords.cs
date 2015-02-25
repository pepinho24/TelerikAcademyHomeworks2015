/*Problem 9. Forbidden words

We are given a string containing a list of forbidden words and a text containing some of these words.
Write a program that replaces the forbidden words with asterisks.
Example text: Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.

Forbidden words: PHP, CLR, Microsoft

The expected result: ********* announced its next generation *** compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in ***.*/
namespace _09.ForbiddenWords
{
    using System;
    using System.Text.RegularExpressions;

    public class ForbiddenWords
    {
        public static void Main()
        {
            //Console.WriteLine("Please enter the text: ");
            //string text = Console.ReadLine();
            string text = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";

            //Console.WriteLine("Please enter the words separating them by \", \" or \"|\"");
            //string words = Console.ReadLine();
            string words = "PHP, CLR, Microsoft";

            PrintCensuredText(text, words);
        }

        private static void PrintCensuredText(string text, string forbiddenWords)
        {
            Console.WriteLine(Regex.Replace(text, forbiddenWords.Replace(", ", "|"), w => new String('*', w.Length)));
        }
    }
}
