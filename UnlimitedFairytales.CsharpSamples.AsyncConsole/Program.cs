using System;
using System.Threading.Tasks;
using UnlimitedFairytales.CsharpSamples.Common;

namespace UnlimitedFairytales.CsharpSamples.AsyncConsole
{
    class Program
    {
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
                Helper.Log("before new From : Current=" + System.Threading.SynchronizationContext.Current);
                var frm = new System.Windows.Forms.Form();
                Helper.Log("after  new From : Current=" + System.Threading.SynchronizationContext.Current);
                await Task.Delay(1000); // dead lock!
            }
            Helper.Log();

            Helper.Log("1st begin.");
            await AsyncSample.Do1Async("1st", 500, true);
            Helper.Log("1st end.");
            Helper.Log("2nd begin.");
            await AsyncSample.Do1Async("2nd", 1000, true);
            Helper.Log("2nd end.");
            Helper.Log("3rd begin.");
            await AsyncSample.Do1Async("3rd", 1500, true);
            Helper.Log("3rd end.");

            Console.WriteLine("All complete.");
            Console.ReadKey();
        }
    }
}
