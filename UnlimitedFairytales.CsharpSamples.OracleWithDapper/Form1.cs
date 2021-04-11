using Dapper;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Windows.Forms;

namespace UnlimitedFairytales.CsharpSamples.OracleWithDapper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("oracle with dapper");
            var conn = new OracleConnection();
            conn.ConnectionString = "User ID=foo; Password=bar; Data Source=192.168.3.251:1521/dev";
            conn.Open();
            var results = conn.Query("select id, name from accounts");
            foreach (var r in results)
            {
                var str = $"id:{r.ID}, name:{r.NAME}"; // Oracleは既定ではselect文の記述に関係なく大文字で列名を返すため、大文字で取得する必要がある
                MessageBox.Show(str);
            }
        }

        
    }
}
