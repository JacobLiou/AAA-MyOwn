using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：返回大于或等于指定的双精度浮点数的最小整数值
        /// </summary>
        /// <param name="a">扩展对象</param>
        /// <returns></returns>
        public static double Ceiling(this double a)
        {
            return Math.Ceiling(a);
        }
    }
}