using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：返回一个16位有符号整数的绝对值
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Int16 Abs(this Int16 value)
        {
            return Math.Abs(value);
        }
    }
}