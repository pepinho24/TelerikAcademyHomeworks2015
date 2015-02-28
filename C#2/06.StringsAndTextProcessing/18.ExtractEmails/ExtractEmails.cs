/*Problem 18. Extract e-mails

Write a program for extracting all email addresses from given text.
All sub-strings that match the format <identifier>@<host>…<domain> should be recognized as emails.*/
namespace _18.ExtractEmails
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class ExtractEmails
    {
        public static void Main()
        {
            string str = "E-mail pesho@pesho.com. personal:pesho@gosho.com return";
            var emailMatches = Regex.Matches(str, @"\w+@\w+\.\w+");
            List<string> emails = new List<string>();

            foreach (var item in emailMatches)
            {
                emails.Add(item.ToString());
            }

            Console.WriteLine("All the e-mails are : {0}", string.Join(", ", emails));
        }
    }
}
