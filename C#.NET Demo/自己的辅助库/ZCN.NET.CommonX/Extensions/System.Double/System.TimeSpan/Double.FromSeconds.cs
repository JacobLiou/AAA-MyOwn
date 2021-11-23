using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：返回表示指定秒数的 System.TimeSpan，其中对秒数的指定精确到最接近的毫秒
        /// </summary>
        /// <param name="value">扩展对象。秒数</param>
        /// <returns></returns>
        public static TimeSpan FromSeconds(this double value)
        {
            return TimeSpan.FromSeconds(value);
        }
    }
}