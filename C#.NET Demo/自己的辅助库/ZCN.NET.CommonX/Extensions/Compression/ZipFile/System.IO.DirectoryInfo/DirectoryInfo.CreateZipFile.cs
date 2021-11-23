using System.IO;
using System.IO.Compression;
using System.Text;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：创建 zip 存档，该存档包含文件和指定目录的目录
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="destinationArchiveFileName">要创建的存档路径，指定为相对路径或绝对路径。相对路径被解释为相对于当前工作目录
        /// </param>
        public static void CreateZipFile(this DirectoryInfo @this, string destinationArchiveFileName)
        {
            ZipFile.CreateFromDirectory(@this.FullName, destinationArchiveFileName);
        }

        /// <summary>
        ///  自定义扩展方法：创建 zip 存档，该存档包括文件和指定目录的目录，使用指定压缩级别，以及可以选择包含基目录
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="destinationArchiveFileName">要生成的存档路径，指定为相对路径或绝对路径。
        ///  相对路径被解释为相对于当前工作目录
        /// </param>
        /// <param name="compressionLevel">创建项时，指示是否要强调速度或压缩有效性的枚举值之一</param>
        /// <param name="includeBaseDirectory">包括从在存档的根的 sourceDirectoryName 的目录名称，则为 true；
        ///  仅包含目录中的内容，则为 false
        /// </param>
        public static void CreateZipFile(this DirectoryInfo @this,
            string destinationArchiveFileName,
            CompressionLevel compressionLevel,
            bool includeBaseDirectory)
        {
            ZipFile.CreateFromDirectory(@this.FullName,
                destinationArchiveFileName,
                compressionLevel,
                includeBaseDirectory);
        }

        /// <summary>
        ///  自定义扩展方法：创建 zip 存档，该存档包括文件和指定目录的目录，使用指定压缩级别和条目名称的字符编码，以及可以选择包含基目录
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="destinationArchiveFileName">要生成的存档路径，指定为相对路径或绝对路径。
        ///  相对路径被解释为相对于当前工作目录
        /// </param>
        /// <param name="compressionLevel">创建项时，指示是否要强调速度或压缩有效性的枚举值之一</param>
        /// <param name="includeBaseDirectory">包括从在存档的根的 sourceDirectoryName 的目录名称，则为 true；
        ///  仅包含目录中的内容，则为 false
        /// </param>
        /// <param name="entryNameEncoding">在归档中读取或写入条目名称时使用的编码。 
        ///  仅当需要针对具有不支持条目名称的 UTF-8 编码的 zip 归档工具和库的互操作性进行编码时，为此参数指定值
        /// </param>
        public static void CreateZipFile(this DirectoryInfo @this,
            string destinationArchiveFileName,
            CompressionLevel compressionLevel,
            bool includeBaseDirectory,
            Encoding entryNameEncoding)
        {
            ZipFile.CreateFromDirectory(@this.FullName,
                destinationArchiveFileName,
                compressionLevel,
                includeBaseDirectory,
                entryNameEncoding);
        }

        /// <summary>
        ///  自定义扩展方法：创建 zip 存档，该存档包含文件和指定目录的目录
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="destinationArchiveFile">要生成的存档路径，指定为相对路径或绝对路径。 相对路径被解释为相对于当前工作目录</param>
        public static void CreateZipFile(this DirectoryInfo @this, FileInfo destinationArchiveFile)
        {
            ZipFile.CreateFromDirectory(@this.FullName, destinationArchiveFile.FullName);
        }

        /// <summary>
        ///  自定义扩展方法：创建 zip 存档，该存档包括文件和指定目录的目录，使用指定压缩级别，以及可以选择包含基目录
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="destinationArchiveFile">文件信息。要生成的存档路径，指定为相对路径或绝对路径。
        ///  相对路径被解释为相对于当前工作目录
        /// </param>
        /// <param name="compressionLevel">创建项时，指示是否要强调速度或压缩有效性的枚举值之一</param>
        /// <param name="includeBaseDirectory">包括从在存档的根的 sourceDirectoryName 的目录名称，则为 true；
        ///  仅包含目录中的内容，则为 false
        /// </param>
        public static void CreateZipFile(this DirectoryInfo @this,
            FileInfo destinationArchiveFile,
            CompressionLevel compressionLevel,
            bool includeBaseDirectory)
        {
            ZipFile.CreateFromDirectory(@this.FullName,
                destinationArchiveFile.FullName,
                compressionLevel,
                includeBaseDirectory);
        }

        /// <summary>
        ///  自定义扩展方法：创建 zip 存档，该存档包括文件和指定目录的目录，使用指定压缩级别和条目名称的字符编码，以及可以选择包含基目录
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="destinationArchiveFile">文件信息。要生成的存档路径，指定为相对路径或绝对路径。
        ///  相对路径被解释为相对于当前工作目录
        /// </param>
        /// <param name="compressionLevel">创建项时，指示是否要强调速度或压缩有效性的枚举值之一</param>
        /// <param name="includeBaseDirectory">包括从在存档的根的 sourceDirectoryName 的目录名称，则为 true；
        ///  仅包含目录中的内容，则为 false
        /// </param>
        /// <param name="entryNameEncoding">在归档中读取或写入条目名称时使用的编码。 
        ///  仅当需要针对具有不支持条目名称的 UTF-8 编码的 zip 归档工具和库的互操作性进行编码时，为此参数指定值
        /// </param>
        public static void CreateZipFile(this DirectoryInfo @this,
            FileInfo destinationArchiveFile,
            CompressionLevel compressionLevel,
            bool includeBaseDirectory,
            Encoding entryNameEncoding)
        {
            ZipFile.CreateFromDirectory(@this.FullName,
                destinationArchiveFile.FullName,
                compressionLevel,
                includeBaseDirectory,
                entryNameEncoding);
        }
    }
}