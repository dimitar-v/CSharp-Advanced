using System;
using System.Linq;

namespace _04._Find_Evens_or_Odds
{
    class Find_Evens_or_Odds
    {
        static void Main(string[] args)
        {
            Predicate<int> isEven = n => n % 2 == 0;
            Predicate<int> isOdd = n => n % 2 != 0;

            var range = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var command = Console.ReadLine();

            switch (command)
            {
                case "odd":
                    PrintSpecialNums(range[0], range[1], isOdd);
                    break;
                case "even":
                    PrintSpecialNums(range[0], range[1], isEven);
                    break;
            }

        }

        private static void PrintSpecialNums(int from, int to, Predicate<int> isSpecial)
        {
            for (int i = from; i <= to; i++)
            {
                if (isSpecial(i))
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
