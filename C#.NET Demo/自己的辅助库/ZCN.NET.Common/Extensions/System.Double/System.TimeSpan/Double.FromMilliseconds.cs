using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：返回表示指定毫秒数的 System.TimeSpan
        /// </summary>
        /// <param name="value">扩展对象。毫秒数</param>
        /// <returns></returns>
        public static TimeSpan FromMilliseconds(this double value)
        {
            return TimeSpan.FromMilliseconds(value);
        }
    }
}