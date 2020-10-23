using System;
using System.Linq;

namespace Stack
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var input = string.Empty;
            CustomStack<string> stack = new CustomStack<string>();
            while ((input = Console.ReadLine()) != "END")
            {
                var commandArgs = input.Split(new char[] { ' ', ','}, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var command = commandArgs[0];
                switch (command)
                {
                    case "Push":
                        var items = commandArgs.Skip(1).ToArray();
                        foreach (var item in items)
                        {
                            stack.Push(item);
                        }
                        break;
                    case "Pop":
                        try
                        {
                            stack.Pop();
                        }
                        catch (InvalidOperationException e)
                        {

                            Console.WriteLine(e.Message);
                        }
                        break;

                }

            }

            try
            {
                for (int i = 0; i < 2; i++)
                {
                    foreach (var item in stack)
                    {
                        Console.WriteLine(item);
                    } 
                }  

            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
