// display characteristics (size and number of colors).
/* Problem 2. Constructors

   Define several constructors for the defined classes that take different sets of arguments (the full information for the class or part of it).
   Assume that model and manufacturer are mandatory (the others are optional). All unknown data fill with null.
*/
namespace _01.DefineClass
{
    using System;

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
            get { return this.numberOfColors; }
            set
            {
                if (numberOfColors > 0)
                {
                    this.numberOfColors = value;
                }
                else
                {
                    throw new ArgumentException("The number of colors must be more than 0!");
                }
            }
        }

        public Size Size
        {
            get { return this.size; }
            set { this.size = value; }
        }

        public override string ToString()
        {
            return string.Format("Diagonal Length: {0}, Number of Colors: {1}", this.Size.DiagonalLength, this.NumberOfColors);
        }
    }
}
