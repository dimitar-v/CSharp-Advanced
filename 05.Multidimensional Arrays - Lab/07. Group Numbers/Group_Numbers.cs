using System;
using System.Linq;

namespace _07._Group_Numbers
{
    class Group_Numbers
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var jaggedArr = new int[3][];

            jaggedArr[0] = input.Where(x => Math.Abs(x) % 3 == 0).ToArray(); 
            jaggedArr[1] = input.Where(x => Math.Abs(x) % 3 == 1).ToArray(); 
            jaggedArr[2] = input.Where(x => Math.Abs(x) % 3 == 2).ToArray();

            foreach (var arr in jaggedArr)
            {
                Console.WriteLine(string.Join(' ',arr));
            }
        }
    }
}
