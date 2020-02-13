using System;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            this.label1.Text = await Form1.Do1Async(nameof(this.button1), 1000) + " at " + DateTime.Now.ToString("HH:mm:ss.");
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            this.label2.Text = await Form1.Do1Async(nameof(this.button2), 1000) + " at " + DateTime.Now.ToString("HH:mm:ss.");
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            var task = Task.WhenAll(
                    Task.Run(() => { System.Threading.Thread.Sleep(1000); return (new Random()).Next(1, 9) * 100;}),
                    Task.Run(() => { System.Threading.Thread.Sleep(2000); return (new Random()).Next(1, 9); }));
            var results = await task;
            var sum = 0;
            foreach (var result in results)
            {
                sum += result;
            }
            this.label3.Text = sum + " at " + DateTime.Now.ToString("HH:mm:ss.");
        }

        static async Task<string> Do1Async(string no, int wait)
        {
            Console.WriteLine(no + nameof(Do1Async));
            await Task.Delay(wait);
            return await Do2Async(no, wait);
        }

        static async Task<string> Do2Async(string no, int wait)
        {
            Console.WriteLine(no + nameof(Do2Async));
            await Task.Delay(wait);
            return await Do3Async(no, wait);
        }

        static async Task<string> Do3Async(string no, int wait)
        {
            Console.WriteLine(no + nameof(Do3Async));
            await Task.Delay(wait);
            return no + " was pushed";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(linkLabel1.Text);
        }
    }
}
