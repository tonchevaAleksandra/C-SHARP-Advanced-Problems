using System;

namespace BookWorm
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];
            var player = new Player(0, 0);
            ReadMatrix(n, matrix, player);
            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                var currRow = player.Row;
                var currCol = player.Col;
                SwiTchInput(input, ref currRow, ref currCol);
                if (ValidateTheNewPosition(currRow, currCol, matrix))
                {
                    matrix[player.Row, player.Col] = '-';

                    if (char.IsLetter(matrix[currRow, currCol]))
                    {
                        if (a.Length > 0)
                        {
                            a = a + matrix[currRow, currCol];
                            matrix[currRow, currCol] = 'P';
                        }

                    }

                    player.Row = currRow;
                    player.Col = currCol;
                }
                else
                {
                    a = a.Remove(a.Length - 1);
                }
            }

            PrintResult(a, matrix);
        }

        private static void PrintResult(string a, char[,] matrix)
        {
            Console.WriteLine(a);
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
        }

        private static bool ValidateTheNewPosition(int row, int col, char[,] matrix)
        {
            if (row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1))
                return true;
            return false;
        }
        private static void SwiTchInput(string input, ref int currRow, ref int currCol)
        {
            switch (input)
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

        private static void ReadMatrix(int n, char[,] matrix, Player player)
        {
            for (int i = 0; i < n; i++)
            {
                var currRow = Console.ReadLine().ToCharArray();
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = currRow[j];
                    if (currRow[j] == 'P')
                    {
                        player.Row = i;
                        player.Col = j;
                    }
                }
            }
        }
    }

    public class Player
    {
        public int Row { get; set; }
        public int Col { get; set; }
        public Player(int row, int col)
        {
            this.Row = row;
            this.Col = col;
        }
    }
}
