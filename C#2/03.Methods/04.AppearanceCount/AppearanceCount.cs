/*Problem 4. Appearance count

Write a method that counts how many times given number appears in given array.
Write a test program to check if the method is workings correctly.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class AppearanceCount
{
    public static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 1, 2, 3, 4, 5, 6, 7, 1, 2, 3, 4, 5, 6, 7, 1, 2, 3, 4, 5, 6, 7, 1, 2, 3, 4, 5, 6, 7 };
        int number = 4;

        int count = GetAppearanceCount(numbers, number);
        Console.WriteLine(count);
    }

    private static int GetAppearanceCount(int[] numbers, int number)
    {
        int count = 0;

        foreach (var num in numbers)
        {
            if (num == number)
            {
                count++;   
            }
        }

        return count;
    }
}
