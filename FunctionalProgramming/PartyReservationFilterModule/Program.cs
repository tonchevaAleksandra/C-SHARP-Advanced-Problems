using System;
using System.Collections.Generic;
using System.Linq;

namespace PartyReservationFilterModule
{
    class Program
    {
        static void Main(string[] args)
        {
            var reservations = Console.ReadLine()
                .Split()
                .ToList();

          
            List<string> filters = new List<string>();
            string input;
           
            while ((input=Console.ReadLine())!="Print")
            {
                var cmdArgs = input.Split(";");
                string command = cmdArgs[0];
                string filter = cmdArgs[1];
                string param = cmdArgs[2];
                //filters= GetFilters(filters, command, filter, param);

                switch (command)
                {
                    case "Add filter":
                        filters.Add(filter + " " + param);

                        break;
                    case "Remove filter":
                        if (filters.Contains(filter + " " + param))
                            filters.Remove(filter + " " + param);
                        break;

                }

            }

            foreach (var item in filters)
            {
                string[] filterArgs = item.Split();
                string filter = filterArgs[0] + " " + filterArgs[1];
                string param = filterArgs[2];
                Predicate<string> predicate = GetPredicate(filter, param);
                reservations.RemoveAll(predicate);
            }

            if(reservations.Any())
            Console.WriteLine(string.Join(" ", reservations));
          
        }

        //static List<string> GetFilters(List<string> filters, string command, string filter, string param)
        //{
        //    switch (command)
        //    {
        //        case "Add filter":
        //            filters.Add(filter + " " + param);

        //            break;
        //        case "Remove filter":
        //           if(filters.Contains(filter + " " + param))
        //                    filters.Remove(filter + " " + param);
        //            break;
               
        //    }
        //    return filters;
        //}

        static Predicate<string> GetPredicate(string filter, string param)
        {
           
            Predicate<string> predicate  = filter switch
            {
                   "Starts with" => predicate =new Predicate<string>(name=>
                    name.StartsWith(param)),
                  "Ends with" => predicate= new Predicate<string>(name=>
                  name.EndsWith(param)),
                  "Length" => predicate= new Predicate<string>(name=>
                  name.Length==int.Parse(param)),
                  "Contains" =>predicate= new Predicate<string>(name=>
                  name.Contains(param)),
                  _=>null
            };

            return predicate;
        }
    }
}
