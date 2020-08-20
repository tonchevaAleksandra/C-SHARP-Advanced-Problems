using System;
using System.Linq;

namespace Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];

            ReadTheMatrix(n, matrix);


            string[] cooredinates = Console.ReadLine()
            .Split()
            .ToArray();



            for (int i = 0; i < cooredinates.Length; i++)
            {
                int[] currentCoordinates = cooredinates[i]
                    .Split(",", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                int row = currentCoordinates[0];
                int col = currentCoordinates[1];
                int bombValue = matrix[row, col];
                if (bombValue > 0)
                {
                    matrix = ExplodeBomb(row, col, matrix, bombValue);
                    matrix[row, col] = 0;
                }
            }

            int aliveCells = 0;
            int sum = 0;
            CountTheAliveCells(n, matrix, ref aliveCells, ref sum);
            PrintResult(n, matrix, aliveCells, sum);
        }

        private static void PrintResult(int n, int[,] matrix, int aliveCells, int sum)
        {
            Console.WriteLine($"Alive cells: { aliveCells}");
            Console.WriteLine($"Sum: {sum}");

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }

        private static void CountTheAliveCells(int n, int[,] matrix, ref int aliveCells, ref int sum)
        {
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (matrix[row, col] > 0)
                    {
                        sum += matrix[row, col];
                        aliveCells++;
                    }
                }
            }
        }

        static int[,] ExplodeBomb(int row, int col, int[,] matrix, int bombValue)
        {
            if (IsValidCell(matrix, row - 1, col - 1) && matrix[row - 1, col - 1] > 0)
            {
                matrix[row - 1, col - 1] -= bombValue;
            }
            if (IsValidCell(matrix, row - 1, col) && matrix[row - 1, col] > 0)
            {
                matrix[row - 1, col] -= bombValue;
            }
            if (IsValidCell(matrix, row - 1, col + 1) && matrix[row - 1, col + 1] > 0)
            {
                matrix[row - 1, col + 1] -= bombValue;
            }
            if (IsValidCell(matrix, row, col - 1) && matrix[row, col - 1] > 0)
            {
                matrix[row, col - 1] -= bombValue;
            }
            if (IsValidCell(matrix, row, col + 1) && matrix[row, col + 1] > 0)
            {
                matrix[row, col + 1] -= bombValue;
            }
            if (IsValidCell(matrix, row + 1, col - 1) && matrix[row + 1, col - 1] > 0)
            {
                matrix[row + 1, col - 1] -= bombValue;
            }
            if (IsValidCell(matrix, row + 1, col) && matrix[row + 1, col] > 0)
            {
                matrix[row + 1, col] -= bombValue;
            }
            if (IsValidCell(matrix, row + 1, col + 1) && matrix[row + 1, col + 1] > 0)
            {
                matrix[row + 1, col + 1] -= bombValue;
            }
            return matrix;
        }

        static bool IsValidCell(int[,] matrix, int row, int col)
        {
            if (row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1))
            {
                return true;
            }
            return false;
        }

        private static void ReadTheMatrix(int n, int[,] matrix)
        {
            for (int row = 0; row < n; row++)
            {
                int[] currentRow = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }
        }
    }
}
