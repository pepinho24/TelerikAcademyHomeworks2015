using System;
namespace _01.DefineClass
{
    public class Size
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Size(double width)
            : this(width, width)
        {

        }

        public Size(double width, double height)
        {
            this.Width = width;
            this.Height = height;
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
