using System;

namespace MentorMateSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solution to MentorMate Logo by Kiril Simeonov
            // Solved using a two dimensional char array (char matrix)

            int n = int.Parse(Console.ReadLine());

            while (n < 3 || n > 9999 || n % 2 == 0)
            {
                Console.WriteLine("Please, type an odd number between 2 and 10,000");
                n = int.Parse(Console.ReadLine());
            }

            char[,] matrix = CreateMatrix(n);

            PrintMatrix(matrix);

        }

        private static void PrintMatrix(char[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();

            }
        }

        private static char[,] CreateMatrix(int n)
        {
            int rowsNumber = n + 1;
            int colsNumber = n * 10;
            int singleLetterCols = n * 5;

            char[,] matrix = new char[rowsNumber, colsNumber];
            for (int rows = 0; rows < rowsNumber; rows++)
            {

                for (int cols = 0; cols < colsNumber; cols++)
                {

                    if ((cols > n - 1 - rows && cols <= n - 1 - rows + n) //for first M
                        || (cols > n - 1 - rows + singleLetterCols && cols <= n - 1 - rows + n + singleLetterCols)) //for second M
                    {
                        matrix[rows, cols] = '*';
                    }
                    else if (((cols > n - 1 + rows && cols <= n - 1 + rows + n)) //for first M
                        || ((cols > n - 1 + rows + singleLetterCols && cols <= n - 1 + rows + n + singleLetterCols))) //for second M
                    {

                        matrix[rows, cols] = '*';
                    }
                    else if (((cols > 3 * n - 1 - rows && cols <= 3 * n - 1 - rows + n)) //for first M
                        || ((cols > 3 * n - 1 - rows + singleLetterCols && cols <= 3 * n - 1 - rows + n + singleLetterCols))) //for second M
                    {

                        matrix[rows, cols] = '*';
                    }
                    else if (((cols > 3 * n - 1 + rows && cols <= 3 * n - 1 + rows + n)) //for first M
                        || ((cols > 3 * n - 1 + rows + singleLetterCols && cols <= 3 * n - 1 + rows + n + singleLetterCols))) //for second M
                    {

                        matrix[rows, cols] = '*';
                    }

                    else
                    {
                        matrix[rows, cols] = '-';
                    }
                }

            }
            return matrix;
        }
    }
}
