using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：返回指定数字以 10 为底的对数
        /// </summary>
        /// <param name="d">扩展对象。要查找其对数的数字</param>
        /// <returns></returns>
        public static double Log10(this double d)
        {
            return Math.Log10(d);
        }
    }
}