using Npgsql;
using System;

namespace UnlimitedFairytales.CsharpSamples.Postgres
{
    class Program
    {
        static void Main(string[] args)
        {
            NpgsqlConnection conn;
            conn = new NpgsqlConnection();
            conn.ConnectionString = @"Username = foo; Password = bar; Host = 192.168.3.252; Port = 5432; Database = test";
            conn.Open();

            var cmd = conn.CreateCommand();
            cmd.CommandText = "select * from accounts";
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var str = "id:" + reader.GetInt32(0).ToString() + Environment.NewLine
                    + "name:" + reader.GetString(1);
                Console.WriteLine(str);
            }
            Console.ReadKey();
        }
    }
}
