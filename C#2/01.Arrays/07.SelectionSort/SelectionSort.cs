//Problem 7. Selection sort

//Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
//Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.

//Selection sort animation. Red is current min. Yellow is sorted list. Blue is current item.
//http://upload.wikimedia.org/wikipedia/commons/9/94/Selection-Sort-Animation.gif
namespace _07.SelectionSort
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SelectionSort
    {
        public static void Main()
        {
            Console.Write("Please enter an array of integers separated by space: ");
            int[] array = ReadArray();
            SortWithSelectionSort(array);

            PrintArray(array);
        }

        private static void PrintArray(int[] array)
        {
            Console.WriteLine(string.Join(", ", array));
        }

        private static void SortWithSelectionSort(int[] array)
        { 
            int i, j;
            int temp;
            int iMin;

            //advance the position through the entire array 
            //   (could do j < n-1 because single element is also min element) 
            for (j = 0; j < array.Length - 1; j++)
            {
                // find the min element in the unsorted a[j .. n-1] 

                // assume the min is the first element 
                iMin = j;
                // test against elements after j to find the smallest 
                for (i = j + 1; i < array.Length; i++)
                {
                    // if this element is less, then it is the new minimum 
                    if (array[i] <array[iMin])
                    {
                        // found new minimum; remember its index 
                        iMin = i;
                    }
                }

                // iMin is the index of the minimum element. Swap it with the current position 
                if (iMin != j)
                {
                    // swap a[j] and a[iMin];
                    temp = array[j];
                    array[j] = array[iMin];
                    array[iMin] = temp;
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
