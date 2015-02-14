/*
 Problem 1. Fill the matrix

Write a program that fills and prints a matrix of size (n, n) as shown below:
Example for n=4:

a)			
1	5	9	13
2	6	10	14
3	7	11	15
4	8	12	16
b)
1	8	9	16
2	7	10	15
3	6	11	14
4	5	12	13
c)
7	11	14	16
4	8	12	15
2	5	9	13
1	3	6	10
d)*
1	12	11	10
2	13	16	9
3	14	15	8
4	5	6	7
 */
namespace _01.FillMatrix
{
    using System;

    public class FillMatrix
    {
        public static void Main()
        {
            Console.Write("Choose the size of the (n, n) matrix: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("The matrix as A: ");
            PrintMatrix(FillMatrixAsA(n));

            Console.WriteLine("The matrix as B: ");
            PrintMatrix(FillMatrixAsB(n));

            Console.WriteLine("The matrix as C: ");
            PrintMatrix(FillMatrixAsC(n));

            Console.WriteLine("The matrix as D: ");
            PrintMatrix(FillMatrixAsD(n));
        }

        private static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("{0,4} ", matrix[row, col]);
                }

                Console.WriteLine();
            }
        }

        private static int[,] FillMatrixAsA(int n)
        {
            int[,] matrix = new int[n, n];

            for (int number = 1, col = 0; col < n; col++)
            {
                for (int row = 0; row < n; row++, number++)
                {
                    matrix[row, col] = number;
                }
            }

            return matrix;
        }

        private static int[,] FillMatrixAsB(int n)
        {
            int[,] matrix = new int[n, n];

            for (int number = 1, row = 0; row < n; row++)
            {
                if (row % 2 == 0)
                {
                    for (int col = 0; col < n; col++)
                    {
                        matrix[col, row] = number;
                        number++;
                    }
                }
                else if (row % 2 != 0)
                {
                    for (int col = n - 1; col >= 0; col--)
                    {
                        matrix[col, row] = number;
                        number++;
                    }
                }
            }

            return matrix;
        }

        private static int[,] FillMatrixAsC(int n)
        {
            int[,] matrix = new int[n, n];

            int rows = n;
            int cols = rows;

            int rowFinish = rows - 1;
            int rowStart = rowFinish;

            int colStart = 0;
            int colFinish = cols - 1;

            int number = 1;

            //read
            for (int i = 0; i < 2 * rows - 1; i++)
            {
                if (i < rows)
                {
                    for (int row = rowStart, col = colStart; row <= rowFinish; row++, col++)
                    {
                        matrix[row, col] = number;
                        number++;
                    }

                    rowStart--;
                    colStart = 0;
                }
                else
                {
                    rowStart = 0;

                    for (int row = rowStart, col = colStart + 1; col <= colFinish; row++, col++)
                    {
                        matrix[row, col] = number;
                        number++;
                    }

                    colStart++;
                }
            }

            return matrix;
        }

        private static int[,] FillMatrixAsD(int n)
        {
            int[,] matrix = new int[n, n];

            int row = 0;
            int col = 0;
            int k = 0;
            int number = 1;

            while (number <= n * n)
            {
                for (; row < n - k; row++)
                {
                    matrix[row, col] = number;

                    if (number == n * n)
                    {
                        return matrix;
                    }

                    number++;
                }

                number--;
                row--;

                for (; col < n - k; col++)
                {
                    matrix[row, col] = number;

                    if (number == n * n)
                    {
                        return matrix;
                    }

                    number++;
                }

                number--;
                col--;

                for (; row > k; row--)
                {
                    matrix[row, col] = number;

                    if (number == n * n)
                    {
                        return matrix;
                    }

                    number++;
                }

                k++;

                for (; col > k; col--)
                {
                    matrix[row, col] = number;

                    if (number == n * n)
                    {
                        return matrix;
                    }

                    number++;
                }
            }

            return matrix;
        }

        private static void Right()
        {
            throw new NotImplementedException();
        }

        private static void Left()
        {
            throw new NotImplementedException();
        }

        private static void Down()
        {
            throw new NotImplementedException();
        }

        private static void Up()
        {
            throw new NotImplementedException();
        }
    }
}
