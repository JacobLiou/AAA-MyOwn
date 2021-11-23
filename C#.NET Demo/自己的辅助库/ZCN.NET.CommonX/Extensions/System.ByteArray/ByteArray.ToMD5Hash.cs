using System;
using System.Security.Cryptography;
using System.Text;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：将 8 位无符号整数的数组转换为 MD5 方式加密的字符串
        /// </summary>
        /// <param name="this">扩展对象。字节数组</param>
        /// <returns></returns>
        public static string ToMd5Hash(this Byte[] @this)
        {
            using (MD5 md5 = MD5.Create())
            {
                var sb = new StringBuilder();
                byte[] hashBytes = md5.ComputeHash(@this);
                foreach (byte bytes in hashBytes)
                {
                    sb.Append(bytes.ToString("X2"));//X2 表示二进制
                }

                return sb.ToString();
            }
        }

    }
}