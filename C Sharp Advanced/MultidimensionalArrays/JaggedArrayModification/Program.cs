using System;
using System.Collections.Generic;
using System.Linq;

namespace JaggedArrayModification
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[][] array = new int[rows][];
            for (int row = 0; row < rows; row++)
            {

                int[] currentRow = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();
                array[row] = currentRow;
            }
            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                var cmdArgs = input.Split();
                var command = cmdArgs[0];
                var row = int.Parse(cmdArgs[1]);
                var col = int.Parse(cmdArgs[2]);
                var value = int.Parse(cmdArgs[3]);
                if (row < 0
                    || row >= rows
                    || col < 0
                    || col >= array[row].Length)
                {
                    Console.WriteLine("Invalid coordinates");
                    continue;
                }
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


            Console.WriteLine(string.Join(Environment.NewLine, array.Select(currRow => string.Join(" ", currRow))));

        }
    }
}
