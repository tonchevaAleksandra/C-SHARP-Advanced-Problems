using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rabbits
{
    public class Cage
    {
        private List<Rabbit> data;
        public string Name { get; set; }
        public int Capacity { get; set; }
        public int Count
        {
            get
            {
                return this.data.Count;
            }
        }

        public Cage(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.data = new List<Rabbit>();
        }

        public void Add(Rabbit rabbit)
        {
            if (this.Count < this.Capacity)
                this.data.Add(rabbit);
        }

        public bool RemoveRabbit(string name)
        {
            if (this.data.Any(r => r.Name == name))
            {
                var current = this.data.Where(r => r.Name == name).FirstOrDefault();
                this.data.Remove(current);
                return true;
            }

            return false;
        }
        //•	Method RemoveSpecies(string species) - removes all rabbits by given species
        public void RemoveSpecies(string species)
        {
            var list = this.data.Where(r => r.Species == species).ToList();
            foreach (var item in list)
            {
                this.data.Remove(item);
            }
        }
        //•	Method SellRabbit(string name) - sell(set its Available property to false without removing it from the collection) the first rabbit with the given name, also return the rabbit
        public Rabbit SellRabbit(string name)
        {
            Rabbit rabbit = this.data.Find(r => r.Name == name);
            rabbit.Bool = true;
            return rabbit;
        }

        //•	Method SellRabbitsBySpecies(string species) - sells(set their Available property to false without removing them from the collection) and returns all rabbits from that species as an array
        public Rabbit[] SellRabbitsBySpecies(string species)
        {
            var rabbits = new List<Rabbit>();
            foreach (var item in this.data)
            {
                if (item.Species == species)
                {
                    item.Bool = true;
                    rabbits.Add(item);
                }
            }

            return rabbits.ToArray();

        }
        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Rabbits available at {this.Name}:");
            foreach (var item in this.data.Where(r=>r.Bool==true))
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString().Trim();
        }
    }
}
