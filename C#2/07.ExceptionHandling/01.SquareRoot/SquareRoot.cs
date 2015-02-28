/*Problem 1. Square root

Write a program that reads an integer number and calculates and prints its square root.
If the number is invalid or negative, print Invalid number.
In all cases finally print Good bye.
Use try-catch-finally block.*/
namespace _01.SquareRoot
{
    using System;

    public class SquareRoot
    {
        public static void Main()
        {
            try
            {
                Console.Write("Enter an integer number: ");
                uint n = uint.Parse(Console.ReadLine());

                Console.WriteLine("Square root of {0} is {1}!", n, Math.Sqrt(n));
            }
            catch (ArgumentNullException)
            {
                Console.Error.WriteLine("Invalid number!");
            }
            catch (FormatException)
            {
                Console.Error.WriteLine("Invalid number!");
            }
            catch (OverflowException)
            {
                Console.Error.WriteLine("Invalid number!");
            }
            finally
            {
                Console.WriteLine("Good bye!");
            }
        }
    }
}
