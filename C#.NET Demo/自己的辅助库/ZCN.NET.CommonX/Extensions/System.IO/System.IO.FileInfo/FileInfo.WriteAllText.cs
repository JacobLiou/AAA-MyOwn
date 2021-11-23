using System.IO;
using System.Text;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：创建一个新文件，在其中写入指定的字符串，然后关闭文件。如果目标文件已存在，则覆盖该文件
        /// </summary>
        /// <param name="this">扩展对象。文件信息对象</param>
        /// <param name="contents">要写入文件的字符串</param>
        public static void WriteAllText(this FileInfo @this,string contents)
        {
            File.WriteAllText(@this.FullName,contents);
        }

        /// <summary>
        ///  自定义扩展方法：创建一个新文件，将指定编码方式在其中写入指定的字符串，然后关闭文件。如果目标文件已存在，则覆盖该文件
        /// </summary>
        /// <param name="this">扩展对象。文件信息对象</param>
        /// <param name="contents">要写入文件的字符串</param>
        /// <param name="encoding">编码方式</param>
        public static void WriteAllText(this FileInfo @this,string contents,Encoding encoding)
        {
            File.WriteAllText(@this.FullName,contents,encoding);
        }
    }
}