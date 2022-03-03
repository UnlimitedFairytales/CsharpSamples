using System;
using System.Linq;

namespace UnlimitedFairytales.CsharpSamples.SQLiteWithEF
{
    /* System.Data.SQLite パッケージ利用時の注意点
     * 1. App.configは、Nugetパッケージ導入時の自動書き換えだけでは記載が足りず、以下の追記も必要）
       https://stackoverflow.com/questions/29129796/no-entity-framework-provider-found-for-ef-6-and-sqlite-1-0-96-0

  <entityFramework>
    <providers>
      ...
      <provider invariantName="System.Data.SQLite" type="System.Data.SQLite.EF6.SQLiteProviderServices, System.Data.SQLite.EF6" />
      ...
    </providers>
  </entityFramework>
  ...
     * 2. 別途、App.configに接続設定の追記も必要
  <connectionStrings>
    <add name="Sample" providerName="System.Data.SQLite.EF6" connectionString="Data Source=DB\sqlite.db" />
  </connectionStrings>
     
     *
     * 3. DBファイル作成に未対応(1.0.115.5時点では対応されて作られるようになった？)
     * 4. MigrationコマンドもSystem.Data.Sqliteパッケージでは未対応。非公式Nugetパッケージを使えば可能だが…
     *    スキーマ作成済みのDBファイルの用意が推奨される
     *    create table accounts(id INTEGER, name TEXT, PRIMARY KEY (id));
     */

    /* EntityFramework の使い方と注意点
     * 
     * 1. Dtoは、大文字小文字を区別する。自動生成しない場合は注意。[Table()]や[Column()]で調整可能
     * 
     * 2. Select（全て）
     * ToListの時点でレイジーロードが終了し、データをDtoに詰めてしまう。10万件とか取得しちゃうとかなり遅い。
     * var accounts = context.Accounts.ToList();
     * 
     * 3. Select（特定）
     * var accounts = context.Accounts.Find(id);
     * 
     * 4. 削除
     * RemoveRange()は、Delete文を1行ずつ発行してしまう
     * context.Accounts.RemoveRange(accounts);
     * context.SaveChanges();
     * 
     * 5. 削除（全件）
     * SQLが明らかなら、下記のように直接SQLを発行したほうが速い
     * context.Database.ExecuteSqlCommand("Delete from accounts");
     * 
     * 6. Update文の発行に対応する記述はこんな感じ
     * db.Entry(item).State = EntityState.Modified;
     * context.SaveChanges();
     * 
     * 7. トランザクションの明示的な開始
     * 明示的な開始をしていなければ、SaveChanges時、ExecuteSqlCommand時にトランザクション開始～全SQL実施～コミットされるため、不要ならトランザクション必要はない。
     * 複数のSaveChangeやExecuteSqlCommandを1つのトランザクションで処理したい場合に使用する。
     * using(var tx = context.Database.BeginTransaction())
     * {
     *     ...
     *     context.SaveChanges();
     *     tx.Commit();
     * }
     * 
     * 8. DtoがDBレコードと一致していることを想定する設計方針の限界
     * そもそも論として、Web環境や並列アクセスが当たり前の環境では、楽観ロックか悲観ロックが必須である。
     * DtoはあくまでDtoと割り切り、DBと一致していることを期待するべきではないように思える。
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sqlite with EF");
            using (var context = new SQLiteContext())
            {
                var count = context.Database.SqlQuery<int>("SELECT COUNT(*) FROM sqlite_master WHERE type='table' AND name='accounts'").FirstOrDefault();
                if (count <= 0)
                {
                    context.Database.ExecuteSqlCommand("create table accounts (id INTEGER NOT NULL, name TEXT, primary key(id))");
                }
                var accounts = context.Accounts.ToList();
                if (accounts.Count == 0)
                {
                    using (var tx = context.Database.BeginTransaction())
                    {
                        context.Accounts.Add(new DbDtos.Account() { Id = 1, Name = "Alice" });
                        context.Accounts.Add(new DbDtos.Account() { Id = 2, Name = "Bob" });
                        context.SaveChanges();
                        tx.Commit();
                    }
                    using (var tx = context.Database.BeginTransaction())
                    {
                        context.Database.ExecuteSqlCommand("INSERT INTO accounts(id, name) values(3, 'Carol')");
                        context.Database.ExecuteSqlCommand("INSERT INTO accounts(id, name) values(4, 'Dave')");
                        tx.Commit();
                    }
                    accounts = context.Accounts.ToList();
                }
                foreach (var item in accounts)
                {
                    Console.WriteLine($"id={item.Id}, name={item.Name}");
                }
                Console.ReadKey();
            }
        }
    }
}
