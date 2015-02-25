/*Problem 8. Extract sentences

Write a program that extracts from a given text all sentences containing given word.
Example:

The word is: in

The text is: We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.

The expected result is: We are living in a yellow submarine. We will move out of it in 5 days.

Consider that the sentences are separated by . and the words – by non-letter symbols.*/
namespace _08.ExtractSentences
{
    using System;
    using System.Text.RegularExpressions;

    public class ExtractSentences
    {
        public static void Main()
        {
            string text = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            // Console.WriteLine("Please enter the text: ");
            // string text = Console.ReadLine();

            string word = "in";
            // Console.WriteLine("Please enter the word: ");
            // string word = Console.ReadLine();

            Console.WriteLine("The sentences that contain the word \"{0}\" are: ", word);

            foreach (Match sentence in Regex.Matches(text, @"\s*([^\.]*\b" + word + @"\b.*?\.)"))
            {
                Console.WriteLine(sentence.Groups[1]);
            }
        }
    }
}
