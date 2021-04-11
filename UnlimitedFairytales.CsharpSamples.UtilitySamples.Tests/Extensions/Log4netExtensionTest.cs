using log4net.Core;
using System;
using System.Reflection;
using UnlimitedFairytales.CsharpSamples.UtilitySamples.Extensions;
using Xunit;

namespace UnlimitedFairytales.CsharpSamples.UtilitySamples.Tests.Extensions
{
    public class Log4netExtensionTest
    {
        class DummyClass
        {
        }

        class DummyClass2
        {
        }

        // UNDONE:static Log4netExtension()

        [Fact]
        public void TestGetLogger()
        {
            {
                // Arrange
                // log4net.config.xml
                var obj = new DummyClass();
                // Act
                var logger = Log4netExtension.GetLogger(obj, "fooLogger");
                // Assert
                Assert.Equal("fooLogger", logger.Logger.Name);
                Assert.Equal(LoggerManager.GetRepository(Assembly.GetEntryAssembly()), logger.Logger.Repository);
            }
            {
                // Arrange
                // log4net.config.xml
                var obj = new DummyClass();
                // Act
                var logger = Log4netExtension.GetLogger(obj);
                // Assert
                Assert.Equal(typeof(DummyClass).FullName, logger.Logger.Name);
                Assert.Equal(LoggerManager.GetRepository(Assembly.GetEntryAssembly()), logger.Logger.Repository);
            }
            {
                // Arrange
                // log4net.config.xml
                var obj = new DummyClass();
                // Act
                var logger = Log4netExtension.GetLogger(obj, typeof(DummyClass2));
                // Assert
                Assert.Equal(typeof(DummyClass2).FullName, logger.Logger.Name);
                Assert.Equal(LoggerManager.GetRepository(Assembly.GetEntryAssembly()), logger.Logger.Repository);
            }
        }

        [Fact]
        public void TestGetLogger_Error()
        {
            // Arrange
            // log4net.config.xml
            var obj = new DummyClass();
            // Act
            var logger = Log4netExtension.GetLogger("hoge");
            // Assert
            try
            {
                throw new Exception("任意のエラー");
            }
            catch (Exception ex)
            {
                log4net.GlobalContext.Properties["UserId"] = "12345";
                logger.Error("メッセージ", ex);
            }
        }
    }
}
