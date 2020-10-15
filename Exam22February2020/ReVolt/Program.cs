using System;

namespace ReVolt
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int countCmds = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];
            var playersPosition = new int[2];
            for (int row = 0; row < n; row++)
            {
                var currRow = Console.ReadLine().ToCharArray();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = currRow[col];
                    if (matrix[row, col] == 'f')
                    {
                        playersPosition[0] = row;
                        playersPosition[1] = col;
                    }
                }
            }

            bool isWon = false;
          
            for (int i = 0; i < countCmds; i++)
            {
                var command = Console.ReadLine();
                var currRow = playersPosition[0];
                var currCol = playersPosition[1];
                matrix[playersPosition[0], playersPosition[1]] = '-';
                SwitchCommand(command, ref currRow, ref currCol);
                if (currRow >= 0 && currRow < n && currCol >= 0 && currCol < n)
                {
                    SetMatrixPosition(n, matrix, ref playersPosition, ref isWon, command, ref currRow, ref currCol);
                }
                else
                {
                    CheckTheIndexes(n, ref playersPosition, ref currRow, ref currCol);
                    SetMatrixPosition(n, matrix, ref playersPosition, ref isWon, command, ref currRow, ref currCol);
                    //playersPosition[0] = currRow;
                    //playersPosition[1] = currCol;
                    //matrix[playersPosition[0], playersPosition[1]] = 'f';
                }

                if (isWon)  break;
            }

            if (isWon) Console.WriteLine("Player won!");
            else Console.WriteLine("Player lost!");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
        }

        private static void SetMatrixPosition(int n, char[,] matrix, ref int[] playersPosition, ref bool isWon, string command, ref int currRow, ref int currCol)
        {
            switch (matrix[currRow, currCol])
            {
                case 'B':
                    SwitchCommand(command, ref currRow, ref currCol);
                    CheckTheIndexes(n, ref playersPosition, ref currRow, ref currCol);
                    SetMatrixPosition( n, matrix, ref  playersPosition, ref  isWon,  command, ref  currRow, ref  currCol);
                    playersPosition[0] = currRow;
                    playersPosition[1] = currCol;
                    matrix[playersPosition[0], playersPosition[1]] = 'f';
                    break;
                case 'T':
                    matrix[playersPosition[0], playersPosition[1]] = 'f';
                    matrix[currRow, currCol] = 'T';
                    break;
                case 'F':

                    isWon = true;
                    playersPosition[0] = currRow;
                    playersPosition[1] = currCol;
                    matrix[playersPosition[0], playersPosition[1]] = 'f';
                    break;
                case '-':
                    playersPosition[0] = currRow;
                    playersPosition[1] = currCol;
                    matrix[playersPosition[0], playersPosition[1]] = 'f';
                    break;
            }
        }

        private static void CheckTheIndexes(int n, ref int[] playersPosition, ref int currRow, ref int currCol)
        {
            if (currRow < 0) currRow = n - 1;
            if (currRow == n) currRow = 0;
            if (currCol < 0) currCol= n - 1;
            if (currCol == n) currCol = 0;
        }

        private static void SwitchCommand(string command, ref int currRow, ref int currCol)
        {
            switch (command)
            {
                case "up":
                    currRow--;
                    break;
                case "down":
                    currRow++;
                    break;
                case "left":
                    currCol--;
                    break;
                case "right":
                    currCol++;
                    break;
                default:
                    break;
            }
        }
    }
}
