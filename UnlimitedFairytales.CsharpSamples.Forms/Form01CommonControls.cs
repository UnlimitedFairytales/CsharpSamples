using System;
using System.Drawing;
using System.Windows.Forms;

namespace UnlimitedFairytales.CsharpSamples.Forms
{
	public partial class Form01CommonControls : Form
	{
		public Form01CommonControls()
		{
			InitializeComponent();
		}

		private void Form01CommonControls_Load(object sender, EventArgs e)
		{
			this.button1.Click += (o, e1) => MessageBox.Show(this, this.button1.Text);
			this.checkBox1.Click += (o, e1) => MessageBox.Show(this, this.checkBox1.Text);
			this.checkedListBox1.Items.AddRange(new string[] { "checkedListBox1", "checkedListBox2", "checkedListBox3" });
			this.comboBox1.DataSource = new string[] { "comboBox1", "comboBox2", "comboBox3" };
			this.dateTimePicker1.Value = DateTime.Now;
			this.label1.ForeColor = Color.Red;
			this.linkLabel1.LinkClicked += (o,e1) => MessageBox.Show(this, this.linkLabel1.Text);
			this.listBox1.DataSource = new string[] { "listBox1", "listBox2", "listBox3" };
			this.listView1.Items.AddRange(new ListViewItem[] { new ListViewItem("listView1"), new ListViewItem("listView2"), new ListViewItem("listView3") });
			this.maskedTextBox1.Mask = "###-####";
			this.monthCalendar1.SelectionStart = DateTime.Now;
			this.notifyIcon1.Icon = this.Icon;
			this.numericUpDown1.ValueChanged += delegate(object o, EventArgs e4) { this.progressBar1.Value = (int)this.numericUpDown1.Value; };
			this.pictureBox1.Image = this.Icon.ToBitmap();
			this.progressBar1.Value = (int)this.numericUpDown1.Value;
			this.radioButton1.Checked = false;
			this.richTextBox1.Text = "richTextBox";
			this.textBox1.Text = "textBox";
			this.toolTip1.SetToolTip(this, this.Text);
			this.treeView1.Nodes.AddRange(new TreeNode[] { new TreeNode("treeView1"), new TreeNode("treeView2"), new TreeNode("treeView3") });
			this.webBrowser1.Url = new Uri("https://www.google.co.jp/");
		}
	}
}
