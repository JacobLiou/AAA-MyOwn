using System.IO;
using System.IO.Compression;

namespace ZCN.NET.CommonX.Extensionsn
{
    public static partial class CommonExtensions
    {
        /*微软官方文档：https://docs.microsoft.com/zh-cn/dotnet/api/system.io.compression.gzipstream?view=netcore-3.1*/

        /// <summary>
        ///  自定义扩展方法：创建压缩文件。
        ///  如果文件属性为隐藏或者文件扩展名为 .gz，则不创建压缩文件。
        /// </summary>
        /// <param name="this">扩展对象。文件信息对象,需要包含文件全路径名称</param>
        /// <returns></returns>
        public static void CreateGZip(this FileInfo @this)
        {
            if ((File.GetAttributes(@this.FullName) & FileAttributes.Hidden) !=
                 FileAttributes.Hidden & @this.Extension != ".gz")
            {
                using (FileStream originalStream = @this.OpenRead())
                {
                    using (FileStream destStream = File.Create(@this.FullName + ".gz"))
                    {
                        using (var gZipStream = new GZipStream(destStream, CompressionMode.Compress))
                        {
                            originalStream.CopyTo(gZipStream);
                        }
                    }
                }
            }
        }

        /// <summary>
        ///   自定义扩展方法：创建压缩文件.
        ///  如果文件属性为隐藏或者文件扩展名为 .gz，则不创建压缩文件。
        /// </summary>
        /// <param name="this">扩展对象。文件信息对象</param>
        /// <param name="destination">压缩文件的名称，包含全路径</param>
        public static void CreateGZip(this FileInfo @this, string destination)
        {
            if ((File.GetAttributes(@this.FullName) & FileAttributes.Hidden) != FileAttributes.Hidden
             & @this.Extension != ".gz")
            {
                using (FileStream originalStream = @this.OpenRead())
                {
                    using (FileStream destStream = File.Create(destination))
                    {
                        using (var gZipStream = new GZipStream(destStream, CompressionMode.Compress))
                        {
                            originalStream.CopyTo(gZipStream);
                        }
                    }
                }
            }
        }

        /// <summary>
        ///   自定义扩展方法：创建压缩文件
        /// </summary>
        /// <param name="this">扩展对象。文件信息对象</param>
        /// <param name="destFileInfo">压缩文件信息的对象，需要包含文件全路径名称</param>
        public static void CreateGZip(this FileInfo @this, FileInfo destFileInfo)
        {
            @this.CreateGZip(destFileInfo.FullName);
        }
    }
}