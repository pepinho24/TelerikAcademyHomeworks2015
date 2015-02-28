/*Problem 24. Order words

Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.*/
namespace _24.OrderWords
{
    using System;
    using System.Linq;

    public class OrderWords
    {
        public static void Main()
        {
            // that is the shortest solution I came up with :D
            foreach (var w in Console.ReadLine().Split(' ').OrderBy(x=>x)) Console.WriteLine(w);
        }
    }
}
