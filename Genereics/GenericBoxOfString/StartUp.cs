using System;

namespace GenericBoxOfString
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            //           •	On the first line, you will get n - the number of strings to read from the console.
            //•	On the next n lines, you will get the actual strings.
            //o For each of them, create a box and call its ToString() method to print its data on the console.
            //Output
            //•	The output should be in the given format:

            //            "{class full name: value}"

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var currString = Console.ReadLine();
                var currBox = new Box<string>(currString);
                Console.WriteLine(currBox.ToString());
            }

        }
    }
}
