using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Filter_By_Age
{
    class Filter_By_Age
    {
        static void Main(string[] args)
        {
            List<KeyValuePair<string, int>> people = new List<KeyValuePair<string, int>>(); 
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(", ");
                people.Add(new KeyValuePair<string, int>(input[0], int.Parse(input[1])));
            }

            var condition = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            var format = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Func<KeyValuePair<string, int>, bool> filter = p => condition == "older" ? p.Value >= age : p.Value < age;

            printByFormat(people.Where(p => filter(p)), format);
        }

        private static void printByFormat(IEnumerable<KeyValuePair<string, int>> people, string[] format)
        {
            if (format.Length == 2)
            {
                foreach (var person in people)
                {
                    Console.WriteLine(format[0] == "age"? $"{person.Value} - {person.Key}" : $"{person.Key} - {person.Value}");
                }
            }
            else
            {
                foreach (var person in people)
                {
                    Console.WriteLine(format[0] == "age" ? $"{person.Value}" : $"{person.Key}");
                }
            }
        }
    }
}
