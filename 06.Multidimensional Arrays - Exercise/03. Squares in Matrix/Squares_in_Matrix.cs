using System;
using System.Linq;

namespace _03._Squares_in_Matrix
{
    class Squares_in_Matrix
    {
        static void Main(string[] args)
        {
            var sizes = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var matrix = new char[sizes[0], sizes[1]];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                var input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = input[j][0];
                }
            }

            var sountOfEqualChars = 0;
            for (int i = 0; i < (matrix.GetLength(0)-1); i++)
            {
                for (int j = 0; j < (matrix.GetLength(1)-1); j++)
                {
                    if (matrix[i, j] == matrix[i, j+1] 
                        && matrix[i, j] == matrix[i + 1, j] 
                        && matrix[i, j] == matrix[i + 1, j + 1])
                    {
                        sountOfEqualChars++;
                    }
                }
            }

            Console.WriteLine(sountOfEqualChars);
        }
    }
}
