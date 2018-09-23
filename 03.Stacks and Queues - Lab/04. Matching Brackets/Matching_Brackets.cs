using System;
using System.Collections.Generic;

namespace _04._Matching_Brackets
{
    class Matching_Brackets
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<int> indexOfOpenBracket = new Stack<int>(input.Length);

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    indexOfOpenBracket.Push(i);
                }

                if (input[i] == ')')
                {
                    Console.WriteLine(input.Substring(indexOfOpenBracket.Peek(), i - indexOfOpenBracket.Pop() + 1));
                }
            }
        }
    }
}
