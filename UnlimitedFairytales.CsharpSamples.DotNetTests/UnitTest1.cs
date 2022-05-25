using System;
using Xunit;

namespace UnlimitedFairytales.CsharpSamples.DotNetTests
{
    public class UnitTest1
    {
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
