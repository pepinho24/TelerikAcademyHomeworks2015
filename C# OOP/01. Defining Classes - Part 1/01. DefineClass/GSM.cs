//Problem 1. Define class
//Define a class that holds information about a mobile phone device: model, manufacturer, price, owner, battery characteristics (model, hours idle and hours talk) and display characteristics (size and number of colors).
// Define 3 separate classes (class GSM holding instances of the classes Battery and Display).

/* Problem 2. Constructors

   Define several constructors for the defined classes that take different sets of arguments (the full information for the class or part of it).
   Assume that model and manufacturer are mandatory (the others are optional). All unknown data fill with null.
*/
/* Problem 6. Static field

   Add a static field and a property IPhone4S in the GSM class to hold the information about iPhone 4S.
*/

using System;
namespace _01.DefineClass
{
    public class GSM
    {
        private static readonly GSM iPhone4S = new GSM("IPhone 4S", "Apple Inc.");

        private const string NotAvailable = "N/A";
        private string model;
        private string manufacturer;
        private double? price;
        private Human owner;
        private Battery battery;
        private Display display;

        public GSM(string model, string manufacturer, double? price = null, Human owner = null, Battery battery = null, Display display = null)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.Battery = battery;
            this.Display = display;
        }

        public static GSM IPhone4S
        {
            get
            {
                return iPhone4S;
            }
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

        public string Manufacturer
        {
            get { return this.manufacturer; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Manufacturer cannot be null or empty!");
                }
                else
                {
                    this.manufacturer = value;
                }
            }
        }

        public double? Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Price cannot be less than 0!");
                }
                else
                {
                    this.price = value;
                }
            }
        }

        public Human Owner
        {
            get { return this.owner; }
            set { this.owner = value; }
        }

        public Battery Battery
        {
            get { return this.battery; }
            set { this.battery = value; }
        }

        public Display Display
        {
            get { return this.display; }
            set { this.display = value; }
        }

        public override string ToString()
        {
            string manufact = this.Manufacturer;
            string model = this.Model;
            string price = this.Price == null ? NotAvailable : this.Price.ToString();
            string owner = this.Owner == null ? NotAvailable : this.Owner.FullName;
            string battery = this.Battery == null ? NotAvailable : this.Battery.ToString();
            string display = this.Display == null ? NotAvailable : this.Display.ToString();

            string gsmInfo = string.Format(@"Model: {1},
    GSM Manufacturer: {0},
    Price: {2}, 
    Owner: {3}, 
    Battery: {4}, 
    Display: {5}",
              manufact, model, price, owner, battery, display);

            return gsmInfo;
        }
    }
}
