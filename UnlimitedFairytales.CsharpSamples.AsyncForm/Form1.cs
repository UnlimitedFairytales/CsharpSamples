using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnlimitedFairytales.CsharpSamples.AsyncForm
{
    public partial class Form1 : Form
    {
        static void Log(string msg = "")
        {
            var dateTime = DateTime.Now.ToString("HH:mm:ss.fff");
            var threadId = "threadId=" + System.Threading.Thread.CurrentThread.ManagedThreadId;
            System.Diagnostics.Trace.WriteLine($"{dateTime} {threadId} {msg}");
        }

        private async Task Do1AsyncWrapper(string buttonName, string self, Label label, bool innerConfigureAwait)
        {
            var target = $"await {nameof(Do1Async)}()";
            Log($"{buttonName} {self} : begin");
            await Do1Async(buttonName, 1000, innerConfigureAwait); // UIスレッドである必要があるため、Do1Asyncの呼び出しはConfigureAwait(true)
            label.Text = $"{buttonName} completed at {DateTime.Now.ToString("HH:mm:ss.fff")}";
            Log($"{buttonName} {self} : end");
        }

        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await Do1AsyncWrapper(
                nameof(this.button1),
                nameof(button1_Click),
                this.label1,
                true);
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            await Do1AsyncWrapper(
                nameof(this.button2),
                nameof(button2_Click),
                this.label2,
                false);
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            var buttonName = nameof(this.button3);
            var self = nameof(button3_Click);
            Form1.Log($"{buttonName} {self} : begin");

            var task = Task.WhenAll(
                    Task.Run(() => { Form1.Log("inner task1");  System.Threading.Thread.Sleep(2000); return (new Random()).Next(1, 9) * 100;}),
                    Task.Run(() => { Form1.Log("inner task2");  System.Threading.Thread.Sleep(2000); return (new Random()).Next(1, 9); }));
            Form1.Log($"{self} : before await 2 parallel tasks");
            var results = await task;
            Form1.Log($"{self} : after await 2 parallel tasks");

            var sum = 0;
            foreach (var result in results)
            {
                sum += result;
            }
            this.label3.Text = sum + " at " + DateTime.Now.ToString("HH:mm:ss.fff");
            Form1.Log($"{buttonName} {self} : end");
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(linkLabel1.Text);
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
            Log($"{name} {self} begin");
            await Task.Delay(wait);
            await Do3Async(name, wait, configureAwait).ConfigureAwait(configureAwait);
            Log($"{name} {self} end");
            return;
        }

        static async Task Do3Async(string name, int wait, bool configureAwait)
        {
            var self = nameof(Do3Async);
            Log($"{name} {self} begin");
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
