using System;
using System.IO;
using System.IO.Compression;

namespace ZipAndExtract
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @".\copyMe.png";
            string zipPath = @"C:\Users\LENOVO\Desktop\SOFTUNI\result.zip";
            string pathExtractedFile = @"C:\Users\LENOVO\Desktop\SOFTUNI";
            ZipFile.CreateFromDirectory(filePath, zipPath);
            ZipFile.ExtractToDirectory(zipPath, pathExtractedFile);
        }
    }
}
