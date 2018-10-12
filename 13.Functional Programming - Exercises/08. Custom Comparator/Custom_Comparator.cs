using System;
using System.Linq;

namespace _08._Custom_Comparator
{
    class Custom_Comparator
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Func<int, int, int> sortFunc = (a,b) => 
                (a % 2 == 0 & b % 2 != 0) ? -1 : 
                (a % 2 != 0 & b % 2 == 0) ? 1 :
                a.CompareTo(b);

            Array.Sort(nums, new Comparison<int>(sortFunc));
            Console.WriteLine(string.Join(' ', nums));
        }
    }
}
