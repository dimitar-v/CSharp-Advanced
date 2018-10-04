using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._The_V_Logger
{
    class The_V_Logger
    {
        static void Main(string[] args)
        {
            var followers = new Dictionary<string, HashSet<string>>(); // new Dictionary<string, Dictionary<string, HashSet<string>>>() "followers" and "following"
            var following = new Dictionary<string, int>();

            string input;

            while ((input = Console.ReadLine()) != "Statistics")
            {
                var data = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                switch (data[1])
                {
                    case "joined":
                        if (!followers.ContainsKey(data[0]))
                        {
                            followers[data[0]] = new HashSet<string>();
                            following[data[0]] = 0;
                        }
                        break;
                    case "followed":
                        if (data[0] != data[2] 
                            && following.ContainsKey(data[0]) 
                            && following.ContainsKey(data[2])
                            && !followers[data[2]].Contains(data[0]))
                        {
                            followers[data[2]].Add(data[0]);
                            following[data[0]]++;
                        }
                        break;
                }
            }

            var names = followers.Keys.OrderByDescending(x => followers[x].Count).ThenBy(x => following[x]);
            var i = 1;

            Console.WriteLine($"The V-Logger has a total of {names.Count()} vloggers in its logs.");
            foreach (var name in names)
            {
                Console.WriteLine($"{i}. {name} : {followers[name].Count} followers, {following[name]} following");
                if (i == 1)
                {
                    foreach (var user in followers[name].OrderBy(x => x))
                    {
                        Console.WriteLine($"*  {user}");
                    }
                }
                i++;
            }
        }
    }
}
