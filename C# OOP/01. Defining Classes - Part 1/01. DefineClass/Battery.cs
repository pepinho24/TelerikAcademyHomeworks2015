// battery characteristics (model, hours idle and hours talk)
/* Problem 2. Constructors

   Define several constructors for the defined classes that take different sets of arguments (the full information for the class or part of it).
   Assume that model and manufacturer are mandatory (the others are optional). All unknown data fill with null.
*/
namespace _01.DefineClass
{
    using System;

    public class Battery
    {
        private string model;
        private double hoursIdle;
        private double hoursTalk;

        public BatteryType BatteryType { get; private set; }

        public Battery(string model, double hoursIdle, double hoursTalk, BatteryType batteryType)
        {
            this.Model = model;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
            this.BatteryType = batteryType;
        }

        public string Model
        {
            get { return this.model; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Model cannot be null or empty!");
                }
                else
                {
                    this.model = value;
                }
            }
        }

        public double HoursIdle
        {
            get { return this.hoursIdle; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Hours idle should not be a negative number!");
                }
                else
                {
                    this.hoursIdle = value;
                }
            }
        }

        public double HoursTalk
        {
            get { return this.hoursTalk; }
            set
            {

                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Hours talk should not be a negative number!");
                }
                else
                {
                    this.hoursTalk = value;
                }
            }
        }

        public override string ToString()
        {
            return string.Format("Battery Model: {0}, HoursIdle: {1}, Hours Talk: {2}, Battery Type: {3}",
                                this.Model, this.HoursIdle, this.HoursTalk, this.BatteryType.ToString());
        }
    }
}
