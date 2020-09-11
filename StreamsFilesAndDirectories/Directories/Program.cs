using System;
using System.IO;

namespace Directories
{
    class Program
    {
        static void Main(string[] args)
        {
            var files = Directory.GetFiles("f:\\documents");
            double size = 0;
            foreach (var file in files)
            {
                var info = new FileInfo(file);

                size += info.Length;
            }

            Console.WriteLine($"Directory size is {size/1024/1024} MB");
        }
    }
}
