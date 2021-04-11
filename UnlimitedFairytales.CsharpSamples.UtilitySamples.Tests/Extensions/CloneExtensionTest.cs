using System;
using UnlimitedFairytales.CsharpSamples.UtilitySamples.Extensions;
using Xunit;

namespace UnlimitedFairytales.CsharpSamples.UtilitySamples.Tests.Extensions
{
    public class CloneExtensionTest
    {
        [Serializable]
        class SerializableClass
        {
            public string Foo;
            public string Bar;
        }

        [Fact]
        public void TestClone()
        {
            {
                // Arrange
                var obj = new SerializableClass() { Foo = "apple", Bar = "banana" };
                // Act
                var cloned = obj.Clone();
                // Assert
                Assert.NotEqual(obj, cloned);
                Assert.Equal(obj.Foo, cloned.Foo);
                Assert.Equal(obj.Bar, cloned.Bar);
            }
        }
    }
}
