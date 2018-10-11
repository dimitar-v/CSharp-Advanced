using System;
using System.Linq;

namespace _03._Count_Uppercase_Words
{
    class Count_Uppercase_Words
    {
        static void Main(string[] args)
        {
            //Console.ReadLine()
            //    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            //    .Where(w => char.IsUpper(w[0]))
            //    .ToList()
            //    .ForEach(w => Console.WriteLine(w));

            var text = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Func<string, bool> IsUpper = w => w[0] == w.ToUpper()[0];

            text.Where(w => IsUpper(w))
                .ToList()
                .ForEach(w => Console.WriteLine(w));
        }
    }
}
