using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Christmas
{
  public  class Bag
    {
        private List<Present> data;

        public string Color { get; set; }
        public int Capacity { get; set; }
        public int Count 
        {
            get
            {
                return this.data.Count;
            }
        }
        public Bag(string color, int capacity)
        {
            this.Color = color;
            this.Capacity = capacity;
            this.data = new List<Present>();
        }

        //•	Method Add(Present present) - adds an entity to the data if there is room for it
        public void Add(Present present)
        {
            if(this.Count<this.Capacity)
            {
                this.data.Add(present);
            }
        }
        //•	Method Remove(string name) - removes a present by given name, if such exists, and returns bool
        public bool Remove(string name)
        {
            if (this.data.Any(x => x.Name == name))
            {
                Present currentPresent = this.data.FirstOrDefault(x => x.Name == name);
                this.data.Remove(currentPresent);
                return true;
            }
            return false;
        }

        //•	Method GetHeaviestPresent() - returns the heaviest present
        public Present GetHeaviestPresent()
        {
            Present heaviest = this.data.OrderByDescending(p => p.Weight).FirstOrDefault();
            return heaviest;
        }
        public Present GetPresent(string name)
        {
            Present present = this.data.FirstOrDefault(p => p.Name == name);
            return present;
        }
        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.Color} bag contains:");
            foreach (var item in this.data)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString().Trim();
        }
    }
}
