

using System;
using System.IO;

namespace CopyBinaryFile
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var stream = new FileStream("f:\\snimki\\1002826_531371093566329_895217298_n.jpg", FileMode.OpenOrCreate);
            var output= new FileStream("outputImage.jpg",)
            byte[] buffer = new byte[4096];

        }
    }
}
