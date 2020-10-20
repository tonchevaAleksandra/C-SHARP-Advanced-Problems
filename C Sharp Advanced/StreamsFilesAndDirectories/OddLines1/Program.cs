using System;
using System.IO;

namespace OddLines1
{
    class Program
    {
        static void Main(string[] args)
        {
            var path1 = Path.Combine("data", "inputText.txt");
            var path2 = Path.Combine("data", "outputText.txt");
            var reader = new StreamReader(path1);
            using (reader)
            {
                int counter = 0;
                string line = reader.ReadLine();
                using (var writer = new StreamWriter(path2))
                {
                    while (line != null)
                    {
                        if (counter % 2 == 1)
                        {
                            writer.WriteLine(line);
                        }
                        counter++;
                        line = reader.ReadLine();
                    }
                }
            }

            //var path = Path.Combine("data", "inputText.txt");
            //using StreamWriter writer = new StreamWriter("outputText.txt", true);

            //using (FileStream file= new FileStream(path, FileMode.Open))
            //{
            //    using (TextReader text= new StreamReader(file))
            //    {

            //        string line = text.ReadLine();
            //        int counter = 0;
            //        while (line!=null)
            //        {
            //            if (counter%2!=0)
            //            {
            //                writer.WriteLine(line);
            //            }

            //            counter++;
            //            line = text.ReadLine();

            //        }
            //    }

            //}



        }
    }
}
