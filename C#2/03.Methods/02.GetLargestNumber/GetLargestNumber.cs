/*Problem 2. Get largest number

Write a method GetMax() with two parameters that returns the larger of two integers.
Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().*/
using System;

public class GetLargestNumber
{
    public static void Main()
    {
        int firstNumber = 4;
        int secondNumber = 3;
        int thirdNumber = 3;

        int biggestNumber = GetMax(firstNumber, secondNumber, thirdNumber);

        Console.WriteLine(biggestNumber);
    }

    private static int GetMax(int firstNumber, int secondNumber, int thirdNumber)
    {
        if (firstNumber >= secondNumber)
        {
            if (firstNumber >= thirdNumber)
            {
                return firstNumber;
            }
            else
            {
                return thirdNumber;
            }
        }
        else if (secondNumber >= firstNumber)
        {
            if (secondNumber >= thirdNumber)
            {
                return secondNumber;
            }
            else
            {
                return thirdNumber;
            }
        }
        else
        {
            return thirdNumber;
        }
    }

    private static int GetMax(int firstNumber, int secondNumber)
    {
        if (firstNumber > secondNumber)
        {
            return firstNumber;
        }
        else
        {
            return secondNumber;
        }
    }
}
