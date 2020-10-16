using System;
using System.Collections.Generic;
using System.Linq;

namespace SantasPresentFactory
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] targets = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

            Stack<int> materials = new Stack<int>(targets);

            int[] targets1 = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

            Queue<int> magic = new Queue<int>(targets1);

            List<Present> presents = new List<Present>();
            presents.Add(new Present("Doll", 150));
            presents.Add( new Present("Wooden train", 250));
            presents.Add( new Present("Teddy bear", 300));
            presents.Add( new Present("Bicycle", 400));
           
          
            while (materials.Any() && magic.Any())
            {
                var result = materials.Peek() * magic.Peek();
                if(presents.Any(p=>p.MaterialsNeeded==result))
                {
                    presents.Find(p => p.MaterialsNeeded == result).Count++;
                    materials.Pop();
                    magic.Dequeue();
                }
                else if(result<0)
                {
                    result = materials.Peek() + magic.Peek();
                    materials.Pop();
                    magic.Dequeue();
                    materials.Push(result);
                }
                else if(result==0)
                {
                    if (materials.Peek() == 0)
                    {
                        materials.Pop();
                    }
                    else magic.Dequeue();
                }
                else
                {
                    var currMaterial = materials.Peek();
                    materials.Pop();
                    magic.Dequeue();
                    materials.Push(currMaterial+15);
                }
            }

            if((presents.Where(p=>p.Name=="Doll" && p.Count>0).Count()!=0
                && presents.Where(p => p.Name == "Wooden train"
                && p.Count > 0).Count() != 0)
                ||(presents.Where(p => p.Name == "Teddy bear"
                && p.Count > 0).Count() != 0
                && presents.Where(p => p.Name == "Bicycle"
                && p.Count > 0).Count() != 0))
            {
                Console.WriteLine("The presents are crafted! Merry Christmas!");
            }
            else
            {
                Console.WriteLine("No presents this Christmas!");
            }
            if(materials.Any())
            {
                Console.WriteLine($"Materials left: {string.Join(", ", materials)}");
            }
            if (magic.Any())
            {
                Console.WriteLine($"Magic left: { string.Join(", ", magic)}");
            }

            presents = presents.Where(p => p.Count > 0).OrderBy(p => p.Name).ToList();

            foreach (Present present in presents)
            {
                Console.WriteLine(present.ToString());
            }
        }
    }

    public class Present
    {
        public string Name { get; set; }
        public int MaterialsNeeded { get; set; }
        public int Count { get; set; }
        public Present(string name, int materialsNeeded)
        {
            this.Name = name;
            this.MaterialsNeeded = materialsNeeded;
           
        }

        public override string ToString()
        {
            return $"{this.Name}: {this.Count}";
        }
    }
}
