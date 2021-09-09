using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace UnlimitedFairytales.CsharpSamples.AsyncExceptionHandling
{
    class Program
    {
        static async Task Main(string[] args)
        {
            try
            {
                Console.WriteLine("aを押すとasync内の例外、それ以外を押すと通常例外を投げます。");
                var input = Console.ReadKey();
                Console.WriteLine();
                if (input.Key == ConsoleKey.A)
                {
                    var task = Task<string>.Run(() =>
                    {
                        return FixText(null);
                    });
                    var str = await task;
                }
                else {
                    dynamic dyna = 1;
                    var str = FixText(dyna);
                }
                
            }
            catch (Exception ex)
            {
                var asyncInnerExList = (ex as AggregateException)?.InnerExceptions;
                if (asyncInnerExList != null && 0 < asyncInnerExList.Count)
                {
                    foreach (var inEx in asyncInnerExList)
                    {
                        LogError(inEx);
                    }
                }
                else
                {
                    LogError(ex);
                }
            }
            Console.WriteLine("終了するには何かキーを押してください。");
            Console.ReadKey();
        }

        static string FixText(string text)
        {
            return text.ToLower();
        }

        static void LogError(Exception ex)
        {
            var nl = Environment.NewLine;
            Console.WriteLine($"{nameof(LogError)}が呼ばれました。");
            Console.WriteLine($"{ex.GetType().Name}{nl}{ex.Message}{nl}{ex.StackTrace}");
        }
    }
}
