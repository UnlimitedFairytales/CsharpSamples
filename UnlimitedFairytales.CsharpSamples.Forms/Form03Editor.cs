using System.Windows.Forms;

namespace UnlimitedFairytales.CsharpSamples.Forms
{
	public partial class Form03Editor : Form
	{
		public Form03Editor()
		{
			InitializeComponent();
		}

		private void Form03Editor_Load(object sender, System.EventArgs e)
		{
			this.SetAndSynchStatusbarVisible(true);
		}

		private void newToolStripMenuItem_Click(object sender, System.EventArgs e)
		{

		}

		private void openToolStripMenuItem_Click(object sender, System.EventArgs e)
		{

		}

		private void saveToolStripMenuItem_Click(object sender, System.EventArgs e)
		{

		}

		private void saveAsToolStripMenuItem_Click(object sender, System.EventArgs e)
		{

		}

		private void exitToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void undoToolStripMenuItem_Click(object sender, System.EventArgs e)
		{

		}

		private void redoToolStripMenuItem_Click(object sender, System.EventArgs e)
		{

		}

		private void cutToolStripMenuItem_Click(object sender, System.EventArgs e)
		{

		}

		private void copyToolStripMenuItem_Click(object sender, System.EventArgs e)
		{

		}

		private void pasteToolStripMenuItem_Click(object sender, System.EventArgs e)
		{

		}

		private void deleteToolStripMenuItem_Click(object sender, System.EventArgs e)
		{

		}

		private void selectAllToolStripMenuItem_Click(object sender, System.EventArgs e)
		{

		}

		private void statusBarToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			this.SetAndSynchStatusbarVisible(this.statusBarToolStripMenuItem.Checked);
		}

		private void userGuideToolStripMenuItem_Click(object sender, System.EventArgs e)
		{

		}

		private void aboutToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			Form03Editor_AboutBox1 aboutbox = new Form03Editor_AboutBox1();
			aboutbox.ShowDialog();
		}

		private void Form03Editor_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
			{
				e.Effect = DragDropEffects.Copy;
			}
		}

		private void Form03Editor_DragDrop(object sender, DragEventArgs e)
		{
			string[] fileNames = (string[])e.Data.GetData(DataFormats.FileDrop);
			if (fileNames != null && 0 < fileNames.Length)
			{
				this.Activate();
				this.BringToFront();
				for (int i = 0; i < fileNames.Length; i++)
				{
					//D&Dされた内容を処理する
				}
			}
		}

		private void Form03Editor_FormClosing(object sender, FormClosingEventArgs e)
		{
			//終了して良いかどうかのチェックを行う
		}

		private void SetAndSynchStatusbarVisible(bool visible)
		{
			this.statusStrip1.Visible = visible;
			this.statusBarToolStripMenuItem.Checked = visible;
		}
	}
}
