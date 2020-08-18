using System;
using System.Linq;

namespace PrimaryDiagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            for (int row = 0; row < n; row++)
            {
                int[] currentRow = ParseArrayFromConsole(' ');
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }

            int sum = 0;
            for (int row = 0; row < n; row++)
            {
                int col = row;
                sum += matrix[row, col];
            }
            Console.WriteLine(sum);
        }

        private static int[] ParseArrayFromConsole(params char[] splitSymbols)
    => Console.ReadLine()
    .Split(splitSymbols, StringSplitOptions.RemoveEmptyEntries)
     .Select(int.Parse)
     .ToArray();
    }
}
