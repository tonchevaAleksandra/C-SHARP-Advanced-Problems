using System;
using System.Linq;

namespace MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] dimensions = Console.ReadLine()
             .Split(" ", StringSplitOptions.RemoveEmptyEntries)
             .Select(int.Parse)
             .ToArray();

            int rows = dimensions[0];
            int cols = dimensions[1];

            int[,] matrix = new int[rows, cols];

            ReadTheMatrix(rows, cols, matrix);

            if (rows < 3 || cols < 3)
            {
                Console.WriteLine($"Sum = {0}");
                return;
            }

            int maxSumMatrix = 0;
            int firstMaxRow = 0;
            int firsrMaxCol = 0;
            CheckForTheMaxSumSquare3x3(rows, cols, matrix, ref maxSumMatrix, ref firstMaxRow, ref firsrMaxCol);
            PrintResult(matrix, maxSumMatrix, firstMaxRow, firsrMaxCol);

        }

        private static void ReadTheMatrix(int rows, int cols, int[,] matrix)
        {
            for (int row = 0; row < rows; row++)
            {
                int[] currentRow = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = currentRow[col];
                }

            }
        }

        private static void CheckForTheMaxSumSquare3x3(int rows, int cols, int[,] matrix, ref int maxSumMatrix, ref int firstMaxRow, ref int firsrMaxCol)
        {
            for (int row = 0; row < rows - 2; row++)
            {
                int currentSum = 0;
                for (int col = 0; col < cols - 2; col++)
                {
                    currentSum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                    if (currentSum > maxSumMatrix)
                    {
                        maxSumMatrix = currentSum;
                        firsrMaxCol = col;
                        firstMaxRow = row;
                    }

                }
            }
        }

        private static void PrintResult(int[,] matrix, int maxSumMatrix, int firstMaxRow, int firsrMaxCol)
        {
            Console.WriteLine($"Sum = {maxSumMatrix}");
            for (int row = firstMaxRow; row < firstMaxRow + 3; row++)
            {
                for (int col = firsrMaxCol; col < firsrMaxCol + 3; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
