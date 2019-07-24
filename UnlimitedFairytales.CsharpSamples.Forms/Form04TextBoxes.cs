using System;
using System.Drawing;
using System.Windows.Forms;

namespace UnlimitedFairytales.CsharpSamples.Forms
{
	public partial class Form04TextBoxes : Form
	{
		public Form04TextBoxes()
		{
			InitializeComponent();
		}

		private const string text = "aaa_bbb_ccc";

		private void SetText(string originaltext)
		{
			this.txtOriginal.Text = originaltext;
			this.txtTxt1.Text = this.txtOriginal.Text;
			this.txtRic1.Text = this.txtOriginal.Text;
			this.txtOriginal.SelectAll();
			this.txtOriginal.Copy();
			this.txtTxt2.SelectAll();
			this.txtTxt2.Paste();
			this.txtRic2.SelectAll();
			this.txtRic2.Paste();

			this.txtOriginal_rich.Text = originaltext;
			this.txtTxt1_rich.Text = this.txtOriginal_rich.Text;
			this.txtRic1_rich.Text = this.txtOriginal_rich.Text;
			this.txtOriginal_rich.SelectAll();
			this.txtOriginal_rich.Copy();
			this.txtTxt2_rich.SelectAll();
			this.txtTxt2_rich.Paste();
			this.txtRic2_rich.SelectAll();
			this.txtRic2_rich.Paste();
		}

		private void btnLf_Click(object sender, EventArgs e)
		{
			this.SetText(text.Replace("_", "\n"));
		}

		private void btnCr_Click(object sender, EventArgs e)
		{
			this.SetText(text.Replace("_", "\r"));
		}

		private void btnCrLf_Click(object sender, EventArgs e)
		{
			this.SetText(text.Replace("_", "\r\n"));
		}

		private void SetBackColor(object sender)
		{
			TextBoxBase s = sender as TextBoxBase;
			if (s.Modified)
			{
				s.BackColor = Color.Aqua;
			}
			else
			{
				s.BackColor = Color.White;
			}
		}

		private void txtOriginal_ModifiedChanged(object sender, EventArgs e)
		{
			this.SetBackColor(sender);
		}

		private void txtTxt1_ModifiedChanged(object sender, EventArgs e)
		{
			this.SetBackColor(sender);
		}

		private void txtTxt2_ModifiedChanged(object sender, EventArgs e)
		{
			this.SetBackColor(sender);
		}

		private void txtRic1_ModifiedChanged(object sender, EventArgs e)
		{
			this.SetBackColor(sender);
		}

		private void txtRic2_ModifiedChanged(object sender, EventArgs e)
		{
			this.SetBackColor(sender);
		}

		private void txtOriginal_rich_ModifiedChanged(object sender, EventArgs e)
		{
			this.SetBackColor(sender);
		}

		private void txtTxt1_rich_ModifiedChanged(object sender, EventArgs e)
		{
			this.SetBackColor(sender);
		}

		private void txtTxt2_rich_ModifiedChanged(object sender, EventArgs e)
		{
			this.SetBackColor(sender);
		}

		private void txtRic1_rich_ModifiedChanged(object sender, EventArgs e)
		{
			this.SetBackColor(sender);
		}

		private void txtRic2_rich_ModifiedChanged(object sender, EventArgs e)
		{
			this.SetBackColor(sender);
		}

		private void btnModifiedToFalse_Click(object sender, EventArgs e)
		{
			foreach (Control item in this.Controls)
			{
				TextBoxBase t = item as TextBoxBase;
				if (t != null)
				{
					t.Modified = false;
				}
			}
		}
	}
}
