using System;

namespace _04._Symbol_in_Matrix
{
    class Symbol_in_Matrix
    {
        static void Main(string[] args)
        {
            var size = int.Parse(Console.ReadLine());
            var matrix = new char[size, size];

            for (int i = 0; i < size; i++)
            {
                var input = Console.ReadLine();

                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = input[j];
                }
            }

            var ch = Console.ReadLine();

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (matrix[i, j] == ch[0])
                    {
                        Console.WriteLine($"({i}, {j})");
                        return;
                    } 
                }
            }
            Console.WriteLine($"{ch[0]} does not occur in the matrix");
        }
    }
}
