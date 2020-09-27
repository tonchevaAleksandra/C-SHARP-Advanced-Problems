using System;
using System.Linq;

namespace ImplementingListTemplate
{
    public class Program
    {
        static void Main(string[] args)
        {
            var list = new MyList<string>();


            var catList = new MyList<Cat>();
            catList.Add(new Cat
            {
               Name= "Gosho"
            });
            catList.Add(new Cat
            {
                Name = "Pesho"
            });
            catList.Add(new Cat
            {
                Name = "Ivan"
            });


            MyList<string> catNames = catList
                .Where(n => n.Name.Length > 4)
                .OrderBy(n => n.Name)
                .Select(n => n.Name)
                .ToMyList();

           catList
                .Where(c => c.Name.Length > 4)
                .OrderBy(c=>c.Name)
                .Select(c => c.Name)
                .ToList()
                .ForEach(Console.WriteLine); ;
            Console.WriteLine(catList[0].Name);

            foreach (Cat cat in catList)
            {
                Console.WriteLine(cat.Name);
            }

            var list2 = new MyList<int>
            {
                1, 2, 3, 4
            };

            var listCats = new MyList<Cat>
            {

            };
            var stringList = new MyList<string>
            {
                "some", "body", "wait"
            };

            var list3 = new MyList<int> { 1, 2, 3, 4 };

            var removed = list3.RemoveAll(x => x % 2 == 0);

            Console.WriteLine(removed); //2
            Console.WriteLine(list3[0]); //1
            Console.WriteLine(list3[1]) ; //3
            Console.WriteLine(list3.Count); //2
        }
    }
}
