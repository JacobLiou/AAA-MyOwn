using System;
using System.Text;
using System.Web;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：使用指定的解码对象将 URL 编码的字节数组转换为已解码的字符串
        /// </summary>
        /// <param name="bytes">要解码的字节数组</param>
        /// <param name="e">指定解码方法的 System.Text.Encoding</param>
        /// <returns></returns>
        public static String UrlDecode(this Byte[] bytes, Encoding e)
        {
            return HttpUtility.UrlDecode(bytes, e);
        }

        /// <summary>
        /// 自定义扩展方法：使用指定的编码对象，从数组中的指定位置开始到指定的字节数为止，将 URL 编码的字节数组转换为已解码的字符串
        /// </summary>
        /// <param name="bytes">要解码的字节数组</param>
        /// <param name="offset">字节中开始解码的位置</param>
        /// <param name="count">要解码的字节数</param>
        /// <param name="e">指定解码方法的 System.Text.Encoding 对象</param>
        /// <returns></returns>
        public static String UrlDecode(this Byte[] bytes, Int32 offset, Int32 count, Encoding e)
        {
            return HttpUtility.UrlDecode(bytes, offset, count, e);
        }
    }
}