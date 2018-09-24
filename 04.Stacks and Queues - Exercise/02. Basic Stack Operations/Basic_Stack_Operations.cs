using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Basic_Stack_Operations
{
    class Basic_Stack_Operations
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

            var stack = new Stack<int>(secondLine.Take(n));

            for (int i = 0; i < s; i++)
            {
                stack.Pop();
            }

            if (stack.Contains(x))
            {
                Console.WriteLine("true");
            }
            else if (stack.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(stack.Min());
            }
        }
    }
}
