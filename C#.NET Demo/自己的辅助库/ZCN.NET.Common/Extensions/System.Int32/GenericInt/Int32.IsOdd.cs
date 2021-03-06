using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：判断该值是否是奇数
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static bool IsOdd(this Int32 @this)
        {
            return @this % 2 != 0;
        }
    }
}