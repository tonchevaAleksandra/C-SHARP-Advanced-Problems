using System;
using System.Linq;
namespace GridChallenge
{
    class Program
    {
        static string gridChallenge(string[] grid)
        {
            grid.Select(x => x.ToCharArray().OrderBy(c => c)).ToArray();
            
            int n = grid.Length;
            char[,] matrix = new char[n,n];
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {

                }
            }

        }
        static void Main(string[] args)
        {

            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine());

                string[] grid = new string[n];

                for (int i = 0; i < n; i++)
                {
                    string gridItem = Console.ReadLine();
                    grid[i] = gridItem;
                }

                string result = gridChallenge(grid);

                Console.WriteLine(result);
            }

        }
    }
}
