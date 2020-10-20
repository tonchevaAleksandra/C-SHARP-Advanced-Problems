using System;

namespace DateModifier
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string firstDate = Console.ReadLine();
            string secondDate = Console.ReadLine();
            DateModifier dates = new DateModifier();
            Console.WriteLine(dates.CalculateDifference(firstDate, secondDate));
        }
    }
}
