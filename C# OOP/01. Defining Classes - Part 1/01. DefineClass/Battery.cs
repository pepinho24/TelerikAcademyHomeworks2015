// battery characteristics (model, hours idle and hours talk)
/* Problem 2. Constructors

   Define several constructors for the defined classes that take different sets of arguments (the full information for the class or part of it).
   Assume that model and manufacturer are mandatory (the others are optional). All unknown data fill with null.
*/
namespace _01.DefineClass
{
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
            get { return model; }
            set { model = value; }
        }

        public double HoursIdle
        {
            get { return hoursIdle; }
            set { hoursIdle = value; }
        }

        public double HoursTalk
        {
            get { return hoursTalk; }
            set { hoursTalk = value; }
        }

        public override string ToString()
        {
        //public Battery(string model, double hoursIdle, double hoursTalk, BatteryType batteryType)

            return string.Format("Battery Model: {0}, HoursIdle: {1}, Hours Talk: {2}, Battery Type: {3}",
                                this.Model, this.HoursIdle, this.HoursTalk, this.BatteryType.ToString());
        }
    }
}
