/*Problem 7. Replace sub-string

Write a program that replaces all occurrences of the sub-string start with the sub-string finish in a text file.
Ensure it will work with large files (e.g. 100 MB).*/
namespace _07.ReplaceSubstring
{
    using System.IO;

    class ReplaceSubstring
    {
        static void Main()
        {
            using (StreamReader input = new StreamReader("../../input.txt"))
            {
                using (StreamWriter output = new StreamWriter("../../output.txt"))
                {
                    for (string line; (line = input.ReadLine()) != null; )
                    {
                        output.WriteLine(line.Replace("start", "finish"));
                    }
                }
            }
        }
    }
}
