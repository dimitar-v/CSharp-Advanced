using System;
using System.Collections.Generic;

namespace _04._Even_Times
{
    class Even_Times
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());

            var counter = new Dictionary<string, int>();

            for (int i = 0; i < num; i++)
            {
                var input = Console.ReadLine();

                if (!counter.ContainsKey(input))
                {
                    counter[input] = 0;
                }

                counter[input]++;
            }

            foreach (var kvp in counter)
            {
                if (kvp.Value%2 ==0)
                {
                    Console.WriteLine(kvp.Key);
                }
            }
        }
    }
}
