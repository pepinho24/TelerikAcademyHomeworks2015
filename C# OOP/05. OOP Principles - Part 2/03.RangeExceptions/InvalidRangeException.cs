/*Define a class InvalidRangeException<T> that holds information about an error condition related to invalid range. 
 * It should hold error message and a range definition [start … end].*/
namespace _03.RangeExceptions
{
    using System;

    public class InvalidRangeException<T> : ArgumentOutOfRangeException
        where T : IComparable<T>
    {
        private T start;
        private T end;

        public InvalidRangeException(string message, T start, T end, Exception ex)
            : base(String.Format("{0}\nParameter should be in range[{1} - {2}]", message, start, end), ex)
        {
            this.Start = start;
            this.End = end;
        }

        public InvalidRangeException(string message, T start, T end)
            : this(message, start, end, null) 
        {
        }

        public InvalidRangeException(T start, T end)
            : this(null, start, end, null) 
        { 
        }
        
        public T Start
        {
            get { return this.start; }
            set { this.start = value; }
        }

        public T End
        {
            get { return this.end; }
            set { this.end = value; }
        }
    }
}
