/*Problem 23. Series of letters

Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.
Example:

input	output
aaaaabbbbbcdddeeeedssaa	abcdedsa*/
namespace _23.SeriesOfLetters
{
    using System;
    using System.Text;

    public class SeriesOfLetters
    {
        public static void Main()
        {
            StringBuilder str = new StringBuilder("aaaaabbbbbcdddeeeedssaa");

            for (int i = 0, index = 0; i < str.Length - 1; i++, index++)
            {
                char currentLetter = str[i];
                while (index < str.Length - 1 && currentLetter == str[index + 1])
                {
                    str.Remove(index + 1, 1);
                }
            }

            Console.WriteLine(str);
        }
    }
}
