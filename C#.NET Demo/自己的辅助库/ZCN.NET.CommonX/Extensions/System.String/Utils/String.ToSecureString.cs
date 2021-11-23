using System;
using System.Security;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///   自定义扩展方法：将字符串转换为保密的文本对象
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns>保密的字符串</returns>
        public static SecureString ToSecureString(this string @this)
        {
            var secureString = new SecureString();
            foreach(Char c in @this)
            {
                secureString.AppendChar(c);
            }

            return secureString;
        }

        /// <summary>
        ///  自定义扩展方法：获取 SecureString 对象的原始字符串内容
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static string GetOriginalString(this SecureString @this)
        {
            string result;

            IntPtr ptr = System.Runtime.InteropServices.Marshal.SecureStringToBSTR(@this);
            try
            {
                //分配托管 System.String，并向其复制存储在非托管内存中的 BSTR 字符串
                result = System.Runtime.InteropServices.Marshal.PtrToStringBSTR(ptr);
            }
            finally
            {
                System.Runtime.InteropServices.Marshal.ZeroFreeBSTR(ptr);//释放指针
            }

            return result;
        }
    }
}