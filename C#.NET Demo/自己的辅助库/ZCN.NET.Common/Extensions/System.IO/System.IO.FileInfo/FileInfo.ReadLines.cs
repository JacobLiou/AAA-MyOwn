using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：读取文件的文本行
        /// </summary>
        /// <param name="this">扩展对象。文件信息对象</param>
        /// <returns></returns>
        public static IEnumerable<string> ReadLines(this FileInfo @this)
        {
            return File.ReadLines(@this.FullName);
        }

        /// <summary>
        ///  自定义扩展方法：读取具有指定编码的文件的文本行
        /// </summary>
        /// <param name="this">扩展对象。文件信息对象</param>
        /// <param name="encoding">应用到文件内容的编码</param>
        /// <returns></returns>
        public static IEnumerable<string> ReadLines(this FileInfo @this, Encoding encoding)
        {
            return File.ReadLines(@this.FullName, encoding);
        }
    }
}