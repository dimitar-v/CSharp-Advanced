using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Same_Values_in_Array
{
    class Count_Same_Values_in_Array
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();

            var counter = new Dictionary<double, int>();

            foreach (var num in nums)
            {
                if (!counter.ContainsKey(num))
                {
                    counter[num] = 0;
                }

                counter[num]++;
            }

            foreach (var key in counter.Keys)
            {
                Console.WriteLine($"{key} - {counter[key]} times");
            }
        }
    }
}
