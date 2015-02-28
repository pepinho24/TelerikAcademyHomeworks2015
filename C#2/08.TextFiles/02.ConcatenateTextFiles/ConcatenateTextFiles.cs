/*Problem 2. Concatenate text files

Write a program that concatenates two text files into another text file.*/
namespace _02.ConcatenateTextFiles
{
    using System;
    using System.IO;

    class ConcatenateTextFiles
    {
        static void WriteToFile(StreamWriter output, string file)
        {
            using (StreamReader input = new StreamReader(file))
            {
                for (string line; (line = input.ReadLine()) != null; )
                {
                    output.WriteLine(line);
                }
            }
        }

        static void Main()
        {
            string[] files = { "../../ConcatenateTextFiles.cs", "../../ConcatenateTextFiles.cs" };

            using (StreamWriter output = new StreamWriter("../../output.txt"))
            {
                foreach (string file in files)
                {
                    WriteToFile(output, file);
                }
            }

            Console.WriteLine("Concatenating of files completed!");
        }
    }
}
