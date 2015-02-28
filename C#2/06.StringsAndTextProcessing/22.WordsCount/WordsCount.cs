/*Problem 22. Words count

Write a program that reads a string from the console and lists all different words in the string along with information how many times each word is found.*/
namespace _22.WordsCount
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class WordsCount
    {
        public static void Main()
        {
            string text = Console.ReadLine();
            string[] allWordsArr = text.Split(new char[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> dict = new Dictionary<string, int>();

            foreach (var word in allWordsArr)
            {
                if (dict.ContainsKey(word))
                {
                    dict[word] = dict[word] + 1;
                }
                else
                {
                    dict.Add(word, 1);
                }
            }

            foreach (var word in dict)
            {
                Console.WriteLine("{0,-15} - {1} {2}", word.Key, word.Value, word.Value > 1 ? "times" : "time");
            }
        }
    }
}
