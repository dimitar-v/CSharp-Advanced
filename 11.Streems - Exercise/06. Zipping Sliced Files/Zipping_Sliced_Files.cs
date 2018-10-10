using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;

namespace _06._Zipping_Sliced_Files
{
    class Zipping_Sliced_Files
    {
        static List<string> fileNames;

        static void Main(string[] args)
        {
            var path = "../../../../files/";
            var parts = 5;
            fileNames = new List<string>();

            Slice(Path.Combine(path, "sliceMe.mp4"), path, parts);

            Assemble(fileNames, path);

        }

        static void Slice(string sourceFile, string destinationDirectory, int parts)
        {
            using (var source = new FileStream(sourceFile, FileMode.Open))
            {
                var buffer = new byte[4096];
                int readBytes;
                var size = Math.Ceiling((decimal)source.Length / parts);
                for (int i = 0; i < parts; i++)
                {
                    fileNames.Add($"Part-{i}.mp4.gz");
                    var totalBytes = 0;
        
                    using (GZipStream gz = new GZipStream(
                        new FileStream(Path.Combine(destinationDirectory, fileNames[i]), FileMode.Create),
                        CompressionMode.Compress, false))
                    {
                        while ((readBytes = source.Read(buffer, 0, buffer.Length)) != 0)
                        {
                            totalBytes += readBytes;

                            gz.Write(buffer, 0, readBytes);

                            if (totalBytes > size)
                            {
                                break;
                            }
                        }
                    }
                }
            }
        }

        static void Assemble(List<string> files, string destinationDirectory)
        {

            using (var newFile = new FileStream(Path.Combine(destinationDirectory, "assembled.mp4"), FileMode.Create))
            {
                var buffer = new byte[4096];
                int readBytes;

                foreach (var file in files)
                {
                    using (GZipStream gz = new GZipStream(
                        new FileStream(Path.Combine(destinationDirectory, file), FileMode.Open),
                        CompressionMode.Decompress, false))
                    {
                        while ((readBytes = gz.Read(buffer, 0, buffer.Length)) != 0)
                        {
                            newFile.Write(buffer, 0, readBytes);
                        }
                    }
                }
            }
        }
    }
}
