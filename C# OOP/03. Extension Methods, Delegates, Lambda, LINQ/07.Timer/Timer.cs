/*Problem 7. Timer

Using delegates write a class Timer that can execute certain method at each t seconds.*/
namespace _07.Timer
{
    using System.Threading;

    public class Timer
    {
        public delegate void Event();

        public int IntervalMiliseconds { get; set; }
        private bool runTimer = true;

        public Event Execute { get; set; }

        public Timer(Event execute)
            : this(1000, execute)
        {
        }

        public Timer(int tSeconds, Event execute)
        {

            this.IntervalMiliseconds = tSeconds;
            this.Execute = execute;
        }

        public void StopTimer()
        {
            this.runTimer = false;
        }
        public void RunTimer()
        {
            this.runTimer = true;
            while (this.runTimer)
            {
                this.Execute();
                Thread.Sleep(this.TSeconds * 1000);
            }
        }

        public int TSeconds { get; set; }
    }
}
