using System.Runtime.InteropServices;

namespace UnlimitedFairytales.CsharpSamples.DateTimeSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var local_tzi = TimeZoneInfo.Local;
            var jst_tzi = DateTimeExtension.GetJstTimeZoneInfo();
            var d_utc = DateTime.UtcNow;
            var d_cnv = d_utc.ToLocalTime();
            var d_lcl = DateTime.Now;
            var d_cn2 = d_lcl.ToUniversalTime();
            var d_cn3 = d_cn2.ToJstTime();
            Console.WriteLine($"TimeZoneInfo.Local             : {local_tzi}");
            Console.WriteLine($"Id == \"Tokyo Standard Time\"    : {jst_tzi}");
            Console.WriteLine($"DateTime.UtcNow                : {d_utc.Ticks} {d_utc} {d_utc.Kind}");
            Console.WriteLine($"DateTime.UtcNow.ToLocalTime()  : {d_cnv.Ticks} {d_cnv} {d_cnv.Kind}");
            Console.WriteLine($"DateTime.Now                   : {d_lcl.Ticks} {d_lcl} {d_lcl.Kind}");
            Console.WriteLine($"DateTime.Now.ToUniversalTime() : {d_cn2.Ticks} {d_cn2} {d_cn2.Kind}");
            Console.WriteLine($"d_cn2.ToJstTime()              : {d_cn3.Ticks} {d_cn3} {d_cn3.Kind}");
        }
    }

    static class DateTimeExtension
    {
        /// <summary>
        /// JSTタイムゾーンを取得する
        /// </summary>
        /// <returns></returns>
        public static TimeZoneInfo GetJstTimeZoneInfo()
        {
            var jstId =
                RuntimeInformation.IsOSPlatform(OSPlatform.Windows) ? "Tokyo Standard Time" :
                RuntimeInformation.IsOSPlatform(OSPlatform.Linux) ? "Asia/Tokyo" :
                "";
            return TimeZoneInfo.GetSystemTimeZones().Where(info => info.Id == jstId).First();
        }

        /// <summary>
        /// JST時刻への変換する。LocalがUTCの場合はJST時刻になったUnspecified、LocalがJSTの場合はLocalとして返す。
        /// </summary>
        /// <returns></returns>
        public static DateTime ToJstTime(this DateTime source, bool treatsUnspecifiedAsJst = false)
        {
            if (source.Kind == DateTimeKind.Unspecified && !treatsUnspecifiedAsJst)
            {
                throw new Exception("DateTime.Kind is Unspecified, but treatsUnspecifiedAsJst = false.");
            }
            var jst_tzi = GetJstTimeZoneInfo();
            if (TimeZoneInfo.Local.Id == TimeZoneInfo.Utc.Id)
            {
                if (source.Kind == DateTimeKind.Unspecified)
                {
                    return source;
                }
                return TimeZoneInfo.ConvertTime(source, jst_tzi);
            }
            else if (TimeZoneInfo.Local.Id == jst_tzi.Id)
            {
                if (source.Kind == DateTimeKind.Unspecified)
                {
                    return new DateTime(source.Year, source.Month, source.Day, source.Hour, source.Minute, source.Second, source.Millisecond, DateTimeKind.Local);
                }
                return source.ToLocalTime();
            }
            throw new Exception("Current local TimeZoneInfo does not support.");
        }
    }
}