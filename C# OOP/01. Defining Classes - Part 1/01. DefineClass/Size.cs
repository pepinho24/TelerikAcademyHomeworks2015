using System;
namespace _01.DefineClass
{
    public class Size
    {
        private double width;
        private double height;

        public Size(double width)
            : this(width, width)
        {

        }

        public Size(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width
        {
            get { return this.width; }
            set
            {
                if (value > 0)
                {
                    this.width = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Width should be greater than 0!");
                }
            }
        }

        public double Height
        {
            get { return this.height; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Height should be greater than 0!");
                }
                else
                {
                    this.height = value;
                }
            }
        }

        public double DiagonalLength
        {
            get
            {
                return Math.Sqrt(this.Height * this.Height + this.Width * this.Width);
            }
        }
    }
}
