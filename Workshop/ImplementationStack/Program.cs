using System;

namespace ImplementationStack
{
  public  class Program
    {
        static void Main(string[] args)
        {
            var stack = new MyStack();
            stack.Push(10);
            stack.Push(20);

            Console.WriteLine(stack.Count); //2
           var result=  stack.Pop();
            Console.WriteLine(result); //20
            Console.WriteLine(stack.Count);//1

            var peekResult = stack.Peek();
            Console.WriteLine(peekResult); //10

            stack.Clear();
            Console.WriteLine(stack.Count); //0

            var newStack = new MyStack();

            for (int i = 0; i < 3; i++)
            {
                newStack.Push(i);
            }
            Console.WriteLine(newStack.Pop());
            Console.WriteLine(newStack.Peek());
            Console.WriteLine(newStack.Peek());
            Console.WriteLine(newStack.Peek());
            Console.WriteLine(newStack.Peek());
            Console.WriteLine(newStack.Peek());
            Console.WriteLine(newStack.Peek());

            newStack.Foreach(newStack => Console.WriteLine((newStack * 10));
        }
    }
}
