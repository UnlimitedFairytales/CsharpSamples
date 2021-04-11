using System;
using System.Globalization;
using System.Threading;

namespace UnlimitedFairytales.CsharpSamples.ResxSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"起動時のカルチャ:{Thread.CurrentThread.CurrentUICulture.DisplayName}");
            Console.WriteLine("resxからの読み取り例：" + Resources.StringResource.ERR_SYSTEM);
            Console.WriteLine();

            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-us", false);
            Console.WriteLine($"en-usカルチャ:{Thread.CurrentThread.CurrentUICulture.DisplayName}");
            Console.WriteLine("resxからの読み取り例：" + Resources.StringResource.ERR_SYSTEM);
            Console.WriteLine();

            Thread.CurrentThread.CurrentUICulture = new CultureInfo("ja-jp", false);
            Console.WriteLine($"ja-jpカルチャ:{Thread.CurrentThread.CurrentUICulture.DisplayName}");
            Console.WriteLine("resxからの読み取り例：" + Resources.StringResource.ERR_SYSTEM);
            Console.WriteLine();

            Thread.CurrentThread.CurrentUICulture = new CultureInfo("", false);
            Console.WriteLine($"空文字列カルチャ:{Thread.CurrentThread.CurrentUICulture.DisplayName}");
            Console.WriteLine("resxからの読み取り例：" + Resources.StringResource.ERR_SYSTEM);
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
