/*Problem 3. English digit

Write a method that returns the last digit of given integer as an English word.
Examples:

input	output
512	    two
1024	four
12309	nine*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class EnglishDigit
{
    private static readonly string[] DigitsAsWords = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};

    public static void Main()
    {
        //while (true)
        //{
          int number = int.Parse(Console.ReadLine());
          string lastDigitAsWord = GetLastDigitAsWord(number);

          Console.WriteLine(lastDigitAsWord);
        //}
    }

    private static string GetLastDigitAsWord(int number)
    {
        return DigitsAsWords[number % 10];
    }
}
