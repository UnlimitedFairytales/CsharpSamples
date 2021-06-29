using Microsoft.Extensions.Configuration;
using System.IO;
using System.Linq;

namespace UnlimitedFairytales.CsharpSamples.ConfigurationBuilderSample
{
    class Class1
    {
        public long Id;
        public string Name;
    }

    class Setting
    {
        public readonly string StringSample;
        public readonly int IntSample;
        public readonly bool BoolSample;
        public readonly string[] StringArraySample;
        public readonly Class1 ClassSample;
        public readonly Class1[] ClassArraySample;

        public Setting(string filePath = "sample-setting.json")
        {
            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile(filePath);
            var configuration = builder.Build();

            this.StringSample = configuration["StringSample"];
            this.IntSample = int.Parse(configuration["IntSample"]);
            this.BoolSample = bool.Parse(configuration["BoolSample"]);
            this.StringArraySample = configuration.GetSection("StringArraySample").GetChildren().Select(x => x.Value).ToArray();
            var kv = configuration.GetSection("ClassSample");
            this.ClassSample = new Class1
            {
                Id = long.Parse(kv["Id"]),
                Name = kv["Name"]
            };
            this.ClassArraySample = configuration.GetSection("ClassArraySample").GetChildren().Select(
                cc => new Class1
                {
                    Id = long.Parse(cc["Id"]),
                    Name = cc["Name"]
                }).ToArray();
        }
    }
}
