using System;
using System.IO;

namespace _01._Odd_Lines
{
    class Odd_Lines
    {
        static void Main(string[] args)
        {
            var path = "../../../../files/";
            var fileName = "text.txt";

            path = Path.Combine(path, fileName);

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                var counter = 0;
                while ((line = reader.ReadLine()) != null)
                {
                    if (counter++ % 2 == 1)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
        }
    }
}
