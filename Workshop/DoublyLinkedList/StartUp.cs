using System;

namespace DoublyLinkedList
{
   public class StartUp
    {
        static void Main(string[] args)
        {
            MyDoublyLinkedList dLL = new MyDoublyLinkedList();
            //dLL.Count = 5; -it's private set, I can't set it out of the class
            for (int i = 0; i < 3; i++)
            {
                dLL.AddFirst(i);
            }

            for (int i = 3; i < 5; i++)
            {
                dLL.AddLast(i);
            }

            dLL.RemoveFirst();
            dLL.RemoveLast();

            dLL.RemoveFirst();

            dLL.Foreach(Console.WriteLine);

            dLL.ToArray();

            var dllt = new DoublyLinkedListTemplate<string>();
            for (int i = 0; i < 10; i++)
            {
                dllt.AddFirst("Pesho " + i);
            }

            dllt.Foreach(Console.WriteLine);
            Console.WriteLine(dllt[0]);

            foreach (var item in dllt)
            {
                string result = item switch
                {
                    "Pesho 1" => item,
                    _ => "This is not Pesho 1"
                };
                Console.WriteLine(result);
            }
            
        }
    }
}
