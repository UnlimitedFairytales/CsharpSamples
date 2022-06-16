using System;
using System.Linq;
using System.Collections.Generic;
using Xunit;

namespace UnlimitedFairytales.CsharpSamples.DotNetTests
{
    public class UnitTest1
    {
        sealed class DummyObject
        {
            private static bool privateEqual(DummyObject a, DummyObject b)
            {
                return a.Num == b.Num
                   && (((((a.NumArray == null && b.NumArray == null)
                       || (a.NumArray != null && b.NumArray != null && a.NumArray.SequenceEqual(b.NumArray))
                       ))))
                   && a.Object == b.Object;
            }

            public override bool Equals(object obj)
            {
                if (obj is DummyObject casted)
                {
                    return privateEqual(this, casted);
                }
                return false;
            }

            public int Num;
            public int[] NumArray;
            public DummyObject2 Object;
        }

        class DummyObject2
        {
            public int Num;
        }

        [Fact]
        public void xUnitTest()
        {
            int actI = 1;
            long actL = 1;
            string actS = "1";
            int[] actArray = new int[] { 1, 2, 4 };
            List<int> actList = new List<int>() { 1, 2, 4 };            
            DummyObject2 innerAct = new DummyObject2() { Num = 1 };
            DummyObject2 innerExp = new DummyObject2() { Num = 1 };
            DummyObject actObj = new DummyObject() { Num = 10, NumArray = new int[] { 11, 12 }, Object = innerAct };
            DummyObject expObj1 = new DummyObject() { Num = 10, NumArray = new int[] { 11, 12 }, Object = innerExp };
            DummyObject expObj2 = new DummyObject() { Num = 10, NumArray = new int[] { 11, 12 }, Object = innerAct };

            Assert.Equal(1, actI);
            Assert.Equal(1L, actI);
            Assert.Equal(1, actL);
            Assert.Equal(1L, actL);
            // Assert.Equal(1, actS);
            // Assert.Equal('1', actS);
            Assert.Equal(new char[] { '1' }, actS);
            Assert.Equal("1", actS);
            Assert.Equal(new int[] { 1, 2, 4 }, actArray);
            Assert.Equal(new int[] { 1, 2, 4 }, actList);
            Assert.Equal(actArray, actList);
            Assert.NotSame(new int[] { 1, 2, 4 }, actArray);
            Assert.NotSame(new int[] { 1, 2, 4 }, actList);
            Assert.NotSame(actArray, actList);

            Assert.NotEqual(expObj1, actObj);
            Assert.Equal(expObj2, actObj);
            Assert.False(expObj2 == actObj);
        }

        [Fact]
        public void MailAddressFormatTest1()
        {
            // OK
            // !#$%&'-=^~|`{+*}/?_
            // NG
            // "()\@[;:],<.>
            new System.Net.Mail.MailAddress("!a@c");
            Assert.Throws<FormatException>(() => new System.Net.Mail.MailAddress("\"a@c"));
            new System.Net.Mail.MailAddress("#a@c");
            new System.Net.Mail.MailAddress("$a@c");
            new System.Net.Mail.MailAddress("%a@c");
            new System.Net.Mail.MailAddress("&a@c");
            new System.Net.Mail.MailAddress("'a@c");
            Assert.Throws<FormatException>(() => new System.Net.Mail.MailAddress("(a@c"));
            Assert.Throws<FormatException>(() => new System.Net.Mail.MailAddress(")a@c"));
            new System.Net.Mail.MailAddress("-a@c");
            new System.Net.Mail.MailAddress("=a@c");
            new System.Net.Mail.MailAddress("^a@c");
            new System.Net.Mail.MailAddress("~a@c");
            Assert.Throws<FormatException>(() => new System.Net.Mail.MailAddress("\\a@c"));
            new System.Net.Mail.MailAddress("|a@c");
            Assert.Throws<FormatException>(() => new System.Net.Mail.MailAddress("@a@c"));
            new System.Net.Mail.MailAddress("`a@c");
            Assert.Throws<FormatException>(() => new System.Net.Mail.MailAddress("[a@c"));
            new System.Net.Mail.MailAddress("{a@c");
            Assert.Throws<FormatException>(() => new System.Net.Mail.MailAddress(";a@c"));
            new System.Net.Mail.MailAddress("+a@c");
            Assert.Throws<FormatException>(() => new System.Net.Mail.MailAddress(":a@c"));
            new System.Net.Mail.MailAddress("*a@c");
            Assert.Throws<FormatException>(() => new System.Net.Mail.MailAddress("]a@c"));
            new System.Net.Mail.MailAddress("}a@c");
            Assert.Throws<FormatException>(() => new System.Net.Mail.MailAddress(",a@c"));
            Assert.Throws<FormatException>(() => new System.Net.Mail.MailAddress("<a@c"));
            Assert.Throws<FormatException>(() => new System.Net.Mail.MailAddress(".a@c"));
            Assert.Throws<FormatException>(() => new System.Net.Mail.MailAddress(">a@c"));
            new System.Net.Mail.MailAddress("/a@c");
            new System.Net.Mail.MailAddress("?a@c");
            new System.Net.Mail.MailAddress("_a@c");
        }

        [Fact]
        public void MailAddressFormatTest2()
        {
            new System.Net.Mail.MailAddress("a..b@c"); // 本来はNGだが、キャリアメールなどで許容される
        }

