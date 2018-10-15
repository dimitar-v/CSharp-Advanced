using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Tagram
{
    class Program
    {
        static void Main(string[] args)
        {
            var users = new Dictionary<string, Dictionary<string, int>>();

            string input;

            while ((input = Console.ReadLine()) != "end")
            {
                if (input.Contains("ban "))
                {
                    var name = input.Remove(0, 4).Trim();

                    if (users.ContainsKey(name))
                    {
                        users.Remove(name);
                    }
                }
                else
                {
                    var data = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                    var user = data[0];
                    var tag = data[1];
                    var likes = int.Parse(data[2]);

                    if (!users.ContainsKey(user))
                    {
                        users[user] = new Dictionary<string, int>();
                    }

                    if (!users[user].ContainsKey(tag))
                    {
                        users[user][tag] = 0;
                    }
                    users[user][tag] += likes;
                }
            }

            foreach (var name in users.Keys.OrderByDescending(n => users[n].Values.Sum()).ThenBy(n => users[n].Count))
            {
                Console.WriteLine(name);
                foreach (var tag in users[name].Keys)
                {
                    Console.WriteLine($"- {tag}: {users[name][tag]}");
                }
            }
        }
    }
}
