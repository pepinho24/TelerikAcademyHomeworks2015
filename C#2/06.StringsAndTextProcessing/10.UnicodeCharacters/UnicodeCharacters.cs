/*Problem 10. Unicode characters

Write a program that converts a string to a sequence of C# Unicode character literals.
Use format strings.
Example:

input	output
Hi!	    \u0048\u0069\u0021*/
namespace _10.UnicodeCharacters
{
    using System;
    using System.Text;

    public class UnicodeCharacters
    {
        public static void Main()
        {
            //Console.WriteLine("Please enter the text: ");
            //string text = Console.ReadLine();
            string text = "Hi!";
            string unicodeText = ConvertTextToUnicodeCharacters(text);

            Console.WriteLine("The text converted to unicode characters is : ");
            Console.WriteLine(unicodeText);
        }

        private static string ConvertTextToUnicodeCharacters(string text)
        {
            StringBuilder str = new StringBuilder(text.Length * 6);
            foreach (var character in text)
            {
                str.Append(string.Format("\\u{0:X4}", (int)character));
            }

            return str.ToString();
        }
    }
}
