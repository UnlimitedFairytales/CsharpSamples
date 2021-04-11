using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Runtime.Serialization;
using System.Windows.Forms;
using UnlimitedFairytales.CsharpSamples.FormUtilitySamples.Exceptions;

namespace UnlimitedFairytales.CsharpSamples.FormUtilitySamples.Tests.Exceptions
{
    [TestClass]
    public class FormValidationExceptionTest
    {
        [TestMethod]
        public void TestConstructor()
        {
            {
                // Arrange
                var ex = new FormValidationException(null, null);
                // Act
                // Assert
                Assert.AreEqual(true, ex.Message.Contains("FormValidationException"));
            }
            {
                // Arrange
                var ex = new FormValidationException(MyMessageConstant.ERR_SYSTEM, null);
                // Act
                // Assert
                Assert.AreEqual(true, ex.Message.Contains(Consts.ERR_SYSTEM));
            }
            {
                // Arrange
                var ctrl = new Control();
                ctrl.Name = "ctlText";
                var ex = new FormValidationException(MyMessageConstant.ERR_SYSTEM, ctrl);
                // Act
                // Assert
                Assert.AreEqual(true, ex.Message.Contains(Consts.ERR_SYSTEM));
                Assert.AreEqual(true, ex.Message.Contains("ctlText"));
            }
            {
                // Arrange
                var ctrl = new Control();
                ctrl.Name = "ctlText";
                var inner = new Exception("inner3");
                var ex = new FormValidationException(MyMessageConstant.ERR_SYSTEM, inner, ctrl);
                // Act
                // Assert
                Assert.AreEqual(true, ex.Message.Contains(Consts.ERR_SYSTEM));
                Assert.AreEqual(true, ex.Message.Contains("ctlText"));
                Assert.AreEqual(inner, ex.InnerException);
            }
        }

        [TestMethod]
        public void TestGetObjectData()
        {
            // Arrange
            var ctrl = new Control();
            ctrl.Name = "ctlText";
            var ex = new FormValidationException(MyMessageConstant.ERR_SYSTEM, ctrl);
            // Act
            var info = new SerializationInfo(typeof(FormValidationException), new FormatterConverter());
            var context = new StreamingContext();
            // Assert
            Assert.ThrowsException<NotSupportedException>(() => ex.GetObjectData(info, context));
        }

        [TestMethod]
        public void TestMessage()
        {
            // Arrange
            var ctrl = new Control();
            ctrl.Name = "ctlText";
            var ex = new FormValidationException(MyMessageConstant.ERR_SYSTEM, ctrl);
            // Act
            // Assert
            Assert.AreEqual(true, ex.Message.Contains(Consts.ERR_SYSTEM));
            Assert.AreEqual(true, ex.Message.Contains("ctlText"));
        }
    }
}
