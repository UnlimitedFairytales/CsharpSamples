using System;
using System.Linq;

namespace UnlimitedFairytales.CsharpSamples.SQLiteWithEF
{
    /* System.Data.SQLite パッケージ利用時の注意点
     * 以下追記必要

  <entityFramework>
    <providers>
      ...
      <provider invariantName="System.Data.SQLite" type="System.Data.SQLite.EF6.SQLiteProviderServices, System.Data.SQLite.EF6" />
      ...
    </providers>
  </entityFramework>
  ...
  <connectionStrings>
    <add name="Sample" providerName="System.Data.SQLite.EF6" connectionString="Data Source=DB\sqlite.db" />
  </connectionStrings>

     * DBファイル作成に未対応
     * また、MigrationもSystem.Data.Sqliteパッケージ単体では未対応
     * 予め、スキーマ作成済みのDBファイルが必要
     * create table accounts(id INTEGER, name TEXT, PRIMARY KEY (id));
     */
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new SQLiteContext())
            {
                var accounts = context.Accounts.ToList();
                if (accounts.Count == 0)
                {
                    using (var tx = context.Database.BeginTransaction())
                    {
                        context.Accounts.Add(new DbDtos.Account() { id = 1, name = "Alice" });
                        context.Accounts.Add(new DbDtos.Account() { id = 2, name = "Bob" });
                        context.SaveChanges();
                        tx.Commit();
                    }
                    accounts = context.Accounts.ToList();
                }
                foreach (var item in accounts)
                {
                    Console.WriteLine($"id={item.id}, name={item.name}");
                }
                Console.ReadKey();
            }
        }
    }
}
