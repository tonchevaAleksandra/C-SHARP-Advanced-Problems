using System;
using System.IO;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<int, int> action = PrintNumbers; //Action have to keep  all variables that keep the Method that we invoke with the Action// Void Methods =>Action

            action(10, 10);

            Action act = Print;
            act();

            Func<int, int, int> someFunc = Sum; // the first two variables are the variables from the parameters of the function, and the third is the variable- RESULT from the method // FUNC  is used for non void Methods
            var result = someFunc(10, 20);
            Console.WriteLine(result);
            Func<int, bool> func = IsEven;// input int => output bool

            ProcessResult(Console.WriteLine);
            ProcessResult(number => Console.WriteLine(number * 2));
            ProcessResult(number => File.WriteAllText("Result.txt", number.ToString()));

        }

        static void ProcessResult(Action<int> act)
        {
            //Calcul;ation
            var result = 42;

            act(result);

        }

        static bool IsEven(int x) => x % 2 == 0;


        static void Print()
        {
            Console.WriteLine("OK");
        }

        static void PrintNumbers(int x, int y)
        {
            Console.WriteLine(x);
            Console.WriteLine(y);
        }

        static int Sum(int x, int y) => x + y;
        
    }
}
