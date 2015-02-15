/*Problem 1. Say Hello

Write a method that asks the user for his name and prints “Hello, <name>”
Write a program to test this method.
Example:

input	output
Peter	Hello, Peter!*/
using System;

public class SayHello
{
    public static void Main()
    {
        Console.Write("Enter a name: ");
        string name = Console.ReadLine();

        SayHelloMethod(name);
    }

    private static void SayHelloMethod(string name)
    {
        Console.WriteLine("Hello, {0}!",name );
    }
}

