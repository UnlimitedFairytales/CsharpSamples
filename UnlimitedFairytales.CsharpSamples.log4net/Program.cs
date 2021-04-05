using log4net;
using System;

namespace UnlimitedFairytales.CsharpSamples.log4net
{
    class Program
    {
        static void Main(string[] args)
        {
            var logger = Log4netExtension.GetLogger(null, typeof(Program));
            try
            {
                throw new Exception();
            }
            catch (Exception ex)
            {
                GlobalContext.Properties["UserId"] = "12345";
                for (int i = 0; i < 100; i++)
                {
                    logger.Debug($"メッセージ{i}", ex);
                }
            }
        }
    }
}
