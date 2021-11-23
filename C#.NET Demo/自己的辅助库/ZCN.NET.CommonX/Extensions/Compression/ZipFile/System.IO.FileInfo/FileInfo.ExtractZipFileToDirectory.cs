using System.IO;
using System.IO.Compression;
using System.Text;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：将指定 zip 存档中的所有文件都解压到文件系统的一目录下
        /// </summary>
        /// <param name="this">扩展对象，包含要解压缩存档的路径</param>
        /// <param name="destinationDirectoryName">放置解压缩文件的目录的路径，指定为相对路径或绝对路径。 
        ///  相对路径被解释为相对于当前工作目录
        /// </param>
        public static void ExtractZipFileToDirectory(this FileInfo @this,string destinationDirectoryName)
        {
            ZipFile.ExtractToDirectory(@this.FullName,destinationDirectoryName);
        }

        /// <summary>
        ///  自定义扩展方法：将指定 zip 存档中的所有文件都解压到文件系统的一目录下
        /// </summary>
        /// <param name="this">扩展对象，包含到要解压缩存档的路径</param>
        /// <param name="destinationDirectoryName">放置解压缩文件的目录的路径，指定为相对路径或绝对路径。 
        ///  相对路径被解释为相对于当前工作目录
        /// </param>
        /// <param name="entryNameEncoding">在归档中读取或写入条目名称时使用的编码。 
        ///  仅当需要针对具有不支持条目名称的 UTF-8 编码的 zip 归档工具和库的互操作性进行编码时，为此参数指定值
        /// </param>
        public static void ExtractZipFileToDirectory(this FileInfo @this,
            string destinationDirectoryName,
            Encoding entryNameEncoding)
        {
            ZipFile.ExtractToDirectory(@this.FullName,destinationDirectoryName,entryNameEncoding);
        }

        /// <summary>
        ///  自定义扩展方法：将指定 zip 存档中的所有文件都解压到文件系统的一目录下
        /// </summary>
        /// <param name="this">扩展对象，文件信息对象，包含到要解压缩存档的路径</param>
        /// <param name="destinationDirectory">目录信息对象，包含到放置解压缩文件的目录的路径，指定为相对路径或绝对路径。 
        ///  相对路径被解释为相对于当前工作目录
        /// </param>
        public static void ExtractZipFileToDirectory(this FileInfo @this,DirectoryInfo destinationDirectory)
        {
            ZipFile.ExtractToDirectory(@this.FullName,destinationDirectory.FullName);
        }

        /// <summary>
        ///  自定义扩展方法：将指定 zip 存档中的所有文件都解压到文件系统的一目录下
        /// </summary>
        /// <param name="this">扩展对象，包含到要解压缩存档的路径</param>
        /// <param name="destinationDirectory">目录信息对象，放置解压缩文件的目录的路径，指定为相对路径或绝对路径。 
        ///  相对路径被解释为相对于当前工作目录
        /// </param>
        /// <param name="entryNameEncoding">在归档中读取或写入条目名称时使用的编码。 
        ///  仅当需要针对具有不支持条目名称的 UTF-8 编码的 zip 归档工具和库的互操作性进行编码时，为此参数指定值
        /// </param>
        public static void ExtractZipFileToDirectory(this FileInfo @this,
            DirectoryInfo destinationDirectory,
            Encoding entryNameEncoding)
        {
            ZipFile.ExtractToDirectory(@this.FullName,destinationDirectory.FullName,entryNameEncoding);
        }
    }
}
