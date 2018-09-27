using System;

namespace _08._Pascal_Triangle
{
    class Pascal_Triangle
    {
        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());

            var pascal = new long[input][];

            for (int i = 0; i < input; i++)
            {
                pascal[i] = new long[i+1];
                pascal[i][0] = 1;
                pascal[i][i] = 1;

                for (int j = 1; j < i; j++)
                {
                    pascal[i][j] = pascal[i - 1][j - 1] + pascal[i - 1][j];
                }
            }

            foreach (var row in pascal)
            {
                Console.WriteLine(string.Join(' ',row));
            }
        }
    }
}
