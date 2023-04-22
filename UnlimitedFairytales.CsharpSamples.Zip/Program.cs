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
            {
                var path = "./zipTarget";
                var name = "zipped.zip";
                ZipFile.CreateFromDirectory(path, name);
            }
            Console.WriteLine("実行ファイルの横にsample-image.zipは展開され、zipTargetは圧縮されました。");
            Console.ReadKey();
        }
    }
}
