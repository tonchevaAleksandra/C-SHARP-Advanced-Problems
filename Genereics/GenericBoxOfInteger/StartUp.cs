using System;

namespace GenericBoxOfInteger
{
   public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                var box = new Box<int>(num);
                Console.WriteLine(box.ToString());
            }
        }
    }
}
