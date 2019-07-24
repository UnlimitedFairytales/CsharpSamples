using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnlimitedFairytales.CsharpSamples.Forms
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnFormCommon_Click(object sender, EventArgs e)
        {
            var frm = new FormCommon();
            frm.Show();
        }

        private void btnFormDgv_Click(object sender, EventArgs e)
        {
            var frm = new FormDgv();
            frm.Show();
        }
    }
}
