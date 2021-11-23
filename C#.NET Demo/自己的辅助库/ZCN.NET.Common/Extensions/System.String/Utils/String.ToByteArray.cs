using System;
using System.Text;

using ZCN.NET.Common.Constants;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///   自定义扩展方法：以指定的编码方式将字符串转换为字节数组 
        /// </summary>
        /// <param name="sourceString">扩展对象</param>
        /// <param name="encoding">编码方式。如果为null，则使用系统默认的编码方式</param>
        /// <returns>字节数组</returns>
        public static byte[] ToByteArray(this string sourceString, Encoding encoding)
        {
            if (encoding == null)
            {
                encoding = Encoding.Default;
            }

            return encoding.GetBytes(sourceString);
        }

        /// <summary>
        ///   自定义扩展方法：以指定的编码方式将字符串转换为字节数组 
        /// </summary>
        /// <param name="sourceString">扩展对象</param>
        /// <param name="encodingName">编码方式。建议使用 EncodingNames 类中的常量值</param>
        /// <returns>字节数组</returns>
        public static byte[] ToByteArray(this string sourceString, string encodingName)
        {
            byte[] bytes = null;

            if (!string.IsNullOrWhiteSpace(encodingName))
            {
                bytes = Encoding.GetEncoding(encodingName).GetBytes(sourceString);
            }
            
            return bytes;
        }

        /// <summary>
        ///   自定义扩展方法：以ASCIIEncoding编码方式将字符串转换为字节数组 
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns>字节数组</returns>
        public static byte[] ToByteArrayByAscii(this string @this)
        {
            return Encoding.ASCII.GetBytes(@this);
        }

        /// <summary>
        ///   自定义扩展方法：将指定字符串（它将二进制数据编码为 Base64 数字）转换为等效的 8 位无符号整数数组。
        ///   如果字符串不是由二进制数据编码为 Base64 数字的字符串，则会转换失败。返回 null。
        /// </summary>
        /// <param name="sourceString">扩展对象。二进制数据编码为 Base64 数字字符串</param>
        /// <returns>字节数组</returns>
        public static byte[] ToByteArrayByBase64(this string sourceString)
        {
            try
            {
                return Convert.FromBase64String(sourceString);
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        ///   自定义扩展方法：使用 Big Endian 字节顺序的 UTF-16 格式的编码将字符串转换为字节数组 
        /// </summary>
        /// <param name="sourceString">扩展对象</param>
        /// <returns>字节数组</returns>
        public static byte[] ToByteArrayByBigEndianUnicode(this string sourceString)
        {
            return Encoding.BigEndianUnicode.GetBytes(sourceString);
        }

        /// <summary>
        ///   自定义扩展方法：使用操作系统的当前 ANSI 代码页的编码将字符串转换为字节数组 
        /// </summary>
        /// <param name="sourceString">扩展对象</param>
        /// <returns>字节数组</returns>
        public static byte[] ToByteArrayByDefault(this string sourceString)
        {
            return Encoding.Default.GetBytes(sourceString);
        }

        /// <summary>
        ///   自定义扩展方法：以 UTF7 编码方式将字符串转换为字节数组 
        /// </summary>
        /// <param name="sourceString">扩展对象</param>
        /// <returns>字节数组</returns>
        public static byte[] ToByteArrayByGB2312(this string sourceString)
        {
            return Encoding.GetEncoding(EncodingNames.GB2312).GetBytes(sourceString);
        }

        /// <summary>
        ///   自定义扩展方法：以 UTF7 编码方式将字符串转换为字节数组 
        /// </summary>
        /// <param name="sourceString">扩展对象</param>
        /// <returns>字节数组</returns>
        public static byte[] ToByteArrayByUtf7(this string sourceString)
        {
            return Encoding.UTF7.GetBytes(sourceString);
        }

        /// <summary>
        ///   自定义扩展方法：以 UTF8 编码方式将字符串转换为字节数组 
        /// </summary>
        /// <param name="sourceString">扩展对象</param>
        /// <returns>字节数组</returns>
        public static byte[] ToByteArrayByUtf8(this string sourceString)
        {
            return Encoding.UTF8.GetBytes(sourceString);
        }

        /// <summary>
        ///   自定义扩展方法：以 UTF32 编码方式将字符串转换为字节数组 
        /// </summary>
        /// <param name="sourceString">扩展对象</param>
        /// <returns>字节数组</returns>
        public static byte[] ToByteArrayByUtf32(this string sourceString)
        {
            return Encoding.UTF32.GetBytes(sourceString);
        }

        /// <summary>
        ///   自定义扩展方法：以 Unicode 编码方式将字符串转换为字节数组 
        /// </summary>
        /// <param name="sourceString">扩展对象</param>
        /// <returns>字节数组</returns>
        public static byte[] ToByteArrayByUnicode(this string sourceString)
        {
            return Encoding.Unicode.GetBytes(sourceString);
        }
    }
}