using System;

namespace UnlimitedFairytales.CsharpSamples.MailKitSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var sender = new MailSender(
                "dummy.co.jp",
                587,
                true,
                true,
                "john.doe@dummy.co.jp",
                "password",
                3000);
            sender.Send("タイトルです。", "本文です", "john.doe@dummy.co.jp", new string[] { "jane.doe@dummy.co.jp" });
        }
    }
}
