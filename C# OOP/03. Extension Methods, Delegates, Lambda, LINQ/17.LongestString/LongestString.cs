﻿/*Problem 17. Longest string

Write a program to return the string with maximum length from an array of strings.
Use LINQ.*/
namespace _17.LongestString
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class LongestString
    {
        public static void Main()
        {
            var strings = new string[] { "1", "22", "333", "4444"};

            //var str = strings.OrderByDescending(s => s.Length).FirstOrDefault();
            var str = (from s in strings
                       orderby s.Length
                       select s).LastOrDefault();                     
                      
            Console.WriteLine("Longest string is: {0}",str);
        }
    }
}
