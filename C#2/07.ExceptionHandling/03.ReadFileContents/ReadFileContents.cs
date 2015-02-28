/*Problem 3. Read file contents

Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), reads its contents and prints it on the console.
Find in MSDN how to use System.IO.File.ReadAllText(…).
Be sure to catch all possible exceptions and print user-friendly error messages.*/
namespace _03.ReadFileContents
{
    using System;
    using System.IO;
    using System.Security;

    public class ReadFileContents
    {
        static void Main()
        {
            Console.Write("Enter the full path of the file you want to read: ");
            string filePath = Console.ReadLine();
            ReadFile(filePath);
        }

        static void ReadFile(string filePath)
        {
            try
            {
                string fileContent = File.ReadAllText(filePath);
                Console.WriteLine("The content of the file is: ");
                Console.WriteLine(fileContent);
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("The file path contains a directory that cannot be found!");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("The file '{0}' was not found!", filePath);
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("No file path is given!");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("The entered file path is incorrect!");
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("The entered file path is over the 248 characters maximum!");
            }
            catch (UnauthorizedAccessException uae)
            {
                Console.WriteLine(uae.Message);
            }
            catch (SecurityException)
            {
                Console.WriteLine("You don't have the required permission to access this file!");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("Invalid file path format!");
            }
            catch (IOException ioe)
            {
                Console.WriteLine(ioe.Message);
            }
        }
    }
}
