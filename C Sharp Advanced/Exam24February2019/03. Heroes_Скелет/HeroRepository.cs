using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Heroes
{
    public class HeroRepository
    {
        private List<Hero> data;
        public int Count 
        {
            get
            {
                return this.data.Count;
            }
        }
        public HeroRepository()
        {
            this.data = new List<Hero>();
        }
        //•	Method Add(Hero hero) – adds an entity to the data.
        public void Add(Hero hero)
        {
            this.data.Add(hero);
        }

        //•	Method Remove(string name) – removes an entity by given hero name.
        public void Remove(string name)
        {
            if(this.data.Any(h=>h.Name==name))
            {
                for (int i = 0; i < this.data.Count; i++)
                {
                    if(this.data[i].Name==name)
                    {
                        this.data.RemoveAt(i);
                    }
                }
            }
        }

        //•	Method GetHeroWithHighestStrength() – returns the Hero which poses the item with the highest stength.

        public Hero GetHeroWithHighestStrength()
        {
            var hero = this.data.OrderByDescending(h => h.Item.Strength).FirstOrDefault();
            return hero;
        }

        //•	Method GetHeroWithHighestAbility() – returns the Hero which poses the item with the highest ability. 
        public Hero GetHeroWithHighestAbility()
        {
            var hero = this.data.OrderByDescending(h => h.Item.Ability).FirstOrDefault();
            return hero;
        }

        //•	Method GetHeroWithHighestIntelligence() – returns the Hero which poses the item with the highest intellgence.
        public Hero GetHeroWithHighestIntelligence()
        {
            var hero = this.data.OrderByDescending(h => h.Item.Intelligence).FirstOrDefault();
            return hero;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Hero hero in this.data)
            {
                sb.AppendLine(hero.ToString());
            }
            return sb.ToString().Trim();
        }
    }
}
