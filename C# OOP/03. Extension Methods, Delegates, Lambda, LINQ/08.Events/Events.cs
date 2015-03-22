/*Problem 8.* Events

Read in MSDN about the keyword event in C# and how to publish events.
Re-implement the above using .NET events and following the best practices.*/
namespace _08.Events
{
    using System;

    public class Events
    {
        public static void Main()
        {
            Timer timer = new Timer();

            timer.TimesUp += TimerOnInterval;

            timer.Run(1000);
            PrintSeparator();

            // Attach delegate as a listener
            timer.TimesUp += delegate(object sender, EventArgs args)
            {
                Console.WriteLine("Printing from degate(object sender, EventArgs args)");
            };

            // Attach anonymous type as a listener
            timer.TimesUp += (sender, args) => Console.WriteLine("Printing from anonymous type (sender, args) =>");
            timer.Run(1000,5);
            PrintSeparator();

            timer.TimesUp -= TimerOnInterval;
            timer.Run(1000, 5);
            PrintSeparator();

            Console.WriteLine("T-t-that's all folks!");
        }

        private static void PrintSeparator()
        {
            Console.WriteLine();
            Console.WriteLine(new string('=',Console.BufferWidth));
            Console.WriteLine();
        }

        private static void TimerOnInterval(object sender, EventArgs eventArgs)
        {
            Console.WriteLine("Printing from TimerOnInterval");
        }
    }
}
