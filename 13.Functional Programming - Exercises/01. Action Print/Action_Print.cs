using System;
using System.Linq;

namespace _01._Action_Print
{
    class Action_Print
    {
        static void Main(string[] args)
        {
            Action<string> print = s => Console.WriteLine(s);

            Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList()
                .ForEach(print);
        }
    }
}