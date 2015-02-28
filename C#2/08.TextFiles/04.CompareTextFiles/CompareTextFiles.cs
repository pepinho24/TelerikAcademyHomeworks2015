/*Problem 4. Compare text files

Write a program that compares two text files line by line and prints the number of lines that are the same and the number of lines that are different.
Assume the files have equal number of lines.*/
namespace _04.CompareTextFiles
{
    using System;
    using System.IO;

    class CompareTextFiles
    {
        static void Main()
        {
            int numberOfLines = 0, sameLinesCount = 0;

            using (StreamReader firstInputFile = new StreamReader("../../FirstInputFile.txt"))
            {
                using (StreamReader secondInputFile = new StreamReader("../../SecondInputFile.txt"))
                {
                    for (string firstLine, secondLine; (firstLine = firstInputFile.ReadLine()) != null && (secondLine = secondInputFile.ReadLine()) != null; numberOfLines++)
                    {
                        if (firstLine == secondLine)
                        {
                            sameLinesCount++;
                        }
                    }
                }
            }

            Console.WriteLine("Number of the same lines is: {0}", sameLinesCount);
            Console.WriteLine("Number of different lines is: {0}", numberOfLines - sameLinesCount);
        }
    }
}
