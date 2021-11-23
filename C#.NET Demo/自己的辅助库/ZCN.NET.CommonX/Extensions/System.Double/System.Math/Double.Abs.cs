using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：返回指定数字的绝对值
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <returns></returns>
        public static double Abs(this double value)
        {
            return Math.Abs(value);
        }
    }
}