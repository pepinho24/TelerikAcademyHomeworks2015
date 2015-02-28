/*Problem 20. Palindromes

Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.*/
namespace _20.Palindromes
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using System.Diagnostics;

    public class Palindromes
    {
        static bool IsPalindrome(string str)
        {
            for (int i = 0; i < str.Length / 2; i++)
            {
                if (str[i] != str[str.Length - 1 - i])
                {
                    return false;
                }
            }

            return true;
        }

        static void Main()
        {
            string str = "Static void Main() ABBA, using System lamal, exe.";
            var palindromes = new List<string>();
            var palindromesWithRegex = new List<string>();
     
            foreach (Match item in Regex.Matches(str, @"\w+"))
            {
                if (IsPalindrome(item.Value))
                {
                    palindromes.Add(item.Value);
                }
            }
            
            // alternative method
            foreach (Match item in Regex.Matches(str, @"\b(?<N>.)+.?(?<-N>\k<N>)+(?(N)(?!))\b")) 
            {
                palindromesWithRegex.Add(item.Value);
            }
           
            Console.WriteLine("All the palindromes(found without regex) are : {0}", string.Join(", ", palindromes));
            Console.WriteLine();
            Console.WriteLine("All the palindromes(found with regex) are : {0}", string.Join(", ", palindromesWithRegex));
        }
    }
}
