using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：在一个文件中追加文本行，然后关闭该文件
        /// </summary>
        /// <param name="this">扩展对象。文件信息对象</param>
        /// <param name="contents">要追加到文件中的文本行</param>
        public static void AppendAllLines(this FileInfo @this,IEnumerable<string> contents)
        {
            File.AppendAllLines(@this.FullName,contents);
        }

        /// <summary>
        ///  自定义扩展方法： 将指定编码向一个文件中追加文本行，然后关闭该文件
        /// </summary>
        /// <param name="this">扩展对象。文件信息对象</param>
        /// <param name="contents">要追加到文件中的文本行</param>
        /// <param name="encoding">要使用的字符编码</param>
        public static void AppendAllLines(this FileInfo @this,IEnumerable<string> contents,Encoding encoding)
        {
            File.AppendAllLines(@this.FullName,contents,encoding);
        }
    }
}