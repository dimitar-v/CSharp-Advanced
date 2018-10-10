using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03._Word_Count
{
    class Word_Count
    {
        static void Main(string[] args)
        {
            var wordCounter = new Dictionary<string, int>();
            var path = "../../../../files/";

            using (var reader = new StreamReader(Path.Combine(path, "words.txt")))
            {
                string word;

                while ((word = reader.ReadLine()?.ToLower()) != null)
                {
                    if (!wordCounter.ContainsKey(word))
                    {
                        wordCounter[word] = 0;
                    }
                }
            }

            using (var reader = new StreamReader(Path.Combine(path, "text.txt")))
            {
                string line;

                while ((line = reader.ReadLine()?.ToLower()) != null)
                {
                    var words = Regex.Split(line, @"[^A-Za-z]+");
                    var keys = new List<string>(wordCounter.Keys);
                    foreach (var word in keys)
                    {
                        wordCounter[word] += words.Where(x => x == word).Count();
                    }
                }
            }

            using (var writer = new StreamWriter(Path.Combine(path, "result.txt")))
            {
                foreach (var kvp in wordCounter.OrderByDescending(x => x.Value))
                {
                    writer.WriteLine(kvp.Key + " - " + kvp.Value);
                }
            }
        }
    }
}
