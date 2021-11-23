using System.IO;
using System.IO.Compression;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /*微软官方文档：https://docs.microsoft.com/zh-cn/dotnet/api/system.io.compression.gzipstream?view=netcore-3.1*/

        /// <summary>
        ///  自定义扩展方法：根据指定文件对象信息创建一个压缩文件，并从文件信息中拷贝内容到一个新的文件中
        /// </summary>
        /// <param name="this">扩展对象。文件信息对象,需要包含文件全路径名称</param>
        public static void ExtractGZipToDirectory(this FileInfo @this)
        {
            using (FileStream originalFileStream = @this.OpenRead())
            {
                string newFileName = Path.GetFileNameWithoutExtension(@this.FullName);

                using (FileStream destFileStream = File.Create(newFileName))
                {
                    using (var gZipStream = new GZipStream(destFileStream, CompressionMode.Compress))
                    {
                        originalFileStream.CopyTo(gZipStream);
                    }
                }
            }
        }

        /// <summary>
        ///  自定义扩展方法：根据指定文件对象信息创建一个压缩文件，并从文件信息中拷贝内容到一个新的文件中
        /// </summary>
        /// <param name="this">扩展对象。文件信息对象,需要包含文件全路径名称</param>
        /// <param name="destination">压缩文件的名称，包含全路径</param>
        public static void ExtractGZipToDirectory(this FileInfo @this, string destination)
        {
            using (FileStream originalFileStream = @this.OpenRead())
            {
                using (FileStream destFileStream = File.Create(destination))
                {
                    //using (var gZipStream = new GZipStream(destFileStream, CompressionMode.Compress))
                    //{
                    //    originalFileStream.CopyTo(gZipStream);
                    //}

                    originalFileStream.CopyTo(destFileStream);
                }
            }
        }

        /// <summary>
        ///   自定义扩展方法：创建压缩文件到指定目录下
        /// </summary>
        /// <param name="this">扩展对象。文件信息对象</param>
        /// <param name="destFileInfo">压缩文件信息的对象，需要包含文件全路径名称</param>
        public static void ExtractGZipToDirectory(this FileInfo @this, FileInfo destFileInfo)
        {
            @this.ExtractGZipToDirectory(destFileInfo.FullName);
        }
    }
}