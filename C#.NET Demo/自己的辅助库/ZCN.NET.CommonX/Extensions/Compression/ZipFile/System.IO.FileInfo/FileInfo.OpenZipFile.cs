//#if NET45 || NETSTANDARD

using System.IO.Compression;
using System.Text;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：以指定的模式打开指定路径上的 zip 归档
        /// </summary>
        /// <param name="this">扩展对象。
        ///  文件对象，包含要打开的存档的路径，指定为相对路径或绝对路径。相对路径被解释为相对于当前工作目录
        /// </param>
        /// <param name="mode">一个枚举值指定在开放的存档项的操作</param>
        /// <returns>打开的 zip 存档</returns>
        public static ZipArchive OpenZipFile(this global::System.IO.FileInfo @this,ZipArchiveMode mode)
        {
            return ZipFile.Open(@this.FullName,mode);
        }

        /// <summary>
        ///  自定义扩展方法：在指定的模式中用指定的项名称汉字解码打开指定路径的 zip 存档
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="mode">一个枚举值指定在开放的存档项的操作</param>
        /// <param name="entryNameEncoding">在归档中读取或写入条目名称时使用的编码。 
        ///  仅当需要针对具有不支持条目名称的 UTF-8 编码的 zip 归档工具和库的互操作性进行编码时，为此参数指定值
        /// </param>
        /// <returns>打开的 zip 存档</returns>
        public static ZipArchive OpenZipFile(this global::System.IO.FileInfo @this,ZipArchiveMode mode,Encoding entryNameEncoding)
        {
            return ZipFile.Open(@this.FullName,mode,entryNameEncoding);
        }
    }
}

//#endif