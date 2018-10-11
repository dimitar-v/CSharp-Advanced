using System;
using System.Linq;

namespace _04._Add_VAT
{
    class Add_VAT
    {
        static void Main(string[] args)
        {
            //Console.ReadLine()
            //    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
            //    .Select(p => double.Parse(p) * 1.2)
            //    .ToList()
            //    .ForEach(p => Console.WriteLine($"{p:F2}"));

            Func<string, string> AddVat = n => $"{double.Parse(n) * 1.2:F2}";

            Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(p => AddVat(p))
                .ToList()
                .ForEach(p => Console.WriteLine(p));
        }
    }
}
