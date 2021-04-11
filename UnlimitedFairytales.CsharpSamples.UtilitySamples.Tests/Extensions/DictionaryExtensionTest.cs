using System.Collections.Generic;
using UnlimitedFairytales.CsharpSamples.UtilitySamples.Extensions;
using Xunit;

namespace UnlimitedFairytales.CsharpSamples.UtilitySamples.Tests.Extensions
{
    public class DictionaryExtensionTest
    {
        [Fact]
        public void TestAddOrUpdate()
        {
            {
                // Arrange
                var dic = new Dictionary<string, string>()
                {
                    ["foo"] = "Alice",
                    ["bar"] = "Bob",
                    ["baz"] = "Carol",
                    ["qux"] = "Dave"
                };
                // Act
                dic.AddOrUpdate("foo", "Eve");
                // Assert
                Assert.Equal("Eve", dic["foo"]);
            }
            {
                // Arrange
                var dic = new Dictionary<string, string>()
                {
                    ["foo"] = "Alice",
                    ["bar"] = "Bob",
                    ["baz"] = "Carol",
                    ["qux"] = "Dave"
                };
                // Act
                dic.AddOrUpdate("foobar", "Eve");
                // Assert
                Assert.Equal("Eve", dic["foobar"]);
            }
        }
    }
}
