namespace _05._64BitArray
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;

    public class BitArray64 : IEnumerable<int>
    {
       private ulong number;

       public BitArray64(ulong number)
        {
            this.Number = number;
        }

        public ulong Number
        {
            get { return this.number; }
            set { this.number = value; }
        }

        public int this[int position]
        {
            get
            {
                CheckPosition(position);

                return ((int)(this.Number >> position) & 1);
            }
            set
            {
                CheckPosition(position);

                if (value < 0 || value > 1)
                {
                    throw new ArgumentException("Invalid bit value.");
                }

                if (((int)(this.Number >> position) & 1) != value)
                {
                    this.Number ^= (1ul << position);
                }
            }
        }

        private static void CheckPosition(int position)
        {
            if (position < 0 || position >= 64)
            {
                throw new IndexOutOfRangeException("Invalid position!");
            }
        }

        public static bool operator ==(BitArray64 firstBitArray, BitArray64 secondBitArray)
        {
            return (firstBitArray.Equals(secondBitArray));
        }

        public static bool operator !=(BitArray64 firstBitArray, BitArray64 secondBitArray)
        {
            return !(firstBitArray.Equals(secondBitArray));
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            for (int position = 0; position < 64; position++)
            {
                result.Insert(0, ((this.Number >> position) & 1));
            }

            return result.ToString();
        }

        public override int GetHashCode()
        {
            return this.Number.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return this.Number.Equals((obj as BitArray64).Number);
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int position = 0; position < 64; position++)
            {
                yield return this[position];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public int CompareTo(object obj)
        {
            return this.Number.CompareTo((obj as BitArray64).Number);
        }
    }
}
