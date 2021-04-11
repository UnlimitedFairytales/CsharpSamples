using System;
using System.Windows.Forms;

namespace UnlimitedFairytales.CsharpSamples.FormUtilitySamples
{
    public class MessageConstant
    {
        public MessageBoxIcon MbIcon { get; protected set; }
        public MessageBoxButtons MbButtons { get; protected set; }
        public string MbMessage
        {
            get
            {
                return this.MbMessageRef?.Invoke();
            }
        }
        protected Func<string> MbMessageRef { get; set; }
        public MessageBoxDefaultButton MbDefaultButton { get; protected set; }


        public MessageConstant(MessageBoxIcon mbIcon, MessageBoxButtons mbButtons, Func<string> mbMessageRef, MessageBoxDefaultButton mbDefaultButton = MessageBoxDefaultButton.Button1)
        {
            this.MbIcon = mbIcon;
            this.MbButtons = mbButtons;
            this.MbMessageRef = mbMessageRef;
            this.MbDefaultButton = mbDefaultButton;
        }

        public DialogResult ShowDialog(Form owner, string additionalMessage = null)
        {
            string msg = MbMessage;
            if (!string.IsNullOrWhiteSpace(additionalMessage))
            {
                msg += Environment.NewLine + Environment.NewLine + additionalMessage;
            }
            string caption = owner == null ? "" : owner.Text;
            return MessageBox.Show(owner, msg, caption, MbButtons, MbIcon, MbDefaultButton);
        }

        public DialogResult ShowDialog(Form owner, Exception exception)
        {
            string msg = MbMessage;
            while (exception != null)
            {
                if (!string.IsNullOrWhiteSpace(exception?.Message))
                {
                    msg += Environment.NewLine + Environment.NewLine + exception.Message;
                }
                exception = exception.InnerException;
            }
            string caption = owner == null ? "" : owner.Text;
            return MessageBox.Show(owner, msg, caption, MbButtons, MbIcon, MbDefaultButton);
        }
    }
}
