using System;
using System.Linq;

namespace _02._Knights_of_Honor
{
    class Knights_of_Honor
    {
        static void Main(string[] args)
        {
            Action<string> printSirAndName = n => Console.WriteLine("Sir " + n);

            Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList()
                .ForEach(printSirAndName);
        }
    }
}
