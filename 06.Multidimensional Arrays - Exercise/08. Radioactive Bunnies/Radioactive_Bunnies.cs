using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Radioactive_Bunnies
{
    class Radioactive_Bunnies
    {
        static char[][] lair;
        static void Main(string[] args)
        {
            var sizes = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            lair = new char[sizes[0]][];
            var player = FillLair(sizes[1]);
            lair[player[0]][player[1]] = '.';
            var moves = Console.ReadLine().ToCharArray();

            for (int i = 0; i < moves.Length; i++)
            {
                var prevX = player[0];
                var prevY = player[1];
                switch (moves[i])
                {
                    case 'U':
                        player[0]--;
                        break;
                    case 'D':
                        player[0]++;
                        break;
                    case 'L':
                        player[1]--;
                        break;
                    case 'R':
                        player[1]++;
                        break;
                    //default:
                    //    Console.WriteLine("Ivalid move!");
                    //    break;
                }

                BunniesSpread( sizes[0], sizes[1]);

                if (player[0] < 0 || player[0] == sizes[0] || player[1] < 0 || player[1] == sizes[1])
                {
                    PrintLair();
                    Console.WriteLine($"won: {prevX} {prevY}");
                    break;
                }

                if (lair[player[0]][player[1]] == 'B')
                {
                    PrintLair();
                    Console.WriteLine($"dead: {player[0]} {player[1]}");
                    break;
                }


            }
        }

        private static void BunniesSpread(int rows, int cols)
        {
            var bunnies = new Queue<int[]>();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (lair[i][j] == 'B')
                    {
                        bunnies.Enqueue(new int[] { i, j });
                    }
                }
            }

            while (bunnies.Count > 0)
            {
                var bunny = bunnies.Dequeue();

                if (bunny[0] > 0)
                {
                    lair[bunny[0] - 1][bunny[1]] = 'B';
                }

                if (bunny[0] < rows - 1)
                {
                    lair[bunny[0] + 1][bunny[1]] = 'B';
                }

                if (bunny[1] > 0)
                {
                    lair[bunny[0]][bunny[1] - 1] = 'B';
                }

                if (bunny[1] < cols - 1)
                {
                    lair[bunny[0]][bunny[1] + 1] = 'B';
                }
            }
        }

        private static void PrintLair()
        {
            foreach (var row in lair)
            {
                Console.WriteLine(string.Join("", row));
            }
        }

        private static int[] FillLair(int col)
        {
            var player = new int[2];
            for (int i = 0; i < lair.Length; i++)
            {
                var input = Console.ReadLine();
                lair[i] = new char[col];
                for (int j = 0; j < col; j++)
                {
                    lair[i][j] = input[j];
                    if (input[j] == 'P')
                    {
                        player[0] = i;
                        player[1] = j;
                    }
                }
            }
            return player;
        }
    }
}
