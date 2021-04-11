using System;
using System.Collections.Generic;
using UnlimitedFairytales.CsharpSamples.UtilitySamples.Extensions;
using Xunit;

namespace UnlimitedFairytales.CsharpSamples.UtilitySamples.Tests.Extensions
{
    public class VarDumpExtensionTest
    {
        class SampleClass
        {
            public int Foo;
            public string Bar;
            public DateTime[] Baz;
            public List<ConsoleColor> Qux;
        }

        [Fact]
        public void Testvar_dump()
        {
            {
                // Arrange
                var obj = new SampleClass() {
                    Foo = 12345,
                    Bar = "banana",
                    Baz = new DateTime[] { new DateTime(2019, 7, 1), new DateTime(2019, 7, 2) },
                    Qux = new List<ConsoleColor> { ConsoleColor.Black, ConsoleColor.White }
                };
                // Act
                var str = obj.var_dump();
                // Assert
                var answer =
@"class SampleClass {
  .Foo => Int32(12345)
  .Bar => String(banana)
  .Baz => Array [
    DateTime(2019/07/01 0:00:00)
    DateTime(2019/07/02 0:00:00)
  ]
  .Qux => List<> [
    ConsoleColor(Black)
    ConsoleColor(White)
  ]
}
";
                Assert.Equal(answer, str);
            }
        }
    }
}
