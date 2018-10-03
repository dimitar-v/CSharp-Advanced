using System;
using System.Collections.Generic;

namespace _03._Periodic_Table
{
    class Periodic_Table
    {
        static void Main(string[] args)
        {
            var periodicTable = new SortedSet<string>();
            var num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                var input = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                foreach (var element in input)
                {
                    periodicTable.Add(element);
                }
            }

            Console.WriteLine(string.Join(' ', periodicTable));
        }
    }
}
