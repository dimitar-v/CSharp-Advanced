using System;
using System.Collections.Generic;

namespace _07._Balanced_Parenthesis
{
    class Balanced_Parenthesis
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var openParenthesesType = new Stack<int>();
            openParenthesesType.Push(-1); // in case "{}}"
            bool isBalanced = true;

            foreach (var ch in input)
            {
                switch (ch)
                {
                    case '(':
                        openParenthesesType.Push(0);
                        break;
                    case '[':
                        openParenthesesType.Push(1);
                        break;
                    case '{':
                        openParenthesesType.Push(2);
                        break;
                    case ')':
                        isBalanced = openParenthesesType.Pop() == 0;
                        break;
                    case ']':
                        isBalanced = openParenthesesType.Pop() == 1;
                        break;
                    case '}':
                        isBalanced = openParenthesesType.Pop() == 2;
                        break;
                }

                if (!isBalanced)
                {
                    Console.WriteLine("NO");
                    return;
                }
            }

            Console.WriteLine(openParenthesesType.Count == 1 ? "YES" : "NO"); // in case "{{}"
        }
    }
}
