/*Problem 7. Reverse number

Write a method that reverses the digits of given decimal number.
Example:

input	output
256	    652*/
using System;
using System.Linq;

public class ReverseNumber
{
    public static void Main()
    {
        decimal number = -123.45M;
        decimal reversedNumber = ReturnReversedNumber(number);

        Console.WriteLine(reversedNumber);
    }

    private static decimal ReturnReversedNumber(decimal number)
    {
        decimal reversedNumber = number;
      
        var numberToChar = number.ToString().ToArray();

        if (numberToChar[0]== '-')
        {
            var temp = numberToChar.Skip(1);
            var num = temp.ToArray().Reverse().ToArray();
            reversedNumber = - decimal.Parse(string.Join("", num));
        }
        else
        {
            var num = numberToChar.ToArray().Reverse().ToArray();
            reversedNumber = decimal.Parse(string.Join("",num));
        }

        return reversedNumber;
    }
}