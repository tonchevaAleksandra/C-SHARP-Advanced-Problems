using System;
using System.Collections.Generic;
using System.Linq;

namespace KnightGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];

            ReadTheMatrix(n, matrix);

            int counter = 0;

            while (true)
            {
                int maxAtackedKnights = 0;
                int maxRow = -1;
                int maxCol = -1;

                for (int row = 0; row < n; row++)
                {
                    for (int col = 0; col < n; col++)
                    {
                        if (matrix[row, col] == 'K')
                        {
                            int currentAttackedKnights = GetCountAttackedKnight(matrix, row, col);
                            if (currentAttackedKnights > maxAtackedKnights)
                            {
                                maxAtackedKnights = currentAttackedKnights;
                                maxRow = row;
                                maxCol = col;
                            }
                        }
                    }
                }
                if (maxAtackedKnights == 0)
                {
                    break;

                }
                matrix[maxRow, maxCol] = '0';
                counter++;

            }

            Console.WriteLine(counter);

        }

        private static void ReadTheMatrix(int n, char[,] matrix)
        {
            for (int row = 0; row < n; row++)
            {
                string curr = Console.ReadLine();
                char[] currentRow = curr
                    .ToCharArray();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }
        }

        static bool IsValidCell(int currRow, int currCol, char[,] matrix)
        {
            if (currRow >= 0 && currRow < matrix.GetLength(0) && currCol >= 0 && currCol < matrix.GetLength(1))
            {
                return true;
            }
            return false;
        }

        static int GetCountAttackedKnight(char[,] matrix, int row, int col)
        {
            int counter = 0;

            if (IsValidCell(row - 2, col - 1, matrix) && matrix[row - 2, col - 1] == 'K')
            {
                counter++;
            }
            if (IsValidCell(row - 2, col + 1, matrix) && matrix[row - 2, col + 1] == 'K')
            {
                counter++;
            }
            if (IsValidCell(row - 1, col - 2, matrix) && matrix[row - 1, col - 2] == 'K')
            {
                counter++;
            }
            if (IsValidCell(row - 1, col + 2, matrix) && matrix[row - 1, col + 2] == 'K')
            {
                counter++;
            }
            if (IsValidCell(row + 1, col + 2, matrix) && matrix[row + 1, col + 2] == 'K')
            {
                counter++;
            }
            if (IsValidCell(row + 1, col - 2, matrix) && matrix[row + 1, col - 2] == 'K')
            {
                counter++;
            }
            if (IsValidCell(row + 2, col + 1, matrix) && matrix[row + 2, col + 1] == 'K')
            {
                counter++;
            }
            if (IsValidCell(row + 2, col - 1, matrix) && matrix[row + 2, col - 1] == 'K')
            {
                counter++;
            }
            return counter;
        }
    }
}
