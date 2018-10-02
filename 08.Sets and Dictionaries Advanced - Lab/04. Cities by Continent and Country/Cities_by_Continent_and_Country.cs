using System;
using System.Collections.Generic;

namespace _04._Cities_by_Continent_and_Country
{
    class Cities_by_Continent_and_Country
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());

            var cities = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < num; i++)
            {
                var input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                var continent = input[0];
                var country = input[1];
                var city = input[2];

                if (!cities.ContainsKey(continent))
                {
                    cities[continent] = new Dictionary<string, List<string>>();
                }

                if (!cities[continent].ContainsKey(country))
                {
                    cities[continent][country] = new List<string>();
                }

                cities[continent][country].Add(city);
            }

            foreach (var continent in cities.Keys)
            {
                Console.WriteLine(continent + ":");
                foreach (var country in cities[continent].Keys)
                {
                    Console.WriteLine($"    {country} -> {string.Join(", ", cities[continent][country])}");
                }
            }
        }
    }
}
