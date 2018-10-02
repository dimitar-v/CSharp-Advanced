using System;
using System.Collections.Generic;

namespace _06._Parking_Lot
{
    class Parking_Lot
    {
        static void Main(string[] args)
        {
            var parking = new HashSet<string>();
            string input;

            while ((input = Console.ReadLine())?.ToLower() != "end")
            {
                var data = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);

                switch (data[0])
                {
                    case "IN":
                        parking.Add(data[1]);
                        break;
                    case "OUT":
                        parking.Remove(data[1]);
                        break;
                    default:
                        Console.WriteLine("Invalid input!");
                        break;
                }
            }

            if (parking.Count > 0)
            {
                foreach (var nums in parking)
                {
                    Console.WriteLine(nums);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
