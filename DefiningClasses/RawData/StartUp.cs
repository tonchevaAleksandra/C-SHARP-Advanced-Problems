using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
{
   public class StartUp
    {
        static void Main(string[] args)
        {
           
            int n = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();
                var model = input[0];
                var engineSpeed = int.Parse(input[1]);
                var enginePower = int.Parse(input[2]);
                var cargoWeight = int.Parse(input[3]);
                var cargoType = input[4];
                var engine = new Engine(engineSpeed, enginePower);
                var cargo = new Cargo(cargoWeight, cargoType);
                var tires = new List<Tire>();
                var tiresArgs = input.Skip(5).ToArray();
                for (int j = 0; j < tiresArgs.Length; j+=2)
                {
                    var tire = new Tire(double.Parse(tiresArgs[j]), int.Parse(tiresArgs[j + 1]));
                    tires.Add(tire);
                }

                var currCar = new Car(model, engine, cargo, tires);
                cars.Add(currCar);
            }

            string type = Console.ReadLine();
            Func<List<Car>, string, List<Car>> func = (cars, type) =>
              {
                 
                  if (type == "fragile")
                  {
                    return cars.Where(c => c.Cargo.CargoType == type &&
                    c.Tires.Any(t => t.TirePressure < 1)).ToList();

                  }
                  else
                  {
                      return cars.Where(c => c.Cargo.CargoType == type).Where(c => c.Engine.EnginePower > 250).ToList();
                  }
            
              };

            var result = func(cars, type);

            foreach (Car car in result)
            {
                Console.WriteLine(car.ToString());
            }
        }
    }
}
