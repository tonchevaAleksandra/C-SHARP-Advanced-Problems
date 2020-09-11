using System;
using System.IO;

namespace StreamsPractice
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Path.DirectorySeparatorChar); // \-the separator for directorires in Windows(for Linux the separator is /)
            //var path = @"c:\pesho\gosho.txt"; - in Wondows is case insensitive - it' s an example for path, in Linux - is case sensitive

            //class Path
            var path = Path.Combine("pesho", "gosho.txt"); // path.Combine can use array of strings
            Console.WriteLine(path);
        }
    }
}
