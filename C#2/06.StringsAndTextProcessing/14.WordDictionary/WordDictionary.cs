/*Problem 14. Word dictionary

A dictionary is stored as a sequence of text lines containing words and their explanations.
Write a program that enters a word and translates it by using the dictionary.
Sample dictionary:

input	    output
.NET	    platform for applications from Microsoft
CLR	        managed execution environment for .NET
namespace	hierarchical organization of classes
 */
namespace _14.WordDictionary
{
    using System;
    using System.Collections.Generic;

    public class WordDictionary
    {
        public static void Main()
        {
            var sampleDictionary = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase){
                                {".NET", "platform for applications from Microsoft"},
                                {"CLR", "managed execution environment for .NET"},
                                {"namespace", "hierarchical organization of classes" }
                                                                                            };

            Console.Write("Find a definition for: ");
            string wordTosearch = Console.ReadLine();

            try
            {
                Console.WriteLine("{0} - {1}", wordTosearch, sampleDictionary[wordTosearch.ToLowerInvariant()]);
            }
            catch (KeyNotFoundException)
            {

                Console.WriteLine("The word '{0}' cannot be found in the dictionary!", wordTosearch);
            }
        }
    }
}
