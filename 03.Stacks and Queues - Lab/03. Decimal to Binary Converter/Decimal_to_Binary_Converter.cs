using System;
using System.Collections.Generic;

namespace _03._Decimal_to_Binary_Converter
{
    class Decimal_to_Binary_Converter
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            if (num == 0)
            {
                Console.WriteLine(0);
                return;
            }

            Stack<int> binary = new Stack<int>();

            while (num != 0)
            {
                binary.Push(num % 2);
                 num /= 2;
            }

            while (binary.Count != 0)
            {
                Console.Write(binary.Pop());
            }

            Console.WriteLine();
        }
    }
}
