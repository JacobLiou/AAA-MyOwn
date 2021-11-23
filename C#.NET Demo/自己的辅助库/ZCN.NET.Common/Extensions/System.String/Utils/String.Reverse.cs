using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：将字符串倒序
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns>倒序后的字符串</returns>
        public static string Reverse(this string @this)
        {
            if (@this.Length <= 1)
                return @this;

            char[] chars = @this.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }
    }
}