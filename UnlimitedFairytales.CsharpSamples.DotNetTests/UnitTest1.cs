using System;
using Xunit;

namespace UnlimitedFairytales.CsharpSamples.DotNetTests
{
    public class UnitTest1
    {
        [Fact]
        public void MailAddressFormatTest1()
        {
            // "()\@[];:,.<>
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
            // "()\@[];:,.<>
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
            // 255
            new System.Net.Mail.MailAddress(
                "12345678901234567890123456789012345678901234567890" +
                "abcdefghijabcdefghijabcdefghijabcdefghijabcdefghij" +
                "12345678901234567890123456789012345678901234567890" +
                "abcdefghijabcdefghijabcdefghijabcdefghijabcdefghij" +
                "12345678901234567890123456789012345678901234567890" +
                "12345" + 
                "@c");
            new System.Net.Mail.MailAddress(
                "12345678901234567890123456789012345678901234567890" +
                "abcdefghijabcdefghijabcdefghijabcdefghijabcdefghij" +
                "12345678901234567890123456789012345678901234567890" +
                "abcdefghijabcdefghijabcdefghijabcdefghijabcdefghij" +
                "12345678901234567890123456789012345678901234567890" +
                "123456" +
                "@c");
            // 255
            new System.Net.Mail.MailAddress(
                "a@" + 
                "12345678901234567890123456789012345678901234567890" +
                "abcdefghijabcdefghijabcdefghijabcdefghijabcdefghij" +
                "12345678901234567890123456789012345678901234567890" +
                "abcdefghijabcdefghijabcdefghijabcdefghijabcdefghij" +
                "12345678901234567890123456789012345678901234567890" +
                "12345");
            // 256
            new System.Net.Mail.MailAddress(
                "a@" +
                "12345678901234567890123456789012345678901234567890" +
                "abcdefghijabcdefghijabcdefghijabcdefghijabcdefghij" +
                "12345678901234567890123456789012345678901234567890" +
                "abcdefghijabcdefghijabcdefghijabcdefghijabcdefghij" +
                "12345678901234567890123456789012345678901234567890" +
                "123456");
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
