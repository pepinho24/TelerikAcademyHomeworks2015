/*Problem 9. Delete odd lines

Write a program that deletes from given text file all odd lines.
The result should be in the same file.*/
namespace _09.DeleteOddLines
{
    using System.Collections.Generic;
    using System.IO;

    class DeleteOddLines
    {
        static List<string> ReadEvenLines()
        {
            List<string> lines = new List<string>();

            int n = 1;

            using (StreamReader input = new StreamReader("../../Input.txt"))
            {
                for (string line; (line = input.ReadLine()) != null; n++)
                {
                    if (n % 2 == 0)
                    {
                        lines.Add(line);
                    }
                }
            }

            return lines;
        }

        static void WriteLines(List<string> lines)
        {
            using (StreamWriter output = new StreamWriter("../../Input.txt"))
                foreach (string line in lines)
                {
                    output.WriteLine(line);
                }
        }

        static void Main()
        {
            // This is not good because it stores all the lines in memory
            //WriteLines(ReadEvenLines());

            string inputFilePath = "../../Input.txt";

            // Here we use a temporary file, source : http://stackoverflow.com/questions/668907/how-to-delete-a-line-from-a-text-file-in-c
            DeleteAllOddLines(inputFilePath);
        }

        private static void DeleteAllOddLines(string inputFilePath)
        {
            var tempFile = Path.GetTempFileName();

            using (var reader = new StreamReader(inputFilePath))
            {
                using (var writer = new StreamWriter(tempFile))
                {
                    string line;
                    bool isOdd = true;

                    while ((line = reader.ReadLine()) != null)
                    {
                        if (!isOdd)
                        {
                            writer.WriteLine(line);
                        }

                        isOdd = !isOdd;
                    }
                }
            }

            File.Delete(inputFilePath);
            File.Move(tempFile, inputFilePath);
            File.Delete(tempFile);
        }
    }
}
