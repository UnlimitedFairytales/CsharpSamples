using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using System;
using System.Threading;

namespace UnlimitedFairytales.CsharpSamples.MailKitSample
{
    class MailSender
    {
        public string SmtpUri { get; private set; }
        public int SmtpPort { get; private set; }
        public bool SmtpUsesTls { get; private set; }
        public bool NeedsAuthentication { get; set; }
        public string SmtpUserId { get; private set; }
        public string SmtpUserPassword { get; private set; }
        public int SafetyWait_ms { get; private set; }

        public MailSender(string smtpUri, int smtpPort, bool smtpUsesTls, bool needsAuthentication = false, string smtpUserId = "", string smtpUserPassword = "", int safetyWait_ms = 3000)
        {
            this.SmtpUri = smtpUri;
            this.SmtpPort = smtpPort;
            this.SmtpUsesTls = smtpUsesTls;
            this.NeedsAuthentication = needsAuthentication;
            this.SmtpUserId = smtpUserId;
            this.SmtpUserPassword = smtpUserPassword;
            this.SafetyWait_ms = safetyWait_ms;
        }

        public void Send(string subject, string text, string fromAddress, string[] toAddresses = null, string[] ccAddresses = null, string[] bccAddresses = null)
        {
            using (var client = new SmtpClient())
            {
                var message = new MimeMessage();
                message.Subject = subject;
                var textPart = new TextPart(MimeKit.Text.TextFormat.Plain) { Text = text };
                message.Body = textPart;
                message.From.Add(new MailboxAddress(fromAddress, fromAddress));
                this.AddAddresses(message, toAddresses, "to");
                this.AddAddresses(message, ccAddresses, "cc");
                this.AddAddresses(message, bccAddresses, "bcc");
                if (this.SmtpUsesTls)
                {
                    client.Connect(this.SmtpUri, this.SmtpPort, SecureSocketOptions.StartTls);
                }
                else
                {
                    client.Connect(this.SmtpUri, this.SmtpPort, this.SmtpUsesTls);
                }
                if (this.NeedsAuthentication)
                {
                    client.Authenticate(this.SmtpUserId, this.SmtpUserPassword);
                }
                // プログラムミスでメールが永久ループに入って飛ぶのが怖いので、ウェイトをかけて致命傷を避ける。
                Thread.Sleep(SafetyWait_ms);
                client.Send(message);
                client.Disconnect(true);
            }
        }

        private void AddAddresses(MimeMessage message, string[] addresses, string toOrCcOrBcc)
        {
            toOrCcOrBcc = toOrCcOrBcc.ToLower();
            if (addresses == null) return;
            foreach (var item in addresses)
            {
                if (string.IsNullOrWhiteSpace(item)) continue;
                switch (toOrCcOrBcc)
                {
                    case "to":
                        message.To.Add(new MailboxAddress(item, item));
                        break;
                    case "cc":
                        message.Cc.Add(new MailboxAddress(item, item));
                        break;
                    case "bcc":
                        message.Bcc.Add(new MailboxAddress(item, item));
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
