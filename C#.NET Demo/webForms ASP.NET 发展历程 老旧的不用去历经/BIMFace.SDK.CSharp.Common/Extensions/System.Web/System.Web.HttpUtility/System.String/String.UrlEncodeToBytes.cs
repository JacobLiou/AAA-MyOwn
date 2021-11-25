using System;
using System.Text;
using System.Web;

namespace BIMFace.SDK.CSharp.Common.Extensions
{
    public static partial class CommonExtension
    {
        /// <summary>
        /// 自定义扩展方法：使用指定的编码对象将字符串转换为 URL 编码的字节数组
        /// </summary>
        /// <param name="str">要编码的文本</param>
        /// <returns>一个已编码的字节数组</returns>
        public static Byte[] UrlEncodeToBytes(this String str)
        {
            return HttpUtility.UrlEncodeToBytes(str);
        }

        /// <summary>
        /// 自定义扩展方法：使用指定的编码对象将字符串转换为 URL 编码的字节数组
        /// </summary>
        /// <param name="str">要编码的文本</param>
        /// <param name="e">指定编码方案的 System.Text.Encoding 对象</param>
        /// <returns>一个已编码的字节数组</returns>
        public static Byte[] UrlEncodeToBytes(this String str, Encoding e)
        {
            return HttpUtility.UrlEncodeToBytes(str, e);
        }
    }
}