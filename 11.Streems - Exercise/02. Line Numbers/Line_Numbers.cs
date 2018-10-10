using System;
using System.IO;

namespace _02._Line_Numbers
{
    class Line_Numbers
    {
        static void Main(string[] args)
        {
            var path = "../../../../files/";
            var sorceFile = "text.txt";
            var fileWithLines = "output.txt";
            sorceFile = Path.Combine(path, sorceFile);
            fileWithLines = Path.Combine(path, fileWithLines);

            using (var reader = new StreamReader(sorceFile))
            {
                using (var writer = new StreamWriter(fileWithLines))
                {
                    string line;
                    var counter = 0;
                    while ((line = reader.ReadLine()) != null)
                    {
                        writer.WriteLine($"Line {++counter}: {line}");
                    }
                }
            }
        }
    }
}
