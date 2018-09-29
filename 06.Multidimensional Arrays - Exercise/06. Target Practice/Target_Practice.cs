using System;
using System.Linq;

namespace _06._Target_Practice
{
    class Target_Practice
    {
        static void Main(string[] args)
        {
            var sizes = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var snake = Console.ReadLine().Trim();
            var shot = Console.ReadLine()
               .Split(' ', StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToArray();

            var matrix = new char[sizes[0]][];
            
            GetMatrix(matrix, sizes[1], snake);

            ShotgunMatrix(matrix, shot[0], shot[1], shot[2]);

            FallingDown(matrix);

            PrintMatrix(matrix);
        }

        private static void FallingDown(char[][] matrix)
        {
            
            for (int i = matrix[0].Length - 1; i >= 0; i--)
            {
                int indexEmpty = -1;
                for (int j = matrix.Length - 1; j >= 0; j--)
                {

                    if (indexEmpty == -1 && matrix[j][i] == ' ')
                    {
                        indexEmpty = j;
                    }

                    if (indexEmpty > -1 && matrix[j][i] != ' ')
                    {
                        matrix[indexEmpty][i] = matrix[j][i];
                        matrix[j][i] = ' ';
                        indexEmpty--;
                    }
                }
            }
        }

        private static void ShotgunMatrix(char[][] matrix, int r, int c, int range)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if (Math.Pow(i - r, 2) + Math.Pow(j - c, 2) <= Math.Pow(range, 2))
                    {
                        matrix[i][j] = ' ';
                    }
                }
            }
        }

        private static void GetMatrix(char[][] matrix, int size, string snake)
        {
            var count = 0;
            var snakeLen = snake.Length;
            for (int i = matrix.Length - 1; i >= 0; i--)
            {
                var arr = new char[size];
                if ((matrix.GetLength(0) - i) % 2 == 1)
                {
                    for (int j = size - 1; j >= 0; j--)
                    {
                        count %= snakeLen;
                        arr[j] = snake[count++];
                    }
                }
                else
                {
                    for (int j = 0; j < size; j++)
                    {
                        count %= snakeLen;
                        arr[j] = snake[count++];
                    }
                }
                matrix[i] = arr;
            }
        }

        static void PrintMatrix(char[][] matrix)
        {
            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join("",row));
            }
        }
    }
}
