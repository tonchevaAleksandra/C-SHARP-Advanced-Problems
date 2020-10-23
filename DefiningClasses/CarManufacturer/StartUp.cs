using System;
using System.Collections.Generic;
using System.Linq;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            
            List<Tire[]> tires = new List<Tire[]>();
            string input;
            while ((input = Console.ReadLine()) != "No more tires")
            {
                var currInfoTire = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                Tire[] currentTires = new Tire[4];
                for (int i = 0; i < currInfoTire.Length; i += 2)
                {
                    var currYear = int.Parse(currInfoTire[i]);
                    var currPressure = double.Parse(currInfoTire[i + 1]);
                    currentTires[i / 2] = new Tire(currYear, currPressure);
                }

                tires.Add(currentTires);

            }

            List<Engine> engines = new List<Engine>();

            while ((input = Console.ReadLine()) != "Engines done")
            {
                var currInfoEngine = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                int horesePower = int.Parse(currInfoEngine[0]);
                double cubicCapacity = double.Parse( currInfoEngine[1]);
                Engine currEngine = new Engine(horesePower, cubicCapacity);
                engines.Add(currEngine);
            }


            List<Car> cars = new List<Car>();

            while ((input = Console.ReadLine()) != "Show special")
           { 
                var infoSpecialCar = input.Split(" ",StringSplitOptions.RemoveEmptyEntries).ToArray();
                var make = infoSpecialCar[0];
                var model = infoSpecialCar[1];
                var year = int.Parse(infoSpecialCar[2]);
                var fuelQuantity = double.Parse(infoSpecialCar[3]);
                var fuelConsumption = double.Parse(infoSpecialCar[4]);
                var engineIndex = int.Parse(infoSpecialCar[5]);
                var tiresIndex = int.Parse(infoSpecialCar[6]);

                Engine engine = engines[engineIndex];
                Tire[] currTires = tires[tiresIndex];
                Car currCar = new Car(make, model, year, fuelQuantity, fuelConsumption, engine, currTires);
               
                cars.Add(currCar);

            }

         
            
            List<Car> specialCars = new List<Car>();
            foreach (var car in cars)
            {
                var currPressure = new List<double>();
                foreach (Tire tire in car.Tires)
                {
                   currPressure.Add(tire.Pressure);
                }
                double tireSum = currPressure.Sum();
                if ((tireSum >= 9 && tireSum <= 10) && car.Year>=2017 && car.Engine.HorsePower>330)
                {
                    specialCars.Add(car);
                }
            }
           

            foreach (Car car in specialCars)
            {
                car.Drive(20);

                Console.WriteLine(car.WhoAmI());
              
            }
        }
    }
}
