using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace UnlimitedFairytales.CsharpSamples.UtilitySamples.Extensions
{
    public static class StringToDateTimeExtension
    {
        /// <summary>
        /// <para>yyyyMMddHHmmssfff etc.</para>
        /// <para>yyyy-MM-dd HH:mm:ss.fff etc.</para>
        /// <para>yyyy/MM/dd HH:mm:ss.fff etc.</para>
        /// <para>ISO8601(basic)</para>
        /// <para>ISO8601(extended)</para>
        /// </summary>
        /// <param name="localDateTime">Local datetime.</param>
        /// <returns></returns>
        public static DateTime? LocalToLocal(this string localDateTime)
        {
            if (string.IsNullOrWhiteSpace(localDateTime)) return null;
            var formats = new[] {
                "yyyyMMdd", "yyyyMMddHHmmss", "yyyyMMddHHmmssfff",
                "yyyy-MM-dd", "yyyy-MM-dd HH:mm:ss", "yyyy-MM-dd HH:mm:ss.fff",
                "yyyy/MM/dd", "yyyy/MM/dd HH:mm:ss", "yyyy/MM/dd HH:mm:ss.fff",
                "yyyyMMddTHHmmssK",
                "yyyy-MM-ddTHH:mm:ssK"
            };
            return DateTime.ParseExact(localDateTime, formats, DateTimeFormatInfo.InvariantInfo, DateTimeStyles.AssumeLocal);
        }

        /// <summary>
        /// <para>yyyyMMddHHmmssfff etc.</para>
        /// <para>yyyy-MM-dd HH:mm:ss.fff etc.</para>
        /// <para>yyyy/MM/dd HH:mm:ss.fff etc.</para>
        /// <para>ISO8601(basic)</para>
        /// <para>ISO8601(extended)</para>
        /// </summary>
        /// <param name="localDateTime">Utc datetime.</param>
        /// <returns></returns>
        public static DateTime? UtcToLocal(this string utcDateTime)
        {
            if (string.IsNullOrWhiteSpace(utcDateTime)) return null;
            var formats = new[] {
                "yyyyMMdd", "yyyyMMddHHmmss", "yyyyMMddHHmmssfff",
                "yyyy-MM-dd", "yyyy-MM-dd HH:mm:ss", "yyyy-MM-dd HH:mm:ss.fff",
                "yyyy/MM/dd", "yyyy/MM/dd HH:mm:ss", "yyyy/MM/dd HH:mm:ss.fff",
                "yyyyMMddTHHmmssK",
                "yyyy-MM-ddTHH:mm:ssK"
            };
            return DateTime.ParseExact(utcDateTime, formats, DateTimeFormatInfo.InvariantInfo, DateTimeStyles.AssumeUniversal);
        }
    }
}
