using System;
using System.Collections.Generic;
using System.Linq;

namespace Miner
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] field = new char[n, n];

            string[] commands = Console.ReadLine()
           .Split()
           .ToArray();

            int startRow = -1;
            int startCol = -1;
            int allCoal = 0;

            for (int row = 0; row < n; row++)
            {
                char[] currentRow = Console.ReadLine()
                    .Split()
                    .Select(char.Parse)
                    .ToArray();
                for (int col = 0; col < n; col++)
                {
                    field[row, col] = currentRow[col];
                    if (field[row, col] == 's')
                    {
                        startRow = row;
                        startCol = col;
                    }
                    if (field[row, col] == 'c')
                    {
                        allCoal++;
                    }
                }
            }
            Queue<string> queue = new Queue<string>(commands);
            int collectedCoal = 0;

            bool isGameOver = false;
            while (queue.Any())
            {
                string currentCommand = queue.Dequeue();

                SwitchCommand(field, ref startRow, ref startCol, allCoal, ref collectedCoal, currentCommand, ref isGameOver);
                if(isGameOver)
                {
                    return;
                }
            }

            Console.WriteLine($"{allCoal - collectedCoal} coals left. ({startRow}, {startCol})");
        }

       public static void SwitchCommand(char[,] field, ref int startRow, ref int startCol, int allCoal, ref int collectedCoal, string currentCommand, ref bool isGameOver)
        {
            int currentRow = -1;
            int currentCol = -1;
            if (currentCommand == "up")
            {
                currentRow = startRow - 1;
                currentCol = startCol;

            }
            else if (currentCommand == "down")
            {
                currentRow = startRow + 1;
                currentCol = startCol;

            }
            else if (currentCommand == "right")
            {
                currentRow = startRow;
                currentCol = startCol + 1;
            }
            else if (currentCommand == "left")
            {
                currentRow = startRow;
                currentCol = startCol - 1;
            }
            if (IsValidCell(field, currentRow, currentCol))
            {
                char currentChar = field[currentRow, currentCol];
                SwitchChar(field, ref startRow, ref startCol, allCoal, ref collectedCoal, currentRow, currentCol, currentChar, ref isGameOver);
            }
            

        }

       public static void SwitchChar(char[,] field, ref int startRow, ref int startCol, int allCoal, ref int collectedCoal, int currentRow, int currentCol, char currentChar, ref bool isGameOver)
        {

            if (currentChar == '*')
            {
                startRow = currentRow;
                startCol = currentCol;
            }
            else if (currentChar == 'e')
            {
                Console.WriteLine($"Game over! ({currentRow}, {currentCol})");
                isGameOver = true;
              
            }

            else if (currentChar == 'c')
            {
                collectedCoal++;
                field[currentRow, currentCol] = '*';
                startRow = currentRow;
                startCol = currentCol;
                if (collectedCoal == allCoal)
                {
                    Console.WriteLine($"You collected all coals! ({currentRow}, {currentCol})");
                    isGameOver = true;
                   
                }
            }
            else if (currentChar == 's')
            {
                startRow = currentRow;
                startCol = currentCol;

            }
        }
        public static bool IsValidCell(char[,] field, int row, int col)
        {
            if (row >= 0 && row < field.GetLength(0) && col >= 0 && col < field.GetLength(1))
            {
                return true;
            }
            return false;
        }
    }

   
}
