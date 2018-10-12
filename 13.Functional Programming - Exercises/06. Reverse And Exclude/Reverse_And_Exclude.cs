using System;
using System.Linq;

namespace _06._Reverse_And_Exclude
{
    class Reverse_And_Exclude
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Reverse()
                .ToArray();

            var div = int.Parse(Console.ReadLine());

            //with Func<>
            //Func<int, bool> funcIsNotDivided = n => n % div != 0;

            //Console.WriteLine(string.Join(' ', nums.Where(funcIsNotDivided)));

            //with Predicate<>
            Predicate<int> funcIsNotDivided = n => n % div != 0;

            Console.WriteLine(string.Join(' ', nums.Where(n => funcIsNotDivided(n))));
        }
    }
}
