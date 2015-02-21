/* Problem 11. Adding polynomials

Write a method that adds two polynomials.
Represent them as arrays of their coefficients.
Example:

x2 + 5 = 1x2 + 0x + 5 => {5, 0, 1}*/
using System;

public class AddingPolynomials
{
    private static decimal[] SumOfPolinomials(decimal[] firstPolinomial, decimal[] secondPolinomial)
    {
        int minLenght = 0;
        int smallerPolinomial = 0;
        decimal[] result;

        if (firstPolinomial.Length > secondPolinomial.Length)
        {
            result = new decimal[firstPolinomial.Length];
            minLenght = secondPolinomial.Length;
            smallerPolinomial = 2;
        }
        else
        {
            result = new decimal[secondPolinomial.Length];
            minLenght = firstPolinomial.Length;
            smallerPolinomial = 1;
        }

        for (int i = 0; i < minLenght; i++)
        {
            result[i] = firstPolinomial[i] + secondPolinomial[i];
        }

        for (int i = minLenght; i < result.Length; i++)
        {
            if (smallerPolinomial == 1)
            {
                result[i] = secondPolinomial[i];
            }
            else
            {
                result[i] = firstPolinomial[i];
            }
        }

        return result;
    }

    private static void PrintPolinomial(decimal[] polinomial)
    {
        for (int i = polinomial.Length - 1; i >= 0; i--)
        {
            if (polinomial[i] != 0 && i != 0)
            {
                if (polinomial[i - 1] >= 0)
                {
                    Console.Write("{1}x^{0} +", i, polinomial[i]);
                }
                else
                {
                    Console.Write("{1}x^{0} ", i, polinomial[i]);
                }
            }
            else if (i == 0)
            {
                Console.Write("{0}", polinomial[i]);
            }
        }

        Console.WriteLine();
    }

    static void Main()
    {
        decimal[] firstPolinomial = { 5, -1 };
        Console.Write("First polinomial:                 ");
        PrintPolinomial(firstPolinomial);

        decimal[] secondPolinomial = { 10, -5, 6 };
        Console.Write("Second polinomial:                ");
        PrintPolinomial(secondPolinomial);

        Console.WriteLine();

        decimal[] result = SumOfPolinomials(firstPolinomial, secondPolinomial);
        Console.Write("Sum:                              ");
        PrintPolinomial(result);
    }
}