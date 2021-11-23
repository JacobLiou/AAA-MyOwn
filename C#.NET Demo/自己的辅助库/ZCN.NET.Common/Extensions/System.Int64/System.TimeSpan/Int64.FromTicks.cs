using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  返回表示指定时间的 <see cref="T:System.TimeSpan" />，其中对时间的指定以刻度为单位。
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static TimeSpan FromTicks(this Int64 value)
        {
            return TimeSpan.FromTicks(value);
        }
    }
}