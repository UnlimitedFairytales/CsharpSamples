using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Text;
using System.Windows.Forms;

namespace UnlimitedFairytales.CsharpSamples.PowerShellSample
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
            this.UpdateCdText();
        }

        private void Form1_Disposed(object sender, EventArgs e)
        {
            ps?.Dispose();
            rs?.Dispose();
        }

        private Collection<PSObject> InvokeAndClear(string script)
        {
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
            ps.Streams.ClearStreams();
            ps.Commands.Clear();
            this.UpdateCdText();
            return results;
        }

        private void UpdateCdText()
        {
            ps.AddCommand("Convert-Path");
            ps.AddArgument(".");
            var results = ps.Invoke();
            this.txtCurrentDirectoryOfPs.Text = $"{results.First()}";
            ps.Streams.ClearStreams();
            ps.Commands.Clear();
        }

        private void btnGetChildItem_Click(object sender, EventArgs e)
        {
            var results = this.InvokeAndClear("Get-ChildItem");
            var texts = "";
            foreach (var result in results)
            {
                texts += $"{result.Properties["CreationTime"].Value} {result.Properties["Name"].Value}" + Environment.NewLine;
            }
            this.txtOutput.Text = texts;
        }

        private void btnCd_Click(object sender, EventArgs e)
        {
            this.InvokeAndClear($"cd {this.txtCdParameter.Text}");
        }

        private void btnCdHome_Click(object sender, EventArgs e)
        {
            this.InvokeAndClear("cd $env:USERPROFILE");
        }

        private void btnShowEnv_Click(object sender, EventArgs e)
        {
            var results = this.InvokeAndClear("Get-ChildItem env:");
            var texts = "";
            foreach (var result in results)
            {
                texts += $"{result.Properties["KEY"].Value} {result.Properties["Value"].Value}" + Environment.NewLine;
            }
            this.txtOutput.Text = texts;
        }

        private void btnGetMember_Click(object sender, EventArgs e)
        {
            var results = this.InvokeAndClear("Get-ChildItem | Get-Member -MemberType Properties");
            var dirInfos = (from a in results where $"{a.Properties["TypeName"].Value}" == "System.IO.DirectoryInfo" select a);
            var fileINfos = (from a in results where $"{a.Properties["TypeName"].Value}" == "System.IO.FileInfo" select a);
            var texts = "";
            texts += "System.IO.DirectoryInfoの場合" + Environment.NewLine;
            foreach (var result in dirInfos)
            {
                texts += $"{result.Properties["Name"].Value}" + Environment.NewLine;
            }
            texts += Environment.NewLine;
            texts += "System.IO.FileInfoの場合" + Environment.NewLine;
            foreach (var result in fileINfos)
            {
                texts += $"{result.Properties["Name"].Value}" + Environment.NewLine;
            }
            this.txtOutput.Text = texts;
        }
    }
}
