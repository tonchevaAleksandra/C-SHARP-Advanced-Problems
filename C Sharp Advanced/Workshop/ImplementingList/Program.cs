using System;

namespace ImplementingList
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new MyList();

            list.Add(30);
            list.Add(20);
            list.Add(30);

            //var someList = new MyList { 5, 6, 7 };

            var count = list.Count;

            Console.WriteLine(  count);

            list[0] = 100;
            var number = list[1];
            list.Clear();
            Console.WriteLine(list.Count);

            for (int i = 0; i < 10; i++)
            {
                list.Add(i);
            }


            var otherList = new MyList();
            otherList.Add(1);
            otherList.Add(2);
            otherList.Add(3);
            otherList.Add(4);
            otherList.Add(5);
            otherList.Add(6);

            var removed = otherList.RemoveAt(2);

            for (int i = 0; i < otherList.Count; i++)
            {
                Console.Write(otherList[i]+ " ");
            }
            Console.WriteLine();
            Console.WriteLine(otherList.Count);

            Console.WriteLine(otherList.Contains(8));
            Console.WriteLine(otherList.Contains(1));


            var anotherList = new MyList();

            anotherList.Add(1);
            anotherList.Add(2);

            Console.WriteLine(anotherList[0]);
            Console.WriteLine(anotherList[1]);
            anotherList.Swap(0, 1);
            Console.WriteLine(anotherList[0]);
            Console.WriteLine(anotherList[1]);

            var listToInsert = new MyList();
            listToInsert.Add(1);
            listToInsert.Add(2);
            listToInsert.Add(3);
            listToInsert.Add(4);

            //listToInsert.Insert(5, 200); // Index out og range
            listToInsert.Insert(3, 100);
            Console.WriteLine(listToInsert[3]); //100
            Console.WriteLine(listToInsert[4]); //4
            listToInsert.Insert(5, 200);
            Console.WriteLine(listToInsert[5]); //200

            var randomList = new MyList()
            {
                //6, 7, 8, 9
            };
        }
    }
}
