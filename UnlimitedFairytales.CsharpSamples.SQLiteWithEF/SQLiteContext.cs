using System.Data.Entity;
using UnlimitedFairytales.CsharpSamples.SQLiteWithEF.DbDtos;

namespace UnlimitedFairytales.CsharpSamples.SQLiteWithEF
{
    public class SQLiteContext : DbContext
    {
        public SQLiteContext() : base("name = Sample")
        {
        }

        public DbSet<Account> Accounts { get; set; }
    }


}
