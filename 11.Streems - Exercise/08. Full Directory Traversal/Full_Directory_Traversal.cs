using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _08._Full_Directory_Traversal
{
    class Full_Directory_Traversal
    {
        static void Main(string[] args)
        {
            var path = "../../../../";
            var filesByType = new Dictionary<string, Dictionary<string, decimal>>();

            var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);

            foreach (var filePath in files)
            {
                var file = File.Open(filePath, FileMode.Open);

                var fileExtension = Path.GetExtension(filePath);
                var fileName = Path.GetFileName(filePath);
                var fileSize = Decimal.Divide(file.Length, 1024);
                var directory = Path.GetDirectoryName(filePath).Replace("..\\..\\..\\..", "");

                if (!filesByType.ContainsKey(fileExtension))
                {
                    filesByType[fileExtension] = new Dictionary<string, decimal>();
                }

                if (!filesByType[fileExtension].ContainsKey(directory + "/" + fileName))
                {
                    filesByType[fileExtension][directory + "/" + fileName] = fileSize;
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
