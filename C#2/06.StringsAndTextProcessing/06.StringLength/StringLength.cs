/*Problem 6. String length

Write a program that reads from the console a string of maximum 20 characters. If the length of the string is less than 20, the rest of the characters should be filled with *.
Print the result string into the console.*/
namespace _06.StringLength
{
    using System;

    public class StringLength
    {
        public static void Main()
        {
            string str;
            do
            {
                Console.Write("Please enter a string of maximum 20 characters: ");
                 str = Console.ReadLine();

            } while (str.Length>20);
            
            string newStr = FillString(str);

            Console.WriteLine("The new string is: " + newStr);
        }

        private static string FillString(string str)
        {
            string newStr = str;
            if (str.Length < 20)
            {
                newStr = str + new String('*', 20 - str.Length);
            }

            return newStr;
        }
    }
}
