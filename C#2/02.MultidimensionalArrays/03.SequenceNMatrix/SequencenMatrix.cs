/*
 Problem 3. Sequence n matrix

We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbour elements located on the same line, column or diagonal.
Write a program that finds the longest sequence of equal strings in the matrix.
Example:

matrix				        result
 
ha	fifi ho	hi
fo	ha	 hi	xx              ha, ha, ha	
xxx	ho	 ha	xx
 
matrix          result
 
s	qq	s
pp	pp	s       s, s, s
pp	qq	s
 */
namespace _03.SequenceNMatrix
{
    using System;

    public class SequenceNMatrix
    {
        private static string[,] ReadMatrix()
        {
            Console.WriteLine("Enter the size of the matrix(N, M)");

            int n = 0;
            while (n <1)
            {
                Console.Write("N: ");
                n = int.Parse(Console.ReadLine());
            }

            int m = 0;
            while (m <1)
            {
                Console.Write("M: ");
                m = int.Parse(Console.ReadLine());
            }

            string[,] matrix = new string[n, m];

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m; col++)
                {
                    Console.Write("Enter string at [{0}, {1}]: ", row, col);
                    matrix[row, col] = Console.ReadLine();
                }
            }

            return matrix;
        }

        public static void Main()
        {
            string[,] matrix = {   
                                {"fa",  "sad",  "g",        "df",   "wa",    "aw"},
                                {"fad", "fa",   "fa",       "fa",   "wa",   "aw"},
                                {"fad",   "fad",  "hfa",    "ad", "da",   "aw"},
                                {"sda", "sdge", "fad",      "xcv",  "wa", "aw"}
                                
                           };

            // if you want to fill the matrix from the console input, uncomment the following row
            // matrix = ReadMatrix();

            int rowLength = matrix.GetLength(0);
            int colLength = matrix.GetLength(1);
            int bestSequenceHorizontal = 1;
            int bestSequenceVertical = 1;
            int bestSequenceDiagonal = 1;
            int sequence = 1;

            string bestSequenceStringHorizontal = string.Empty;
            string bestSequenceStringVertical = string.Empty;
            string bestSequenceStringDiagonal = string.Empty;
            string sequenceString;

            /*horrizontal check*/
            for (int row = 0; row < rowLength; row++)
            {
                sequenceString = matrix[row, 0];
                for (int col = 1; col < colLength; col++)
                {
                    if (matrix[row, col - 1] == matrix[row, col])
                    {
                        sequenceString += ", " + matrix[row, col];
                        sequence++;
                    }
                    else
                    {

                        sequenceString = matrix[row, col];
                        sequence = 1;
                    }

                    if (bestSequenceHorizontal < sequence)
                    {
                        bestSequenceHorizontal = sequence;
                        bestSequenceStringHorizontal = sequenceString;
                    }
                }
            }

            Console.Write("Best horizontal sequence: ");
            Console.WriteLine(bestSequenceStringHorizontal);

            sequence = 1;

            /*vertical check*/
            for (int col = 0; col < colLength; col++)
            {
                sequenceString = matrix[0, col];

                for (int row = 1; row < rowLength; row++)
                {
                    if (matrix[row - 1, col] == matrix[row, col])
                    {
                        sequenceString += ", " + matrix[row, col];
                        sequence++;
                    }
                    else
                    {

                        sequenceString = matrix[row, col];
                        sequence = 1;
                    }

                    if (bestSequenceVertical < sequence)
                    {
                        bestSequenceVertical = sequence;
                        bestSequenceStringVertical = sequenceString;
                    }
                }
            }

            Console.Write("Best vertical sequence: ");
            Console.WriteLine(bestSequenceStringVertical);

            sequence = 1;
            //diagonal check

            for (int rows = 0; rows < rowLength - 1; rows++)
            {
                sequenceString = matrix[rows, 0];
                for (int row     = rows, col = 0; row < rowLength - 1; row++, col++)
                {
                    if (matrix[row, col] == matrix[row + 1, col + 1])
                    {
                        sequenceString += ", " + matrix[1 + row, 1 + col];
                        sequence++;
                    }
                    else
                    {
                        sequenceString = matrix[row, col];
                        sequence = 1;
                    }
                    if (bestSequenceDiagonal < sequence)
                    {
                        bestSequenceDiagonal = sequence;
                        bestSequenceStringDiagonal = sequenceString;
                    }
                }
            }

            Console.Write("Best diagonal sequence: ");
            Console.WriteLine(bestSequenceStringDiagonal);

            if (bestSequenceDiagonal > bestSequenceHorizontal && bestSequenceDiagonal > bestSequenceVertical)
            {
                Console.Write("The longest sequence of all is: ");
                Console.WriteLine(bestSequenceStringDiagonal);
            }
            else if (bestSequenceVertical > bestSequenceHorizontal && bestSequenceVertical > bestSequenceDiagonal)
            {
                Console.Write("The longest sequence of all is: ");
                Console.WriteLine(bestSequenceStringVertical);
            }
            else if (bestSequenceDiagonal <= bestSequenceHorizontal && bestSequenceHorizontal >= bestSequenceVertical)
            {
                Console.Write("The longest sequence of all is: ");
                Console.WriteLine(bestSequenceStringHorizontal);
            }
        }
    }
}
