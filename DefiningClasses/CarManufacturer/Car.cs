using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    public class Car
    {
      
        public Car()    
        {
            //this.Make = "VW";
            //this.Model = "Golf";
            //this.Year = 2025;
            //this.FuelQuantity = 200;
            //this.FuelConsumption = 10;
        }


        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption, Engine engine, Tire[] tires)
            
        {

            this.Make = make;
            this.Model = model;
            this.Year = year;
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
            this.Engine = engine;
            this.Tires = tires;
        }
       
        public Engine Engine { get; set; }
        public Tire[] Tires { get; set; }

        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }


        public double Drive(int distance)
        {
            double neededFuel = this.FuelConsumption * distance / 100;
            if (this.FuelQuantity >= neededFuel)
            {
                this.FuelQuantity -= neededFuel;
            }
            return this.FuelQuantity;
        }
        public string WhoAmI()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Make: {this.Make}");
            sb.AppendLine($"Model: {this.Model}");
            sb.AppendLine($"Year: {this.Year}");
            sb.AppendLine($"HorsePowers: {this.Engine.HorsePower}");
            sb.Append($"FuelQuantity: {this.FuelQuantity}");

            return sb.ToString();

        }
    }
}
