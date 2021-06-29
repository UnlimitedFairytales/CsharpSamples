using System;
using System.Text.Json;

namespace UnlimitedFairytales.CsharpSamples.ConfigurationBuilderSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var setting = new Setting();
            var options = new JsonSerializerOptions();
            options.IncludeFields = true;
            var text = JsonSerializer.Serialize<Setting>(setting, options);
            text = text.Replace("[", "[" + Environment.NewLine);
            text = text.Replace("]", Environment.NewLine + "]");
            text = text.Replace("{", "{" + Environment.NewLine);
            text = text.Replace("}", Environment.NewLine + "}");
            text = text.Replace(",", "," + Environment.NewLine);
            Console.WriteLine(text);
            Console.ReadKey();
        }
    }
}
