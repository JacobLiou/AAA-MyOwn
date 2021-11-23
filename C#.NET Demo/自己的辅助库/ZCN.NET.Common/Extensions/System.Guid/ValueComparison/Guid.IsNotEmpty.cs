using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：判断扩展对象的值是否不为空(全0的空Guid)
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static bool IsNotEmpty(this Guid @this)
        {
            return @this != Guid.Empty;
        }
    }
}