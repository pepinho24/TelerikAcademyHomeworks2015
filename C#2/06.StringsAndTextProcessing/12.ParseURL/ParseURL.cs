/*Problem 12. Parse URL

Write a program that parses an URL address given in the format: [protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.
Example:

URL	Information
http://telerikacademy.com/Courses/Courses/Details/212	
[protocol] = http 
[server] = telerikacademy.com 
[resource] = /Courses/Courses/Details/212*/
namespace _12.ParseURL
{
    using System;
    using System.Text.RegularExpressions;

    public class ParseURL
    {
        public static void Main()
        {
            string url = "http://telerikacademy.com/Courses/Courses/Details/212";
            //string url = Console.ReadLine();

            var fragments = Regex.Match(url, "(.*)://(.*?)(/.*)").Groups;

            Console.WriteLine(url);
            Console.WriteLine("[protocol] = " + fragments[1]);
            Console.WriteLine("[server] = " + fragments[2]);
            Console.WriteLine("[resource] = " + fragments[3]);
        }
    }
}
