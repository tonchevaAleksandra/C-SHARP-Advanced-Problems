using System;
using System.Collections.Generic;

namespace Practice
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var list = new List<IAnimal>();
            list.Add(new Cat());
            list.Add(new Bunny());

            foreach (var item in list)
            {
                Console.WriteLine(item.Name);
                item.Move(5, 6);
            }

            //var numbers = new Numbers(new List<int>{ 1, 2, 3 });
            //var sum = 0;
            //foreach (var item in numbers)
            //{
            //    sum += item;
            //}
            //Console.WriteLine(sum);
            var data = new List<int>() { 1, 2, 3, 4, 5, 6 };
            var nums = new Numbers(data,new NumbersReverseEnumerator());
            foreach (var item in nums)
            {
                Console.WriteLine(item);
            }
            

        }
    }
}
