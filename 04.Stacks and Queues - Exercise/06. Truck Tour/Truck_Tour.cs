using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Truck_Tour
{
    class Truck_Tour
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var petrolPomps = new Queue<int>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                petrolPomps.Enqueue(input[0] - input[1]);
            }

            for (int i = 0; i < n; i++)
            {
                int truckTank = 0;
                foreach (var fuel in petrolPomps)
                {
                    truckTank += fuel;
                    if (truckTank < 0)
                    {
                        break;
                    }
                }

                if (truckTank >= 0)
                {
                    Console.WriteLine(i);
                    break;
                }

                petrolPomps.Enqueue(petrolPomps.Dequeue());
            }
        }
    }
}
