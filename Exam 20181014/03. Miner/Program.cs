using System;
using System.Linq;

namespace _03._Miner
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var directions = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            char[][] field = new char[n][];

            int rowM = -1;
            int colM = -1;
            int rowE = -1;
            int colE = -1;
            int coalCount = 0;
            int coalColected = 0;

            for (int i = 0; i < n; i++)
            {
                field[i] = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();

                if (field[i].Contains('s'))
                {
                    rowM = i;
                    colM = Array.IndexOf(field[i], 's');
                }

                if (field[i].Contains('e'))
                {
                    rowE = i;
                    colE = Array.IndexOf(field[i], 'e');
                }

                if (field[i].Contains('c'))
                {
                    for (int j = 0; j < field[i].Length; j++)
                    {
                        if (field[i][j] == 'c')
                        {
                            coalCount++;
                        }
                    }
                }
            }

            for (int i = 0; i < directions.Length; i++)
            {
                if (directions[i] == "up" && rowM - 1 > -1)
                {
                    MakeMove(field, ref rowM, ref colM, -1, 0, ref coalColected);
                }
                else if (directions[i] == "down" && rowM + 1 < field.Length)
                {
                    MakeMove(field, ref rowM, ref colM, +1, 0, ref coalColected);
                }
                else if (directions[i] == "left" && colM - 1 > -1)
                {
                    MakeMove(field, ref rowM, ref colM, 0, -1, ref coalColected);
                }
                else if (directions[i] == "right" && colM + 1 < field[rowM].Length)
                {
                    MakeMove(field, ref rowM, ref colM, 0, +1, ref coalColected);
                }

                if (coalColected == coalCount)
                {
                    Console.WriteLine($"You collected all coals! ({rowM}, {colM})");
                    return;
                }

                if (rowM == rowE && colM == colE)
                {
                    Console.WriteLine($"Game over! ({rowM}, {colM})");
                    return;
                }
            }

            Console.WriteLine($"{coalCount - coalColected} coals left. ({rowM}, {colM})");

        }

        private static void MakeMove(char[][] field, ref int rowM, ref int colM, int r, int c, ref int coalColected)
        {
            field[rowM][colM] = '*';
            rowM += r;
            colM += c;
            if (field[rowM][colM] == 'c')
            {
                coalColected++;
            }
            field[rowM][colM] = 's';
        }
    }
}
