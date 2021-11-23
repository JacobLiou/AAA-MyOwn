using System;
using System.Web;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：将 URL 编码的字节数组转换为已解码的字节数组
        /// </summary>
        /// <param name="bytes">要解码的字节数组</param>
        /// <returns>一个已解码的字节数组</returns>
        public static Byte[] UrlDecodeToBytes(this Byte[] bytes)
        {
            return HttpUtility.UrlDecodeToBytes(bytes);
        }

        /// <summary>
        ///  自定义扩展方法：从数组中的指定位置开始一直到指定的字节数为止，将 URL 编码的字节数组转换为已解码的字节数组
        /// </summary>
        /// <param name="bytes">要解码的字节数组</param>
        /// <param name="offset">字节数组中开始解码的位置</param>
        /// <param name="count">要解码的字节数</param>
        /// <returns>一个已解码的字节数组</returns>
        public static Byte[] UrlDecodeToBytes(this Byte[] bytes, Int32 offset, Int32 count)
        {
            return HttpUtility.UrlDecodeToBytes(bytes, offset, count);
        }
    }
}