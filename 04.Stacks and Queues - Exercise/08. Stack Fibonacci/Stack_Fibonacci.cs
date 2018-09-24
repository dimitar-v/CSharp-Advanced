using System;
using System.Collections.Generic;

namespace _08._Stack_Fibonacci
{
    class Stack_Fibonacci
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            var fib = new Stack<long>(num + 1);

            fib.Push(0);
            fib.Push(1);

            for (int i = 1; i < num; i++)
            {
                long prev = fib.Pop();
                long prev2 = fib.Peek(); 
                fib.Push(prev);
                fib.Push(prev + prev2);
            }

            Console.WriteLine(fib.Pop());
        }
    }
}
