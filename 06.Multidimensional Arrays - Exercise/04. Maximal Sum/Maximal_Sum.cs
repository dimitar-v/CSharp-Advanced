using System;
using System.Linq;

namespace _04._Maximal_Sum
{
    class Maximal_Sum
    {
        static void Main(string[] args)
        {
            var sizes = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var matrix = new int[sizes[0], sizes[1]];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                var input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = input[j];
                }
            }

            var maxSum = int.MinValue;
            var indexX = 0;
            var indexY = 0;
            for (int i = 0; i < (matrix.GetLength(0) - 2); i++)
            {
                for (int j = 0; j < (matrix.GetLength(1) - 2); j++)
                {
                    var sum = matrix[i, j] + matrix[i, j + 1] + matrix[i, j + 2]
                        + matrix[i + 1, j] + matrix[i + 1, j + 1] + matrix[i + 1, j + 2]
                        + matrix[i + 2, j] + matrix[i + 2, j + 1] + matrix[i + 2, j + 2];

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        indexX = i;
                        indexY = j;
                    }
                }

            }

            Console.WriteLine("Sum = " + maxSum);
            Console.WriteLine(matrix[indexX, indexY] + " " + matrix[indexX, indexY + 1] + " " + matrix[indexX, indexY + 2]);
            Console.WriteLine(matrix[indexX + 1, indexY] + " " + matrix[indexX + 1, indexY + 1] + " " + matrix[indexX + 1, indexY + 2]);
            Console.WriteLine(matrix[indexX + 2, indexY] + " " + matrix[indexX + 2, indexY + 1] + " " + matrix[indexX + 2, indexY + 2]);
        }
    }
}
