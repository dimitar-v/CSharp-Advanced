using System;
using System.Collections.Generic;

namespace _01._Reverse_Strings
{
    class Reverse_Strings
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Stack<char> stack = new Stack<char>(input);

            while(stack.Count > 0)
            {
                Console.Write(stack.Pop());
            }

            Console.WriteLine();
        }
    }
}
