using System;
using System.Collections.Generic;
using System.Linq;

namespace _12._Inferno_III
{
    class Inferno_III
    {
        static void Main(string[] args)
        {
            var filters = new Dictionary<string, List<int>>();
            var gems = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            Func<int, int, bool> predicate;

            string input;
            while ((input = Console.ReadLine()) != "Forge")
            {
                var commands = input.Split(';', StringSplitOptions.RemoveEmptyEntries);

                var actionName = commands[1];
                var value = int.Parse(commands[2]);

                switch (commands[0])
                {
                    case "Exclude":
                        if (!filters.ContainsKey(actionName))
                        {
                            filters[actionName] = new List<int>();
                        }
                        filters[actionName].Add(value);
                        break;
                    case "Reverse":
                        if (filters.ContainsKey(actionName))
                        {
                            filters[actionName].Remove(value);
                        }
                        break;
                }
            }

            gems.Insert(0, 0);
            gems.Insert(gems.Count, 0);
            var nums = new List<int>();
            nums.Add(0);
            for (int i = 1; i < gems.Count - 1; i++)
            {
                foreach (var kvp in filters)
                {
                    var actionName = kvp.Key;
                    foreach (var value in kvp.Value)
                    {
                        predicate = GetPredicate(actionName, gems);
                        if(predicate(i, value))
                        {
                            nums.Add(i);
                        }
                    }
                }
            }
            nums.Add(gems.Count - 1);
            nums.Reverse();
            foreach (var i in nums)
            {
                gems.RemoveAt(i);
            }

            Console.WriteLine(string.Join(' ', gems));            
        }

        private static Func<int, int, bool> GetPredicate(string actionName, List<int> gems)
        {
            switch (actionName)
            {
                case "Sum Left": return (i, t) => gems[i - 1] + gems[i] == t;
                case "Sum Right": return (i, t) =>  gems[i] + gems[i + 1] == t;
                case "Sum Left Right": return (i, t) => gems[i - 1] + gems[i] + gems[i + 1] == t;
                default: return (i, t) => true;
            }
        }
    }
}
