using System;
using System.Collections.Generic;
using System.Linq;

namespace AverageStudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<decimal>> grades = new Dictionary<string,List<decimal>> ();

            for (int i = 0; i < n; i++)
            {
                string[] inputArgs = Console.ReadLine()
           .Split()
           .ToArray();
                string name = inputArgs[0];
                decimal grade = decimal.Parse(inputArgs[1]);
                if(!grades.ContainsKey(name))
                {
                    grades.Add(name, new List<decimal>());
                }
                grades[name].Add( grade);
            }

            foreach (var (key,value) in grades)
            {
                string allGrades = string.Join(" ", value.Select(x => x.ToString("F2")));
                Console.WriteLine($"{key} -> {allGrades} (avg: {value.Average():f2})");
            }
        }
    }
}
