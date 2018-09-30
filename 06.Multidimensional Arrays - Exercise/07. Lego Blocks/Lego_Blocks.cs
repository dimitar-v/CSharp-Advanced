using System;
using System.Linq;

namespace _07._Lego_Blocks
{
    class Lego_Blocks
    {
        static void Main(string[] args)
        {
            var size = int.Parse(Console.ReadLine());
            var jagged1 = new int[size][];
            var jagged2 = new int[size][];

            FillJagged(jagged1);
            FillJagged(jagged2);

            var firstRowLenght = jagged1[0].Length + jagged2[0].Length;
            var tottalCells = firstRowLenght;
            bool isFit = true;
            for (int i = 1; i < size; i++)
            {
                var currentRowLenght = jagged1[i].Length + jagged2[i].Length;
                tottalCells += currentRowLenght;
                if (isFit && firstRowLenght != currentRowLenght)
                {
                    isFit = false;
                }
            }

            if (isFit)
            {
                PrintRectangle(jagged1, jagged2);
            }
            else
            {
                Console.WriteLine("The total number of cells is: " + tottalCells);
            }

        }

        private static void PrintRectangle(int[][] jagged1, int[][] jagged2)
        {
            for (int i = 0; i < jagged1.Length; i++)
            { 
                Console.WriteLine($"[{string.Join(", ", jagged1[i])}, {string.Join(", ", jagged2[i].Reverse())}]");
            }
        }

        private static void FillJagged(int[][] jagged)
        {
            for (int i = 0; i < jagged.Length; i++)
            {
                jagged[i] = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
            }
        }
    }
}
