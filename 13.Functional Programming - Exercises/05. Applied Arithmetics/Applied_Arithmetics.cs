using System;
using System.Linq;

namespace _05._Applied_Arithmetics
{
    class Applied_Arithmetics
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Func<int[], int[]> funcAddOne = n => n.Select(x => ++x).ToArray();
            Func<int[], int[]> funcSubtractOne = n => n.Select(x => --x).ToArray();
            Func<int[], int[]> funcMultiplyBy2 = n => n.Select(x => x * 2).ToArray();
            Action<int[]> print = n => Console.WriteLine(string.Join(' ', n));

            string command;
            while ((command = Console.ReadLine().ToLower()) != "end")
            {
                switch (command)
                {
                    case "add":
                        nums = funcAddOne(nums);
                        break;
                    case "subtract":
                        nums = funcSubtractOne(nums);
                        break;
                    case "multiply":
                        nums = funcMultiplyBy2(nums);
                        break;
                    case "print":
                        print(nums);
                        break;
                }
            }
        }
    }
}
