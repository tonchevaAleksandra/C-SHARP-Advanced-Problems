using System;
using System.Collections.Generic;
using System.Linq;

namespace RadioactiveMutantVampireBunnies
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
            int startRow = -1;
            int startCol = -1;

            ReadInput(rows, cols, matrix, ref startRow, ref startCol);

            string commands = Console.ReadLine();
            char[] cmdArgs = commands.ToCharArray();
            Queue<char> queueCmd = new Queue<char>(cmdArgs);
            bool isAlive = true;
            bool isWon = false;
            while (queueCmd.Any() && isAlive && !isWon)
            {
                int currentRow = -1;
                int currentCol = -1;
                char currentCommand = queueCmd.Dequeue();
                switch (currentCommand)
                {
                    case 'L':
                        currentRow = startRow;
                        currentCol = startCol - 1;
                        break;
                    case 'R':
                        currentRow = startRow;
                        currentCol = startCol + 1;
                        break;
                    case 'U':
                        currentRow = startRow - 1;
                        currentCol = startCol;
                        break;
                    case 'D':
                        currentRow = startRow + 1;
                        currentCol = startCol;
                        break;

                }
                if (IsValidCell(matrix, currentRow, currentCol))
                {
                    char currentChar = matrix[currentRow, currentCol];
                    SwitchChar(matrix, ref startRow, ref startCol, currentRow, currentCol, currentChar, ref isAlive, ref isWon);
                    if(isAlive)
                    {
                        SpreadTheBunnies(matrix,ref isAlive, ref isWon);
                    }
                  
                }
                else if(!IsValidCell(matrix,currentRow,currentCol))
                {
                    isWon = true;
                    matrix[startRow, startCol] = '.';
                    SpreadTheBunnies(matrix, ref isAlive,ref isWon);
                    PrintMatrix(matrix);
                    Console.WriteLine($"won: {startRow} {startCol}");
                    break;  
                }
                        
            }         
        }
        static void PrintMatrix(char[,]matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row,col]);
                }
                Console.WriteLine();
            }
        }
        private static void SpreadTheBunnies(char[,] matrix, ref bool isAlive,ref bool isWon)
        {
            List<string> spreadedBunnies = new List<string>();
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    char currentCh = matrix[row, col];

                    if (currentCh == 'B' && !spreadedBunnies.Contains($"{row}, {col}"))
                    {
                        char nextCell;
                        int currRow = -1;
                        int currCol = -1;

                        if (IsValidCell(matrix, row - 1, col))
                        {
                            nextCell = matrix[row - 1, col];
                            currRow = row - 1;
                            currCol = col;
                            CheckTheSpreadCells(ref isAlive, nextCell, currRow, currCol, matrix, spreadedBunnies,ref isWon);
                        }

                        if (IsValidCell(matrix, row, col - 1))
                        {
                            nextCell = matrix[row, col - 1];
                            currRow = row;
                            currCol = col - 1;
                            CheckTheSpreadCells(ref isAlive, nextCell, currRow, currCol, matrix, spreadedBunnies, ref isWon);

                        }

                        if (IsValidCell(matrix, row, col + 1))
                        {
                            currRow = row;
                            currCol = col + 1;
                            nextCell = matrix[row, col + 1];
                            CheckTheSpreadCells(ref isAlive, nextCell, currRow, currCol, matrix, spreadedBunnies, ref isWon);

                        }

                        if (IsValidCell(matrix, row + 1, col))
                        {
                            nextCell = matrix[row + 1, col];
                            currRow = row + 1;
                            currCol = col;
                            CheckTheSpreadCells(ref isAlive, nextCell, currRow, currCol, matrix, spreadedBunnies, ref isWon);
                        }
                    }
                }
            }    
        }

        public static void SwitchChar(char[,] matrix, ref int startRow, ref int startCol, int currentRow, int currentCol, char currentChar, ref bool isAlive, ref bool isWon)
        {

          if(currentChar=='.')
            {
                matrix[startRow, startCol] = '.';
                matrix[currentRow, currentCol] = 'P';
                startRow = currentRow;
                startCol = currentCol;
            }
          else if(currentChar=='B')
            {
                matrix[startRow, startCol] = '.';
                SpreadTheBunnies(matrix, ref isAlive, ref isWon);
                PrintMatrix(matrix);
                Console.WriteLine($"dead: { currentRow} {currentCol}" );
                isAlive = false;
            }      
        }

        private static void CheckTheSpreadCells(ref bool isAlive, char nextCell, int currRow, int currCol, char[,] matrix, List<string> spreadedBunnies,ref bool isWon)
        {
            if (nextCell == 'P' && isAlive)
            {
                isAlive = false;
                SpreadTheBunnies(matrix, ref isAlive, ref isWon);
                PrintMatrix(matrix);
                Console.WriteLine($"dead: {currRow} {currCol}");              
            }
            if(nextCell=='P' && !isAlive)
            {
                matrix[currRow, currCol] = 'B';
                spreadedBunnies.Add($"{currRow}, {currCol}");
            }
            else if(nextCell=='.')
            {
                matrix[currRow, currCol] = 'B';
                spreadedBunnies.Add($"{currRow}, {currCol}");
            }      
        }


        private static void ReadInput(int rows, int cols, char[,] matrix, ref int startRow, ref int startCol)
        {
            for (int row = 0; row < rows; row++)
            {
                string input = Console.ReadLine();
                char[] currentRow = input.ToCharArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = currentRow[col];
                    if (matrix[row, col] == 'P')
                    {
                        startRow = row;
                        startCol = col;
                    }
                }
            }
        }

        public static bool IsValidCell(char[,] matrix, int row, int col)
        {
            if (row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1))
            {
                return true;
            }
            return false;
        }
    }
}
