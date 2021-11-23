using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：计算指定双精度浮点数的整数部分
        /// </summary>
        /// <param name="d">扩展对象。要截断的数字</param>
        /// <returns></returns>
        public static double Truncate(this double d)
        {
            return Math.Truncate(d);
        }
    }
}