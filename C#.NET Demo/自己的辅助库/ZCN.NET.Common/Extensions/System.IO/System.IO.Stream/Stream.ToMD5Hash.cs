using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：将流对象转换为 MD5 方式加密的字符串
        /// </summary>
        /// <param name="this">扩展对象。流对象</param>
        /// <returns></returns>
        public static string ToMd5Hash(this Stream @this)
        {
            using(MD5 md5 = MD5.Create())
            {
                var sb = new StringBuilder();
                byte[] hashBytes = md5.ComputeHash(@this);
                foreach(byte bytes in hashBytes)
                {
                    sb.Append(bytes.ToString("X2"));//X2 表示二进制
                }

                return sb.ToString();
            }
        }
    }
}