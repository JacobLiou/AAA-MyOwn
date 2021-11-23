using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：生成两个 32 位数字的完整乘积
        /// </summary>
        /// <param name="a">扩展对象。第一个乘数</param>
        /// <param name="b">第二个乘数</param>
        /// <returns>绝对值</returns>
        public static long BigMul(this Int32 a, Int32 b)
        {
            return Math.BigMul(a, b);
        }
    }
}