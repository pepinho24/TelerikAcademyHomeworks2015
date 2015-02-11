﻿//Problem 1. Allocate array

//Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5.
//Print the obtained array on the console.
namespace _01.AllocateArray
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class AllocateArray
    {
        static void Main()
        {
            var array = new int[20];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i * 5;
            }

            PrintArray(array);
        }

        private static void PrintArray(int[] array)
        {
            Console.WriteLine(string.Join(", ",array));
        }
    }
}
