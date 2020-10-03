using System;
using System.Linq;

namespace Threeuple
{
  public  class StartUp
    {
        static void Main(string[] args)
        {
            string[] personInfo = Console.ReadLine()
            .Split()
            .ToArray();
            var fullName = personInfo[0] + " " + personInfo[1];
            var adress = personInfo[2];
            var town = personInfo[3];

            string[] beerInfo = Console.ReadLine()
           .Split()
           .ToArray();
            var name = beerInfo[0];
            var liters = int.Parse(beerInfo[1]);
            var drunkOrNot = beerInfo[2] == "drunk" ? true : false;

            string[] bankInfo = Console.ReadLine()
            .Split()
            .ToArray();
            var acountName = bankInfo[0];
            var ballance = double.Parse(bankInfo[1]);
            var bankName = bankInfo[2];

            Tuple<string, string, string> first = new Tuple<string, string, string>(fullName, adress, town);

            Tuple<string, int, bool> second = new Tuple<string, int, bool>(name, liters, drunkOrNot);

            Tuple<string, double, string> third = new Tuple<string, double, string>(acountName, ballance, bankName);

            Console.WriteLine(first);
            Console.WriteLine(second);
            Console.WriteLine(third);
        }
    }
}
