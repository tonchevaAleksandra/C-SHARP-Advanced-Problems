using System;
using System.Linq;

namespace SquareWithMaximumSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var dimensions = ParseArrayFromConsole(',', ' ');
            int rows = dimensions[0];
            int cols = dimensions[1];
            int[,] matrix = new int[rows, cols];

            FullfillTheMatrix(rows, cols, matrix);
            int maxSquareSum = int.MinValue;
            int maxRow = 0;
            int maxCol = 0;
            var square = new int[2, 2];
            FindTheMaxSquareSum(matrix, ref maxSquareSum, ref maxRow, ref maxCol);
            Console.WriteLine($"{matrix[maxRow, maxCol]} {matrix[maxRow, maxCol + 1]}");
            Console.WriteLine($"{matrix[maxRow + 1, maxCol]} {matrix[maxRow + 1, maxCol + 1]}");
            Console.WriteLine(maxSquareSum);

        }

        private static void FullfillTheMatrix(int rows, int cols, int[,] matrix)
        {
            for (int row = 0; row < rows; row++)
            {
                var curr = ParseArrayFromConsole(',', ' ');
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = curr[col];
                }
            }
        }

        private static void FindTheMaxSquareSum(int[,] matrix, ref int maxSquareSum, ref int maxRow, ref int maxCol)
        {
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    var newSquareSum = matrix[row, col] +
                                       matrix[row + 1, col] +
                                       matrix[row, col + 1] +
                                       matrix[row + 1, col + 1];

                    if (newSquareSum > maxSquareSum)
                    {
                        maxSquareSum = newSquareSum;
                        maxRow = row;
                        maxCol = col;
                    }
                }


            }
        }

        private static int[] ParseArrayFromConsole(params char[] splitSymbols)
  => Console.ReadLine()
  .Split(splitSymbols, StringSplitOptions.RemoveEmptyEntries)
   .Select(int.Parse)
   .ToArray();
    }
}
