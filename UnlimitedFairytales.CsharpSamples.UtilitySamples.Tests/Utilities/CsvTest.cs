using CsvHelper;
using CsvHelper.Configuration;
using UnlimitedFairytales.CsharpSamples.UtilitySamples.Utilities;
using Xunit;

namespace UnlimitedFairytales.CsharpSamples.UtilitySamples.Tests.Utilities
{
    public class CsvTest
    {
        // UNDONE:static Csv()

        public class AccountEntity
        {
            public long? Id { get; set; }
            public string Name { get; set; }
            public string EMail { get; set; }
            public int Age { get; set; }
            public string Note { get; set; }
            public string Note2 { get; set; }
            public string Note3 { get; set; }
        }

        public class AccountMap : ClassMap<AccountEntity>
        {
            public AccountMap()
            {
                Map(m => m.Id).Name("ID");
                Map(m => m.Name).Name("名前");
                Map(m => m.EMail).Name("E-Mail");
                Map(m => m.Age).Name("年齢");
                Map(m => m.Note).Name("1 備考").NameIndex(0);
                Map(m => m.Note2).Name("1 備考").NameIndex(1);
                Map(m => m.Note3).Name("1 備考").NameIndex(2);
            }
        }

        [Fact]
        public void TestRead()
        {
            {
                // Arrange
                // Act
                var accounts = Csv.Read("sjis-csv-sample.csv");
                // Assert
                Assert.Equal("1", accounts[0]["ID"]);
                Assert.Equal("Alice", accounts[0]["名前"]);
                Assert.Equal("alice@foo.com", accounts[0]["E-Mail"]);
                Assert.Equal("18", accounts[0]["年齢"]);
                Assert.Equal("note", accounts[0]["1 備考"]);
                Assert.Equal("note2", accounts[0]["1 備考1"]);
                Assert.Equal("note3", accounts[0]["1 備考2"]);

                Assert.Equal("2", accounts[1]["ID"]);
                Assert.Equal("Bob", accounts[1]["名前"]);
                Assert.Equal("bob@bar.com", accounts[1]["E-Mail"]);
                Assert.Equal("21", accounts[1]["年齢"]);
                Assert.Equal("note", accounts[1]["1 備考"]);
                Assert.Equal("note2", accounts[1]["1 備考1"]);
                Assert.Equal("note3", accounts[1]["1 備考2"]);

                Assert.Equal("3", accounts[2]["ID"]);
                Assert.Equal("Carol", accounts[2]["名前"]);
                Assert.Equal("carol@baz.com", accounts[2]["E-Mail"]);
                Assert.Equal("19", accounts[2]["年齢"]);
                Assert.Equal("note", accounts[2]["1 備考"]);
                Assert.Equal("note2", accounts[2]["1 備考1"]);
                Assert.Equal("note3", accounts[2]["1 備考2"]);

                Assert.Equal("4", accounts[3]["ID"]);
                Assert.Equal("Dave", accounts[3]["名前"]);
                Assert.Equal("dave@qux.com", accounts[3]["E-Mail"]);
                Assert.Equal("20", accounts[3]["年齢"]);
                Assert.Equal("note", accounts[3]["1 備考"]);
                Assert.Equal("note2", accounts[3]["1 備考1"]);
                Assert.Equal("note3", accounts[3]["1 備考2"]);
            }
            {
                // Arrange
                // Act
                // Assert
                Assert.Throws<BadDataException>(() => Csv.Read("sjis-csv-badsample.csv"));
            }
            {
                // Arrange
                // Act
                var accounts = Csv.Read("sjis-csv-badsample.csv", 932, true, null);
                // Assert
                Assert.Equal("1", accounts[0]["ID"]);
                Assert.Equal("Alice", accounts[0]["名前"]);
                Assert.Equal("alice@foo.com", accounts[0]["E-Mail"]);
                Assert.Equal("18", accounts[0]["年齢"]);
                Assert.Equal("note", accounts[0]["1 備考"]);
                Assert.Equal("note2", accounts[0]["1 備考1"]);
                Assert.Equal("note3", accounts[0]["1 備考2"]);

                Assert.Equal("2", accounts[1]["ID"]);
                Assert.Equal("Bob", accounts[1]["名前"]);
                Assert.Equal("bob@bar.com", accounts[1]["E-Mail"]);
                Assert.Equal("21", accounts[1]["年齢"]);
                Assert.Equal("note", accounts[1]["1 備考"]);
                Assert.Equal("note2", accounts[1]["1 備考1"]);
                Assert.Equal("note3", accounts[1]["1 備考2"]);

                Assert.Equal("3", accounts[2]["ID"]);
                Assert.Equal("Carol", accounts[2]["名前"]);
                Assert.Equal("carol@baz.com", accounts[2]["E-Mail"]);
                Assert.Equal("19", accounts[2]["年齢"]);
                Assert.Equal("note", accounts[2]["1 備考"]);
                Assert.Equal("note2", accounts[2]["1 備考1"]);
                Assert.Equal("note3", accounts[2]["1 備考2"]);

                Assert.Equal("4", accounts[3]["ID"]);
                Assert.Equal("Dave", accounts[3]["名前"]);
                Assert.Equal("dave@qux.com\"", accounts[3]["E-Mail"]);
                Assert.Equal("20", accounts[3]["年齢"]);
                Assert.Equal("no,te\"", accounts[3]["1 備考"]);
                Assert.Equal("note2", accounts[3]["1 備考1"]);
                Assert.Equal("note3", accounts[3]["1 備考2"]);
            }

        }

