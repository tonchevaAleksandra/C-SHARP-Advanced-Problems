using System;
using System.Collections.Generic;
using System.Linq;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];

            var foodCollected = 0;
            List<int> snakePosition = new List<int>();
            List<int> burrow1 = new List<int>();
            List<int> burrow2 = new List<int>();
            ReadMatrix(matrix, ref snakePosition, ref burrow1,ref burrow2,  n);
           
            string input = Console.ReadLine();
            while (true)
            {
                var currRow = snakePosition[0];
                var currCol = snakePosition[1];
                matrix[snakePosition[0], snakePosition[1]] = '.';
               
                SetNewPosition(input, ref currRow, ref currCol);
                if (IsValidCell(currRow, currCol, n))
                {
                    if (matrix[currRow, currCol] == '*')
                    {
                        foodCollected++;
                        snakePosition[0] = currRow;
                        snakePosition[1] = currCol;
                       
                    }
                    else if (matrix[currRow, currCol] == 'B' && burrow1[0]==currRow && burrow1[1]==currCol)
                    {
                        matrix[currRow, currCol] = '.';
                        snakePosition[0] = burrow2[0] ;
                        snakePosition[1] = burrow2[1];
                    }
                    else if(matrix[currRow, currCol]=='B' && burrow2[0]==currRow && burrow2[1]== currCol)
                    {
                        matrix[currRow, currCol] = '.';
                        snakePosition[0] = burrow1[0];
                        snakePosition[1] = burrow1[1];
                    }
                    else
                    {
                        snakePosition[0] = currRow;
                        snakePosition[1] = currCol;
                    }
                }
                else if(!IsValidCell(currRow, currCol,n))
                {
                    Console.WriteLine("Game over!");
                    break;
                }
                if (foodCollected >= 10)
                {
                    Console.WriteLine("You won! You fed the snake.");
                    matrix[currRow, currCol] = 'S';
                    break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Food eaten: {foodCollected}");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i,j]);
                }
                Console.WriteLine();
            }
        }

        private static bool IsValidCell(int currRow, int currCol, int n)
        {
            if (currRow >= 0 && currRow < n && currCol >= 0 && currCol < n)
                return true;
            return false;
        }
        private static void SetNewPosition(string input, ref int currRow, ref int currCol)
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

        private static void ReadMatrix( char[,] matrix, ref List<int> snakePosition, ref List<int> burrow1, ref List<int> burrow2, int n)
        {
            for (int i = 0; i <n; i++)
            {
                var currRow = Console.ReadLine().ToCharArray();
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = currRow[j];
                    if (currRow[j] == 'S')
                    {
                        snakePosition.Add(i);
                        snakePosition.Add(j);
                    }
                    if (currRow[j] == 'B')
                    {
                        if (burrow1.Count()==2)
                        {
                            burrow2.Add(i);
                            burrow2.Add(j);
                        }
                        else
                        {
                            burrow1.Add(i);
                            burrow1.Add(j);
                        }
                    }
                }

            }
        }
    }
}
