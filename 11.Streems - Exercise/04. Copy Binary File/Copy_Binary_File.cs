using System;
using System.IO;

namespace _04._Copy_Binary_File
{
    class Copy_Binary_File
    {
        static void Main(string[] args)
        {
            var path = "../../../../files/";

            using (var reader = new FileStream(Path.Combine(path, "copyMe.png"), FileMode.Open))
            {
                using (var writer = new FileStream(Path.Combine(path, "copy.png"), FileMode.Create))
                {
                    var buffer = new byte[4096];

                    int read;

                    while ((read = reader.Read(buffer, 0, buffer.Length)) != 0)
                    {
                        writer.Write(buffer, 0, read);
                    }

                }
            }
        }
    }
}
