using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace UnlimitedFairytales.CsharpSamples.UtilitySamples.Utilities
{
    public static class Csv
    {
        static Csv()
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        }

        public static List<IDictionary<string, object>> Read(string filePath,
            int codePage = CodePage.SJIS_WIN,
            bool handlesBadDataFound = false,
            Action<ReadingContext> badDataFound = null)
        {
            using (var fs = File.OpenRead(filePath))
            using (var sr = new StreamReader(fs, Encoding.GetEncoding(codePage)))
            {
                var reader = new CsvReader(sr);
                // reader.Configuration.AllowComments = false;
                if (handlesBadDataFound)
                {
                    reader.Configuration.BadDataFound = badDataFound;
                }
                // reader.Configuration.BufferSize = 2048;
                // reader.Configuration.Comment = '#';
                // reader.Configuration.CountBytes = false;
                // reader.Configuration.CultureInfo = System.Globalization.CultureInfo.CurrentCulture;
                // reader.Configuration.Delimiter = ",";
                // reader.Configuration.DetectColumnCountChanges = false;
                reader.Configuration.Encoding = Encoding.GetEncoding(codePage);
                reader.Configuration.HasHeaderRecord = true;
                // reader.Configuration.HeaderValidated = ...
                // reader.Configuration.IgnoreBlankLines = true;
                // reader.Configuration.IgnoreQuotes = false;
                // reader.Configuration.IncludePrivateMembers = true;
                // reader.Configuration.MemberTypes = MemberTypes.Properties;
                // reader.Configuration.MissingFieldFound = ...
                reader.Configuration.PrepareHeaderForMatch = (header) =>
                {
                    var duplicatedCount = 0;
                    for (int i = 0; i < reader.Context.CurrentIndex + 1; i++)
                    {
                        if (reader.Context.HeaderRecord[i] == header)
                        {
                            duplicatedCount++;
                        }
                    }
                    if (duplicatedCount == 0) return header;
                    return header + duplicatedCount.ToString();
                };
                // reader.Configuration.Quote = '"';
                // reader.Configuration.ReadingExceptionOccurred = ...
                // reader.Configuration.ReferenceHeaderPrefix = ...
                // reader.Configuration.RegisterClassMap<TMap>();
                // reader.Configuration.ShouldSkipRecord = (record) => false;
                // reader.Configuration.ShouldUseConstructorParameters = (record) => false;
                // reader.Configuration.TrimOptions = TrimOptions.None;
                var records = reader.GetRecords<dynamic>().Cast<IDictionary<string, object>>().ToList();
                return records;
            }
        }

        public static List<T> Read<T, TMap>(string filePath,
            bool hasHeaderRecord = true,
            int codePage = CodePage.SJIS_WIN,
            bool handlesBadDataFound = false,
            Action<ReadingContext> badDataFound = null) where TMap : ClassMap<T>
        {
            using (var fs = File.OpenRead(filePath))
            using (var sr = new StreamReader(fs, Encoding.GetEncoding(codePage)))
            {
                var reader = new CsvReader(sr);
                // reader.Configuration.AllowComments = false;
                if (handlesBadDataFound)
                {
                    reader.Configuration.BadDataFound = badDataFound;
                }
                // reader.Configuration.BufferSize = 2048;
                // reader.Configuration.Comment = '#';
                // reader.Configuration.CountBytes = false;
                // reader.Configuration.CultureInfo = System.Globalization.CultureInfo.CurrentCulture;
                // reader.Configuration.Delimiter = ",";
                // reader.Configuration.DetectColumnCountChanges = false;
                reader.Configuration.Encoding = Encoding.GetEncoding(codePage);
                reader.Configuration.HasHeaderRecord = hasHeaderRecord;
                // reader.Configuration.HeaderValidated = ...
                // reader.Configuration.IgnoreBlankLines = true;
                // reader.Configuration.IgnoreQuotes = false;
                // reader.Configuration.IncludePrivateMembers = true;
                // reader.Configuration.MemberTypes = MemberTypes.Properties;
                // reader.Configuration.MissingFieldFound = ...
                // reader.Configuration.PrepareHeaderForMatch = header => header;
                // reader.Configuration.Quote = '"';
                // reader.Configuration.ReadingExceptionOccurred = ...
                // reader.Configuration.ReferenceHeaderPrefix = ...
                reader.Configuration.RegisterClassMap<TMap>();
                // reader.Configuration.ShouldSkipRecord = (record) => false;
                // reader.Configuration.ShouldUseConstructorParameters = (record) => false;
                // reader.Configuration.TrimOptions = TrimOptions.None;
                var records = reader.GetRecords<T>().ToList();
                return records;
            }
        }
    }
}
