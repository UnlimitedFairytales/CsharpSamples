using System;
using System.Windows.Forms;

namespace UnlimitedFairytales.CsharpSamples.Forms
{
    public partial class Form06TabByEnter : Form
    {
        public Form06TabByEnter()
        {
            InitializeComponent();
        }

        [System.Security.Permissions.UIPermission(
            System.Security.Permissions.SecurityAction.Demand,
            Window = System.Security.Permissions.UIPermissionWindow.AllWindows)]
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (!this.rdoProcessDialogKey.Checked) return base.ProcessDialogKey(keyData);
            if (((keyData & Keys.KeyCode) == Keys.Return) &&
                ((keyData & (Keys.Alt | Keys.Control)) == Keys.None))
            {
                this.ProcessTabKey((keyData & Keys.Shift) != Keys.Shift);
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (!this.rdoKeyDown.Checked) return;
            if ((e.KeyCode == Keys.Enter) && !e.Alt && !e.Control)
            {
                this.ProcessTabKey(!e.Shift);
                e.SuppressKeyPress = true;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (!this.rdoKeyUp.Checked) return;
            if ((e.KeyCode == Keys.Enter) && !e.Alt && !e.Control)
            {
                this.ProcessTabKey(!e.Shift);
                e.SuppressKeyPress = true;
            }
        }

        private void txtWithMessageBox_Validated(object sender, EventArgs e)
        {
            MessageBox.Show("Validated!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click!");
        }
    }
}
