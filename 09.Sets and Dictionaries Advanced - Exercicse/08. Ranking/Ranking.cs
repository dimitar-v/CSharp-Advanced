using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Ranking
{
    class Ranking
    {
        static void Main(string[] args)
        {
            var contests = new Dictionary<string, string>();
            var candidate = new Dictionary<string, Dictionary<string, int>>();

            string input;

            while ((input = Console.ReadLine()) != "end of contests")
            {
                var contest = input.Split(':');
                contests[contest[0]] = contest[1];
            }

            while ((input = Console.ReadLine()) != "end of submissions")
            {
                var data = input.Split("=>");
                var contest = data[0];
                if (contests.ContainsKey(contest) && contests[contest] == data[1])
                {
                    var name = data[2];
                    var points = int.Parse(data[3]);

                    if (!candidate.ContainsKey(name))
                    {
                        candidate[name] = new Dictionary<string, int>();
                    }

                    if (!candidate[name].ContainsKey(contest) || candidate[name][contest] < points)
                    {
                        candidate[name][contest] = points;
                    }
                }
            }

            var bestCandidate = candidate.Keys.OrderByDescending(x => candidate[x].Values.Sum()).ToList()[0];

            Console.WriteLine($"Best candidate is {bestCandidate} with total {candidate[bestCandidate].Values.Sum()} points.");
            Console.WriteLine("Ranking:");

            foreach (var name in candidate.Keys.OrderBy(x => x))
            {
                Console.WriteLine(name);
                foreach (var contest in candidate[name].Keys.OrderByDescending(x => candidate[name][x]))
                {
                    Console.WriteLine($"#  {contest} -> {candidate[name][contest]}");
                }
            }
        }
    }
}
