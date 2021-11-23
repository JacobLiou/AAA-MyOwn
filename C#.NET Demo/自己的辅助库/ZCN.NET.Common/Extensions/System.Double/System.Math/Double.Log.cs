using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：返回指定数字的自然对数（底为 e）。
        /// </summary>
        /// <param name="d">扩展对象。要查找其对数的数字</param>
        /// <returns></returns>
        public static double Log(this double d)
        {
            return Math.Log(d);
        }

        /// <summary>
        /// 自定义扩展方法：返回指定数字在使用指定底时的对数
        /// </summary>
        /// <param name="d">扩展对象。要查找其对数的数字</param>
        /// <param name="newBase">对数的底</param>
        /// <returns></returns>
        public static double Log(this double d, double newBase)
        {
            return Math.Log(d, newBase);
        }
    }
}