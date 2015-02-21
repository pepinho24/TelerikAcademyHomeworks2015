/*Problem 8. Number as array

Write a method that adds two positive integer numbers represented as arrays of digits (each array element arr[i] contains a digit; the last digit is kept in arr[0]).
Each of the numbers that will be added could have up to 10 000 digits.*/
using System;
using System.Linq;

public class NumberAsArray
{
    public static void Main()
    {
        string firstNumber = "923";
        string secondNumber = "345";

        int[] firstArr = ConvertNumberToIntArray(firstNumber);
        int[] secondArr = ConvertNumberToIntArray(secondNumber);

        Array.Reverse(firstArr);
        Array.Reverse(secondArr);

        int[] result = SumTwoIntegersAsArrays(firstArr, secondArr);
    }

    private static int[] SumTwoIntegersAsArrays(int[] firstArr, int[] secondArr)
    {
        int[] result;
        int currentResult = 0;
        int reminder = 0;

        if (firstArr.Length > secondArr.Length)
        {
            result = new int[firstArr.Length + 1];
        }
        else
        {
            result = new int[secondArr.Length + 1];
        }

        for (int i = 0; i < result.Length; i++)
        {
            // if i is within the array's range get the i-th element of the array, else get 0
            int firstNumber = (firstArr.Length > i) ? firstArr[i] : 0; 
            int secondNumber = (secondArr.Length > i) ? secondArr[i] : 0;

            currentResult = firstNumber + secondNumber + reminder;

            if (currentResult > 9)
            {
                currentResult = currentResult - 10;
                reminder = 1;
            }
            else
            {
                reminder = 0;
            }

            result[i] = currentResult;
        }
        return result;
    }

    private static int[] ConvertNumberToIntArray(string number)
    {
        // the following code means: convert the number to array of chars, 
        // then stringify every char and parse it to integer,
        // and finally convert the result to array of integers
        return number.ToArray().Select(x => int.Parse(x.ToString())).ToArray();
    }
}