using System;
using System.IO;
using System.IO.Compression;

namespace ZipAndExtract1
{
    class Program
    {
        static void Main(string[] args)
        {
            var zipFile = @"..\Myzip.zip";
            var file = "copyMe.png";

            using(var archive= ZipFile.Open(zipFile,ZipArchiveMode.Create))
            {
                archive.CreateEntryFromFile(file, Path.GetFileName(file));
            }
        }
    }
}
