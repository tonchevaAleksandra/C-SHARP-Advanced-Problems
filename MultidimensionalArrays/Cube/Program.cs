using System;

namespace Cube
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,,] cube = new string[3, 3, 3];

            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    cube[row, col, 0] += 'w';
                    cube[row, col, 2] += 'y';
                }
            }

            for (int row = 0; row < 3; row++)
            {
                for (int depth = 0; depth < 3; depth++)
                {
                    cube[row, 0, depth] += 'b';
                    cube[row, 2, depth] += 'g';
                }
            }
            for (int col = 0; col < 3; col++)
            {
                for (int depth = 0; depth < 3; depth++)
                {
                    cube[0, col, depth] += 'r';
                    cube[2, col, depth] += 'o';
                }
            }
            

        }
    }
}
