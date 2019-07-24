using System;
using System.Data;
using System.Windows.Forms;

namespace UnlimitedFairytales.CsharpSamples.Forms
{
	public partial class Form13DgvIndexAndDataSourceAndDelete : Form
	{
		public Form13DgvIndexAndDataSourceAndDelete()
		{
			InitializeComponent();
		}

		private void Form08DgvIndexAndDataSourceAndDelete_Load(object sender, EventArgs e)
		{
			DataTable source = new DataTable();
			source.Columns.Add("A");
			source.Columns.Add("B");
			source.Columns.Add("C");
            source.Columns.Add("E");
            source.Rows.Add("A-1", "B-3", "C-1");
			source.Rows.Add("A-2", "B-2", "C-2");
			source.Rows.Add("A-3", "B-1", "C-3");
            this.dataGridView1.DataSource = source;
			this.dataGridView1.Columns["Column1"].DisplayIndex = 0;
			this.dataGridView1.Columns["Column2"].DisplayIndex = 1;
			this.dataGridView1.Columns["Column3"].DisplayIndex = 2;
			this.dataGridView1.Columns["Column4"].DisplayIndex = 3;
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			DataGridView dgv = (DataGridView)sender;
			if (dgv.Columns["Column4"] != null && dgv.Columns["Column4"].Index == e.ColumnIndex)
			{
				if (e.RowIndex >= 0 && e.RowIndex < dgv.Rows.Count - 1)
				{
					if (this.Confirms())
					{
						dgv.Rows.RemoveAt(e.RowIndex);
					}
				}
			}
		}

		private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
		{
			e.Cancel = !this.Confirms();
		}

		private bool Confirms()
		{
			return MessageBox.Show("削除しますか？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
		}

		private void dataGridView1_Sorted(object sender, EventArgs e)
		{
			DataView dv = ((DataTable)((DataGridView)sender).DataSource).DefaultView;
			Console.WriteLine(dv.Sort.ToString() + " で　表示がソートされました。");
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			string disp = "エラー";
			string name = "エラー";
			string dpnm = "エラー";
			if (0 <= e.ColumnIndex)
			{
				disp = this.dataGridView1.Columns[e.ColumnIndex].DisplayIndex.ToString();
				name = this.dataGridView1.Columns[e.ColumnIndex].Name;
				dpnm = this.dataGridView1.Columns[e.ColumnIndex].DataPropertyName;
			}
			string dtri = "なし";
			if (0 <= e.RowIndex && e.RowIndex < this.dataGridView1.Rows.Count - 1 && 0 <= e.ColumnIndex)
			{
				dtri =((DataTable)this.dataGridView1.DataSource).Rows.IndexOf(((DataRowView)this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row).ToString();
			}
			Console.WriteLine("CellClick : e.[c,r]=[" + e.ColumnIndex.ToString() + "," + e.RowIndex.ToString() + "]"
				 + "  /  dgvColumn.DisplayIndex=Name=" + disp + "=" + name
				 + "  /  [dgvColumn.DataPropertyName,DataTable.Rows.Index]=[" + dpnm + "," + dtri + "]");
		}
	}
}
