using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：判断扩展对象的值是否是指定数的因子(factorNumber % @this == 0)
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="factorNumber">指定数</param>
        /// <returns></returns>
        public static bool IsFactorOf(this Int64 @this,Int64 factorNumber)
        {
            return factorNumber % @this == 0;
        }
    }
}