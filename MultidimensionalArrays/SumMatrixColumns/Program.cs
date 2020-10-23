using System;
using System.Linq;

namespace SumMatrixColumns
{
    class Program
    {
        static void Main(string[] args)
        {
            //SomeMethor(1, 2, 3, 4);
            //SomeMethor();
            //SomeMethor(5, 6);
            int[] dimensions = ParseArrayFromConsole(',',' ');
            int rows = dimensions[0];
            int cols = dimensions[1];
            int[,] matrix = new int[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                int[] curr = ParseArrayFromConsole(' ');
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = curr[col];
                }
            }
            
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                int sumOfCurrCol = 0;
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    sumOfCurrCol += matrix[row, col];
                }
                Console.WriteLine(sumOfCurrCol);
            }
        }

      
        private static int[] ParseArrayFromConsole(params char[] splitSymbols)
      => Console.ReadLine()
      .Split(splitSymbols,StringSplitOptions.RemoveEmptyEntries)
       .Select(int.Parse)
       .ToArray();

    }
}
