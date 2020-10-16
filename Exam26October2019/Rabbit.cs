using System;
using System.Collections.Generic;
using System.Text;

namespace Rabbits
{
   public class Rabbit
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public bool Available { get; set; }
        public Rabbit(string name, string species)
        {
            this.Name = name;
            this.Species = species;
            this.Available = true;
        }
        public override string ToString()
        {
            return $"Rabbit ({this.Species}): {this.Name}".ToString();
        }
    }
}
