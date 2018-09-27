using System;
using System.Linq;

namespace _02._Sum_Matrix_Columns
{
    class Sum_Matrix_Columns
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
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int j = 0; j < col; j++)
                {
                    matrix[i, j] = input[j];
                }
            }

            for (int i = 0; i < col; i++)
            {
                var sum = 0;
                for (int j = 0; j < row; j++)
                {
                    sum += matrix[j, i];
                }

                Console.WriteLine(sum);
            }
        }
    }
}
