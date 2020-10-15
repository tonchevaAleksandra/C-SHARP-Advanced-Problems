using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Guild
{
    public class Guild
    {
        private List<Player> roster;
        public string Name { get; set; }
        public int Capacity { get; set; }
        public int Count
        {
            get
            {
                return this.roster.Count;
            }

        }
        public Guild(string name, int capacity)
        {
            this.roster = new List<Player>();
            this.Name = name;
            this.Capacity = capacity;
        }

        public void AddPlayer(Player player)
        {
            if (this.Count < this.Capacity)
            {
                this.roster.Add(player);
            }
        }

        //•	Method RemovePlayer(string name) - removes a player by given name, if such exists, and returns bool

        public bool RemovePlayer(string name)
        {
            bool isRemoved = false;
            foreach (var item in this.roster)
            {
                if(item.Name==name)
                {
                    this.roster.Remove(item);
                    isRemoved = true;
                }
            }
           
            return isRemoved;
        }
        //•	Method PromotePlayer(string name) - promote(set his rank to "Member") the first player with the given name.If the player is already a "Member", do nothing
        public void PromotePlayer(string name)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if(this.roster[i].Name==name)
                {
                    this.roster[i].Rank = "Member";
                }
            }
        }

        //•	Method DemotePlayer(string name)- demote(set his rank to "Trial") the first player with the given name.If the player is already a "Trial",  do nothing.

        public void DemotePlayer(string name)
        {
            foreach (var item in this.roster)
            {
                if (item.Name == name)
                {
                    item.Rank = default;
                }
                break;
            }
        }

        //•	Method KickPlayersByClass(string class) - removes all the players by the given class and returns all players from that class as an array

        public Player[] KickPlayersByClass(string className)
        {
            var arr = this.roster.Where(p => p.Class == className).ToArray();
            this.roster.RemoveAll(p => p.Class == className);
            return arr;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Players in the guild: {this.Name}");
            foreach (var item in this.roster)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString().Trim();
        }
    }
}
