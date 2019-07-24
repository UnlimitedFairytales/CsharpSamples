using System;
using System.Data;
using System.Windows.Forms;

namespace UnlimitedFairytales.CsharpSamples.Forms
{
	public partial class Form11DgvEvent : Form
	{
		public Form11DgvEvent()
		{
			Console.WriteLine("InitializeComponent を呼び出します。");
			InitializeComponent();
			Console.WriteLine("InitializeComponent は呼び出しました。");
		}

		private void Form06DgvEvent_Load(object sender, EventArgs e)
		{
			Console.WriteLine("Loadイベントハンドラが開始しました。");

			string[] cmbSource = new[] { "B-1", "B-2", "B-3" };
			((DataGridViewComboBoxColumn)this.dataGridView1.Columns["Column2"]).DataSource = cmbSource;
			DataTable source = new DataTable();
			source.Columns.Add("A");
			source.Columns.Add("B");
			source.Columns.Add("C");
			source.Rows.Add("A-1", "B-1", "C-1");
			source.Rows.Add("A-2", "B-2", "C-2");
			source.Rows.Add("A-3", "B-3", "C-3");
			this.dataGridView1.DataSource = source;

			Console.WriteLine("Loadイベントハンドラを終了します。");
		}
		//1番目
		private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
		{
			Console.WriteLine("CellEnter : 列" + e.ColumnIndex.ToString() + ", 行" + e.RowIndex.ToString());
		}
		//2番目
		private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
		{
			Console.WriteLine("CellBeginEdit : 列" + e.ColumnIndex.ToString() + ", 行" + e.RowIndex.ToString());
		}
		//3番目
		private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
		{
			DataGridView dgv = (DataGridView)sender;
			if (dgv.CurrentCell != null)
			{
				Console.WriteLine("EditingControlShowing : 列" + dgv.CurrentCell.ColumnIndex.ToString() + ", 行" + dgv.CurrentCell.RowIndex.ToString());
			}		
		}
		//4番目
		private void dataGridView1_CellLeave(object sender, DataGridViewCellEventArgs e)
		{
			Console.WriteLine("CellLeave : 列" + e.ColumnIndex.ToString() + ", 行" + e.RowIndex.ToString());
		}
		//5番目
		private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
			Console.WriteLine("CellValidating : 列" + e.ColumnIndex.ToString() + ", 行" + e.RowIndex.ToString());
		}
		//6番目
		private void dataGridView1_CellParsing(object sender, DataGridViewCellParsingEventArgs e)
		{
			Console.WriteLine("CellParsing : 列" + e.ColumnIndex.ToString() + ", 行" + e.RowIndex.ToString());
		}
		//7番目
		private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			Console.WriteLine("CellValueChanged : 列" + e.ColumnIndex.ToString() + ", 行" + e.RowIndex.ToString());
		}
		//8番目
		private void dataGridView1_CellValidated(object sender, DataGridViewCellEventArgs e)
		{
			Console.WriteLine("CellValidated : 列" + e.ColumnIndex.ToString() + ", 行" + e.RowIndex.ToString());
		}
		//9番目
		private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
			Console.WriteLine("CellEndEdit : 列" + e.ColumnIndex.ToString() + ", 行" + e.RowIndex.ToString());
		}
		//セルクリック
		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			Console.WriteLine("CellClick : 列" + e.ColumnIndex.ToString() + ", 行" + e.RowIndex.ToString());
		}
		//セルコンテントクリック
		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			Console.WriteLine("CellContentClick : 列" + e.ColumnIndex.ToString() + ", 行" + e.RowIndex.ToString());
		}
		//フォーマッティング
		private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			//MessageBoxやブレークポイント設置で無限ループに陥る
			//Console.WriteLine("CellFormatting : 列" + e.ColumnIndex.ToString() + ", 行" + e.RowIndex.ToString());
		}
	}
}
