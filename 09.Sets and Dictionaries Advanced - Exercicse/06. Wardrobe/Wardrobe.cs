using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _06._Wardrobe
{
    class Wardrobe
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var wardrobe = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                var input = Regex.Split(Console.ReadLine(), " -> ");
                var color = input[0];
                var items = input[1].Split(',');

                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe[color] = new Dictionary<string, int>();
                }

                foreach (var item in items)
                {
                    if (!wardrobe[color].ContainsKey(item))
                    {
                        wardrobe[color][item] = 0;
                    }

                    wardrobe[color][item]++;
                }
            }

            var clothing = Console.ReadLine().Split(' ');
            var isColor = false;

            foreach (var color in wardrobe.Keys)
            {
                isColor = clothing[0] == color;
                Console.WriteLine(color + " clothes:");

                foreach (var item in wardrobe[color].Keys)
                {
                    Console.Write($"* {item} - {wardrobe[color][item]}");
                    Console.WriteLine(isColor && item == clothing[1]? " (found!)" : "");                  
                }
            }
        }
    }
}
