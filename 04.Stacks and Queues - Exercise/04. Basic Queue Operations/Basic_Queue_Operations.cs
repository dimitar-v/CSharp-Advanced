using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Basic_Queue_Operations
{
    class Basic_Queue_Operations
    {
        static void Main(string[] args)
        {
            var firstLine = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray(); ;
            int n = firstLine[0];
            int s = firstLine[1];
            int x = firstLine[2];

            var secondLine = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse);

            var queue = new Queue<int>(secondLine.Take(n));

            for (int i = 0; i < s; i++)
            {
                queue.Dequeue();
            }

            Console.WriteLine(queue.Contains(x) ? "true" : 
                queue.Count == 0 ? "0" : queue.Min() + "");
        }
    }
}
