using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[3, 6]; //row,column
            var cube = new int[5, 5, 5];
            string[,] names= new string[2, 2];
            names[0, 0] = "Pesho";

            int[,] someValues =
            {
                {1,2,3,4 },
                {5,6,7,8 }
            };
            matrix[3, 6] = 1000;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = row + col;
                    Console.Write(matrix[row, col] + " ");

                }
                Console.WriteLine();
            }

            Console.WriteLine(matrix.GetLength(0));//count rows
            Console.WriteLine(matrix.GetLength(1));//count col


        }
    }
}
