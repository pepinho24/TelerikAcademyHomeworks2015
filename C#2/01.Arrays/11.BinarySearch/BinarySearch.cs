//Problem 11. Binary search

//Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.
namespace _11.BinarySearch
{
    using System;

    public class BinarySearch
    {
        public static void Main()
        {
            int[] array = { -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            // int[] array = ReadArray();
            // Array.Sort(array);

            Console.Write("Enter the element: ");
            int key = Int32.Parse(Console.ReadLine());
            int imin = 0;
            int imax = array.Length;

            bool found = false;
            {
                // continue searching while [imin,imax] is not empty
                while (imax >= imin)
                {
                    // calculate the midpoint for roughly equal partition 
                    int imid = (imin + imax) / 2;

                    // determine which subarray to search
                    if (array[imid] < key) // change min index to search upper subarray
                    {
                        imin = imid + 1;
                    }
                    else if (array[imid] > key) // change max index to search lower subarray
                    {
                        imax = imid - 1;
                    }
                    else // key found at index imid
                    {
                        Console.WriteLine("The number {0} is on position {1}", key, imid);
                        found = true;
                        break;
                    }
                }

                // key not found
                if (found == false)
                {
                    Console.WriteLine("Number {0} is not found in the array!", key);
                }
            }
        }

        private static int[] ReadArray()
        {
            string arrayAsString = Console.ReadLine();
            string[] arrayOfStrings = arrayAsString.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] arrayOfIntegers = new int[arrayOfStrings.Length];

            for (int i = 0; i < arrayOfStrings.Length; i++)
            {
                try
                {
                    arrayOfIntegers[i] = int.Parse(arrayOfStrings[i]);
                }
                catch (FormatException)
                {
                    throw new FormatException("Input string was not in the correct format!");
                }
            }

            return arrayOfIntegers;
        }
    }
}
