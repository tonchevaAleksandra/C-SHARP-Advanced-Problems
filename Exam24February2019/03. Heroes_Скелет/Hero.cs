using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes
{
 public   class Hero
    {
        //        •	Name: string
        //•	Level: int
        //•	Item: Item
        public string Name { get; set; }
        public int Level { get; set; }
        public Item Item { get; set; }

        public Hero(string name, int level, Item item)
        {
            this.Name = name;
            this.Level = level;
            this.Item = item;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Hero: {this.Name} – {this.Level}lvl");
            sb.AppendLine(this.Item.ToString());
            return sb.ToString().Trim();
        }
    }
}
