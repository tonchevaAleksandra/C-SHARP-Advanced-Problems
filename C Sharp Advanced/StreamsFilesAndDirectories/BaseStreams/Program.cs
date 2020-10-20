using System;
using System.IO;
using System.Linq;
using System.Text;

namespace BaseStreams
{
    class Program
    {
        static void Main(string[] args)
        {
            var stream = new FileStream("text.txt", FileMode.OpenOrCreate);

            //Console.WriteLine(stream.Length);//in bytes

            byte[] buffer = new byte[50];

            //var totalBytesRead = stream.Read(buffer, 0, buffer.Length);
            //Console.WriteLine(totalBytesRead);
            ////stream.Write();

            //var result = Encoding.UTF8.GetString(buffer);
            //Console.WriteLine(result);

            //totalBytesRead = stream.Read(buffer, 0, buffer.Length);
            //Console.WriteLine(totalBytesRead);
            //result = Encoding.UTF8.GetString(buffer);
            //Console.WriteLine(result);
            var result = new StringBuilder();

            while (true)
            {
                var totalBytes = stream.Read(buffer, 0, buffer.Length);
                if(totalBytes<buffer.Length)
                {
                    var lastPart = /*new byte[totalBytes];*/ buffer.Take(totalBytes).ToArray();
                    result.Append(Encoding.UTF8.GetString(lastPart));
                    break;
                }
                result.Append(Encoding.UTF8.GetString(buffer));

            }
            Console.WriteLine(result);
        }
    }
}
