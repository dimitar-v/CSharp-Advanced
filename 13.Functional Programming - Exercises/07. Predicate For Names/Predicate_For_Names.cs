using System;
using System.Linq;

namespace _07._Predicate_For_Names
{
    class Predicate_For_Names
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            Predicate<string> siNotMore = s => s.Length <= n;

            Console.WriteLine(string.Join(Environment.NewLine, Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Where(w => siNotMore(w))));
        }
    }
}
