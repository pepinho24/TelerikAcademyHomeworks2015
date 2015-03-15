/*
 Problem 8. Matrix

        Define a class Matrix<T> to hold a matrix of numbers (e.g. integers, floats, decimals).

 * Problem 9. Matrix indexer

        Implement an indexer this[row, col] to access the inner matrix cells.

 * Problem 10. Matrix operations

        Implement the operators + and - (addition and subtraction of matrices of the same size) and * for matrix multiplication.
        Throw an exception when the operation cannot be performed.
        Implement the true operator (check for non-zero elements). * I assume that if the matrix contains only zeros it should be true*
 */
namespace _08_10.Matrix
{
    using System;

    public class StartingPointMatrix
    {
        public static void Main()
        {
            Matrix<int> firstMatrix = new Matrix<int>(3, 3);
            Matrix<int> secondMatrix = new Matrix<int>(3, 2);
            
            // the matrices are filled with the values from the last problem (Practice 2) from whe link below where you can check the result
            // http://www.mathwarehouse.com/algebra/matrix/multiply-matrix.php
            FillFirstMatrixForMultiplication(firstMatrix);
            FillSecondMatrixForMultiplication(secondMatrix);

            Console.WriteLine("Matrix A: ");
            Console.WriteLine(firstMatrix);

            Console.WriteLine("Matrix B: ");
            Console.WriteLine(secondMatrix);

            Matrix<int> multiplication = firstMatrix * secondMatrix;

            Console.WriteLine("Matrix AxB: ");
            Console.WriteLine(multiplication);

            PrintSeparatorLine();

            firstMatrix = new Matrix<int>(2, 2);
            secondMatrix = new Matrix<int>(2, 2);

            FillMatrixForAdditionAndSubstraction(firstMatrix);
            FillMatrixForAdditionAndSubstraction(secondMatrix);

            Console.WriteLine("Matrix A: ");
            Console.WriteLine(firstMatrix);

            Console.WriteLine("Matrix B: ");
            Console.WriteLine(secondMatrix);
            
            Matrix<int> addition = firstMatrix + secondMatrix;
            Console.WriteLine("Matrix A+B: ");
            Console.WriteLine(addition);
            
            Matrix<int> substraction = firstMatrix - secondMatrix;
            Console.WriteLine("Matrix A-B: ");
            Console.WriteLine(substraction);

            PrintSeparatorLine();

            Console.WriteLine("Is the addition result only zeros? {0}", addition? "yes": "no");
            Console.WriteLine("Is the substraction result only zeros? {0}", substraction ? "yes" : "no");
        }

        private static void PrintSeparatorLine()
        {
            Console.WriteLine(new string('=', Console.BufferWidth));
        }

        private static void FillMatrixForAdditionAndSubstraction(Matrix<int> matrix)
        {
            int[,] fMatrix = new int[,] { { 1, 2 }, { 3, 4 } };
            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    matrix[row, col] = fMatrix[row, col];
                }
            }
        }

        private static void FillFirstMatrixForMultiplication(Matrix<int> firstMatrix)
        {
            int[,] fMatrix = new int[,] { { 6, 3, 0 }, { 2, 5, 1 }, { 9, 8, 6 } };

            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    firstMatrix[row, col] = fMatrix[row, col];
                }
            }
        }

        private static void FillSecondMatrixForMultiplication(Matrix<int> secondMatrix)
        {
            int[,] sMatrix = new int[,] { { 7, 4 }, { 6, 7 }, { 5, 0 } };

            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    secondMatrix[row, col] = sMatrix[row, col];
                }
            }
        }
    }
}
