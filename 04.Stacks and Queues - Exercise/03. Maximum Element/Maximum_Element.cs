using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Maximum_Element
{
    class Maximum_Element
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            var stack = new Stack<byte>(105);

            for (int i = 0; i < num; i++)
            {
                var command = Console.ReadLine().Split(' ').Select(byte.Parse).ToArray();

                switch (command[0])
                {
                    case 1:
                        stack.Push(command[1]);
                        break;
                    case 2:
                        stack.Pop();
                        break;
                    case 3:
                        Console.WriteLine(stack.Max());
                        break;
                }
            }
        }
    }
}
