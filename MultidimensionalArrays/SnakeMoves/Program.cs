using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SnakeMoves
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] dimensions = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

            int rows = dimensions[0];
            int cols = dimensions[1];

            string input = Console.ReadLine();
          
            char[,] matrix = new char[rows, cols];
            var queue = new Queue<char>(input);

            for (int row = 0; row < rows; row++)
            {
                if (row % 2 == 0 )
                {
                    PrintTheOddRows(cols, matrix, queue, row);
                }
                else
                {
                    PrintTheEvenRows(cols, matrix, queue, row);
                }
            }
        }

        private static void PrintTheEvenRows(int cols, char[,] matrix, Queue<char> queue, int row)
        {
            char[] currentRow = new char[cols];
            for (int col = cols - 1; col >= 0; col--)
            {
                matrix[row, col] = queue.Dequeue();
                queue.Enqueue(matrix[row, col]);
                currentRow[col] = matrix[row, col];
            }

            string result = new string(currentRow);
            Console.WriteLine(result);
        }

        private static void PrintTheOddRows(int cols, char[,] matrix, Queue<char> queue, int row)
        {
            for (int col = 0; col < cols; col++)
            {
                matrix[row, col] = queue.Dequeue();
                queue.Enqueue(matrix[row, col]);
                Console.Write(matrix[row, col]);
            }
            Console.WriteLine();
        }
    }
}
