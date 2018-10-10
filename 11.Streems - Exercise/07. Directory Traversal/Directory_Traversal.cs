using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _07._Directory_Traversal
{
    class Directory_Traversal
    {
        static void Main(string[] args)
        {
            var path = "../../../../files/";
            var filesByType = new Dictionary< string, Dictionary<string, decimal>>();

            var files = Directory.GetFiles(path);

            foreach (var filePath in files)
            {
                var file = File.Open(filePath, FileMode.Open);

                var fileExtension = Path.GetExtension(filePath);
                var fileName = Path.GetFileName(filePath);
                var fileSize = Decimal.Divide(file.Length, 1024);

                if (!filesByType.ContainsKey(fileExtension))
                {
                    filesByType[fileExtension] = new Dictionary<string, decimal>();
                }

                if (!filesByType[fileExtension].ContainsKey(fileName))
                {
                    filesByType[fileExtension][fileName] = fileSize;
                }
            }

            var desctopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            using (var report = new StreamWriter(Path.Combine(desctopPath, "report.txt")))
            {
                foreach (var kvp in filesByType.OrderByDescending(e => e.Value.Count).ThenBy(e => e.Key))
                {
                    report.WriteLine(kvp.Key);
                    foreach (var file in kvp.Value.OrderBy(f => f.Value))
                    {
                        report.WriteLine($"--{file.Key} - {file.Value:F3}kb");
                    }
                }
            }
        }
    }
}
