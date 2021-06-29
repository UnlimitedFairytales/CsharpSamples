using System;
using System.IO;
using System.IO.Compression;

namespace UnlimitedFairytales.CsharpSamples.Zip
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var stream = new FileStream("./sample-image.zip", FileMode.Open, FileAccess.Read))
            using (var zipArchive = new ZipArchive(stream, ZipArchiveMode.Read, false))
            {
                zipArchive.ExtractToDirectory("./unzipped/", true);
            }
        }
    }
}
