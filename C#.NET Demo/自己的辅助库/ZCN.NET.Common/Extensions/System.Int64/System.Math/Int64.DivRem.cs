using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：计算两个 64 位有符号整数的商，并通过输出参数返回余数。
        ///  如果除数等于0，则返回结果0，余数也为0
        /// </summary>
        /// <param name="a">扩展对象。被除数</param>
        /// <param name="b">除数</param>
        /// <param name="result">余数</param>
        /// <returns>绝对值</returns>
        public static Int64 DivRem(this Int64 a, Int64 b, out Int64 result)
        {
            if(b == 0)
            {
                result = 0;
                return 0;
            }

            return Math.DivRem(a, b, out result);
        }
    }
}