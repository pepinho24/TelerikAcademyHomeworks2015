/*Problem 6. First larger than neighbours

Write a method that returns the index of the first element in array that is larger than its neighbours, or -1, if there’s no such element.
Use the method from the previous exercise.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class FirstLargerThanNeighbours
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

    public static void Main()
    {
        int[] array = { 1, 2, 3, 4, 5, 6, 6, 7, 5, 1, 3 };
        Console.WriteLine("The array: [{0}]", string.Join(", ", array));

        int index = ReturnFirstLargerThanNeighbours(array);
        string message = string.Empty;
        
        if (index < 0 || index > array.Length)
        {
            message = "There is no number larger than its neighbours!";
        }
        else
        {
            message = string.Format("The index of the first number larger than its neighbours is {0}", index);
        }

        Console.WriteLine(message);
    }

    private static int ReturnFirstLargerThanNeighbours(int[] array)
    {
        int index = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (IsBiggerFromTheNeighbors(array, i))
            {
                index = i;
                return index;
            }
        }

        return index;
    }
}
