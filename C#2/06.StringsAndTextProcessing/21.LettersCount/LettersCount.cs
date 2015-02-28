/*Problem 21. Letters count

Write a program that reads a string from the console and prints all different letters in the string along with information how many times each letter is found.*/
namespace _21.LettersCount
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class LettersCount
    {
        public static void Main()
        {
            string sentence = Console.ReadLine();
            var wordCounts = new Dictionary<char, int>();

            foreach (char c in sentence)
            {
                if (!char.IsLetter(c))
                {
                    continue;
                }

                // case sensitive
                if (!wordCounts.ContainsKey(c))
                {
                    wordCounts.Add(c, 1);
                }
                else
                {
                    wordCounts[c]++;
                }
            }

            var orderedWordCounts = wordCounts.OrderByDescending(x => x.Value);
            foreach (var word in orderedWordCounts)
            {
                string timesString = word.Value > 1 ? "times" : "time";
                Console.WriteLine("{0}: {1} {2}", word.Key, word.Value, timesString);
            }
        }
    }
}
