using System;
using System.Linq;

namespace _02._Sum_Numbers
{
    class Sum_Numbers
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Console.WriteLine(nums.Length + Environment.NewLine + nums.Sum());
        }
    }
}
