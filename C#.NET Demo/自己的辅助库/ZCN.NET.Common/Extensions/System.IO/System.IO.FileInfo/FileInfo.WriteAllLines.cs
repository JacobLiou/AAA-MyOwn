using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：创建一个新文件，在其中写入指定的字符串数组，然后关闭该文件
        /// </summary>
        /// <param name="this">扩展对象。文件信息对象</param>
        /// <param name="contents">要写入文件的字符串数组</param>
        public static void WriteAllLines(this FileInfo @this,string[] contents)
        {
            File.WriteAllLines(@this.FullName,contents);
        }

        /// <summary>
        ///  自定义扩展方法：创建一个新文件，将指定编码格式在其中写入指定的字符串数组，然后关闭该文件
        /// </summary>
        /// <param name="this">扩展对象。文件信息对象</param>
        /// <param name="contents">要写入文件的字符串数组</param>
        /// <param name="encoding">编码格式</param>
        public static void WriteAllLines(this FileInfo @this,string[] contents,Encoding encoding)
        {
            File.WriteAllLines(@this.FullName,contents,encoding);
        }

        /// <summary>
        ///  自定义扩展方法：创建一个新文件，在其中写入指定的字符串数组，然后关闭该文件
        /// </summary>
        /// <param name="this">扩展对象。文件信息对象</param>
        /// <param name="contents">要写入文件的字符串数组</param>
        public static void WriteAllLines(this FileInfo @this,IEnumerable<string> contents)
        {
            File.WriteAllLines(@this.FullName,contents);
        }

        /// <summary>
        ///  自定义扩展方法：创建一个新文件，将指定编码格式在其中写入指定的字符串数组，然后关闭该文件
        /// </summary>
        /// <param name="this">扩展对象。文件信息对象</param>
        /// <param name="contents">要写入文件的字符串数组</param>
        /// <param name="encoding">编码格式</param>
        public static void WriteAllLines(this FileInfo @this,IEnumerable<string> contents,Encoding encoding)
        {
            File.WriteAllLines(@this.FullName,contents,encoding);
        }
    }
}