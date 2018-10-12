using System;
using System.Linq;

namespace _03._Custom_Min_Function
{
    class Custom_Min_Function
    {
        static void Main(string[] args)
        {
            Func<int[], int> min = nums => 
            {
                var m = int.MaxValue;
                foreach (var n in nums)
                {
                    if (n < m)
                    {
                        m = n;
                    }
                }
                return m;
            };

            Console.WriteLine( min(Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray()));
        }
    }
}
