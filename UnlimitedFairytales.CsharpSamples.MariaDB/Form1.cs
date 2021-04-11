using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace UnlimitedFairytales.CsharpSamples.MariaDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("mariadb");
            var conn = new MySqlConnection();
            conn.ConnectionString = "User ID=root; Password=foo; Data Source=192.168.3.253; Port=3306; Database=test";
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
