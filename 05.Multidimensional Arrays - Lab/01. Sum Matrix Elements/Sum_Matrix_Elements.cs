using System;
using System.Linq;

namespace _01._Sum_Matrix_Elements
{
    class Sum_Matrix_Elements
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var row = sizes[0];
            var col = sizes[1];

            int[,] matrix = new int[row, col];

            for (int i = 0; i < row; i++)
            {
                int[] input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

                for (int j = 0; j < col; j++)
                {
                    matrix[i, j] = input[j];
                }
            }

            var sum = 0;

            foreach (var element in matrix)
            {
                sum += element;
            }

            Console.WriteLine(matrix.GetLength(0));
            Console.WriteLine(matrix.GetLength(1));
            Console.WriteLine(sum);
        }
    }
}
