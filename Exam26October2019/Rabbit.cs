using System;
using System.Collections.Generic;
using System.Text;

namespace Rabbits
{
   public class Rabbit
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public bool Bool { get; set; }
        public Rabbit(string name, string species)
        {
            this.Name = name;
            this.Species = species;
            this.Bool = true;
        }
        public override string ToString()
        {
            return $"Rabbit ({this.Species}): {this.Name}".ToString();
        }
    }
}
