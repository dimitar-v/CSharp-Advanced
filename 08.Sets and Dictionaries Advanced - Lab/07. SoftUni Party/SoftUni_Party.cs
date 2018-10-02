using System;
using System.Collections.Generic;

namespace _07._SoftUni_Party
{
    class SoftUni_Party
    {
        static void Main(string[] args)
        {
            var vip = new HashSet<string>();
            var regular = new HashSet<string>();

            string input;

            while ((input = Console.ReadLine())?.ToLower() != "party")
            {
                if (Char.IsDigit(input[0]))
                {
                    vip.Add(input);
                }
                else
                {
                    regular.Add(input);
                }
            }

            while ((input = Console.ReadLine())?.ToLower() != "end")
            {
                if (Char.IsDigit(input[0]))
                {
                    vip.Remove(input);
                }
                else
                {
                    regular.Remove(input);
                }
            }

            Console.WriteLine(vip.Count + regular.Count);

            foreach (var guest in vip)
            {
                Console.WriteLine(guest);
            }

            foreach (var guest in regular)
            {
                Console.WriteLine(guest);
            }
        }
    }
}
