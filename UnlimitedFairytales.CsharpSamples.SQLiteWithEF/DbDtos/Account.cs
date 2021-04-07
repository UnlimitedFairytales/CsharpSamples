using System.ComponentModel.DataAnnotations.Schema;

namespace UnlimitedFairytales.CsharpSamples.SQLiteWithEF.DbDtos
{
    [Table("accounts")]
    public class Account
    {
        public int id { get; set; }

        public string name { get; set; }
    }
}
