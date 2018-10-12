using System;
using System.Linq;

namespace _13._TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            var total = int.Parse(Console.ReadLine());

            var namesList = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries); 

            Func<string, int, bool> isName = (name, i) => name.Sum(x => x) >= i;

            Func<string[], Func<string, int, bool>, string> returnName = (names, isN) => names.FirstOrDefault(n => isN(n, total));

            Console.WriteLine(returnName(namesList, isName));
        }
    }
}
