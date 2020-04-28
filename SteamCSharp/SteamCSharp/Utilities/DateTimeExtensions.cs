using System;

namespace SteamCSharp.Utilities
{
    public static class DateTimeExtensions
    {
        /// <summary>
        /// Converts a unix time to <see cref="DateTime"/>.
        /// </summary>
        /// <param name="unixTime">The unix time which will be converted into a <see cref="DateTime"/>.</param>
        /// <returns>Returns a converted unix time in <see cref="DateTime"/>.</returns>
        public static DateTime ToDateTime(this ulong unixTime)
        {
            var origin = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            return origin.AddSeconds(unixTime);
        }

        /// <summary>
        /// Converts a <see cref="DateTime"/> to unix time.
        /// </summary>
        /// <param name="dateTime">The <see cref="DateTime"/> which will be converted into a unix time.</param>
        /// <returns>Returns a converted <see cref="DateTime"/> in unix time.</returns>
        public static ulong ToUnixTimeStamp(this DateTime dateTime)
        {
            DateTime origin = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            TimeSpan timeSpanSinceOrigin = dateTime.Subtract(origin);
            return Convert.ToUInt64(timeSpanSinceOrigin.TotalSeconds);
        }
    }
}
