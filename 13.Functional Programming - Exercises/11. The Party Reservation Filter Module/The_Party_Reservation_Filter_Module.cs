using System;
using System.Collections.Generic;
using System.Linq;

namespace _11._The_Party_Reservation_Filter_Module
{
    class The_Party_Reservation_Filter_Module
    {
        static void Main(string[] args)
        {
            var filters = new Dictionary<string, List<string>>();
            var reservation = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Predicate<string> predicate;

            string input;
            while ((input = Console.ReadLine()) != "Print")
            {
                var commands = input.Split(';', StringSplitOptions.RemoveEmptyEntries);

                var filterAction = commands[0];
                var filterType = commands[1];
                var value = commands[2];

                switch (filterAction)
                {
                    case "Add filter":
                        if (!filters.ContainsKey(filterType))
                        {
                            filters[filterType] = new List<string>();
                        }

                        filters[filterType].Add(value);
                        break;
                    case "Remove filter":
                        filters[filterType].Remove(value);
                        break;
                }
            }

            foreach (var kvp in filters)
            {
                var filterType = kvp.Key;
                foreach (var value in kvp.Value)
                {
                    predicate = GetPredicat(filterType, value);
                    reservation = ChangeReservarion(reservation, predicate);
                }
            }

            Console.WriteLine(string.Join(' ', reservation));
        }

        private static string[] ChangeReservarion(string[] reservation, Predicate<string> predicate) => reservation.Where(g => !predicate(g)).ToArray();

        private static Predicate<string> GetPredicat(string filterType, string value)
        {
            switch (filterType)
            {
                case "Starts with": return p => p.StartsWith(value);
                case "Ends with": return p => p.EndsWith(value);
                case "Length": return p => p.Length == int.Parse(value);
                case "Contains": return p => p.Contains(value);
                default: return null;
            }
        }
    }
}
