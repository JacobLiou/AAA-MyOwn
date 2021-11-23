using System;
using System.Text;

using ZCN.NET.CommonX.Extensions;

namespace ZCN.NET.CommonX.Utils
{
    /// <summary>
    ///  对字符串进行Base64方式加密解密工具类
    /// </summary>
    public static partial class Base64Utils
    {
        #region Base64(可逆加密)

        /// <summary>
        ///  使用 UTF8 编码格式，对字符串进行进行 Base64 方式编码（加密）
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns>编码后的字符串</returns>
        public static string EncryptByBase64(this string @this)
        {
            lock (typeof(Base64Utils))
            {
                if (@this.IsNullOrWhiteSpace())
                    return null;

                byte[] bytes = Encoding.UTF8.GetBytes(@this);
                return Convert.ToBase64String(bytes);
            }
        }

        /// <summary>
        ///  使用 UTF8 编码格式，对字符串进行进行 Base64 方式解码（解密）
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns>解码后的字符串</returns>
        public static string DecryptByBase64(this string @this)
        {
            lock (typeof(Base64Utils))
            {
                if (@this.IsNullOrWhiteSpace())
                    return null;

                byte[] bytes = Convert.FromBase64String(@this);
                return Encoding.UTF8.GetString(bytes);
            }
        }

        /// <summary>
        ///  使用自定义的编码格式，对字符串进行进行 Base64 方式编码（加密）
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="encodingName">编码方式。建议使用 EncodingNames 类获取编码名称</param>
        /// <returns>编码后的字符串</returns>
        public static string EncryptByBase64(this string @this, string encodingName)
        {
            lock (typeof(Base64Utils))
            {
                if (@this.IsNullOrWhiteSpace() || encodingName.IsNullOrWhiteSpace())
                    return null;

                byte[] bytes = Encoding.GetEncoding(encodingName).GetBytes(@this);
                return Convert.ToBase64String(bytes);
            }
        }

        /// <summary>
        ///  使用自定义的编码格式，对字符串进行进行 Base64 方式解码（解密）
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="encodingName">编码方式，需要与加密时使用相同的编码方式</param>
        /// <returns>解码后的字符串</returns>
        public static string DecryptByBase64(this string @this, string encodingName)
        {
            lock (typeof(Base64Utils))
            {
                if (@this.IsNullOrWhiteSpace() || encodingName.IsNullOrWhiteSpace())
                    return null;

                byte[] bytes = Convert.FromBase64String(@this);
                return Encoding.GetEncoding(encodingName).GetString(bytes);
            }
        }
        #endregion
    }
}