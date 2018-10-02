﻿using System;
using System.Collections.Generic;

namespace _05._Record_Unique_Names
{
    class Record_Unique_Names
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var names = new HashSet<string>();

            for (int i = 0; i < num; i++)
            {
                names.Add(Console.ReadLine());
            }

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
