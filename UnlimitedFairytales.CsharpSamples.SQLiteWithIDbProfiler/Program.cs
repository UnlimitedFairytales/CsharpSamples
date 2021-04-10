using StackExchange.Profiling.Data;
using System;
using System.Data.Common;
using System.Data.SQLite;
using System.IO;

namespace UnlimitedFairytales.CsharpSamples.SQLiteWithIDbProfiler
{
    class Program
    {
        static readonly string DB_FILE_PATH = @"DB\sqlite.db";
        static void Main(string[] args)
        {
            DbConnection conn;
            if (!File.Exists(DB_FILE_PATH))
            {
                conn = CreateDbFileAndOpen(DB_FILE_PATH);
            }
            else
            {
                conn = new SQLiteConnection();
                conn.ConnectionString = $@"Data Source={DB_FILE_PATH}";
                conn = DecorateDbConnection(conn);
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

        static DbConnection CreateDbFileAndOpen(string dbFilePath)
        {
            var dirPath = Path.GetDirectoryName(DB_FILE_PATH);
            if (!Directory.Exists(dirPath))
            {
                Directory.CreateDirectory(dirPath);
            }
            SQLiteConnection.CreateFile(dbFilePath);
            DbConnection conn = new SQLiteConnection();
            conn.ConnectionString = $@"Data Source={dbFilePath}";
            conn = DecorateDbConnection(conn);
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

        static DbConnection DecorateDbConnection(DbConnection innerDbConnection)
        {
            var profiler = new Log4netDbProfiler();
            var conn = new ProfiledDbConnection(innerDbConnection, profiler);
            return conn;
        }
    }
}
