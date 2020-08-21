using System;
using System.Collections.Generic;
using System.Linq;

namespace Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            //input in the format "{contest}:{password for contest}" until you receive "end of contests"

            Dictionary<string, string> contestsPass = new Dictionary<string, string>();

            string input;
            while ((input = Console.ReadLine()) != "end of contests")
            {
                string[] arguments = input.Split(":");
                string contestName = arguments[0];
                string pass = arguments[1];
                contestsPass.Add(contestName, pass);
            }

            Dictionary<string, Dictionary<string, int>> students = new Dictionary<string, Dictionary<string, int>>();
            //"{contest}=>{password}=>{username}=>{points}" until you receive "end of submissions". 
            string input2;
            while ((input2 = Console.ReadLine()) != "end of submissions")
            {
                string[] inputArgs = input2.Split("=>");
                string contest = inputArgs[0];
                string password = inputArgs[1];
                string username = inputArgs[2];
                int points = int.Parse(inputArgs[3]);

                if (contestsPass.ContainsKey(contest) && contestsPass[contest] == password)
                {
                    if (!students.ContainsKey(username))
                    {
                        students.Add(username, new Dictionary<string, int>());
                        students[username].Add(contest, points);
                    }
                    else
                    {
                        if (!students[username].ContainsKey(contest))
                        {
                            students[username].Add(contest, points);
                        }
                        else if (students[username][contest] < points)
                        {
                            students[username][contest] = points;
                        }
                    }
                }
            }

            students = PrintResults(students);
        }

        private static Dictionary<string, Dictionary<string, int>> PrintResults(Dictionary<string, Dictionary<string, int>> students)
        {
            var bestStudents = students.OrderByDescending(x => x.Value.Values.Sum()).ToDictionary(x => x.Key, x => x.Value);
            var bestPointsStudent = bestStudents.Take(1);
            foreach (var item in bestPointsStudent)
            {
                Console.WriteLine($"Best candidate is {item.Key} with total {item.Value.Values.Sum()} points.");
            }
            Console.WriteLine("Ranking:");
            students = students.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

            foreach (var (key, value) in students)
            {
                Console.WriteLine($"{key}");
                foreach (var item in value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {item.Key} -> {item.Value}");
                }
            }

            return students;
        }
    }
}
