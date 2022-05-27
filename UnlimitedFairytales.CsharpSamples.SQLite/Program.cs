using System;
using System.Data.SQLite;
using System.IO;

namespace UnlimitedFairytales.CsharpSamples.SQLite
{
    class Program
    {
        static readonly string DB_FILE_PATH = @"DB\sqlite.db";
        static void Main(string[] args)
        {
            Console.WriteLine("sqlite");
            SQLiteConnection conn;
            if (!File.Exists(DB_FILE_PATH))
            {
                conn = CreateDbFileAndOpen(DB_FILE_PATH);
            }
            else
            {
                conn = new SQLiteConnection();
                conn.ConnectionString = $@"Data Source={DB_FILE_PATH}";
                conn.Open();
            }
            
            var cmd = conn.CreateCommand();
            cmd.CommandText = "select * from accounts";
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    var str = "id:" + reader.GetInt32(0).ToString() + Environment.NewLine
                        + "name:" + reader.GetString(1);
                    Console.WriteLine(str);
                }
            }
            Console.ReadKey();
        }

        // レガシ.NET Framework + System.Data.SQLiteではCodeFirstをサポートしていないため、手動作成が必要（別途野良OSSはあるが）
        // これはEntity Frameworkの作法（DbContextで接続処理等が隠蔽されている）時、とても面倒になる
        // SQLite CreateDatabase not supported error
        // https://stackoverflow.com/questions/8505999/sqlite-createdatabase-not-supported-error
        static SQLiteConnection CreateDbFileAndOpen(string dbFilePath)
        {
            var dirPath = Path.GetDirectoryName(DB_FILE_PATH);
            if (!Directory.Exists(dirPath))
            {
                Directory.CreateDirectory(dirPath);
            }
            SQLiteConnection.CreateFile(dbFilePath);
            var conn = new SQLiteConnection();
            conn.ConnectionString = $@"Data Source={dbFilePath}";
            conn.Open();
            var cmd = conn.CreateCommand();
            cmd.CommandText = "create table accounts (id INTEGER NOT NULL, name TEXT, primary key(id))";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "insert into accounts VALUES(1, 'Alice')";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "insert into accounts VALUES(2, 'Bob')";
            cmd.ExecuteNonQuery();
            return conn;
        }
    }
}
