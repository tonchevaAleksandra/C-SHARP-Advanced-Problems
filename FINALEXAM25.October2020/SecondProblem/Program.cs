using System;
using System.Collections.Generic;
using System.Linq;

namespace Garden
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
            int[,] garden = new int[rows, cols];
          
            List<int> flowersPositions = new List<int>();
            string input;
            while ((input = Console.ReadLine()) != "Bloom Bloom Plow")
            {
                int[] currPosFlower = input
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                int row = currPosFlower[0];
                int col = currPosFlower[1];
                if (!IsValidCell(row, col, garden))
                {
                    Console.WriteLine("Invalid coordinates.");
                    continue;
                }
                else
                {
                    garden[row, col] = 1;
                    flowersPositions.Add(row);
                    flowersPositions.Add(col);
                }

            }

            BloomFlowers(garden, flowersPositions);

            PrintGardenPositions(garden);

        }

        private static void BloomFlowers(int[,] garden, List<int> flowersPositions)
        {
            for (int i = 0; i < flowersPositions.Count; i += 2)
            {
                int currRow = flowersPositions[i];
                int currCol = flowersPositions[i + 1];
                for (int row = 0; row < garden.GetLength(0); row++)
                {
                    if (row != currRow)
                        garden[row, currCol]++;
                }
                for (int col = 0; col < garden.GetLength(1); col++)
                {
                    if (col != currCol)
                        garden[currRow, col]++;
                }
            }
        }

        private static void PrintGardenPositions(int[,] garden)
        {
            for (int i = 0; i < garden.GetLength(0); i++)
            {
                for (int j = 0; j < garden.GetLength(1); j++)
                {
                    Console.Write(garden[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

      
        private static bool IsValidCell(int row, int col, int[,] garden)
        {
            if (row >= 0 && row < garden.GetLength(0) && col >= 0 && col < garden.GetLength(1))
                return true;
            return false;
        }
    }
}
