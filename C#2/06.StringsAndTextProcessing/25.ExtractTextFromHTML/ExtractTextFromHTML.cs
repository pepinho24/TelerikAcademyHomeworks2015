/*Problem 25. Extract text from HTML

Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags.
Example input:

<html>
  <head><title>News</title></head>
  <body><p><a href="http://academy.telerik.com">Telerik
    Academy</a>aims to provide free real-world practical
    training for young people who want to turn into
    skilful .NET software engineers.</p></body>
</html>
Output:

Title: News

Text: Telerik Academy aims to provide free real-world practical training for young people who want to turn into skilful .NET software engineers.*/
namespace _25.ExtractTextFromHTML
{
    using System;
    using System.IO;
    using System.Text.RegularExpressions;

    public class ExtractTextFromHTML
    {

        static void Main(string[] args)
        {
             //string text = "<html><head><title>News</title></ head><body><p><a href=\"http://academy.telerik.com\">Telerik Academy</a>aims to provide free real-world practical training for young people who want to turn into skilful .NET software engineers.</p></body></html>";
            string text = string.Empty;
            using (var reader = new StreamReader("../../HTMLFile.html"))
            {
                text = reader.ReadToEnd();
            }
            
            string title = GetTitle(text);
            string body = GetText(text);

            Console.WriteLine("Title:  {0} {1} Text:   {2}", String.IsNullOrWhiteSpace(title) ? "No title": title, Environment.NewLine, body);
        }

        private static string GetText(string sample)
        {
            string text = Regex.Match(sample, @"<\s*body\s*>.*?<\s*/\s*body\s*>", RegexOptions.Singleline).ToString();
            return Regex.Replace(text, @"<.*?>", String.Empty);
        }

        private static string GetTitle(string sample)
        {
            string head = Regex.Match(sample, @"<\s*head\s*>.*?<\s*/\s*head\s*>").ToString();
            if (head == String.Empty || !head.Contains("title"))
            {
                return string.Empty;
            }

            string title = Regex.Match(head, @"<\s*title\s*>.*?<\s*/\s*title\s*>").ToString();
            title = Regex.Replace(title, @"<\s*title\s*>", String.Empty);
            title = Regex.Replace(title, @"<\s*/\s*title\s*>", String.Empty);

            return title.Trim();
        }
    }
}
