using System;
using System.Collections.Generic;
using System.Linq;

namespace ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> carNumbers = new HashSet<string>();
            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                string[] inputArgs = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string command = inputArgs[0];
                string number = inputArgs[1];
                switch (command)
                {
                    case "IN":
                        carNumbers.Add(number);
                        break;
                    case "OUT":
                        carNumbers.Remove(number);
                        break;
                    default:
                        break;
                }
            }
            if (carNumbers.Any())
            {
                Console.WriteLine(string.Join(Environment.NewLine, carNumbers)); 
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
