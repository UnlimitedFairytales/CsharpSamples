using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnlimitedFairytales.CsharpSamples.PowerShellSample2
{
    public partial class Form1 : Form
    {
        Runspace rs;
        PowerShell ps;

        public Form1()
        {
            InitializeComponent();
            this.Disposed += Form1_Disposed;
            this.rs = RunspaceFactory.CreateRunspace();
            rs.Open();
            this.ps = PowerShell.Create(rs);
        }

        private void Form1_Disposed(object sender, EventArgs e)
        {
            ps?.Dispose();
            rs?.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dResult = MessageBox.Show("リモートPCのCPU性能によっては、かなりの時間がかかります。", "OKで続行します", MessageBoxButtons.OKCancel);
            if (dResult != DialogResult.OK) return;
            var script = File.ReadAllText("script.ps1");
            // AddScript の場合、変数は展開される
            // AddCommand + AddParameterの場合、変数が展開されない。また、cdコマンド時に/を¥への自動置き換えなどもしてくれない
            ps.AddScript(script);
            var results = ps.Invoke();
            if (ps.HadErrors)
            {
                var sb = new StringBuilder();
                foreach (var error in ps.Streams.Error)
                {
                    sb.AppendLine(error.ToString());
                }
                MessageBox.Show(sb.ToString());
            }
            else
            {
                var text = "";
                foreach (var result in results)
                {
                    if (result.ToString() == "System.Collections.DictionaryEntry")
                    {
                        text += $"{result.Properties["KEY"].Value} {result.Properties["Value"].Value}" + Environment.NewLine;
                    }
                    else
                    {
                        text += $"{result}" + Environment.NewLine;
                    }
                    
                }
                this.richTextBox1.Text = text;
            }
            ps.Streams.ClearStreams();
            ps.Commands.Clear();
        }
    }
}
