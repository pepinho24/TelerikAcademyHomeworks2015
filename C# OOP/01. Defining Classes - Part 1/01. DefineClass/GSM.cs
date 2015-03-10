//Problem 1. Define class
    //Define a class that holds information about a mobile phone device: model, manufacturer, price, owner, battery characteristics (model, hours idle and hours talk) and display characteristics (size and number of colors).
   // Define 3 separate classes (class GSM holding instances of the classes Battery and Display).

/* Problem 2. Constructors

   Define several constructors for the defined classes that take different sets of arguments (the full information for the class or part of it).
   Assume that model and manufacturer are mandatory (the others are optional). All unknown data fill with null.
*/

namespace _01.DefineClass
{
    public class GSM
    {
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
      
        public string Model
        {
            get { return model; }
            set { model = value; }
        } 
        
        public string Manufacturer
        {
            get { return manufacturer; }
            set { manufacturer = value; }
        }

        public double? Price
        {
            get { return price; }
            set { price = value; }
        }

        public Human Owner
        {
            get { return owner; }
            set { owner = value; }
        }

        public Battery Battery
        {
            get { return battery; }
            set { battery = value; }
        }
        
        public Display Display
        {
            get { return display; }
            set { display = value; }
        }
    }
}
