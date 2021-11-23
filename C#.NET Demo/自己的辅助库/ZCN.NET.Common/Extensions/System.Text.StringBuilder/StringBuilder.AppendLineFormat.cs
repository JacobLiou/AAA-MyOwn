using System.Collections.Generic;
using System.Text;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：将格式化后的字符串追加到扩展对象结尾(带有换行符号) 
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="format">格式化字符串</param>
        /// <param name="args">格式化参数</param>
        /// <returns></returns>
        public static StringBuilder AppendLineFormat(this StringBuilder @this, string format, params object[] args)
        {
            @this.AppendLine(string.Format(format, args));

            return @this;
        }

        /// <summary>
        ///  自定义扩展方法：将格式化后的字符串追加到扩展对象结尾(带有换行符号) 
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="format">格式化字符串</param>
        /// <param name="args">格式化参数</param>
        /// <returns></returns>
        public static StringBuilder AppendLineFormat(this StringBuilder @this, string format,
            List<IEnumerable<object>> args)
        {
            @this.AppendLine(string.Format(format, args));

            return @this;
        }
    }
}