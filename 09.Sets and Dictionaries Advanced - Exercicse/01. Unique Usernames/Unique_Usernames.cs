using System;
using System.Collections.Generic;

namespace _01._Unique_Usernames
{
    class Unique_Usernames
    {
        static void Main(string[] args)
        {
            var usernames = new HashSet<string>();
            var num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                usernames.Add(Console.ReadLine());
            }

            foreach (var username in usernames)
            {
                Console.WriteLine(username);
            }
        }
    }
}
