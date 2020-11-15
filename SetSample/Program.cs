using System;
using System.Collections.Generic;

namespace SetSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var companyTeams = new HashSet<string>() { "Ferrari", "McLaren", "Mercedes" };

            var traditionalTeams = new HashSet<string>() { "Ferrari", "McLaren" };

            var privateTeams = new HashSet<string>() { "Red Bull", "Toro Rosso", "Force India", "Sauber" };

            if (privateTeams.Add("Williams"))
            {
                Console.WriteLine("Williams added");
            }

            if (!companyTeams.Add("McLaren"))
            {
                Console.WriteLine("McLaren was already in this set");
            }

            if (traditionalTeams.IsSubsetOf(companyTeams))
            {
                Console.WriteLine("tranditionalTeams is subset of companyTeams");
            }

            if (companyTeams.IsSupersetOf(traditionalTeams))
            {
                Console.WriteLine("companyTeams is a superset of tranditionalTeams");
            }

            traditionalTeams.Add("Williams");

            if (privateTeams.Overlaps(traditionalTeams))
            {
                Console.WriteLine("At least one team is the same with traditional and private teams");
            }

            var allTeams = new SortedSet<string>(companyTeams);
            allTeams.UnionWith(privateTeams);
            allTeams.UnionWith(traditionalTeams);
            Console.WriteLine();
            Console.WriteLine("All teams");

            foreach (var team in allTeams)
            {
                Console.WriteLine(team);
            }

            allTeams.ExceptWith(privateTeams);
            Console.WriteLine();
            Console.WriteLine("no private team left");

            foreach (var team in allTeams)
            {
                Console.WriteLine(team);
            }
        }
    }
}
