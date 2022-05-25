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
            options.WriteIndented = true;
            var text = JsonSerializer.Serialize<Setting>(setting, options);
            Console.WriteLine(text);
            Console.ReadKey();
        }
    }
}
