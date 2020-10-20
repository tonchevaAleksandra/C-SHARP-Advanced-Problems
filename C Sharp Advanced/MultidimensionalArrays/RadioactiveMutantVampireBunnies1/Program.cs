using System;
using System.Collections.Generic;
using System.Linq;

namespace RadioactiveMutantVampireBunnies1
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

            char[,] matrix = new char[rows, cols];

            int playerRow = -1;
            int playerCol = -1;
            for (int row = 0; row < rows; row++)
            {
                char[] currentRow = Console.ReadLine().ToCharArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = currentRow[col];
                    if (matrix[row, col] == 'P')
                    {
                        playerRow = row;
                        playerCol = col;
                    }
                }
            }


            char[] directions = Console.ReadLine().ToCharArray();

            bool isWon = false;
            foreach (char direction in directions)
            {
                int currentPlayerRow = playerRow;
                int currentPlayerCol = playerCol;
                switch (direction)
                {
                    case 'U':
                        currentPlayerRow--;
                        break;
                    case 'D':
                        currentPlayerRow++;
                        break;
                    case 'L':
                        currentPlayerCol--;
                        break;
                    case 'R':
                        currentPlayerCol++;
                        break;

                }

                isWon = Iswon(matrix, currentPlayerRow, currentPlayerCol);
                if (isWon)
                {
                    matrix[playerRow, playerCol] = '.';
                }
                else
                {
                    if (matrix[currentPlayerRow, currentPlayerCol] == 'B')
                    {
                        matrix[playerRow, playerCol] = '.';
                        playerRow = currentPlayerRow;
                        playerCol = currentPlayerCol;
                    }
                    else
                    {
                        matrix[playerRow, playerCol] = '.';
                        matrix[currentPlayerRow, currentPlayerCol] = 'P';
                        playerRow = currentPlayerRow;
                        playerCol = currentPlayerCol;
                    }


                }

                List<int> bunnies = new List<int>();
                AddTheExistingBunnies(rows, cols, matrix, bunnies);

                for (int i = 0; i < bunnies.Count; i += 2)
                {
                    int bunnyRow = bunnies[i];
                    int bunnyCol = bunnies[i + 1];
                    SpreadBunnies(matrix, bunnyRow, bunnyCol);
                }

                //won or die
                if (isWon || matrix[playerRow, playerCol] == 'B')
                {
                    break;
                }

            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(matrix[row,col]);
                }
                Console.WriteLine();
            }

            if(isWon)
            {
                Console.WriteLine($"won: {playerRow} {playerCol}");
            }
            else
            {
                Console.WriteLine($"dead: {playerRow} {playerCol}");
            }

        }

        private static void AddTheExistingBunnies(int rows, int cols, char[,] matrix, List<int> bunnies)
        {
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (matrix[row, col] == 'B')
                    {
                        bunnies.Add(row);
                        bunnies.Add(col);
                    }
                }
            }
        }

        private static void SpreadBunnies(char[,] matrix, int bunnyRow, int bunnyCol)
        {
            if (bunnyRow - 1 >= 0)
            {
                matrix[bunnyRow - 1, bunnyCol] = 'B';
            }
            if (bunnyRow + 1 < matrix.GetLength(0))
            {
                matrix[bunnyRow + 1, bunnyCol] = 'B';
            }
            if (bunnyCol - 1 >= 0)
            {
                matrix[bunnyRow, bunnyCol - 1] = 'B';
            }
            if (bunnyCol + 1 < matrix.GetLength(1))
            {
                matrix[bunnyRow, bunnyCol + 1] = 'B';
            }
        }

        private static bool Iswon(char[,] matrix, int currentPlayerRow, int currentPlayerCol)
        {
            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);
            return currentPlayerRow < 0 || currentPlayerRow >= n || currentPlayerCol < 0 || currentPlayerCol >= m;
        }
    }
}
