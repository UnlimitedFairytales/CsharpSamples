using SevenZip;
using System;
using System.IO;
using System.Linq;
using System.Reflection;

namespace UnlimitedFairytales.CsharpSamples.SevenZipSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var exeDirPath = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);

            // 初期設定
            {
                // x64用です
                var libraryPath = Path.Combine(exeDirPath, "lib\\7-Zip\\7z.dll");
                SevenZip.SevenZipExtractor.SetLibraryPath(libraryPath);
                SevenZip.SevenZipCompressor.SetLibraryPath(libraryPath);
            }
            // 例1
            {
                var zipPath = Path.Combine(exeDirPath, "sample-files\\sample-texts.zip");
                var outputPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory), "unzip1");
                FileStream stream = new FileStream(zipPath, FileMode.Open, FileAccess.Read);
                Unzip(stream, outputPath);
            }
            // 例2
            {
                var zipPath = Path.Combine(exeDirPath, "sample-files\\sample-texts-nested.zip");
                var outputPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory), "unzip2");
                FileStream stream = new FileStream(zipPath, FileMode.Open, FileAccess.Read);
                Unzip(stream, outputPath);
            }
            // 例2
            {
                var zipPath = Path.Combine(exeDirPath, "sample-files\\sample-texts-nested.zip");
                var outputPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory), "unzip3");
                FileStream stream = new FileStream(zipPath, FileMode.Open, FileAccess.Read);
                UnzipAsFlat(stream, outputPath);
            }
        }

        static void Unzip(FileStream stream, string outputDirPath)
        {
            if (Directory.Exists(outputDirPath))
            {
                Directory.Delete(outputDirPath, true);
            }
            Directory.CreateDirectory(outputDirPath);
            using (var extractor = new SevenZipExtractor(stream, InArchiveFormat.Zip))
            {
                extractor.ExtractArchive(outputDirPath);
            }
        }

        static void UnzipAsFlat(FileStream stream, string outputDirPath)
        {
            if (Directory.Exists(outputDirPath))
            {
                Directory.Delete(outputDirPath, true);
            }
            Directory.CreateDirectory(outputDirPath);
            using (var extractor = new SevenZipExtractor(stream, InArchiveFormat.Zip))
            {
                var fileDatas = extractor.ArchiveFileData;
                foreach (var fileData in fileDatas)
                {
                    if (!fileData.IsDirectory)
                    {
                        var outputFilePath = Path.Combine(outputDirPath, Path.GetFileName(fileData.FileName));
                        using (var outputFileStream = File.Create(outputFilePath))
                        {
                            extractor.ExtractFile(fileData.Index, outputFileStream);
                        }                            
                    }
                }
            }
        }
    }
}
