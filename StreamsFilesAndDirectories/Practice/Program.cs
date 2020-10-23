using System;
using System.IO;
using System.Linq;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //FileStream stream = new FileStream(@"text.txt", FileMode.Open);
            ////relative path - search where the program starts

            //StreamWriter writer = new StreamWriter("text.txt");
            // using (writer)
            // {
            //     writer.Write("Test");
            // }
            // using var reader = new StreamReader("text.txt");
            // string result = reader.ReadLine();
            // Console.WriteLine(result);
            // reader.ReadToEnd();

            FileStream stream = new FileStream("result.txt", FileMode.OpenOrCreate);
            //using var writer = new BinaryWriter(stream);

            //writer.Write(true);
            //writer.Write(false);
            //writer.Write("101");

            using var reader = new BinaryReader(stream);
            var first = reader.ReadBoolean();
            var second = reader.ReadString();
            Console.WriteLine(first);
            Console.WriteLine(second);
        }
    }
}
