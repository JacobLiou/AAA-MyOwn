using System;
using System.Web;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：将字节数组转换为编码的 URL 字符串
        /// </summary>
        /// <param name="bytes">要编码的字节数组</param>
        /// <returns>一个已编码的字符串</returns>
        public static String UrlEncode(this Byte[] bytes)
        {
            return HttpUtility.UrlEncode(bytes);
        }

        /// <summary>
        /// 自定义扩展方法： 从数组的指定位置开始到指定的字节数为止，将字节数组转换为 URL 编码的字符串
        /// </summary>
        /// <param name="bytes">要编码的字节数组</param>
        /// <param name="offset">字节数组中开始编码的位置</param>
        /// <param name="count">要编码的字节数</param>
        /// <returns>一个已编码的字符串</returns>
        public static String UrlEncode(this Byte[] bytes, Int32 offset, Int32 count)
        {
            return HttpUtility.UrlEncode(bytes, offset, count);
        }
    }
}