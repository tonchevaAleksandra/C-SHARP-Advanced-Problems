using System;
using System.Collections.Generic;
using System.Linq;

namespace TronRacers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];
            var firstP = new Player(0, 0, 'f');
            var secondP = new Player(0, 0,'s');
            List<Player> players = new List<Player>();
            players.Add(firstP);
            players.Add(secondP);
            for (int i = 0; i < n; i++)
            {
                var currRow = Console.ReadLine().ToCharArray();
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = currRow[j];
                    if(currRow[j]=='f')
                    {
                        firstP.Row = i;
                        firstP.Col = j;
                    }
                    if(currRow[j]=='s')
                    {
                        secondP.Row = i;
                        secondP.Col = j;
                    }
                }
            }

            while (firstP.IsAlive && secondP.IsAlive)
            {
                var input = Console.ReadLine().Split().ToArray();
                var command1 = input[0];
                var command2 = input[1];
                var firstRow = firstP.Row;
                var firstCol = firstP.Col;
                var secondRow = secondP.Row;
                var secondCol = secondP.Col;

                SwitchCommand(command1, ref firstRow, ref firstCol, matrix);
                CheckValidityOfIndexes( ref firstRow,  ref firstCol,  matrix);
                CheckCurrentCell( firstRow, firstCol, ref matrix, firstP.Char, ref players);
                if (!firstP.IsAlive) break;

                SwitchCommand(command2, ref secondRow, ref secondCol, matrix);
                CheckValidityOfIndexes(ref secondRow, ref secondCol,  matrix);
                CheckCurrentCell( secondRow, secondCol, ref matrix, secondP.Char, ref  players);
               
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i,j]);
                }
                Console.WriteLine();
            }

        }

        private static void CheckCurrentCell( int row, int col, ref char[,] matrix, char playersChar,ref List<Player> players)
        {
            var player = players.FirstOrDefault(p => p.Char == playersChar);
            if(matrix[row, col]=='*')
            {
                matrix[row, col] = player.Char;
                players.FirstOrDefault(p => p.Char == player.Char).Row = row;
                players.FirstOrDefault(p => p.Char == player.Char).Col = col;
            }
            else if(matrix[row, col]!=player.Char)
            {
                matrix[row, col] = 'x';
                players.FirstOrDefault(p => p.Char == player.Char).IsAlive = false;
            }

        }
        private static void CheckValidityOfIndexes( ref int row, ref int col, char[,] matrix)
        {
            if (row < 0) row = matrix.GetLength(0) - 1;
            if (row >= matrix.GetLength(0)) row = 0;
            if (col < 0) col = matrix.GetLength(1) - 1;
            if (col >= matrix.GetLength(1)) col = 0;
        }
        private static void SwitchCommand(string command,ref int row, ref int col, char[,] matrix)
        {
            switch (command)
            {
                case "up":
                    row--;
                    break;
                case "down":
                    row++;
                    break;
                case "left":
                    col--;
                    break;
                case "right":
                    col++;
                    break;
                default:
                    break;
            }
        }
    }

    public class Player
    {
        public int Row { get; set; }
        public int Col { get; set; }
        public char Char { get; set; }
        public bool IsAlive { get; set; }
        public Player(int row, int col, char character)
        {
            this.Row = row;
            this.Col = col;
            this.Char = character;
            this.IsAlive = true;
        }
    }
}