        [Fact]
        public void MailAddressFormatTest3()
        {
            // OK
            // !#$%&'-=^~|`{+*}/?_
            // NG
            // "()\@[;:],<.>
            new System.Net.Mail.MailAddress("a@!c");
            Assert.Throws<FormatException>(() => new System.Net.Mail.MailAddress("a@\"c"));
            new System.Net.Mail.MailAddress("a@#c");
            new System.Net.Mail.MailAddress("a@$c");
            new System.Net.Mail.MailAddress("a@%c");
            new System.Net.Mail.MailAddress("a@&c");
            new System.Net.Mail.MailAddress("a@'c");
            Assert.Throws<FormatException>(() => new System.Net.Mail.MailAddress("a@(c"));
            Assert.Throws<FormatException>(() => new System.Net.Mail.MailAddress("a@)c"));
            new System.Net.Mail.MailAddress("a@-c");
            new System.Net.Mail.MailAddress("a@=c");
            new System.Net.Mail.MailAddress("a@^c");
            new System.Net.Mail.MailAddress("a@~c");
            Assert.Throws<FormatException>(() => new System.Net.Mail.MailAddress("a@\\c"));
            new System.Net.Mail.MailAddress("a@|c");
            Assert.Throws<FormatException>(() => new System.Net.Mail.MailAddress("a@@c"));
            new System.Net.Mail.MailAddress("a@`c");
            Assert.Throws<FormatException>(() => new System.Net.Mail.MailAddress("a@[c"));
            new System.Net.Mail.MailAddress("a@{c");
            Assert.Throws<FormatException>(() => new System.Net.Mail.MailAddress("a@;c"));
            new System.Net.Mail.MailAddress("a@+c");
            Assert.Throws<FormatException>(() => new System.Net.Mail.MailAddress("a@:c"));
            new System.Net.Mail.MailAddress("a@*c");
            Assert.Throws<FormatException>(() => new System.Net.Mail.MailAddress("a@]c"));
            new System.Net.Mail.MailAddress("a@}c");
            Assert.Throws<FormatException>(() => new System.Net.Mail.MailAddress("a@,c"));
            Assert.Throws<FormatException>(() => new System.Net.Mail.MailAddress("a@<c"));
            Assert.Throws<FormatException>(() => new System.Net.Mail.MailAddress("a@.c"));
            Assert.Throws<FormatException>(() => new System.Net.Mail.MailAddress("a@>c"));
            new System.Net.Mail.MailAddress("a@/c");
            new System.Net.Mail.MailAddress("a@?c");
            new System.Net.Mail.MailAddress("a@_c");
        }
        [Fact]
        public void MailAddressFormatTest4()
        {
            // 255 chars @c
            new System.Net.Mail.MailAddress(
                "12345678901234567890123456789012345678901234567890" +
                "abcdefghijabcdefghijabcdefghijabcdefghijabcdefghij" +
                "12345678901234567890123456789012345678901234567890" +
                "abcdefghijabcdefghijabcdefghijabcdefghijabcdefghij" +
                "12345678901234567890123456789012345678901234567890" +
                "12345" + 
                "@c");
            // 256 chars @c
            new System.Net.Mail.MailAddress(
                "12345678901234567890123456789012345678901234567890" +
                "abcdefghijabcdefghijabcdefghijabcdefghijabcdefghij" +
                "12345678901234567890123456789012345678901234567890" +
                "abcdefghijabcdefghijabcdefghijabcdefghijabcdefghij" +
                "12345678901234567890123456789012345678901234567890" +
                "123456" +
                "@c");
            // a@ 255 chars
            new System.Net.Mail.MailAddress(
                "a@" + 
                "12345678901234567890123456789012345678901234567890" +
                "abcdefghijabcdefghijabcdefghijabcdefghijabcdefghij" +
                "12345678901234567890123456789012345678901234567890" +
                "abcdefghijabcdefghijabcdefghijabcdefghijabcdefghij" +
                "12345678901234567890123456789012345678901234567890" +
                "12345");
            // a@ 256 chars
            new System.Net.Mail.MailAddress(
                "a@" +
                "12345678901234567890123456789012345678901234567890" +
                "abcdefghijabcdefghijabcdefghijabcdefghijabcdefghij" +
                "12345678901234567890123456789012345678901234567890" +
                "abcdefghijabcdefghijabcdefghijabcdefghijabcdefghij" +
                "12345678901234567890123456789012345678901234567890" +
                "123456");
            // 256 chars @ 256 chars
            new System.Net.Mail.MailAddress(
                "12345678901234567890123456789012345678901234567890" +
                "abcdefghijabcdefghijabcdefghijabcdefghijabcdefghij" +
                "12345678901234567890123456789012345678901234567890" +
                "abcdefghijabcdefghijabcdefghijabcdefghijabcdefghij" +
                "12345678901234567890123456789012345678901234567890" +
                "123456" +
                "@" +
                "12345678901234567890123456789012345678901234567890" +
                "abcdefghijabcdefghijabcdefghijabcdefghijabcdefghij" +
                "12345678901234567890123456789012345678901234567890" +
                "abcdefghijabcdefghijabcdefghijabcdefghijabcdefghij" +
                "12345678901234567890123456789012345678901234567890" +
                "123456");
        }
    }
}
