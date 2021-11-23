using System;
using System.Web;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：对字符串进行编码
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <returns>编码后的字符串</returns>
        public static String JavaScriptStringEncode(this String value)
        {
            return HttpUtility.JavaScriptStringEncode(value);
        }

        /// <summary>
        /// 自定义扩展方法：对字符串进行编码
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <param name="addDoubleQuotes">是否用双引号括住编码的字符串</param>
        /// <returns>编码后的字符串</returns>
        public static String JavaScriptStringEncode(this String value,Boolean addDoubleQuotes)
        {
            return HttpUtility.JavaScriptStringEncode(value,addDoubleQuotes);
        }
    }
}