using System.Threading.Tasks;

namespace UnlimitedFairytales.CsharpSamples.Common
{
    public static class AsyncSample
    {
        public static async Task Do1Async(string name, int wait, bool configureAwait)
        {
            var self = nameof(Do1Async);
            Helper.Log($"{name} {self} begin");
            await Task.Delay(wait);
            await Do2Async(name, wait, configureAwait).ConfigureAwait(configureAwait);
            Helper.Log($"{name} {self} end");
            return;
        }

        static async Task Do2Async(string name, int wait, bool configureAwait)
        {
            var self = nameof(Do2Async);
            Helper.Log($"{name} {self} begin as ConfigureAwait={configureAwait}");
            await Task.Delay(wait);
            await Do3Async(name, wait, configureAwait).ConfigureAwait(configureAwait);
            Helper.Log($"{name} {self} end");
            return;
        }

        static async Task Do3Async(string name, int wait, bool configureAwait)
        {
            var self = nameof(Do3Async);
            Helper.Log($"{name} {self} begin as ConfigureAwait={configureAwait}");
            await Task.Run(() => {
                Helper.Log($"{name} {self} inner task before sleep.");
                System.Threading.Thread.Sleep(wait);
                Helper.Log($"{name} {self} inner task after sleep.");
            }).ConfigureAwait(configureAwait);
            Helper.Log($"{name} {self} end");
            return;
        }
    }
}
