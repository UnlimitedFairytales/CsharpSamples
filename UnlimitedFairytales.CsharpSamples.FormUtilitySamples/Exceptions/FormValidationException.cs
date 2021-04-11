using System;
using System.Runtime.Serialization;
using System.Windows.Forms;

namespace UnlimitedFairytales.CsharpSamples.FormUtilitySamples.Exceptions
{
    public class FormValidationException : Exception
    {
        public MessageConstant MessageConstant { get; protected set; }
        public Control InvalidTarget { get; set; }

        public FormValidationException(MessageConstant msg, Control invalidTarget = null)
            : base(msg?.MbMessage)
        {
            Setup(msg, invalidTarget);
        }
        public FormValidationException(MessageConstant msg, Exception innerException, Control invalidTarget = null)
            : base(msg?.MbMessage, innerException)
        {
            Setup(msg, invalidTarget);
        }

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotSupportedException();
        }

        public override string Message
        {
            get
            {
                return base.Message
                    + Environment.NewLine + "InvalidTarget : " + InvalidTarget?.Name;
            }
        }

        private void Setup(MessageConstant msg, Control invalidTarget)
        {
            MessageConstant = msg;
            this.InvalidTarget = invalidTarget;
        }
    }
}
