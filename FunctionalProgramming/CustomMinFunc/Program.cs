using System;
using System.Linq;

namespace CustomMinFunc
{
    class Program
    {
        static void Main(string[] args)
        {

            Func<int[], int> minFunc = x =>
            {
                int minValue = int.MaxValue;
                foreach (var item in x)
                {
                    if (item < minValue)
                        minValue = item;
                }

                return minValue;
            };

        var arr= Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToArray();

            Console.WriteLine(minFunc(arr));
             
        }
    }
}
