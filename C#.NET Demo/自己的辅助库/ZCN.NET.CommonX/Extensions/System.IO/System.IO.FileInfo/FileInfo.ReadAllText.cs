using System.IO;
using System.Text;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：打开一个文本文件，读取文件的所有行，然后关闭该文件
        /// </summary>
        /// <param name="this">扩展对象。文件信息对象</param>
        /// <returns></returns>
        public static string ReadAllText(this FileInfo @this)
        {
            return File.ReadAllText(@this.FullName);
        }

        /// <summary>
        ///  自定义扩展方法：打开一个文件，将指定编码读取文件的所有行，然后关闭该文件
        /// </summary>
        /// <param name="this">扩展对象。文件信息对象</param>
        /// <param name="encoding">应用到文件内容的编码</param>
        /// <returns></returns>
        public static string ReadAllText(this FileInfo @this, Encoding encoding)
        {
            return File.ReadAllText(@this.FullName, encoding);
        }
    }
}