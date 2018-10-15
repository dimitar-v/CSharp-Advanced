using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _01._Data_Transfer
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());

            var regex = "^s:(.*?);r:(.*?);m--\"([a-zA-Z ]*)\"$";

            int totalMb = 0;
            
            var result = new List<string>();

            for (int i = 0; i < num; i++)
            {
                var input = Console.ReadLine();

                Match valid = Regex.Match(input, regex);

                if (valid.Success)
                {
                    totalMb += valid.Value.ToString()
                        .Where(c => char.IsDigit(c))
                        .Select(c => c - '0')
                        .Sum();
                    string sender = ClearName(valid.Groups[1].ToString());
                    var receiver = ClearName(valid.Groups[2].ToString());
                    var message = valid.Groups[3];

                    result.Add($"{sender} says \"{message}\" to {receiver}");
                }
            }

            foreach (var line in result)
            {
                Console.WriteLine(line);
            }

            Console.WriteLine($"Total data transferred: {totalMb}MB");
        }

        private static string ClearName(string str) => string.Join("", str.Where(c => char.IsLetter(c) || c == ' ').ToArray());
    }
}
