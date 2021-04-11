using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace UnlimitedFairytales.CsharpSamples.UtilitySamples.Utilities
{
    public static class Mail
    {
        public static void Send(
            string host,
            string authName,
            string authPswd,
            string subject,
            string body,
            string from,
            string[] toArray = null,
            string[] ccArray = null,
            string[] bccArray = null,
            MailPriority priority = MailPriority.Normal,
            bool enableSsl = true,
            int? port = null)
        {
            var enc = Encoding.UTF8;
            var client = new SmtpClient()
            {
                Host = host,
                EnableSsl = enableSsl,
                Port = port ?? (enableSsl ? 587 : 25),
                DeliveryMethod = SmtpDeliveryMethod.Network,
                Credentials = enableSsl ? new NetworkCredential(authName, authPswd) : null
            };
            var msg = new MailMessage();
            msg.Subject = ToBase64(subject, enc);
            msg.Body = body;
            msg.BodyEncoding = enc;
            msg.IsBodyHtml = false;
            msg.Priority = priority;
            msg.From = new MailAddress(from);
            var empty = new string[0];
            foreach (var to in toArray ?? empty)
            {
                msg.To.Add(to);
            }
            foreach (var cc in ccArray ?? empty)
            {
                msg.CC.Add(cc);
            }
            foreach (var bcc in bccArray ?? empty)
            {
                msg.Bcc.Add(bcc);
            }
            client.Send(msg);
            client.Dispose();
        }

        private static string ToBase64(string text, Encoding enc)
        {
            // RFC2047
            var raw = Convert.ToBase64String(enc.GetBytes(text));
            var encodedWord = string.Format("=?{0}?B?{1}?=", enc.BodyName, raw);
            return encodedWord;
        }
    }
}
