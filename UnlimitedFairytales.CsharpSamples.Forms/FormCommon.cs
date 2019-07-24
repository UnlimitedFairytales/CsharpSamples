using System;
using System.Windows.Forms;

namespace UnlimitedFairytales.CsharpSamples.Forms
{
	public partial class FormCommon : Form
	{
		public FormCommon()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Form01CommonControls f = new Form01CommonControls();
			f.ShowDialog();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Form02ShowDialog f = new Form02ShowDialog();
			MessageBox.Show(f.ShowDialog().ToString() + " pressed.");
			
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Form03Editor f = new Form03Editor();
			f.ShowDialog();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			Form04TextBoxes f = new Form04TextBoxes();
			f.ShowDialog();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			Form05ComboBoxesAndListBoxes f = new Form05ComboBoxesAndListBoxes();
			f.ShowDialog();
		}

        private void button6_Click(object sender, EventArgs e)
        {
            Form06TabByEnter f = new Form06TabByEnter();
            f.ShowDialog();
        }
    }
}
