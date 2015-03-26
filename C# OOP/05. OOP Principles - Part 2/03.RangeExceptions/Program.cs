/*Problem 3. Range Exceptions

Define a class InvalidRangeException<T> that holds information about an error condition related to invalid range. 
 * It should hold error message and a range definition [start … end].
Write a sample application that demonstrates the InvalidRangeException<int> and InvalidRangeException<DateTime> 
 * by entering numbers in the range [1..100] and dates in the range [1.1.1980 … 31.12.2013].*/
namespace _03.RangeExceptions
{
    using System;

    public class Program
    {
        public static void Main()
        {
            try
            {
                throw new InvalidRangeException<int>("Invalid input!", 1, 100);
            }
            catch (InvalidRangeException<int> e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("{0}{0}", Environment.NewLine);

            try
            {
                throw new InvalidRangeException<DateTime>("Invalid date!", new DateTime(1980, 1, 1), new DateTime(2013, 12, 31));
            }
            catch (InvalidRangeException<DateTime> e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
