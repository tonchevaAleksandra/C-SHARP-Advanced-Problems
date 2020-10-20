using System;
using System.Linq;

namespace PresentDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int presents = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            Santa santa = new Santa(0, 0);
            int totalNiceKids = 0;
            string[,] matrix = new string[n, n];
            for (int i = 0; i < n; i++)
            {
               
                var currRow = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
               
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = currRow[j];
                    if (currRow[j] == "S")
                    {
                        santa.Row = i;
                        santa.Col = j;
                    }
                    if (currRow[j] == "V")
                    {
                        totalNiceKids++;
                    }
                }
            }

            string input;
            while ((input = Console.ReadLine()) != "Christmas morning")
            {
                var currRow = santa.Row;
                var currCol = santa.Col;
                SwitchTheMove(input, ref currRow, ref currCol);
                matrix[santa.Row, santa.Col] = "-";
                presents = CheckCurrentPositionChar(presents, matrix, currRow, currCol);
                santa.Row = currRow;
                santa.Col = currCol;
                matrix[currRow, currCol] = "S";
                if (!CheckPresentsCount(ref presents)) break;
            }
            if (!CheckPresentsCount(ref presents) && input!= "Christmas morning")
            {
                Console.WriteLine("Santa ran out of presents!");
            }
            bool isHappy = true;
            int unhappy = 0;
            PrintTheMatrix(n,ref matrix, ref isHappy, ref unhappy);
            if(isHappy)
            {
                Console.WriteLine($"Good job, Santa! {totalNiceKids} happy nice kid/s.");
            }
            else
            {
                Console.WriteLine($"No presents for {unhappy} nice kid/s.");
            }
        }

        private static int CheckCurrentPositionChar(int presents, string[,] matrix, int currRow, int currCol)
        {
            if (matrix[currRow, currCol] == "C")
            {
                if (matrix[currRow - 1, currCol] == "V"
                    || matrix[currRow - 1, currCol] == "X")
                {
                    presents--;
                    matrix[currRow - 1, currCol] = "-";

                }
                if (matrix[currRow + 1, currCol] == "V"
                    || matrix[currRow + 1, currCol] == "X")
                {
                    presents--;
                    matrix[currRow + 1, currCol] = "-";

                }
                if (matrix[currRow, currCol - 1] == "V"
                   || matrix[currRow, currCol - 1] == "X")
                {
                    presents--;
                    matrix[currRow, currCol - 1] = "-";

                }
                if (matrix[currRow, currCol + 1] == "V"
                   || matrix[currRow, currCol + 1] == "X")
                {
                    presents--;
                    matrix[currRow, currCol + 1] = "-";

                }
            }

            else if (matrix[currRow, currCol] == "V")
            {
                presents--;

            }

            return presents;
        }

        private static void PrintTheMatrix(int n, ref string[,] matrix, ref bool isHappy, ref int unhappy)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]+" ");
                    if (matrix[i, j] == "V")
                    {
                        unhappy++;
                        isHappy = false;
                    }

                }
                Console.WriteLine();
            }
        }

        private static bool CheckPresentsCount(ref int presents)
        {
            if (presents > 0) return true;
            return false;
        }
        private static void SwitchTheMove(string input, ref int currRow, ref int currCol)
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
    }

    public class Santa
    {
        public int Row { get; set; }
        public int Col { get; set; }
        public Santa(int row, int col)
        {
            this.Row = row;
            this.Col = col;
        }
    }
}
