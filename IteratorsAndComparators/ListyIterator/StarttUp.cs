using System;
using System.Linq;

namespace ListyIterator
{
    public class StarttUp
    {
        static void Main(string[] args)
        {

            var input = string.Empty;
            ListyIterator<string> list = null;
            while ((input = Console.ReadLine()) != "END")
            {
                var commmandArgs = input.Split();
                var command = commmandArgs[0];
                switch (command)
                {
                    case "Create":
                        var data = commmandArgs.Skip(1).ToArray();
                        list = new ListyIterator<string>(data);
                        break;
                    case "HasNext":
                        Console.WriteLine(list.HasNext());
                        break;
                    case "Move":
                        Console.WriteLine(list.Move());
                        break;
                    case "Print":
                        try
                        {
                            list.Print();
                        }
                        catch (InvalidOperationException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;

                    case "PrintAll":
                        try
                        {
                            list.PrintAll();
                        }
                        catch (InvalidOperationException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                }
            }
        }
    }
}
