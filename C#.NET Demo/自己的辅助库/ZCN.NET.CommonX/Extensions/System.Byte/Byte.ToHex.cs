using System.Collections.Generic;
using System.Text;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///    自定义扩展方法： 转换为16进制字符串
        /// </summary>
        /// <param name="b">字节实例</param>
        /// <returns></returns>
        public static string ToHex(this byte b)
        {
            return b.ToString("X2");
        }

        /// <summary>
        ///     自定义扩展方法：转换为16进制字符串
        /// </summary>
        /// <param name="bytes">字节的IEnumerable集合实例</param>
        /// <returns></returns>
        public static string ToHex(this IEnumerable<byte> bytes)
        {
            var sb = new StringBuilder();

            foreach (byte b in bytes)
            {
                sb.Append(b.ToString("X2"));
            }

            return sb.ToString();
        }

        /// <summary>
        ///     自定义扩展方法：转换为16进制字符串，中间用空格分开
        /// </summary>
        /// <param name="bytes">字节的IEnumerable集合实例</param>
        /// <returns></returns>
        public static string ToHexWithWhiteSpace(this IEnumerable<byte> bytes)
        {
            var sb = new StringBuilder();

            foreach (byte b in bytes)
            {

                sb.Append(" " + b.ToString("X2"));
            }

            return sb.ToString().RemoveFirst(" ");
        }

        /// <summary>
        ///     自定义扩展方法：转换为16进制字符串，中间用空格分开
        /// </summary>
        /// <param name="bytes">字节的IEnumerable集合实例</param>
        /// <param name="separator">分隔符。例如：横线、下划线、点号等</param>
        /// <returns></returns>
        public static string ToHexWithSeparator(this IEnumerable<byte> bytes, string separator)
        {
            var sb = new StringBuilder();

            foreach (byte b in bytes)
            {
                sb.Append(separator + b.ToString("X2"));
            }

            return sb.ToString().RemoveFirst(separator);
        }
    }
}