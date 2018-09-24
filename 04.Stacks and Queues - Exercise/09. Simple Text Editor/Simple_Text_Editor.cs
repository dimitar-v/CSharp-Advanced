using System;
using System.Collections.Generic;

namespace _09._Simple_Text_Editor
{
    class Simple_Text_Editor
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            var stack = new Stack<string>();
            var text = "";

            for (int i = 0; i < num; i++)
            {
                var input = Console.ReadLine().Split();

                switch (input[0])
                {
                    case "1":
                        stack.Push(text);
                        text += input[1];
                        break;
                    case "2":
                        stack.Push(text);
                        int count = int.Parse(input[1]);
                        text = text.Substring(0, text.Length - count);
                        break;
                    case "3":
                        int index = int.Parse(input[1]) - 1;
                        Console.WriteLine(text[index]);
                        break;
                    case "4":
                        text = stack.Pop();
                        break;
                }
            }
        }
    }
}
