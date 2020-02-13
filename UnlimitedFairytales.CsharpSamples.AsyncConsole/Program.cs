using System;
using System.Threading.Tasks;

namespace UnlimitedFairytales.CsharpSamples.AsyncConsole
{
    class Program
    {
        // Project > build > advanced settings > Language Version > latest miner(C#7.1 <=)
        // This is alias for Task.GetAwaiter().GetResult()
        static async Task Main(string[] args)
        {
            Console.WriteLine("Press d or else.");
            var key = Console.ReadKey();
            Console.WriteLine();
            if (key.Key == ConsoleKey.D)
            {
                Console.WriteLine("Deadlock sample.");
                Console.WriteLine(await Do1Async("1", 300, true));
                Console.WriteLine(await Do1Async("2", 200, true));
                Console.WriteLine(await Do1Async("3", 100, true));
            }
            else
            {
                Console.WriteLine("Normal async sample.");
                Console.WriteLine(await Do1Async("1", 300, false));
                Console.WriteLine(await Do1Async("2", 200, false));
                Console.WriteLine(await Do1Async("3", 100, false));
            }
            Console.WriteLine("Complete.");
            Console.ReadKey();
        }

        static async Task<string> Do1Async(string no, int wait, bool raisesDeadLock)
        {
            Console.WriteLine(no + nameof(Do1Async));
            await Task.Delay(wait);
            return await Do2Async(no, wait, raisesDeadLock);
        }

        static async Task<string> Do2Async(string no, int wait, bool raisesDeadLock)
        {
            Console.WriteLine(no + nameof(Do2Async));
            await Task.Delay(wait);
            return await Do3Async(no, wait, raisesDeadLock);
        }

        static async Task<string> Do3Async(string no, int wait, bool raisesDeadLock)
        {
            Console.WriteLine(no + nameof(Do3Async));
            if (raisesDeadLock)
            {
                Console.WriteLine("Current=" + System.Threading.SynchronizationContext.Current);
                var frm = new System.Windows.Forms.Form();
                Console.WriteLine("Current=" + System.Threading.SynchronizationContext.Current);
            }
            await Task.Delay(wait); // if raisesDeadLock, dead lock!
            return no + " called";
        }
    }
}
