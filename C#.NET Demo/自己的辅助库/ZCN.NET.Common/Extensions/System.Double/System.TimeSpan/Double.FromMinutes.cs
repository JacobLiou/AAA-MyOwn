using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：返回表示指定分钟数的 System.TimeSpan，其中对分钟数的指定精确到最接近的毫秒
        /// </summary>
        /// <param name="value">扩展对象。分钟数</param>
        /// <returns></returns>
        public static TimeSpan FromMinutes(this double value)
        {
            return TimeSpan.FromMinutes(value);
        }
    }
}