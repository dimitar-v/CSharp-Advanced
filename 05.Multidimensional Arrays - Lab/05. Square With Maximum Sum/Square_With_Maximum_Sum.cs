using System;
using System.Linq;

namespace _05._Square_With_Maximum_Sum
{
    class Square_With_Maximum_Sum
    {
        static void Main(string[] args)
        {
            var sizes = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var row = sizes[0];
            var col = sizes[1];

            var matrix = new int[row, col];

            for (int i = 0; i < row; i++)
            {
                var input = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int j = 0; j < col; j++)
                {
                    matrix[i, j] = input[j];
                }
            }

            var maxSum = int.MinValue;
            var indexRow = 0;
            var indexCow = 0;

            for (int i = 0; i < (matrix.GetLength(0) - 1); i++)
            {
                for (int j = 0; j < (matrix.GetLength(1) - 1); j++)
                {
                    var sum = matrix[i, j] + matrix[i, j + 1]
                        + matrix[i + 1, j] + matrix[i + 1, j + 1];
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        indexRow = i;
                        indexCow = j;
                    }
                }
            }

            Console.WriteLine(matrix[indexRow, indexCow] + " " + matrix[indexRow, indexCow + 1]);
            Console.WriteLine(matrix[indexRow + 1, indexCow] + " " + matrix[indexRow + 1, indexCow + 1]);
            Console.WriteLine(maxSum);
        }
    }
}
