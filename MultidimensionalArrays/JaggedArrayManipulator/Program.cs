using System;
using System.Linq;

namespace JaggedArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            double[][] array = new double[rows][];

            ReadTheArray(rows, array);

            array = CheckTheLengthOfRows(rows, array);
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = input.Split();

                string command = cmdArgs[0];
                int row = int.Parse(cmdArgs[1]);
                int col = int.Parse(cmdArgs[2]);
                double value = double.Parse(cmdArgs[3]);
                if (row < 0 || row > rows - 1 || col < 0 || array[row].Length - 1 < col)
                {
                    continue;
                }
                ManipulateTheArray(array, command, row, col, value);
            }

            PrintTheArray(rows, array);

        }

        private static void PrintTheArray(int rows, double[][] array)
        {
            for (int row = 0; row < rows; row++)
            {
                Console.WriteLine(string.Join(" ", array[row]));
            }
        }

        private static void ReadTheArray(int rows, double[][] array)
        {
            for (int row = 0; row < rows; row++)
            {
                double[] currentRow = Console.ReadLine()
                    .Split()
                    .Select(double.Parse)
                    .ToArray();
                array[row] = currentRow;

            }
        }

        private static void ManipulateTheArray(double[][] array, string command, int row, int col, double value)
        {
            switch (command)
            {
                case "Add":
                    array[row][col] += value;
                    break;
                case "Subtract":
                    array[row][col] -= value;
                    break;

                default:
                    break;
            }
        }

        private static double[][] CheckTheLengthOfRows(int rows, double[][] array)
        {
            for (int row = 1; row < rows; row++)
            {
                if (array[row - 1].Length == array[row].Length)
                {
                    array[row - 1] = array[row - 1].Select(x => x * 2).ToArray();
                    array[row] = array[row].Select(x => x * 2).ToArray();
                }
                else
                {
                    array[row - 1] = array[row - 1].Select(x => x / 2).ToArray();
                    array[row] = array[row].Select(x => x / 2).ToArray();
                }
            }
            return array;
        }
    }
}
