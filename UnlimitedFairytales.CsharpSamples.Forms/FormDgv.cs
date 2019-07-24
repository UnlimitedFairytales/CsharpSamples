using System;
using System.Windows.Forms;

namespace UnlimitedFairytales.CsharpSamples.Forms
{
	public partial class FormDgv : Form
	{
		public FormDgv()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Form11DgvEvent f = new Form11DgvEvent();
			f.ShowDialog();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Form12DgvColumnOrder f = new Form12DgvColumnOrder();
			f.ShowDialog();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Form13DgvIndexAndDataSourceAndDelete f = new Form13DgvIndexAndDataSourceAndDelete();
			f.ShowDialog();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			Form14DgvCustomizedSelecting f = new Form14DgvCustomizedSelecting();
			f.ShowDialog();
		}

        private void button5_Click(object sender, EventArgs e)
        {
            Form15DgvNumericAndTextFormat f = new Form15DgvNumericAndTextFormat();
            f.ShowDialog();
        }
	}
}