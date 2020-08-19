using System;
using System.Linq;

namespace DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[,] matrix = new int[rows,rows];

            for (int row = 0; row < rows; row++)
            {
                int[] currentRow = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < rows; col++)
                {
                    matrix[row,col] = currentRow[col];
                }
            }

            int sum1 = 0;
            for (int row = 0; row < rows; row++)
            {
                int currCol = row;
                sum1 += matrix[row, currCol];
            }
            int sum2 = 0;
            int col2 = rows-1;
            for (int row = 0; row < rows; row++)
            {
                sum2 += matrix[row, col2];
                col2--;
            }
            int diff = Math.Abs(sum1 - sum2);
            Console.WriteLine(diff);
        }
    }
}
