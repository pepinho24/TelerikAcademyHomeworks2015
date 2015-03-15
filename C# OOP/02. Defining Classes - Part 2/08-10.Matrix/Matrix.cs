/*
 Problem 8. Matrix

        Define a class Matrix<T> to hold a matrix of numbers (e.g. integers, floats, decimals).

 * Problem 9. Matrix indexer

        Implement an indexer this[row, col] to access the inner matrix cells.

 * Problem 10. Matrix operations

        Implement the operators + and - (addition and subtraction of matrices of the same size) and * for matrix multiplication.
        Throw an exception when the operation cannot be performed.
        Implement the true operator (check for non-zero elements).
 */
namespace _08_10.Matrix
{
    using System;
    using System.Text;
    using System.Linq;

    public class Matrix<T>
        where T : IComparable
    {
        private int rows;
        private int cols;
        private T[,] matrix;

        public Matrix(int rowsCount, int colsCount)
        {
            this.Rows = rowsCount;
            this.Cols = colsCount;
            this.matrix = new T[rowsCount, colsCount];
        }

        public T this[int row, int col]
        {
            get
            {
                CheckIndexes(row, col);
                return this.matrix[row, col];
            }
            set
            {
                CheckIndexes(row, col);
                this.matrix[row, col] = value;
            }
        }

        private void CheckIndexes(int row, int col)
        {
            if ((row < 0 || row >= this.Rows) ||
                (col < 0 || col >= this.Cols))
            {
                throw new IndexOutOfRangeException();
            }
        }

        public int Rows
        {
            get { return this.rows; }
            private set
            {
                if (value < 1) { throw new ArgumentOutOfRangeException("Rows Count", "The matrix must have at least one row!"); }

                this.rows = value;
            }
        }

        public int Cols
        {
            get { return this.cols; }
            private set
            {
                if (value < 1) { throw new ArgumentOutOfRangeException("Columns Count", "The matrix must have at least one column!"); }

                this.cols = value;
            }
        }

        public static Matrix<T> operator +(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix.Rows != secondMatrix.Rows|| firstMatrix.Cols != secondMatrix.Cols )
            {
                throw new Exception("Addition cannot be applied to matrices with different dimensions!");
            }

            Matrix<T> resultMatrix = new Matrix<T>(firstMatrix.Rows, firstMatrix.Cols);

            for (int row = 0; row < resultMatrix.Rows; row++)
            {
                for (int col = 0; col < resultMatrix.Cols; col++)
                {
                    // http://stackoverflow.com/questions/8122611/c-sharp-adding-two-generic-values
                    resultMatrix[row, col] = (dynamic)firstMatrix[row, col] + secondMatrix[row, col];
                }
            }

            return resultMatrix;
        }

        public static Matrix<T> operator -(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix.Rows != secondMatrix.Rows || firstMatrix.Cols != secondMatrix.Cols)
            {
                throw new Exception("Substraction cannot be applied to matrices with different dimensions!");
            }

            Matrix<T> resultMatrix = new Matrix<T>(firstMatrix.Rows, firstMatrix.Cols);

            for (int row = 0; row < resultMatrix.Rows; row++)
            {
                for (int col = 0; col < resultMatrix.Cols; col++)
                {
                    // http://stackoverflow.com/questions/8122611/c-sharp-adding-two-generic-values
                    resultMatrix[row, col] = (dynamic)firstMatrix[row, col] - secondMatrix[row, col];
                }
            }

            return resultMatrix;
        }

        public static Matrix<T> operator *(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            // http://www.mathwarehouse.com/algebra/matrix/multiply-matrix.php
            if (firstMatrix.Cols != secondMatrix.Rows)
            {
                throw new Exception("The matrices cannot be multiplied!");
            }

            Matrix<T> resultMatrix = new Matrix<T>(firstMatrix.Rows, secondMatrix.Cols);
            dynamic temp;

            for (int matrixRow = 0; matrixRow < resultMatrix.Rows; matrixRow++)
            {
                for (int matrixCol = 0; matrixCol < resultMatrix.Cols; matrixCol++)
                {
                    temp = 0;
                    for (int index = 0; index < secondMatrix.Rows; index++)
                    {
                        temp += (dynamic)firstMatrix[matrixRow, index] * secondMatrix[index, matrixCol];
                    }

                    resultMatrix[matrixRow, matrixCol] = temp;
                }
            }

            return resultMatrix;
        }

        private static bool OverrideBool(Matrix<T> matrix)
        {
            for (int row = 0; row < matrix.Rows; row++)
            {
                for (int col = 0; col < matrix.Cols; col++)
                {
                    if (matrix[row, col] != (dynamic)0)
                        return false;
                }
            }

            return true;
        }

        public static bool operator true(Matrix<T> matrix)
        {
            return OverrideBool(matrix);
        }

        public static bool operator false(Matrix<T> matrix)
        {
            return OverrideBool(matrix);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            for (int row = 0; row < this.Rows; row++)
            {
                for (int col = 0; col < this.Cols; col++)
                {
                    result.Append(this.matrix[row, col] + "\t");
                }

                result.AppendLine();
            }

            return result.ToString();
        }
    }
}
