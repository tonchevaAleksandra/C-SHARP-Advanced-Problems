using System;
using System.Linq;

namespace Crossfire
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] targets = Console.ReadLine()
             .Split()
             .Select(int.Parse)
             .ToArray();
            int rows = targets[0];
            int cols = targets[1];
            int[,] matrix = new int[rows, cols];
            FillTheMatrix(rows, cols, matrix);

        }

        private static void FillTheMatrix(int rows, int cols, int[,] matrix)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (i == 0)
                    {
                        matrix[i, j] = j + 1;
                    }
                    else
                    {
                        matrix[i, j] = cols * i + j + 1;
                    }

                }
            }
        }
    }
}
