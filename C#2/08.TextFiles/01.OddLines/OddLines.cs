/*Problem 1. Odd lines

Write a program that reads a text file and prints on the console its odd lines.*/
namespace _01.OddLines
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class OddLines
    {
        static void Main()
        {
            string line = string.Empty;

            using (StreamReader input = new StreamReader("../../OddLines.cs"))
            {
                for (int n = 1; (line = input.ReadLine()) != null; n++)
                {
                    if (n % 2 == 1) Console.WriteLine(line); //odd lines
                    //if (n % 2 == 0) Console.WriteLine(line); //even lines
                }
            }
        }
    }
}
