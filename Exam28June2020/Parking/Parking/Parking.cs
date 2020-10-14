using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parking
{
   public class Parking
    {
        private List<Car> data;
        public string Type { get; set; }
        public int Capacity { get; set; }
        public int Count
        {
            get
            {
                return this.data.Count;
            }
        }
        public Parking(string type, int capacity)
        {
            this.data = new List<Car>();
            this.Type = type;
            this.Capacity = capacity;
        }

        public void Add(Car car)
        {
            if(this.Capacity>this.Count)
            {
                this.data.Add(car);
            }
        }
        public bool Remove(string manufacturer, string model)
        {
            foreach (var item in this.data)
            {
                if(item.Manufacturer== manufacturer && item.Model==model)
                {
                    this.data.Remove(item);
                    return true;
                }
            }
            return false;
        }

        public Car GetLatestCar()
        {
            if (this.Count == 0)
                return null;
            else
            {
                Car currCar = this.data.OrderByDescending(c => c.Year).First();
                return currCar;
            }
        }

        public Car GetCar(string manufacturer, string model)
        {
            foreach (var item in this.data)
            {
                if (item.Manufacturer == manufacturer && item.Model == model)
                    return item;
            }

            return null;
        }

        public string GetStatistics()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"The cars are parked in {this.Type}:");
            foreach (var item in this.data)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString().Trim();
        }
    }
}