        [Fact]
        public void TestReadTTMap()
        {
            {
                // Arrange
                // Act
                var accounts = Csv.Read<AccountEntity, AccountMap>("sjis-csv-sample.csv");
                // Assert
                Assert.Equal(1, accounts[0].Id.Value);
                Assert.Equal("Alice", accounts[0].Name);
                Assert.Equal("alice@foo.com", accounts[0].EMail);
                Assert.Equal(18, accounts[0].Age);
                Assert.Equal("note", accounts[0].Note);
                Assert.Equal("note2", accounts[0].Note2);
                Assert.Equal("note3", accounts[0].Note3);

                Assert.Equal(2, accounts[1].Id.Value);
                Assert.Equal("Bob", accounts[1].Name);
                Assert.Equal("bob@bar.com", accounts[1].EMail);
                Assert.Equal(21, accounts[1].Age);
                Assert.Equal("note", accounts[1].Note);
                Assert.Equal("note2", accounts[1].Note2);
                Assert.Equal("note3", accounts[1].Note3);

                Assert.Equal(3, accounts[2].Id.Value);
                Assert.Equal("Carol", accounts[2].Name);
                Assert.Equal("carol@baz.com", accounts[2].EMail);
                Assert.Equal(19, accounts[2].Age);
                Assert.Equal("note", accounts[2].Note);
                Assert.Equal("note2", accounts[2].Note2);
                Assert.Equal("note3", accounts[2].Note3);

                Assert.Equal(4, accounts[3].Id.Value);
                Assert.Equal("Dave", accounts[3].Name);
                Assert.Equal("dave@qux.com", accounts[3].EMail);
                Assert.Equal(20, accounts[3].Age);
                Assert.Equal("note", accounts[3].Note);
                Assert.Equal("note2", accounts[3].Note2);
                Assert.Equal("note3", accounts[3].Note3);
            }
            {
                // Arrange
                // Act
                // Assert
                Assert.Throws<BadDataException>(() => Csv.Read<AccountEntity, AccountMap>("sjis-csv-badsample.csv"));
            }
            {
                // Arrange
                // Act
                var accounts = Csv.Read<AccountEntity, AccountMap>("sjis-csv-badsample.csv", true, 932, true, null);
                // Assert
                Assert.Equal(1, accounts[0].Id.Value);
                Assert.Equal("Alice", accounts[0].Name);
                Assert.Equal("alice@foo.com", accounts[0].EMail);
                Assert.Equal(18, accounts[0].Age);
                Assert.Equal("note", accounts[0].Note);
                Assert.Equal("note2", accounts[0].Note2);
                Assert.Equal("note3", accounts[0].Note3);

                Assert.Equal(2, accounts[1].Id.Value);
                Assert.Equal("Bob", accounts[1].Name);
                Assert.Equal("bob@bar.com", accounts[1].EMail);
                Assert.Equal(21, accounts[1].Age);
                Assert.Equal("note", accounts[1].Note);
                Assert.Equal("note2", accounts[1].Note2);
                Assert.Equal("note3", accounts[1].Note3);

                Assert.Equal(3, accounts[2].Id.Value);
                Assert.Equal("Carol", accounts[2].Name);
                Assert.Equal("carol@baz.com", accounts[2].EMail);
                Assert.Equal(19, accounts[2].Age);
                Assert.Equal("note", accounts[2].Note);
                Assert.Equal("note2", accounts[2].Note2);
                Assert.Equal("note3", accounts[2].Note3);

                Assert.Equal(4, accounts[3].Id.Value);
                Assert.Equal("Dave", accounts[3].Name);
                Assert.Equal("dave@qux.com\"", accounts[3].EMail);
                Assert.Equal(20, accounts[3].Age);
                Assert.Equal("no,te\"", accounts[3].Note);
                Assert.Equal("note2", accounts[3].Note2);
                Assert.Equal("note3", accounts[3].Note3);
            }
        }
    }
}
