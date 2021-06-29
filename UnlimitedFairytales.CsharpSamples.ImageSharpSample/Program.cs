using SixLabors.ImageSharp;
using System;

namespace UnlimitedFairytales.CsharpSamples.ImageSharpSample
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var img = Image.Load("./sample-image.png"))
            {
                Console.WriteLine(img.Size().ToString());
            }
            Console.ReadKey();
        }
    }
}
