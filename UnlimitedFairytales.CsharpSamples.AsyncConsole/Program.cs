using System;
using System.Threading.Tasks;

namespace UnlimitedFairytales.CsharpSamples.AsyncConsole
{
    class Program
    {
        static void Log(string msg = "")
        {
            var dateTime = DateTime.Now.ToString("HH:mm:ss.fff");
            var threadId = "threadId=" + System.Threading.Thread.CurrentThread.ManagedThreadId;
            System.Diagnostics.Trace.WriteLine($"{dateTime} {threadId} {msg}");
        }

        // Project > build > advanced settings > Language Version > latest miner(C#7.1 <=)
        // "async Task Main" is alias for Task.GetAwaiter().GetResult()
        static async Task Main(string[] args)
        {
            Console.WriteLine("Press d or else.");
            var key = Console.ReadKey();
            Console.WriteLine();
            if (key.Key == ConsoleKey.D)
            {
                /*
                 * If raisesDeadLock mode, deadlock!
                 * Reason
                 * https://stackoverflow.com/questions/58960005/async-await-deadlock-when-using-windowsformssynchronizationcontext-in-a-console
                 * 
                 * 1. 
                 * WindowsFormsSynchronizationContext depends on Win32 message loop.
                 * But, console application don't start it.
                 * Win32 message loop is started by the followings.
                 * A. C#  Application.Run()
                 * B. C++ LRESULT CALLBACK WndProc()
                 * 
                 * 2.
                 * new Form() or other controls, switchs SynchronizationContext to WindowsFormsSynchronizationContext.
                 * (WindowsFormsSynchronizationContext.AutoInstall = true)
                 * 
                 * 3. 
                 * Program is WindowsFormsSynchronizationContext mode, but it don't start Win32 message loop.
                 * In this state, WindowsFormsSynchronizationContext.Post() (It is called by completing of await) don't work.
                 */
                Console.WriteLine("Deadlock sample.");
                Log("before new From : Current=" + System.Threading.SynchronizationContext.Current);
                var frm = new System.Windows.Forms.Form();
                Log("after  new From : Current=" + System.Threading.SynchronizationContext.Current);
                await Task.Delay(1000); // dead lock!
            }
            Log();

            Log("1st begin.");
            await Do1Async("1st", 500, true);
            Log("1st end.");
            Log("2nd begin.");
            await Do1Async("2nd", 1000, true);
            Log("2nd end.");
            Log("3rd begin.");
            await Do1Async("3rd", 1500, true);
            Log("3rd end.");

            Console.WriteLine("All complete.");
            Console.ReadKey();
        }

        static async Task Do1Async(string name, int wait, bool configureAwait)
        {
            var self = nameof(Do1Async);
            Log($"{name} {self} begin");
            await Task.Delay(wait);
            await Do2Async(name, wait, configureAwait).ConfigureAwait(configureAwait);
            Log($"{name} {self} end");
            return;
        }

        static async Task Do2Async(string name, int wait, bool configureAwait)
        {
            var self = nameof(Do2Async);
            Log($"{name} {self} begin as ConfigureAwait={configureAwait}");
            await Task.Delay(wait);
            await Do3Async(name, wait, configureAwait).ConfigureAwait(configureAwait);
            Log($"{name} {self} end");
            return;
        }

        static async Task Do3Async(string name, int wait, bool configureAwait)
        {
            var self = nameof(Do3Async);
            Log($"{name} {self} begin as ConfigureAwait={configureAwait}");
            await Task.Run(() => {
                Log($"{name} {self} inner task before sleep.");
                System.Threading.Thread.Sleep(wait);
                Log($"{name} {self} inner task after sleep.");
            }).ConfigureAwait(configureAwait);
            Log($"{name} {self} end");
            return;
        }
    }
}
