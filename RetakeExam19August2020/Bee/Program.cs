using System;
using System.Linq;

namespace Bee
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];
            var beeRow = 0;
            var beeCol = 0;
            ReadMatrix(n, matrix, ref beeRow, ref beeCol);

            int polinateFlowers = 0;

            string input = Console.ReadLine();
            while (input != "End")
            {
                Moves(ref beeRow, ref beeCol, input, ref matrix);
                if (beeRow >= 0 && beeCol >= 0 && beeRow < matrix.GetLength(0) && beeCol < matrix.GetLength(1))
                {
                    if (matrix[beeRow, beeCol] == '.')
                    {
                        matrix[beeRow, beeCol] = 'B';
                        input = Console.ReadLine();
                        continue;
                    }
                    else if (matrix[beeRow, beeCol] == 'O')
                    {
                        matrix[beeRow, beeCol] = 'B';
                        continue;
                    }
                    else
                    {
                        matrix[beeRow, beeCol] = 'B';
                        polinateFlowers++;
                        input = Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("The bee got lost!");
                    break;
                }
            }
            PrintResult(polinateFlowers);

            PrintMatrix(matrix);
        }

        private static void ReadMatrix(int n, char[,] matrix, ref int beeRow, ref int beeCol)
        {
            for (int i = 0; i < n; i++)
            {
                char[] currRow = Console.ReadLine().ToCharArray();

                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = currRow[j];
                    if (matrix[i, j] == 'B')
                    {
                        beeRow = i;
                        beeCol = j;
                    }

                }
            }
        }

        private static void PrintMatrix(char[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
        }

        private static void PrintResult(int polinateFlowers)
        {
            if (polinateFlowers < 5)
            {
                Console.WriteLine($"The bee couldn't pollinate the flowers, she needed {5 - polinateFlowers} flowers more");
            }
            else
            {
                Console.WriteLine($"Great job, the bee managed to pollinate {polinateFlowers} flowers!");
            }
        }

        private static void Moves(ref int beeRow, ref int beeCol, string input, ref char[,] matrix)
        {
            matrix[beeRow, beeCol] = '.';
            switch (input)
            {
                case "up":
                    beeRow--;

                    break;
                case "down":
                    beeRow++;
                    break;
                case "left":
                    beeCol--;
                    break;
                case "right":
                    beeCol++;
                    break;
                default:
                    break;
            }
        }
    }
}
