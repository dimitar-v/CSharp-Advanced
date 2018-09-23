using System;
using System.Collections.Generic;

namespace _05._Hot_Potato
{
    class Hot_Potato
    {
        static void Main(string[] args)
        {
            var kids = Console.ReadLine().Split(' ');
            var childrenRing = new Queue<string>(kids);
            int num = int.Parse(Console.ReadLine());

            while (childrenRing.Count > 1)
            {
                for (int i = 1; i < num; i++)
                {
                    childrenRing.Enqueue(childrenRing.Dequeue());
                }

                Console.WriteLine("Removed " + childrenRing.Dequeue());
            }

            Console.WriteLine("Last is " + childrenRing.Dequeue());
        }
    }
}
