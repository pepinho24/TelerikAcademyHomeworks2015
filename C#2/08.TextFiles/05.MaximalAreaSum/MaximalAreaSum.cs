/*Problem 5. Maximal area sum

Write a program that reads a text file containing a square matrix of numbers.
Find an area of size 2 x 2 in the matrix, with a maximal sum of its elements.
The first line in the input file contains the size of matrix N.
Each of the next N lines contain N numbers separated by space.
The output should be a single number in a separate text file.
Example:

input	    output
4 
2 3 3 4     17
0 2 3 4 
3 7 1 2 
4 3 3 2	*/
namespace _05.MaximalAreaSum
{
    using System;
    using System.IO;

    class MaximalAreaSum
    {
        static int[,] ReadMatrix()
        {
            using (StreamReader input = new StreamReader("../../Input.txt"))
            {
                int n = int.Parse(input.ReadLine());
                int[,] matrix = new int[n, n];

                for (int row = 0; row < n; row++)
                {
                    string[] numbers = input.ReadLine().Split(' ');

                    for (int col = 0; col < n; col++)
                        matrix[row, col] = int.Parse(numbers[col]);
                }

                return matrix;
            }
        }

        static int GetMax(int[,] matrix)
        {
            int maxSum = int.MinValue;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    maxSum = Math.Max(maxSum, matrix[row, col] + matrix[row + 1, col] + matrix[row, col + 1] + matrix[row + 1, col + 1]);
                }
            }

            return maxSum;
        }

        static void WriteResult(int maxSum)
        {
            using (StreamWriter output = new StreamWriter("../../Output.txt"))
            {
                output.WriteLine(maxSum);
            }
        }

        static void Main()
        {
            WriteResult(GetMax(ReadMatrix()));
        }
    }
}
