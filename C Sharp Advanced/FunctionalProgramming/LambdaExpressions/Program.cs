using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaExpressions
{

    delegate int MyDelegate(int x, int y);//

    //delegate int SomeDelegate(string input);
    delegate void SomeDelegate(int x);
    class Program
    {
        static void Main(string[] args)
        {
            //Lambda Syntax :
            //parameters=> body
            //"=>" goes to

            var list = new List<int>
            {
                1,2,3,4
            };

            list = list.Where(x => x % 2 == 0) //Where(IsEven) //Where(x=>{ var result= x%2==0;
            //    return result;}
                .ToList();


            //Implicit Lambda expressions
            //msg=>Console.WriteLine(msg);

            //Explicit lambda expressions
            // (string mesg) => {Console.WriteLine(msg);}

            //ZERO Parameters
            // () => {Console.WriteLine("hi"); }  
            // () => MyMethod();

            //More parameters
            // (x,y) => { return x + y; }


            MyDelegate somefunc = Sum;
            var result=somefunc(5, 5);
            Console.WriteLine(result);
            //SomeDelegate myDelegate = int.Parse;

            SomeDelegate someDelegate = /*x =>*/ Console.WriteLine/*(x)*/;

            someDelegate += x => Console.WriteLine(x+10);// multicast delegate
            someDelegate += x => Console.WriteLine(x+100);// multicast delegate

            someDelegate(5);// multicast delegate
        }

        static void Print() // ()=>Console.WriteLine("Kef");
        {
            Console.WriteLine("Kef");

        }

        static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        static int Sum(int x, int y) // (x,y)=> x+y;
        {
            return x + y;
        }
    }
}
