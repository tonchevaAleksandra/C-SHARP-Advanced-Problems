using System;
using System.Collections.Generic;
using System.Linq;

namespace SpeedRacing
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                //"{model} {fuelAmount} {fuelConsumptionFor1km}"
                var inputArgs = Console.ReadLine().Split().ToArray();
                var model = inputArgs[0];
                var fuelAmount = double.Parse(inputArgs[1]);
                var fuelConsumption = double.Parse(inputArgs[2]);

                var currCar = new Car(model, fuelAmount, fuelConsumption);

                cars.Add(currCar);
            }

            string input;
            while ((input=Console.ReadLine())!="End")
            {
                //"Drive {carModel} {amountOfKm}"
                var cmdArgs = input.Split().Skip(1).ToArray();
                var model = cmdArgs[0];
                var amountOfKm = double.Parse(cmdArgs[1]);
                var car = cars.Find(x => x.Model == model);
                car.Drive(amountOfKm);
            }

            foreach (Car car in cars)
            {
                Console.WriteLine(car.ToString());
            }
        }
    }
}
