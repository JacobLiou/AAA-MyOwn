using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：将指定分割符号，将字符串分割为字符串数组
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="separator">分割符号</param>
        /// <param name="option">字符串分割选项枚举</param>
        /// <returns></returns>
        public static string[] Split(this string @this,string separator,StringSplitOptions option = StringSplitOptions.None)
        {
            return @this.Split(new[] {separator}, option);
        }
    }
}