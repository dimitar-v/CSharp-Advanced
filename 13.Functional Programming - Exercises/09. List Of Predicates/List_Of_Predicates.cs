using System;
using System.Linq;

namespace _09._List_Of_Predicates
{
    class List_Of_Predicates
    {
        static void Main(string[] args)
        {
            var end = int.Parse(Console.ReadLine());
            var divs = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Action<int> print = i => Console.Write(i + " ");

            Predicate<int> isNumFunc = n =>
            {
                foreach (var d in divs)
                {
                    if (n % d != 0)
                    {
                        return false;
                    }
                }
                return true;
            };

            for (int i = 1; i <= end; i++)
            {
                if (isNumFunc(i))
                {
                    print(i);
                }
            }

            Console.WriteLine();
        }
    }
}
