using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnlimitedFairytales.CsharpSamples.UIExceptionHandling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUI_Click(object sender, EventArgs e)
        {
            Thread.Sleep(1000);
            throw new Exception("サンプルメッセージ1");
        }

        private async void btnTask_Click(object sender, EventArgs e)
        {
            var tasks = new Task[]{
                Task.Delay(1000),
                Task.Run(() => System.Threading.Thread.Sleep(1000)),
                Task.Run(() => { System.Threading.Thread.Sleep(1000); throw new Exception("サンプルメッセージ2"); })
            };
            await Task.WhenAll(tasks);
        }

        private void btnShowDialog_Click(object sender, EventArgs e)
        {
            var frm = new Form1();
            frm.ShowDialog();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            var frm = new Form1();
            frm.Show();
        }
    }
}
