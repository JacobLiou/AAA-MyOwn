using System.Text;

using ZCN.NET.CommonX.Constants;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///   自定义扩展方法：使用ASCII编码方式将二进制字节数组转换为字符串 
        /// </summary>
        /// <param name="bytes">字节数组</param>
        /// <returns>字节数组</returns>
        public static string ToStringByASCII(this byte[] bytes)
        {
            if (bytes == null)
                return null;

            return Encoding.ASCII.GetString(bytes);
        }

        /// <summary>
        ///   自定义扩展方法：使用 Big Endian 字节顺序的 UTF-16 格式的编码方式将二进制字节数组转换为字符串 
        /// </summary>
        /// <param name="bytes">字节数组</param>
        /// <returns>字节数组</returns>
        public static string ToStringByBigEndianUnicode(this byte[] bytes)
        {
            if (bytes == null)
                return null;

            return Encoding.BigEndianUnicode.GetString(bytes);
        }

        /// <summary>
        ///   自定义扩展方法：使用操作系统的当前 ANSI 代码页的编码方式将二进制字节数组转换为字符串 
        /// </summary>
        /// <param name="bytes">字节数组</param>
        /// <returns>字节数组</returns>
        public static string ToStringByDefault(this byte[] bytes)
        {
            if (bytes == null)
                return null;

            return Encoding.Default.GetString(bytes);
        }

        /// <summary>
        ///   自定义扩展方法：使用 GB2312 编码方式将二进制字节数组转换为字符串 
        /// </summary>
        /// <param name="bytes">字节数组</param>
        /// <returns>字节数组</returns>
        public static string ToStringByGB2312(this byte[] bytes)
        {
            if (bytes == null)
                return null;

            return Encoding.GetEncoding(EncodingNames.GB2312).GetString(bytes);
        }

        #region 从 .NET 5.0 开始，Encoding.UTF7 开始被标记为已过时 。请考虑使用 Encoding.UTF8 】

        ///// <summary>
        /////   自定义扩展方法：使用 UTF7 编码方式将二进制字节数组转换为字符串 
        ///// </summary>
        ///// <param name="bytes">字节数组</param>
        ///// <returns>字节数组</returns>
        //public static string ToStringByUTF7(this byte[] bytes)
        //{
        //    if (bytes == null)
        //        return null;

        //    return Encoding.UTF7.GetString(bytes);
        //}

        #endregion

        /// <summary>
        ///   自定义扩展方法：使用 UTF8 编码方式将二进制字节数组转换为字符串 
        /// </summary>
        /// <param name="bytes">字节数组</param>
        /// <returns>字节数组</returns>
        public static string ToStringByUTF8(this byte[] bytes)
        {
            if (bytes == null)
                return null;

            return Encoding.UTF8.GetString(bytes);
        }

        /// <summary>
        ///   自定义扩展方法：使用 UTF32 编码方式将二进制字节数组转换为字符串 
        /// </summary>
        /// <param name="bytes">字节数组</param>
        /// <returns>字节数组</returns>
        public static string ToStringByUTF32(this byte[] bytes)
        {
            if (bytes == null)
                return null;

            return Encoding.UTF32.GetString(bytes);
        }

        /// <summary>
        ///   自定义扩展方法：使用 Unicode 编码方式将二进制字节数组转换为字符串 
        /// </summary>
        /// <param name="bytes">字节数组</param>
        /// <returns>字节数组</returns>
        public static string ToStringByUnicode(this byte[] bytes)
        {
            if (bytes == null)
                return null;

            return Encoding.Unicode.GetString(bytes);
        }

        /// <summary>
        ///   自定义扩展方法：以指定的编码方式将字符串转换为字节数组 
        /// </summary>
        /// <param name="bytes">字节数组</param>
        /// <param name="encoding">编码方式。如果为null，则使用系统默认的编码方式</param>
        /// <returns>字节数组</returns>
        public static string ToStringByEncoding(this byte[] bytes, Encoding encoding)
        {
            if (bytes == null)
                return null;

            return encoding.GetString(bytes);
        }

        /// <summary>
        ///   自定义扩展方法：以指定的编码方式将字符串转换为字节数组 
        /// </summary>
        /// <param name="bytes">字节数组</param>
        /// <param name="encodingName">编码方式。建议使用 EncodingNames 类中的常量值</param>
        /// <returns>字节数组</returns>
        public static string ToStringByEncoding(this byte[] bytes, string encodingName)
        {
            if (bytes == null)
                return null;

            string str = "";
            if (!string.IsNullOrWhiteSpace(encodingName))
            {
                str = Encoding.GetEncoding(encodingName).GetString(bytes);
            }

            return str;
        }
    }
}