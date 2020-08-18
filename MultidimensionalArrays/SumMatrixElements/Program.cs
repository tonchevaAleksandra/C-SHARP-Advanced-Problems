using System;
using System.Linq;

namespace SumMatrixElements
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] dimensions = Console.ReadLine()
                        .Split(", ",StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToArray();
            int rows = dimensions[0];
            int cols = dimensions[1];

            Console.WriteLine(rows);
            Console.WriteLine(cols);

            int[,] matrix= new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] currentRow = ParseArrayFromConsole();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = currentRow[col];
                }

            }
            long sum = 0;
            //foreach (var item in matrix)
            //{
            //    sum += item;
            //}

             sum = matrix.Cast<int>().Sum();
            Console.WriteLine(sum);
        }

        private static int[] ParseArrayFromConsole()
       =>  Console.ReadLine()
       .Split(", ", StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();
       
    }
}
