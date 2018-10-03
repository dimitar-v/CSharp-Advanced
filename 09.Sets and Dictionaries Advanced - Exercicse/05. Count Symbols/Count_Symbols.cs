using System;
using System.Collections.Generic;

namespace _05._Count_Symbols
{
    class Count_Symbols
    {
        static void Main(string[] args)
        {
            var str = Console.ReadLine();

            var counter = new SortedDictionary<char, int>();

            foreach (var ch in str)
            {
                if (!counter.ContainsKey(ch))
                {
                    counter[ch] = 0;
                }

                counter[ch]++;
            }

            foreach (var kvp in counter)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value} time/s");
            }
        }
    }
}
