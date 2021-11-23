using System.IO;
using System.Text;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：从流的当前位置到末尾读取流
        /// </summary>
        /// <param name="this">扩展对象。文件信息对象</param>
        /// <returns></returns>
        public static string ReadToEnd(this FileInfo @this)
        {
            using(FileStream stream = File.Open(@this.FullName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                using(var reader = new StreamReader(stream, Encoding.Default))
                {
                    return reader.ReadToEnd();
                }
            }
        }

        /// <summary>
        ///  自定义扩展方法：从流的指定的位置到末尾读取流
        /// </summary>
        /// <param name="this">扩展对象。文件信息对象</param>
        /// <param name="position">指定的位置</param>
        /// <returns></returns>
        public static string ReadToEnd(this FileInfo @this, long position)
        {
            using(FileStream stream = File.Open(@this.FullName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                stream.Position = position;

                using(var reader = new StreamReader(stream, Encoding.Default))
                {
                    return reader.ReadToEnd();
                }
            }
        }

        /// <summary>
        ///  自定义扩展方法：将指定编码方式从流的当前位置到末尾读取流
        /// </summary>
        /// <param name="this">扩展对象。文件信息对象</param>
        /// <param name="encoding">应用到文件内容的编码</param>
        /// <returns></returns>
        public static string ReadToEnd(this FileInfo @this, Encoding encoding)
        {
            using(FileStream stream = File.Open(@this.FullName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                using(var reader = new StreamReader(stream, encoding))
                {
                    return reader.ReadToEnd();
                }
            }
        }

        /// <summary>
        ///  自定义扩展方法：将指定编码方式从流的指定的位置到末尾读取流
        /// </summary>
        /// <param name="this">扩展对象。文件信息对象</param>
        /// <param name="encoding">应用到文件内容的编码</param>
        /// <param name="position">指定的位置</param>
        /// <returns></returns>
        public static string ReadToEnd(this FileInfo @this, Encoding encoding, long position)
        {
            using(FileStream stream = File.Open(@this.FullName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                stream.Position = position;

                using(var reader = new StreamReader(stream, encoding))
                {
                    return reader.ReadToEnd();
                }
            }
        }
    }
}