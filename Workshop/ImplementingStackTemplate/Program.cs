using System;
using System.Globalization;
using System.Threading;

namespace ImplementingStackTemplate
{
   public class Program
    {
        static void Main(string[] args)
        {
            var stack = new MyStack<Cat>();

            stack.Push(new Cat
            {
                Name = "Stancho"
            });
            stack.Push(new Cat
            {
                Name = "Ivan"
            });
            stack.Push(new Cat
            {
                Name = "Pesho"
            });

           

            foreach (Cat cat in stack)
            {
                Console.WriteLine(cat.Name);
            }


            //Thread.CurrentThread.CurrentUICulture = CultureInfo.InvariantCulture;
        }
    }
}
