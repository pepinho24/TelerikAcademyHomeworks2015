/* Problem 11. Adding polynomials

Write a method that adds two polynomials.
Represent them as arrays of their coefficients.
Example:

x2 + 5 = 1x2 + 0x + 5 => {5, 0, 1}*/
using System;

public class AddingPolynomials
{
    private static decimal[] SumOfPolynomials(decimal[] firstPolynomial, decimal[] secondPolynomial)
    {
        int minLenght = 0;
        int smallerPolynomial = 0;
        decimal[] result;

        if (firstPolynomial.Length > secondPolynomial.Length)
        {
            result = new decimal[firstPolynomial.Length];
            minLenght = secondPolynomial.Length;
            smallerPolynomial = 2;
        }
        else
        {
            result = new decimal[secondPolynomial.Length];
            minLenght = firstPolynomial.Length;
            smallerPolynomial = 1;
        }

        for (int i = 0; i < minLenght; i++)
        {
            result[i] = firstPolynomial[i] + secondPolynomial[i];
        }

        for (int i = minLenght; i < result.Length; i++)
        {
            if (smallerPolynomial == 1)
            {
                result[i] = secondPolynomial[i];
            }
            else
            {
                result[i] = firstPolynomial[i];
            }
        }

        return result;
    }

    private static void Printpolynomial(decimal[] polynomial)
    {
        for (int i = polynomial.Length - 1; i >= 0; i--)
        {
            if (polynomial[i] != 0 && i != 0)
            {
                if (polynomial[i - 1] >= 0)
                {
                    Console.Write("{1}x^{0} +", i, polynomial[i]);
                }
                else
                {
                    Console.Write("{1}x^{0} ", i, polynomial[i]);
                }
            }
            else if (i == 0)
            {
                Console.Write("{0}", polynomial[i]);
            }
        }

        Console.WriteLine();
    }

    static void Main()
    {
        decimal[] firstPolynomial = { 5, -1 };
        Console.Write("First polynomial:                 ");
        Printpolynomial(firstPolynomial);

        decimal[] secondPolynomial = { 10, -5, 6 };
        Console.Write("Second polynomial:                ");
        Printpolynomial(secondPolynomial);

        Console.WriteLine();

        decimal[] result = SumOfPolynomials(firstPolynomial, secondPolynomial);
        Console.Write("Sum:                              ");
        Printpolynomial(result);
    }
}