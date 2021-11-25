using System;
using System.Text;
using System.Web;

namespace BIMFace.SDK.CSharp.Common.Extensions
{
    public static partial class CommonExtension
    {
        /// <summary>
        ///  自定义扩展方法：使用指定的解码对象将 URL 编码的字符串转换为已解码的字节数组
        /// </summary>
        /// <param name="str">要解码的字符串</param>
        /// <returns>一个已解码的字节数组</returns>
        public static Byte[] UrlDecodeToBytes(this String str)
        {
            return HttpUtility.UrlDecodeToBytes(str);
        }

        /// <summary>
        ///  自定义扩展方法：使用指定的解码对象将 URL 编码的字符串转换为已解码的字节数组
        /// </summary>
        /// <param name="str">要解码的字符串</param>
        /// <param name="e">指定解码方法的 System.Text.Encoding 对象</param>
        /// <returns>一个已解码的字节数组</returns>
        public static Byte[] UrlDecodeToBytes(this String str, Encoding e)
        {
            return HttpUtility.UrlDecodeToBytes(str, e);
        }
    }
}