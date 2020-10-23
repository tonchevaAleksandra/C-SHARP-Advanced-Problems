using System;
using System.IO;
using System.Linq;

namespace SliceAFile
{
    class Program
    {
        static void Main(string[] args)
        {
            using var reader = new FileStream("sliceMe.txt",FileMode.Open);
            var parts = 4;

            var length = reader.Length / parts;

            while (length % 4 != 0)
            {
                length++;
            }

            var buffer = new byte[length];

            for (int i = 0; i < parts; i++)
            {
                var bytesRead = reader.Read(buffer, 0, buffer.Length);

                if (bytesRead < buffer.Length)
                {
                    buffer = buffer
                        .Take(bytesRead)
                        .ToArray();
                }

                using var currentPartStream = new FileStream($"Part{i + 1}.txt", FileMode.OpenOrCreate);

                currentPartStream.Write(buffer, 0, buffer.Length);
            }

            var files = Directory.GetFiles(".");
            foreach (var file in files)
            {
                Console.WriteLine(file);
            }

        }
    }
}
