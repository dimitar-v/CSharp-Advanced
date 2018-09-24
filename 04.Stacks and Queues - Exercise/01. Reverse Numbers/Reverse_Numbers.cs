using System;
using System.Collections.Generic;

namespace _01._Reverse_Numbers
{
    class Reverse_Numbers
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ');
            var reverce = new Stack<string>(nums);

            while (reverce.Count > 0)
            {
                Console.Write(reverce.Pop() + " ");
            }

            Console.WriteLine();
        }
    }
}
