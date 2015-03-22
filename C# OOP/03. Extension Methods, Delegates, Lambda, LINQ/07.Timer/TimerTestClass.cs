namespace _07.Timer
{
    using System;

    public class TimerTestClass
    {
        public static void Main()
        {
            var timer = new Timer(delegate() { Console.WriteLine("Working!"); });
            timer.RunTimer();
        }
    }
}
