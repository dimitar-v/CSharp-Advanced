using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Average_Student_Grades
{
    class Average_Student_Grades
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());

            var grades = new Dictionary<string, List<double>>();

            for (int i = 0; i < num; i++)
            {
                var input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (!grades.ContainsKey(input[0]))
                {
                    grades[input[0]] = new List<double>();
                }

                grades[input[0]].Add(double.Parse(input[1]));
            }

            foreach (var name in grades.Keys)
            {
                Console.WriteLine($"{name} -> {string.Join(' ', grades[name].Select(i => i.ToString("F2")))} (avg: {grades[name].Average():F2})");
            }
        }
    }
}
