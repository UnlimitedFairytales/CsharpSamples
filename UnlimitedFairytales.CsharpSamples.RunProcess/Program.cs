using System;
using System.Diagnostics;
using System.Reflection;

namespace UnlimitedFairytales.CsharpSamples.RunProcess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var p = new Process())
            {
                var errors = new List<string>();
                var exePath = Path.GetFullPath("..\\..\\..\\..\\UnlimitedFairytales.CsharpSamples.RunProcessInner\\bin\\Debug\\net6.0\\UnlimitedFairytales.CsharpSamples.RunProcessInner.exe");
                p.StartInfo.WorkingDirectory = Path.GetDirectoryName(exePath);
                p.StartInfo.FileName = exePath;
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.RedirectStandardError = true;
                p.OutputDataReceived += (sender, e) =>
                {
                    var temp = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(e.Data);
                    Console.ForegroundColor = temp;
                };
                p.ErrorDataReceived += (sender, e) =>
                {
                    var temp = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(e.Data);
                    if (e.Data != null)
                    {
                        errors.Add(e.Data);
                    }
                    Console.ForegroundColor = temp;
                };

                p.Start();
                p.BeginOutputReadLine();
                p.BeginErrorReadLine();
                p.WaitForExit();

                if (0 < errors.Count)
                {
                    Console.WriteLine("子プロセスでエラーがありました。");
                    var temp = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Red;
                    foreach (var error in errors)
                    {
                        Console.WriteLine(error);
                    }
                    Console.ForegroundColor = temp;
                }
                Console.Write($"終了コード={p.ExitCode}");
            }
        }
    }
}