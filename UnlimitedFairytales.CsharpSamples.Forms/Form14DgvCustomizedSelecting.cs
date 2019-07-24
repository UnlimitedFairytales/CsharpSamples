using System;
using System.Data;
using System.Windows.Forms;

namespace UnlimitedFairytales.CsharpSamples.Forms
{
	public partial class Form14DgvCustomizedSelecting : Form
	{
		public Form14DgvCustomizedSelecting()
		{
			InitializeComponent();
		}

		private void Form09DgvCustomizedSelecting_Load(object sender, EventArgs e)
		{
			string[] cmbSource = new[] { "D-1", "D-2", "D-3" };
			((DataGridViewComboBoxColumn)this.dataGridView1.Columns["Column4"]).DataSource = cmbSource;
			DataTable source = new DataTable();
			source.Columns.Add("A");
			source.Columns.Add("C");
			source.Columns.Add("D");
			source.Rows.Add("A-1", "TRUE", "D-1");
			source.Rows.Add("A-2", "true", "D-2");
			source.Rows.Add("A-3", "TruE", "D-3");
			this.dataGridView1.DataSource = source;

			DataTable source2 = new DataTable();
			string[] cmbSource2 = new[] { "D-1", "D-2", "D-3" };
			source2.Columns.Add("A");
			source2.Columns.Add("C");
			source2.Columns.Add("D");
			source2.Rows.Add("A-1", "FALSE", "D-1");
			source2.Rows.Add("A-2", "false", "D-2");
			source2.Rows.Add("A-3", "FalsE", "D-3");
			((DataGridViewComboBoxColumn)this.dataGridView2.Columns["dataGridViewComboBoxColumn1"]).DataSource = cmbSource2;
			this.dataGridView2.DataSource = source2;
		}

		private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			DataGridView dgv = (DataGridView)sender;
			DataGridViewComboBoxEditingControl ctl = dgv.EditingControl as DataGridViewComboBoxEditingControl;
			if (ctl != null)
			{
				ctl.DroppedDown = true;
			}
		}
	}
}
