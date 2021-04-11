using System.Net.Mail;
using UnlimitedFairytales.CsharpSamples.UtilitySamples.Utilities;
using Xunit;

namespace UnlimitedFairytales.CsharpSamples.UtilitySamples.Tests.Utilities
{
    public class MailTest
    {
        public string Body =>
@"【お問い合わせサンプル】より

お問い合わせありがとうございます。
下記内容にて、お問い合わせを受け付けました。

名前
Alice

メール
alice@foo.com

性別
女性

お問い合わせ種類
お問い合わせ種類1

お問い合わせ内容
このテキストはサンプルです。このテキストはサンプルです。
このテキストはサンプルです。このテキストはサンプルです。";

        [Fact(Skip = "This test confirms send mail.")]
        public void TestSend()
        {
            {
                // Arrange
                // Act
                // Assert
                Mail.Send(
                    "smtp.mailtrap.io",
                    "7387aad7ba7380",
                    "5537ae2f39e233",
                    "【メール送信サンプル1】お問い合わせありがとうございました",
                    Body,
                    "alice@foo.com",
                    new[] { "bob@bar.com" },
                    new[] { "carol@baz.com" },
                    new[] { "dave@qux.com"},
                    MailPriority.High,
                    true,
                    2525);
            }
            {
                // Arrange
                // Act
                // Assert
                Mail.Send(
                    "smtp.mailtrap.io",
                    "7387aad7ba7380",
                    "5537ae2f39e233",
                     "【メール送信サンプル2】お問い合わせありがとうございました",
                    Body,
                    "alice@foo.com",
                    new[] { "bob@bar.com" },
                    null,
                    null,
                    MailPriority.Low,
                    true,
                    2525);
            }
            {
                // Arrange
                // Act
                // Assert
                Mail.Send(
                    "smtp.mailtrap.io",
                    "7387aad7ba7380",
                    "5537ae2f39e233",
                     "【メール送信サンプル3】お問い合わせありがとうございました",
                    Body,
                    "alice@foo.com",
                    null,
                    new[] { "bob@bar.com" },
                    null,
                    MailPriority.Low,
                    true,
                    2525);
            }
        }
    }
}
