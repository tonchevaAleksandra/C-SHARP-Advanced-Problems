using System;
using System.Collections.Generic;
using System.Linq;

namespace CarSalesMan
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var engines = new List<Engine>();

            Func<string, bool> tryParseFunc = TryParse();

            for (int i = 0; i < n; i++)
            {
                var inputArgs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
               
                var model = inputArgs[0];
                var power = int.Parse(inputArgs[1]);

                Engine currEngine = CreateEngine(tryParseFunc, inputArgs, model, power);
                engines.Add(currEngine);
            }

            var m = int.Parse(Console.ReadLine());

            var cars = new List<Car>();

            for (int i = 0; i < m; i++)
            {
               
                var inputArgs = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).ToArray();
                var model = inputArgs[0];
                var engineModel = inputArgs[1];
                var engine = engines.Find(e => e.Model == engineModel);
               
               var currCar = CreateCar(tryParseFunc, inputArgs, model, engine);

                cars.Add(currCar);

            }

            foreach (Car car in cars)
            {
                Console.WriteLine(car.ToString());
            }

        }

        private static Car CreateCar(Func<string, bool> tryParseFunc, string[] inputArgs, string model, Engine engine)
        {
            Func<string[], Car> createCar = x =>
            {
                if (x.Length == 4)
                {
                    var weight = int.Parse(inputArgs[2]);
                    var color = inputArgs[3];

                     return new Car(model, engine, weight, color);
                }
                else if (inputArgs.Length == 3)
                {

                    if (tryParseFunc(inputArgs[2]))
                    {
                        var weight = int.Parse(inputArgs[2]);
                        return new Car(model, engine, weight);
                    }
                    else
                    {
                        var color = inputArgs[2];
                        return new Car(model, engine, color);
                    }
                }
                else
                {
                    return new Car(model, engine);
                }

               
            };
            var currCar = createCar(inputArgs);
            return currCar;
        }

        private static Func<string, bool> TryParse()
        {
            return x =>
            {
                int number;
                if (Int32.TryParse(x, out number))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            };
        }

        private static Engine CreateEngine(Func<string, bool> tryParseFunc, string[] inputArgs, string model, int power)
        {
            Func<string[], Engine> createEngine = x =>
            {
                if (x.Length == 4)
                {
                    var displacement = int.Parse(x[2]);
                    var efficiency = x[3];

                    return new Engine(model, power, displacement, efficiency);
                }
                else if (x.Length == 3)
                {
                    if (tryParseFunc(x[2]))
                    {
                        return new Engine(model, power, int.Parse(x[2]));
                    }
                    else
                    {
                        return new Engine(model, power, x[2]);
                    }
                }
                else
                {
                    return new Engine(model, power);
                }

            };
            var currEngine = createEngine(inputArgs);
            return currEngine;
        }


    }
}
