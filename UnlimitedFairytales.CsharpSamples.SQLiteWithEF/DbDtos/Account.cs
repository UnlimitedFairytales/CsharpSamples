using System.ComponentModel.DataAnnotations.Schema;

namespace UnlimitedFairytales.CsharpSamples.SQLiteWithEF.DbDtos
{
    [Table("accounts")]
    public class Account
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; }
    }
}
