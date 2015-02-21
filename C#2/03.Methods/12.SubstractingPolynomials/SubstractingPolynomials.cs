/*Problem 12. Subtracting polynomials

Extend the previous program to support also subtraction and multiplication of polynomials.*/
using System;

public class SubstractingPolynomials
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

    private static decimal[] SubstractionOfPolynomials(decimal[] firstPolynomial, decimal[] secondPolynomial)
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
            result[i] = firstPolynomial[i] - secondPolynomial[i];
        }

        for (int i = minLenght; i < result.Length; i++)
        {
            if (smallerPolynomial == 1)
            {
                result[i] = -secondPolynomial[i];
            }
            else
            {
                result[i] = firstPolynomial[i];
            }
        }

        return result;
    }

    private static decimal[] MultiplyPolynomials(decimal[] firstPolynomial, decimal[] secondPolynomial)
    {
        var result = new decimal[firstPolynomial.Length + secondPolynomial.Length];

        // declare zeros at result polynom
        for (int i = 0; i < result.Length; i++)
        {
            result[i] = 0;
        }

        for (int i = 0; i < firstPolynomial.Length; i++)
        {
            for (int j = 0; j < secondPolynomial.Length; j++)
            {
                int position = i + j;
                result[position] += (firstPolynomial[i] * secondPolynomial[j]);
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

    public static void Main()
    {
        decimal[] firstPolynomial = { 5, -1 };
        Console.Write("First polynomial:                 ");
        Printpolynomial(firstPolynomial);

        decimal[] secondPolynomial = { 10, -5, 6 };
        Console.Write("Second polynomial:                ");
        Printpolynomial(secondPolynomial);

        decimal[] result;
        Console.WriteLine();

        result = SumOfPolynomials(firstPolynomial, secondPolynomial);
        Console.Write("Sum:                              ");
        Printpolynomial(result);

        result = SubstractionOfPolynomials(firstPolynomial, secondPolynomial);
        Console.Write("Substraction:                     ");
        Printpolynomial(result);

        result = MultiplyPolynomials(firstPolynomial, secondPolynomial);
        Console.Write("Multiplication:                   ");
        Printpolynomial(result);
    }
}