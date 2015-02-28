/*Problem 13. Reverse sentence

Write a program that reverses the words in given sentence.
Example:

input	
C# is not C++, not PHP and not Delphi!
 
output	
Delphi not and PHP, not C++ not is C#!*/
namespace _13.ReverseSentence
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    public class ReverseSentence
    {
        public static void Main()
        {
            //Console.WriteLine("Please enter the text: ");
            string text = "C# is not C++, not PHP and not Delphi!";
            // string text = Console.ReadLine();
            var newText = ReverseWordsOrderInSentence(text);

            Console.WriteLine("Original text: ");
            Console.WriteLine(text);
            
            Console.WriteLine(new string('=', Console.WindowWidth));

            Console.WriteLine("Reversed text: ");
            Console.WriteLine(newText);
        }

        private static string ReverseWordsOrderInSentence(string text)
        {
            string regex = @"\s+|,\s*|\.\s*|!\s*|$";
            StringBuilder str = new StringBuilder();

            var words = new Stack<string>();

            foreach (var word in Regex.Split(text, regex))
            {
                if (!String.IsNullOrEmpty(word))
                {
                    words.Push(word);
                }
            }

            foreach (var separator in Regex.Matches(text, regex))
            {
                if (words.Any())
                {
                    str.Append(words.Pop() + separator);
                }
            }

            return str.ToString();
        }
    }
}
