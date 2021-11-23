using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：判断扩展对象的值是否是指定值的倍数(@this % factor == 0)
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="factor">指定值</param>
        /// <returns></returns>
        public static bool IsMultipleOf(this Int64 @this,Int64 factor)
        {
            return @this % factor == 0;
        }
    }
}