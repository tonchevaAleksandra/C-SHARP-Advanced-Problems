using System;
using System.Linq;

namespace Tuple
{
   public class StartUp
    {
        static void Main(string[] args)
        {

            string[] personInfo = Console.ReadLine()
                   .Split()
                   .ToArray();
            var fullName = personInfo[0] + " " + personInfo[1];
            var adress = personInfo[2];


            string[] personBeer = Console.ReadLine()
           .Split()
           .ToArray();
            var name = personBeer[0];
            var liters = int.Parse(personBeer[1]);


            string[] nums = Console.ReadLine()
           .Split()
           .ToArray();
            var integer = int.Parse(nums[0]);
            var doubleNum = double.Parse(nums[1]);


            Tuple<string, string> firstTuple = new Tuple<string, string>(fullName, adress);
            Tuple<string, int> secondTuple = new Tuple<string, int>(name, liters);
            Tuple<int, double> thirdTuple = new Tuple<int, double>(integer, doubleNum);

            Console.WriteLine(firstTuple);
            Console.WriteLine(secondTuple);
            Console.WriteLine(thirdTuple);
        }
    }
}
