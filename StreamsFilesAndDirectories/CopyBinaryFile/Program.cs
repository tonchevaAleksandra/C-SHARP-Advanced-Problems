

using System;
using System.IO;
using System.Linq;

namespace CopyBinaryFile
{
    class Program
    {
        static void Main(string[] args)
        {

            using var reader = new FileStream("copyMe.png", FileMode.OpenOrCreate);
            using var writer = new FileStream("./copyTo.png", FileMode.OpenOrCreate);

            byte[] buffer = new byte[4096];

            while (true)
            {
                var bytesToRead = reader.Read(buffer, 0, buffer.Length);

                if (bytesToRead < buffer.Length)
                {
                    buffer = buffer
                        .Take(bytesToRead)
                        .ToArray();
                    writer.Write(buffer, 0, buffer.Length);
                    break;
                }

                writer.Write(buffer, 0, buffer.Length);
            }

        }
    }
}
