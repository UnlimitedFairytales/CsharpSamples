using System;
using System.Data.SQLite;
using System.IO;
using Dapper;

namespace UnlimitedFairytales.CsharpSamples.SQLiteWithDapper
{
    class Program
    {
        static readonly string DB_FILE_PATH = @"DB\sqlite.db";
        static void Main(string[] args)
        {
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

            var results = conn.Query("select * from accounts");

            foreach (var r in results)
            {
                Console.WriteLine($"id:{r.id}, name:{r.name}");
            }
            Console.ReadKey();
        }

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
            conn.Execute("create table accounts (id INTEGER NOT NULL, name TEXT, primary key(id))");
            conn.Execute("insert into accounts VALUES(1, 'Alice')");
            conn.Execute("insert into accounts VALUES(2, 'Bob')");
            return conn;
        }
    }
}
