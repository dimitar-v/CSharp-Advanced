using System;
using System.Collections.Generic;

namespace _06._Traffic_Jam
{
    class Traffic_Jam
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Queue<string> traffic = new Queue<string>();
            int count = 0;
            string command;

            while ((command = Console.ReadLine()) != "end")
            {
                if (command == "green")
                {
                    for (int i = 0; i < num; i++)
                    {
                        if (traffic.Count == 0)
                        {
                            break;
                        }
                        Console.WriteLine(traffic.Dequeue() + " passed!");
                        count++;
                    }
                }
                else
                {
                    traffic.Enqueue(command);
                }
            }

            Console.WriteLine(count + " cars passed the crossroads.");
        }
    }
}
