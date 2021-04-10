using Oracle.ManagedDataAccess.Client;
using System;
using System.Windows.Forms;

namespace UnlimitedFairytales.CsharpSamples.Oracle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var conn = new OracleConnection();
            conn.ConnectionString = "User ID=foo; Password=bar; Data Source=192.168.3.251:1521/dev";
            conn.Open();
            var cmd = conn.CreateCommand();
            cmd.CommandText = "select * from accounts";
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    var str = "id:" + reader.GetInt32(0).ToString() + Environment.NewLine
                        + "name:" + reader.GetString(1);
                    MessageBox.Show(str);
                }
            }
        }
    }
}