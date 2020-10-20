using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonTrainer
{
   public class Pokemon
    {
       
        public Pokemon(string name, string element, int health)
        {
            this.Name = name;
            this.Element = element;
            this.Health = health;
        }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string element;

        public string Element
        {
            get { return element; }
            set { element = value; }
        }

        private int health;

        public int Health
        {
            get { return health; }
            set { health = value; }
        }

    }
}
