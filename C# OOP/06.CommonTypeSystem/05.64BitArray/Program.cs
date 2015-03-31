/*Problem 5. 64 Bit array

Define a class BitArray64 to hold 64 bit values inside an ulong value.
Implement IEnumerable<int> and Equals(…), GetHashCode(), [], == and !=.*/
namespace _05._64BitArray
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        public static void Main()
        {
            BitArray64 firstArray = new BitArray64(7u);
            BitArray64 secondArray = new BitArray64(8u);

            Console.WriteLine("FirstArray:");
            Console.WriteLine(firstArray);
            firstArray[1] = 0;
            Console.WriteLine("Modified FirstArray:");
            Console.WriteLine(firstArray);

            Console.WriteLine("SecondArray:");
            Console.WriteLine(secondArray);

            Console.WriteLine("firstArray == secondArray : {0}", firstArray == secondArray);
            Console.WriteLine("firstArray.Equals(firstArray) : {0}",firstArray.Equals(firstArray));
            Console.WriteLine("firstArray != secondArray : {0}", firstArray != secondArray);
        }
    }
}
