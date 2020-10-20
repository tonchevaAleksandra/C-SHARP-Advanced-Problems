using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<string> updates = new Stack<string>();
            StringBuilder text = new StringBuilder();
            updates.Push(text.ToString());
            for (int i = 0; i < n; i++)
            {
                string[] arr = Console.ReadLine().Split();
                int  command = int.Parse(arr[0]);
                switch (command)
                {
                    case 1:
                        string some = arr[1];
                        text.Append(some);
                        updates.Push(text.ToString());
                        break;
                    case 2:
                        int count = int.Parse(arr[1]);
                        text.Remove(text.Length - count,count);
                        updates.Push(text.ToString());

                        break;
                    case 3:
                        int index = int.Parse(arr[1]);
                        Console.WriteLine(text[index-1]);

                        break;
                    case 4:
                        updates.Pop();
                        text = new StringBuilder();
                        text.Append(updates.Peek());
                        break;

                   
                }

            }
        }
    }
}
