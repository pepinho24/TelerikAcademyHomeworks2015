namespace _08.Events
{
    using System;
    using System.Collections;
    using System.Threading;

    // A delegate type for hooking up for notifications when the interval of time passes.
    public delegate void ChangedEventHandler(object sender, EventArgs e);

    public class Timer
    {
        // An event that clients can use to be notified
        // when the interval of time passes
        public event ChangedEventHandler TimesUp; // EventHandler

        private bool isRunning { get; set; }
        private int repeatingTimesCount { get; set; }

        // invoke event when the interval of time passes
        public void Run(int intervalTime, int repeatingTimesCount = 10)
        {
            this.repeatingTimesCount = repeatingTimesCount;
            this.isRunning = true;

            while (isRunning && this.repeatingTimesCount > 0)
            {
                this.OnTimeUp();
                this.repeatingTimesCount--;
                Thread.Sleep(intervalTime);
            }
        }

        public void Stop()
        {
            this.isRunning = false;
        }

        // Invoke the TimesUp event; called when the interval of time passes
        private void OnTimeUp()
        {
            if (this.TimesUp != null)
            {
                this.TimesUp(this, EventArgs.Empty);
            }
        }
    }
}
