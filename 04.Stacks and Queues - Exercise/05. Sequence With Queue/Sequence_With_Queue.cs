using System;
using System.Collections.Generic;

namespace _05._Sequence_With_Queue
{
    class Sequence_With_Queue
    {
        static void Main(string[] args)
        {
            long num = long.Parse(Console.ReadLine());

            var first50 = new Queue<long>(50);

            first50.Enqueue(num);

            for (int i = 0; i < 50; i+=3)
            {
                var s = first50.Dequeue();
                Console.Write(s + " ");
                first50.Enqueue(s + 1);
                first50.Enqueue(2*s + 1);
                first50.Enqueue(s + 2);
            }

            while (first50.Count > 2)
            {
                Console.Write(first50.Dequeue() + " ");
            }

            Console.WriteLine();
        }
    }
}
