using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                  .Split();
            Stack<string> result = new Stack<string>(input.Reverse());

            while (result.Count!=1)
            {
                var firstNum = int.Parse(result.Pop());
                var operation = result.Pop();
                var secondNum = int.Parse(result.Pop());
                var tempResult = operation switch 
                {
                   "+" =>(firstNum+secondNum),
                   "-"=>(firstNum-secondNum),
                   _=>0
                };
                result.Push(tempResult.ToString());
            }
            Console.WriteLine(result.Pop());
        }
    }
}