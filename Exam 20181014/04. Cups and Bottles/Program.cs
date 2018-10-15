using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Cups_and_Bottles
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputCaps = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var inputBottles = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var cups = new Queue<int>(inputCaps.Length);
            var bottles = new Stack<int>(inputBottles.Length);
            var wastedLittersOfWater = 0;

            foreach (var cap in inputCaps)
            {
                cups.Enqueue(cap);
            }

            foreach (var litr in inputBottles)
            {
                bottles.Push(litr);
            }

            while (true)
            {
                var cup = cups.Dequeue();
                
                while (true)
                {
                    var bottle = bottles.Pop();
                   
                    if (bottle >= cup)
                    {
                        wastedLittersOfWater += bottle - cup;
                        break;
                    }
                    else
                    {
                        cup -= bottle;
                    }

                    if (cup <= 0 || bottles.Count == 0)
                    {
                        break;
                    }
                }

                if (bottles.Count == 0)
                {
                    Console.WriteLine($"Cups: {string.Join(' ', cups)}\nWasted litters of water: {wastedLittersOfWater}");
                    return;
                }

                if (cups.Count == 0)
                {
                    Console.WriteLine($"Bottles: {string.Join(' ', bottles)}\nWasted litters of water: {wastedLittersOfWater}");
                    return;
                }
            }
        }
    }
}
