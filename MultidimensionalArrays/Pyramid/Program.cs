using System;

namespace Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            // recomended not more than 20 rows to see the pyramid of pascal triangle
            long[][] pascalTriangle = new long[rows][];
            if (rows >= 1)
                pascalTriangle[0] = new long[] { 1 };
            if (rows >= 2)
            {
                pascalTriangle[1] = new long[] { 1, 1 };
            }

            for (int row = 2; row < rows; row++)
            {
                pascalTriangle[row] = new long[row + 1];
                pascalTriangle[row][0] = 1;

                for (int col = 1; col < row; col++)
                {
                    pascalTriangle[row][col] = pascalTriangle[row - 1][col] + pascalTriangle[row - 1][col - 1];
                }

                pascalTriangle[row][row] = 1;

            }

            var lastRowLength = string.Join(" ",pascalTriangle[rows-1]).Length;
            foreach (long[] vcurrentRow in pascalTriangle)
            {
                string currentRowText = string.Join(" ", vcurrentRow);
                int diff = lastRowLength - currentRowText.Length;
                int halfDiff = diff / 2;
                string whiteSpace = new string(' ', halfDiff);
                Console.WriteLine($"{whiteSpace}{currentRowText}");
            }
        }
    }
}
