using System;
using System.Linq;

namespace _02._Diagonal_Difference
{
    class Diagonal_Difference
    {
        static void Main(string[] args)
        {
            var size = int.Parse(Console.ReadLine());
            var matrix = new int[size, size];

            for (int i = 0; i < size; i++)
            {
                var row = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = row[j];
                }
            }

            var sumD1 = 0;
            var sumD2 = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                sumD1 += matrix[i, i];
                sumD2 += matrix[i, matrix.GetLength(0) - 1 - i];
            }

            Console.WriteLine(Math.Abs(sumD1 - sumD2));
        }
    }
}
