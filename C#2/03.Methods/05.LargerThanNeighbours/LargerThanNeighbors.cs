/*Problem 5. Larger than neighbours

Write a method that checks if the element at given position in given array of integers is larger than its two neighbours (when such exist).*/
using System;

public class LargerThanNeighbours
{
    private static bool IsBiggerFromTheNeighbors(int[] array, int index)
    {
        if (index >= array.Length - 1 || index < 0)
        {
            Console.WriteLine("No Such Element With That Index!");
            return false;
        }

        if (index == 0)
        {
            if (array[index] > array[index + 1])
            {
                return true;
            }
        }
        else if (index == array.Length - 1)
        {
            if (array[index] > array[index - 1])
            {
                return true;
            }
        }
        else
        {
            if (array[index] > array[index - 1] && array[index] > array[index + 1])
            {
                return true;
            }
        }

        return false;
    }

    static void Main()
    {
        int[] array = new int[] { 1, 5, 7, 4, 8, 6, 9, 1, 4, 2, 5, 6, 3, 7, 4, 1, 8, 5, 6, 9, 5, 1, 4 };
        Console.WriteLine("The array is [{0}]", string.Join(", ",array));

        Console.Write("Enter an index: ");
        int index = Int32.Parse(Console.ReadLine());
        Console.WriteLine(IsBiggerFromTheNeighbors(array, index));
    }
}