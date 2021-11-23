using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法： 创建一个与指定的 System.String 具有相同值的 System.String 的新实例
        /// </summary>
        /// <param name="str">字符串</param>
        /// <returns> 值与 str 相同的新字符串</returns>
        public static string Copy(this string str)
        {
            return String.Copy(str);
        }
    }
}