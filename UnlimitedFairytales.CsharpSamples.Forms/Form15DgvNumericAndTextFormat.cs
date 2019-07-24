using System.Data;
using System.Windows.Forms;

namespace UnlimitedFairytales.CsharpSamples.Forms
{
	public partial class Form15DgvNumericAndTextFormat : Form
	{
		public Form15DgvNumericAndTextFormat()
		{
			InitializeComponent();
		}

		private void Form10DgvNumericAndTextFormat_Load(object sender, System.EventArgs e)
		{
			DataTable source = new DataTable();
			source.Columns.Add("A");
			source.Columns.Add("B");
			source.Columns.Add("C");
			source.Columns["A"].DataType = typeof(decimal);
			source.Rows.Add("1234", "B-1", "C-1");
			source.Rows.Add("-1234", "B-2", "C-2");
			source.Rows.Add("1234.567", "B-3", "C-3");
			this.dataGridView2.DataSource = source;
		}

		private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
		{
			DataGridView dgv = (DataGridView)sender;
			if (dgv.CurrentCell != null && dgv.Columns["Column1"] != null && dgv.CurrentCell.ColumnIndex == dgv.Columns["Column1"].Index)
			{
				DataGridViewTextBoxEditingControl txt = e.Control as DataGridViewTextBoxEditingControl;
				if (txt != null)
				{
					txt.ImeMode = System.Windows.Forms.ImeMode.Disable;
					txt.KeyDown -= new KeyEventHandler(HandleKeyDownEvent);
					txt.KeyDown += new KeyEventHandler(HandleKeyDownEvent);
				}
			}	
		}

		private void dataGridView2_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
		{
			DataGridView dgv = (DataGridView)sender;
			if (dgv.CurrentCell != null && dgv.Columns["dataGridViewTextBoxColumn1"] != null && dgv.CurrentCell.ColumnIndex == dgv.Columns["dataGridViewTextBoxColumn1"].Index)
			{
				DataGridViewTextBoxEditingControl txt = e.Control as DataGridViewTextBoxEditingControl;
				if (txt != null)
				{
					txt.ImeMode = System.Windows.Forms.ImeMode.Disable;
					txt.KeyDown -= new KeyEventHandler(HandleKeyDownEvent);
					txt.KeyDown += new KeyEventHandler(HandleKeyDownEvent);
				}
			}
		}

		void HandleKeyDownEvent(object sender, KeyEventArgs e)
		{
			decimal dummy;
			TextBox txt = (TextBox)sender;
			if (((Keys.D0 <= e.KeyCode && e.KeyCode <= Keys.D9) ||            // 数字
				(Keys.NumPad0 <= e.KeyCode && e.KeyCode <= Keys.NumPad9) ||   // Numpadの数字
				(e.KeyCode == Keys.Back) ||                                   // Backspace
				(e.KeyCode == Keys.Delete) ||                                 // Delete
				(e.KeyCode == Keys.Left) ||                                   // ←
				(e.KeyCode == Keys.Right) ||                                  // →
				(e.Control && e.KeyCode == Keys.Z) ||                         // Ctrl + Z
				(e.Control && e.KeyCode == Keys.X) ||                         // Ctrl + X
				(e.Control && e.KeyCode == Keys.C) ||                         // Ctrl + C
				(e.Control && e.KeyCode == Keys.A)) ||                        // Ctrl + A
				((e.KeyCode == Keys.OemMinus || e.KeyCode == Keys.Subtract) && (!txt.Text.Contains("-")) && (txt.SelectionStart == 0)) ||
				((e.KeyCode == Keys.OemPeriod || e.KeyCode == Keys.Decimal) && (!txt.Text.Contains("."))) ||
				((e.Control && (e.KeyCode == Keys.V)) && decimal.TryParse(Clipboard.GetText(), out dummy)))
			{
				e.SuppressKeyPress = false;
			}
			else
			{
				e.SuppressKeyPress = true;
			}
		}

		private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			DataGridView dgv = (DataGridView)sender;
			if (dgv.Columns["Column1"] != null && dgv.Columns["Column1"].Index == e.ColumnIndex)
			{
				if (e.RowIndex >= 0)
				{
					decimal num = 0;
					if (decimal.TryParse(dgv[e.ColumnIndex, e.RowIndex].Value.ToString(), out num))
					{
						dgv[e.ColumnIndex, e.RowIndex].Value = num;
					}
				}
			}
		}
	}
}
