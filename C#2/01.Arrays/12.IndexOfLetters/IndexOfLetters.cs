//Problem 12. Index of letters

//Write a program that creates an array containing all letters from the alphabet (A-Z).
//Read a word from the console and print the index of each of its letters in the array.
namespace _12.IndexOfLetters
{
    using System;

    public class IndexOfLetters
    {
        public static void Main()
        {
            char[] letters = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

            Console.Write("Enter a word: ");
            string word = Console.ReadLine();

            Console.WriteLine("Indexes of the letters of the word {0}: ", word);

            foreach (char letter in word)
            {
                Console.WriteLine("{0} : {1}", letter, Array.IndexOf(letters,char.ToLower(letter)));
            }
        }
    }
}
