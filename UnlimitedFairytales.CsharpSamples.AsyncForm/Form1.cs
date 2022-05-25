using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnlimitedFairytales.CsharpSamples.Common;

namespace UnlimitedFairytales.CsharpSamples.AsyncForm
{
    public partial class Form1 : Form
    {
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
            Helper.Log($"{buttonName} {self} : begin");

            var task = Task.WhenAll(
                    Task.Run(() => { Helper.Log("inner task1"); System.Threading.Thread.Sleep(2000); return (new Random()).Next(1, 9) * 100; }),
                    Task.Run(() => { Helper.Log("inner task2"); System.Threading.Thread.Sleep(2000); return (new Random()).Next(1, 9); }));
            Helper.Log($"{self} : before await 2 parallel tasks");
            var results = await task;
            Helper.Log($"{self} : after await 2 parallel tasks");

            var sum = 0;
            foreach (var result in results)
            {
                sum += result;
            }
            this.label3.Text = sum + " at " + DateTime.Now.ToString("HH:mm:ss.fff");
            Helper.Log($"{buttonName} {self} : end");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(linkLabel1.Text);
        }

        private async Task Do1AsyncWrapper(string buttonName, string self, Label label, bool innerConfigureAwait)
        {
            var target = $"await {nameof(AsyncSample.Do1Async)}()";
            Helper.Log($"{buttonName} {self} : begin");
            // label.Textを後続で呼び出すためUIスレッドである必要がある。
            // この呼び出しはConfigureAwait(true)である必要がある。
            await AsyncSample.Do1Async(buttonName, 1000, innerConfigureAwait);
            label.Text = $"{buttonName} completed at {DateTime.Now.ToString("HH:mm:ss.fff")}";
            Helper.Log($"{buttonName} {self} : end");
        }
    }
}