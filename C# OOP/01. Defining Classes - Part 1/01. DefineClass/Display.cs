// display characteristics (size and number of colors).
/* Problem 2. Constructors

   Define several constructors for the defined classes that take different sets of arguments (the full information for the class or part of it).
   Assume that model and manufacturer are mandatory (the others are optional). All unknown data fill with null.
*/
namespace _01.DefineClass
{
    public class Display
    {
        private const int DefaultNumberOfColors = 2;
        private Size size;
        private int numberOfColors;

        public Display(Size size, int numberOfColors = DefaultNumberOfColors)
        {
            this.Size = size;
            this.NumberOfColors = numberOfColors;
        }

        public int NumberOfColors
        {
            get { return numberOfColors; }
            set { numberOfColors = value; }
        }
        
        public Size Size
        {
            get { return size; }
            set { size = value; }
        }
    }
}
