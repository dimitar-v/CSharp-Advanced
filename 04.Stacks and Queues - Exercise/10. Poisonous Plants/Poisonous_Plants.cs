using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._Poisonous_Plants
{
    class Poisonous_Plants
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var input = Console.ReadLine().Split();
            var plants = new Queue<long>(input.Take(num).Select(long.Parse));

            for (int i = 0; i < num; i++)
            {
                var first = plants.Dequeue();
                plants.Enqueue(first);
                var plantsCount = plants.Count;

                for (int j = 1; j < plantsCount; j++)
                {
                    var second = plants.Dequeue();
                    if (second <= first)
                    {
                        plants.Enqueue(second);
                    }

                    first = second;
                }

                if (plantsCount == plants.Count)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }
    }
}
