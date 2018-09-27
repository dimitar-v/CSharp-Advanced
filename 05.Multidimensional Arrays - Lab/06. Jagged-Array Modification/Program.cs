using System;
using System.Linq;

namespace _06._Jagged_Array_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = int.Parse(Console.ReadLine());
            var matrix = new int[size][];

            for (int i = 0; i < matrix.Length; i++)
            {
                var row = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                matrix[i] = row; 
            }

            string input;

            while((input = Console.ReadLine()?.ToLower()) != "end")
            {
                var command = input
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                var row = int.Parse(command[1]);
                var col = int.Parse(command[2]);
                var value = int.Parse(command[3]);

                if (row < 0 || row > size - 1 || col < 0 || col > size - 1)
                {
                    Console.WriteLine("Invalid coordinates");
                    continue;
                }

                switch (command[0])
                {
                    case "add":
                        matrix[row][col] += value;
                        break;
                    case "subtract":
                        matrix[row][col] -= value;
                        break;
                    default:
                        Console.WriteLine("Invalid command");
                        break;
                }
            }

            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join(' ', row));
            }
        }
    }
}
