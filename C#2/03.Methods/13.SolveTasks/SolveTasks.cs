/* Problem 13. Solve tasks

Write a program that can solve these tasks:
Reverses the digits of a number
Calculates the average of a sequence of integers
Solves a linear equation a * x + b = 0
Create appropriate methods.
Provide a simple text-based menu for the user to choose which task to solve.
Validate the input data:
The decimal number should be non-negative
The sequence should not be empty
a should not be equal to 0
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

public class SolveTasks
{
    static decimal LinearEquation(decimal a, decimal b)
    {
        return -(b) / a;
    }

    static double AverageOfIntegers(int[] arr)
    {
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }

        return (double)sum / arr.Length;
    }

    static string ReverseDigits(decimal num)
    {
        string numToString = num.ToString();
        char[] numToChar = numToString.ToArray();
       
        Array.Reverse(numToChar);

        return string.Join("",numToChar);
    }


    static void Main()
    {
        ChangeCultureToUS();

        PrintMenu();
        byte choice = byte.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1: SolveTaskReverseDigits();
                break;
            case 2: SolveTaskAverageSum();
                break;
            case 3: SolveTaskLinearEquation();
                break;
            default: Console.WriteLine("Invalid choice.");
                break;
        }
    }

    private static void ChangeCultureToUS()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US");
        Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture("en-US");
    }

    private static void SolveTaskLinearEquation()
    {
        Console.Write("Please enter a: ");
        decimal a = decimal.Parse(Console.ReadLine());

        while (a == 0)
        {
            Console.WriteLine("Please enter a!=0");
            a = decimal.Parse(Console.ReadLine());
        }

        Console.Write("Please enter b: ");
        decimal b = decimal.Parse(Console.ReadLine());

        Console.WriteLine("{0}x {1}= 0", a == 1 ? string.Empty : a.ToString(), (b >= 0) ? ("+ " + b.ToString()) : b.ToString());
        Console.WriteLine("x = {0}", LinearEquation(a, b));
    }

    private static void SolveTaskAverageSum()
    {
        Console.Write("Please enter number of integers: ");

        string str = Console.ReadLine();
        int size = int.Parse(str);
        while (size < 1)
        {
            Console.Write("Please enter a number bigger than 1: ");
            str = Console.ReadLine();
            size = int.Parse(str);
        }

        int[] array = new int[size];

        Console.WriteLine("Now enter {0} numbers", size);
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Number {0}: ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("The average sum is: {0}", AverageOfIntegers(array));
    }

    private static void SolveTaskReverseDigits()
    {
        decimal number = decimal.Parse(Console.ReadLine().Replace(',','.'));
        
        while (number < 0)
        {
            Console.Write("Please enter positive number: ");
            number = decimal.Parse(Console.ReadLine());
        }

        Console.WriteLine(ReverseDigits(number));
    }

    private static void PrintMenu()
    {
        Console.WriteLine("1-Reverse digits of number.");
        Console.WriteLine("2-Calculates the average of a sequence of integers.");
        Console.WriteLine("3-Solves a linear equation a * x + b = 0");
        Console.Write("Your choice: ");
    }
}