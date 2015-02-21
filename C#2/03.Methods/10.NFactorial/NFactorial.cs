/*Problem 10. N Factorial

Write a program to calculate n! for each n in the range [1..100].
Hint: Implement first a method that multiplies a number represented as array of digits by given integer number.*/
using System;
using System.Numerics;

public class NFactorial
{
    public static BigInteger CalculateFactorial(int n)
    {
        BigInteger result = new BigInteger(1);
        for (int i = 2; i <= n; ++i)
        {
            result = i * result;
        }

        return result;
    }

    public static void Main()
    {
        Console.Write("Please enter a number in the range [1-100]: ");
        int number = int.Parse(Console.ReadLine());

        var result = CalculateFactorial(number);
        Console.WriteLine(result.ToString());
    }
}