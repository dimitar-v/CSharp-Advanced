using System;
using System.Linq;

namespace _01._Sort_Even_Numbers
{
    class Sort_Even_Numbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine( string.Join(", ", Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Where(n => n % 2 == 0)
                .OrderBy(n => n)
                .ToArray()));
        }
    }
}
