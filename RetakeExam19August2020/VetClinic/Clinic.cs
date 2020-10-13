using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VetClinic
{
   public class Clinic
    {
        private List<Pet> data;
        public int Capacity { get; set; }
        public int Count
        {
            get
            {
               return this.data.Count;
            }
        }
        public Clinic(int capacity)
        {
            this.Capacity = capacity;
            data = new List<Pet>();
        }
        public void Add(Pet pet)
        {
            if(this.Count<this.Capacity)
            {
                this.data.Add(pet);
            }
        }

        public bool Remove(string name)
        {
            bool isRemovedByName = false;
            for (int i = 0; i < this.data.Count; i++)
            {
                var currPetName = this.data[i].Name;
                if (currPetName == name)
                {
                    this.data.RemoveAt(i);
                    isRemovedByName = true;
                }                  
            }

            return isRemovedByName;
        }

        public Pet GetPet(string name, string owner)
        {

            for (int i = 0; i < this.data.Count; i++)
            {
                var currPetName = this.data[i].Name;
                var currOwner = this.data[i].Owner;
                if (currPetName == name && currOwner==owner)
                return this.data[i];
                
            }
            return null;
        }

        public Pet GetOldestPet()
        {
            return this.data.OrderByDescending(p => p.Age).FirstOrDefault();
        }

        public string GetStatistics()
        {
            StringBuilder sb = new StringBuilder();
          sb.AppendLine("The clinic has the following patients:");
            foreach (var pet in this.data)
            {
                sb.AppendLine($"Pet {pet.Name} with owner: { pet.Owner}");
            }
            return sb.ToString().Trim();
        }
    }
}
