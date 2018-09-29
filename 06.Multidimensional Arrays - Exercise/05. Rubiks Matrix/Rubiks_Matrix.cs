using System;
using System.Linq;

namespace _05._Rubiks_Matrix
{
    class Rubiks_Matrix
    {
        static void Main(string[] args)
        {
            var sizes = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var matrixRubiks = new int[sizes[0], sizes[1]];

            var count = 1;
            for (int i = 0; i < matrixRubiks.GetLength(0); i++)
            {
                for (int j = 0; j < matrixRubiks.GetLength(1); j++)
                {
                    matrixRubiks[i, j] = count++; 
                }
            }

            var commandCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < commandCount; i++)
            {
                var command = Console.ReadLine().Split();
                var target = int.Parse(command[0]);
                var moves = int.Parse(command[2]);
                switch (command[1])
                {
                    case "up":
                        matrixRubiks = RotateMatrics(matrixRubiks, target, moves, true);
                        break;
                    case "down":
                        matrixRubiks = RotateMatrics(matrixRubiks, target, -moves, true);
                        break;
                    case "left":
                        matrixRubiks = RotateMatrics(matrixRubiks, target, moves, false);
                        break;
                    case "right":
                        matrixRubiks = RotateMatrics(matrixRubiks, target, -moves, false);
                        break;
                    default:
                        break;
                }
            }
            //PrintMatrix(matrixRubiks);
            count = 1;
            for (int i = 0; i < matrixRubiks.GetLength(0); i++)
            {
                for (int j = 0; j < matrixRubiks.GetLength(1); j++)
                {
                    if (matrixRubiks[i, j] == count)
                    {
                        Console.WriteLine("No swap required");
                    }
                    else 
                    {
                        matrixRubiks = SwapMatrix(matrixRubiks, i, j, count);
                    }

                    count++;
                }
            }

            //PrintMatrix(matrixRubiks);
        }

        private static int[,] SwapMatrix(int[,] matrixRubiks, int r, int c, int count)
        {
            for (int i = r; i < matrixRubiks.GetLength(0); i++)
            {
                for (int j = 0; j < matrixRubiks.GetLength(1); j++)
                {
                    if (matrixRubiks[i,j] == count)
                    {
                        Console.WriteLine($"Swap ({r}, {c}) with ({i}, {j})");
                        var temp = matrixRubiks[r, c];
                        matrixRubiks[r, c] = matrixRubiks[i, j];
                        matrixRubiks[i, j] = temp;
                        return matrixRubiks;
                    } 
                }
            }
            return matrixRubiks;
        }

        static int[,] RotateMatrics(int[,] matrix, int tar, int moves, bool isColumn)
        {
            var targetLenght = isColumn ? matrix.GetLength(1) : matrix.GetLength(0);
            moves %= targetLenght;

            if (moves < 0)
            {
                moves += targetLenght;
            }

            for (int i = 0; i < moves; i++)
            {
                var temp = isColumn ? matrix[0, tar] : matrix[tar, 0];
                for (int j = 0; j < targetLenght - 1; j++)
                {
                    if (isColumn)
                    {
                        matrix[j, tar] = matrix[j + 1, tar];
                    }
                    else
                    {
                        matrix[tar, j] = matrix[tar, j + 1];
                    }
                    
                }
                if (isColumn)
                {
                    matrix[targetLenght - 1, tar] = temp;
                }
                else
                {
                    matrix[tar, targetLenght - 1] = temp;
                }
                
            }

            return matrix;
        }

        static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine(matrix[i, matrix.GetLength(1) - 1]);
            }
        }
    }
}
