using System.IO;
using System.Text;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：打开一个文件，向其中追加指定的字符串，然后关闭该文件。
        ///  如果文件不存在，此方法创建一个文件，将指定字符串写入文件，然后关闭该文件
        /// </summary>
        /// <param name="this">扩展对象。文件信息对象</param>
        /// <param name="contents">要追加到文件中的字符串</param>
        public static void AppendAllText(this FileInfo @this, string contents)
        {
            File.AppendAllText(@this.FullName, contents);
        }

        /// <summary>
        ///  自定义扩展方法：将指定编码将指定字符串追加到文件中，如果文件还不存在则创建该文件
        /// </summary>
        /// <param name="this">扩展对象。文件信息对象</param>
        /// <param name="contents">要追加到文件中的字符串</param>
        /// <param name="encoding">要使用的字符编码</param>
        public static void AppendAllText(this FileInfo @this, string contents, Encoding encoding)
        {
            File.AppendAllText(@this.FullName, contents, encoding);
        }
    }
}