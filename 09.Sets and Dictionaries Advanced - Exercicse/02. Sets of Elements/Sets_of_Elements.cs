using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Sets_of_Elements
{
    class Sets_of_Elements
    {
        static void Main(string[] args)
        {
            var n = new HashSet<string>();
            var m = new HashSet<string>();

            var nums = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse) 
                .ToArray();

            for (int i = 0; i < nums[0]; i++)
            {
                n.Add(Console.ReadLine());
            }

            for (int i = 0; i < nums[1]; i++)
            {
                m.Add(Console.ReadLine());
            }

            var commonNums = n.Intersect(m);

            Console.WriteLine(string.Join(' ', commonNums));

            //foreach (var item in n)
            //{
            //    if (m.Contains(item))
            //    {
            //        Console.Write(item + " ");
            //    }
            //}
        }
    }
}
