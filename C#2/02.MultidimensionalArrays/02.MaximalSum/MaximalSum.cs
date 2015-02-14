/*
 Problem 2. Maximal sum

    Write a program that reads a rectangular matrix of size N x M 
    and finds in it the square 3 x 3 that has maximal sum of its elements.
 */
namespace _02.MaximalSum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MaximalSum
    {
        public static void Main()
        {
            int[,] matrix = {
                                {7, 1, 3, 3, 2, 1},
                                {10,10,10,0,0,950},
                                {10,10,10,0,0,0},
                                {10,10,10,0,50,1000},
                                {1, 3, 9, 8, 5, 6},
                                {4, 6, 7, 9, 1, 0} 
                            };
            
            // if you want to fill the matrix from the console input, uncomment the following row
            //matrix = ReadMatrix();

            int bestSum = int.MinValue;
            int bestSumRow = 0;
            int bestSumCol = 0;

            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2]
                            + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2]
                            + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                    if (sum > bestSum)
                    {
                        bestSum = sum;
                        bestSumRow = row;
                        bestSumCol = col;
                    }
                }
            }

            Console.WriteLine("The best sum is: " + bestSum);
            Console.WriteLine("{0,4} {1,4} {2,4}", matrix[bestSumRow, bestSumCol], matrix[bestSumRow, bestSumCol + 1], matrix[bestSumRow, bestSumCol + 2]);
            Console.WriteLine("{0,4} {1,4} {2,4}", matrix[bestSumRow + 1, bestSumCol], matrix[bestSumRow + 1, bestSumCol + 1], matrix[bestSumRow + 1, bestSumCol + 2]);
            Console.WriteLine("{0,4} {1,4} {2,4}", matrix[bestSumRow + 2, bestSumCol], matrix[bestSumRow + 2, bestSumCol + 1], matrix[bestSumRow + 2, bestSumCol + 2]);
        }

        private static int[,] ReadMatrix()
        {
            Console.WriteLine("Enter the size of the matrix(N, M), N and M should be integers bigger than two");

            int n = 0;
            while (n < 3)
            {
                Console.Write("N: ");
                n = int.Parse(Console.ReadLine());
            }

            int m = 0;
            while (m < 3)
            {
                Console.Write("M: ");
                m = int.Parse(Console.ReadLine());
            }

            int[,] matrix = new int[n, m];

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m; col++)
                {
                    Console.Write("Enter number at [{0}, {1}]: ", row, col);
                    matrix[row, col] = int.Parse(Console.ReadLine());
                }
            }

            return matrix;
        }
    }
}
