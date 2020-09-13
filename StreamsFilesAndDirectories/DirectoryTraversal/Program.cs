using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DirectoryTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputDir = Console.ReadLine();

            string[] files = Directory.GetFiles(inputDir);

            Dictionary<string, Dictionary<string, double>> filesToSort = new Dictionary<string, Dictionary<string, double>>();

            filesToSort = GetFileInfoToDictionary(files, filesToSort);

            filesToSort = filesToSort.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

            string resultPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            using var writer = new StreamWriter($"{resultPath}/report.txt");
            WriteFileInfoOnReportFile(filesToSort, writer);

        }

        private static void WriteFileInfoOnReportFile(Dictionary<string, Dictionary<string, double>> filesToSort, StreamWriter writer)
        {
            foreach (var file in filesToSort)
            {
                string ext = file.Key;
                var currDict = file.Value.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

                writer.WriteLine(ext);

                foreach (var output in currDict)
                {
                    writer.WriteLine("--{0} - {1}kb", output.Key, output.Value / 1024);
                }

            }
        }

        static Dictionary<string, Dictionary<string, double>> GetFileInfoToDictionary(string[] files, Dictionary<string, Dictionary<string, double>> filesToSort)
        {
            foreach (var filePath in files)
            {

                var file = new FileInfo(filePath);
                string fileName = file.Name;
                var size = file.Length;

                string extension = file.Extension;

                if (!filesToSort.ContainsKey(extension))
                {
                    filesToSort.Add(extension, new Dictionary<string, double>());
                }

                filesToSort[extension].Add(fileName, size);
            }

            return filesToSort;
        }
    }
}
