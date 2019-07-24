using System;
using System.Data;
using System.Windows.Forms;

namespace UnlimitedFairytales.CsharpSamples.Forms
{
	public partial class Form12DgvColumnOrder : Form
	{
		public Form12DgvColumnOrder()
		{
			InitializeComponent();
		}

		private void Form07DgvColumnOrder_Load(object sender, EventArgs e)
		{
			
		}

		private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
		{
			Console.WriteLine("CellEnter : 列" + e.ColumnIndex.ToString() + ", 行" + e.RowIndex.ToString() +", Column.DisplayIndex" + this.dataGridView1.Columns[e.ColumnIndex].DisplayIndex.ToString());
		}

		private void dataGridView2_CellEnter(object sender, DataGridViewCellEventArgs e)
		{
			Console.WriteLine("CellEnter : 列" + e.ColumnIndex.ToString() + ", 行" + e.RowIndex.ToString() + ", Column.DisplayIndex" + this.dataGridView2.Columns[e.ColumnIndex].DisplayIndex.ToString());
		}

		private void dataGridView3_CellEnter(object sender, DataGridViewCellEventArgs e)
		{
			Console.WriteLine("CellEnter : 列" + e.ColumnIndex.ToString() + ", 行" + e.RowIndex.ToString() + ", Column.DisplayIndex" + this.dataGridView3.Columns[e.ColumnIndex].DisplayIndex.ToString());
		}

		private void dataGridView4_CellEnter(object sender, DataGridViewCellEventArgs e)
		{
			Console.WriteLine("CellEnter : 列" + e.ColumnIndex.ToString() + ", 行" + e.RowIndex.ToString() + ", Column.DisplayIndex" + this.dataGridView4.Columns[e.ColumnIndex].DisplayIndex.ToString());
		}

		private void dataGridView5_CellEnter(object sender, DataGridViewCellEventArgs e)
		{
			Console.WriteLine("CellEnter : 列" + e.ColumnIndex.ToString() + ", 行" + e.RowIndex.ToString() + ", Column.DisplayIndex" + this.dataGridView5.Columns[e.ColumnIndex].DisplayIndex.ToString());
		}

		private void btnBind_Click(object sender, EventArgs e)
		{
			DataTable source1 = new DataTable();
			source1.Columns.Add("D");
			source1.Columns.Add("A");
			source1.Columns.Add("C");
			source1.Columns.Add("B");
			source1.Rows.Add("D-1", "A-1", "C-1", "B-1");
			source1.Rows.Add("D-2", "A-2", "C-2", "B-2");
			source1.Rows.Add("D-3", "A-3", "C-3", "B-3");
			this.dataGridView1.DataSource = source1;

			DataTable source2 = new DataTable();
			source2.Columns.Add("D");
			source2.Columns.Add("A");
			source2.Columns.Add("E");
			source2.Columns.Add("C");
			source2.Columns.Add("B");
			source2.Rows.Add("D-1", "A-1", "E-1", "C-1", "B-1");
			source2.Rows.Add("D-2", "A-2", "E-2", "C-2", "B-2");
			source2.Rows.Add("D-3", "A-3", "E-3", "C-3", "B-3");
			this.dataGridView2.DataSource = source2;

			DataTable source3 = new DataTable();
			source3.Columns.Add("D");
			source3.Columns.Add("A");
			source3.Columns.Add("C");
			source3.Columns.Add("B");
			source3.Rows.Add("D-1", "A-1", "C-1", "B-1");
			source3.Rows.Add("D-2", "A-2", "C-2", "B-2");
			source3.Rows.Add("D-3", "A-3", "C-3", "B-3");
			this.dataGridView3.DataSource = source3;

			DataTable source4 = new DataTable();
			source4.Columns.Add("D");
			source4.Columns.Add("A");
			source4.Columns.Add("E");
			source4.Columns.Add("C");
			source4.Columns.Add("B");
			source4.Rows.Add("D-1", "A-1", "E-1", "C-1", "B-1");
			source4.Rows.Add("D-2", "A-2", "E-2", "C-2", "B-2");
			source4.Rows.Add("D-3", "A-3", "E-3", "C-3", "B-3");
			this.dataGridView4.DataSource = source4;

			DataTable source5 = new DataTable();
			source5.Columns.Add("D");
			source5.Columns.Add("A");
			source5.Columns.Add("E");
			source5.Columns.Add("C");
			source5.Columns.Add("B");
			source5.Rows.Add("D-1", "A-1", "E-1", "C-1", "B-1");
			source5.Rows.Add("D-2", "A-2", "E-2", "C-2", "B-2");
			source5.Rows.Add("D-3", "A-3", "E-3", "C-3", "B-3");
			this.dataGridView5.DataSource = source5;

			this.dataGridView5.Columns["E"].DisplayIndex = 0;
			this.dataGridView5.Columns["C"].DisplayIndex = 1;
			this.dataGridView5.Columns["Column5_3"].DisplayIndex = 2;
			this.dataGridView5.Columns["Column5_4"].DisplayIndex = 3;
			this.dataGridView5.Columns["Column5_2"].DisplayIndex = 4;
			this.dataGridView5.Columns["Column5_1"].DisplayIndex = 5;
		}
	}
}
