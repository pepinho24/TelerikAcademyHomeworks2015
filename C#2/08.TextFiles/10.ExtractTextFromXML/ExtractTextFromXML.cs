/*Problem 10. Extract text from XML

Write a program that extracts from given XML file all the text without the tags.
Example:

<?xml version="1.0"><student><name>Pesho</name><age>21</age><interests count="3"><interest>Games</interest><interest>C#</interest><interest>Java</interest></interests></student>*/
namespace _10.ExtractTextFromXML
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class ExtractTextFromXML
    {
        static void Main(string[] args)
        {
            string inputPath = @"..\..\input.xml";

            try
            {
                using (StreamReader input = new StreamReader(inputPath))
                {
                    for (int i; (i = input.Read()) != -1; ) // Read char by char
                    {
                        if (i == '>') // Inside text node
                        {
                            string text = String.Empty;

                            while ((i = input.Read()) != -1 && i != '<')
                            {
                                text += (char)i;
                            }

                            if (!String.IsNullOrWhiteSpace(text))
                            {
                                Console.WriteLine(text.Trim());
                            }
                        }
                    }
                }
            }

            catch (DirectoryNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (FileNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (FileLoadException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (EndOfStreamException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (IOException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
