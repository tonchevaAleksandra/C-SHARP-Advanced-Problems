using System;

using System.Collections.Generic;
using System.Linq;

namespace StackPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>() { 1, 2, 3, 4 };
            var digit = list.Any(num => num % 2 == 0);
            var inputStr = "TEXT";
            var curr = inputStr.All(c => char.IsUpper(c));//return true
            Stack<string> myStack = new Stack<string>();
            new List<int>();
           
            //list.Add("first");

            myStack.Push("first"); // add element on top of stack

            myStack.Push("second");
            myStack.Push("third");

            var result = myStack.Pop(); // remove the last added element 

            var contains = myStack.Contains("five");
            Console.WriteLine(result);
            result = myStack.Peek();// give the last element without remove it

            myStack.Pop();
            myStack.Pop();

            var otherResult = myStack.TryPop(out var output);
            Console.WriteLine(output);

            string text = "some text";
            int res = 0;
            if (int.TryParse(text, out res))
            {
                Console.WriteLine(res);
            }
            else
            {
                Console.WriteLine("Invalid input");
            }

            var secondStack = new Stack<char>(Console.ReadLine());
            Console.WriteLine(string.Join(string.Empty,secondStack));

            
        }
    }
}
