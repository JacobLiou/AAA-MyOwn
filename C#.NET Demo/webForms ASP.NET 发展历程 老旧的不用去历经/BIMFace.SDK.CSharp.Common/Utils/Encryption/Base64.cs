using System;
using System.Text;

using BIMFace.SDK.CSharp.Common.Extensions;

// /* ---------------------------------------------------------------------------------------
//    文件名：Base64Utility.cs
//    文件功能描述：
// 
//    创建标识：20200308
//    作   者：张传宁 （QQ：905442693  微信：savionzhang）  
//    作者博客：https://www.cnblogs.com/SavionZhang/
//    BIMFace专栏地址：https://www.cnblogs.com/SavionZhang/p/11424431.html
// 
//    修改标识： 
//    修改描述：
//  ------------------------------------------------------------------------------------------*/

namespace BIMFace.SDK.CSharp.Common.Utils
{
    /// <summary>
    ///  字符串加密解密工具类
    /// </summary>
    public static partial class Base64Utility
    {
        #region Base64(可逆加密)

        /// <summary>
        ///  使用 UTF8 编码格式，对字符串进行进行 Base64 方式编码（加密）
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns>编码后的字符串</returns>
        public static string EncryptByBase64(this string @this)
        {
            lock (typeof(Base64Utility))
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
            lock (typeof(Base64Utility))
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
            lock (typeof(Base64Utility))
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
            lock (typeof(Base64Utility))
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