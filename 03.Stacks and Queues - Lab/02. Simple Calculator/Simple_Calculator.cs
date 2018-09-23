using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Simple_Calculator
{
    class Simple_Calculator
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(' ').Reverse();
            Stack<string> stack = new Stack<string>();

            foreach (var item in input)
            {
                stack.Push(item);
            }

            while (stack.Count > 1)
            {
                int fisrtOperand = int.Parse(stack.Pop());
                string operand = stack.Pop();
                int secondOperand = int.Parse(stack.Pop());

                switch (operand)
                {
                    case "+":
                        stack.Push((fisrtOperand + secondOperand).ToString());
                        break;
                    case "-":
                        stack.Push((fisrtOperand - secondOperand).ToString());
                        break;
                }
            }

            Console.WriteLine(stack.Peek());
        }
    }
}
