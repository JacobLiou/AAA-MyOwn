using System.IO;
using System.IO.Compression;
using System.Text;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /*微软官方文档：https://docs.microsoft.com/zh-cn/dotnet/api/system.io.compression.gzipstream?view=netcore-3.1*/

        #region Compress

        /// <summary>
        ///   自定义扩展方法：使用操作系统当前的ANSI编码格式压缩字符串。返回压缩后的字节数组。
        ///   如果字符串为 Null、空、空白，则返回 null
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static byte[] CompressByGZip(this string @this)
        {
            if (string.IsNullOrWhiteSpace(@this))
                return null;

            byte[] byteArr = Encoding.Default.GetBytes(@this);
            using (var memoryStream = new MemoryStream())
            {
                using (var gZipStream = new GZipStream(memoryStream, CompressionMode.Compress))
                {
                    gZipStream.Write(byteArr, 0, byteArr.Length);
                    gZipStream.Close();

                    return memoryStream.ToArray();
                }
            }
        }

        /// <summary>
        ///   自定义扩展方法：使用指定的编码格式压缩字符串。返回压缩后的字节数组。
        ///   如果字符串为 Null、空、空白，则返回 null
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="encoding">编码格式</param>
        /// <returns></returns>
        public static byte[] CompressByGZip(this string @this, Encoding encoding)
        {
            if (string.IsNullOrWhiteSpace(@this))
                return null;

            byte[] byteArr = encoding.GetBytes(@this);
            using (var memoryStream = new MemoryStream())
            {
                using (var gZipStream = new GZipStream(memoryStream, CompressionMode.Compress))
                {
                    gZipStream.Write(byteArr, 0, byteArr.Length);
                    gZipStream.Close();

                    return memoryStream.ToArray();
                }
            }
        }

        /// <summary>
        ///   自定义扩展方法：使用指定的编码格式压缩字符串到指定的文件。
        ///   如果字符串为 Null、空、空白，则不创建压缩文件。
        ///   如果需要解压缩，请调用对应的 DecompressFormFileByGZip()方法
        /// </summary>
        /// <param name="compressData">待压缩字符串</param>
        /// <param name="zipFilePath">压缩后的文件名称(包含完全路径)</param>
        public static void CompressToFileByGZip(this string compressData, string zipFilePath)
        {
            if (string.IsNullOrWhiteSpace(compressData))
                return;

            byte[] bytes = Encoding.UTF8.GetBytes(compressData);
            using (var originalStream = new MemoryStream(bytes))
            {
                using (FileStream destFileStream = File.Create(zipFilePath))
                {
                    using (var gZipStream = new GZipStream(destFileStream, CompressionMode.Compress))
                    {
                        originalStream.CopyTo(gZipStream);
                        gZipStream.Close();
                    }
                }
            }
        }

        #endregion

        #region Decompress

        /// <summary>
        ///   自定义扩展方法：使用操作系统当前的ANSI编码格式解压缩。返回解压缩后的字符串。
        ///   如果字节数组为 Null 或者 长度为0，则返回空字符串
        /// </summary>
        /// <param name="this">扩展对象。8位无符号整数数组</param>
        /// <returns></returns>
        public static string DecompressByGZip(this byte[] @this)
        {
            if (@this == null || @this.Length == 0)
                return string.Empty;

            const int bufferSize = 1024;
            using (var memoryStream = new MemoryStream(@this))
            {
                using (var zipStream = new GZipStream(memoryStream, CompressionMode.Decompress))
                {
                    // 内存流 用于接收解压的字节
                    using (var outStream = new MemoryStream())
                    {
                        var buffer = new byte[bufferSize];
                        int totalBytes = 0;
                        int readBytes;
                        while ((readBytes = zipStream.Read(buffer, 0, bufferSize)) > 0)
                        {
                            outStream.Write(buffer, 0, readBytes);
                            totalBytes += readBytes;
                        }
                        return Encoding.Default.GetString(outStream.GetBuffer(), 0, totalBytes);
                    }
                }
            }
        }

        /// <summary>
        ///   自定义扩展方法： 使用指定的编码格式解压缩。返回解压缩后的字符串。
        ///   如果字节数组为 Null 或者 长度为0，则返回空字符串
        /// </summary>
        /// <param name="this">扩展对象。8位无符号整数数组</param>
        /// <param name="encoding">编码格式</param>
        /// <returns></returns>
        public static string DecompressByGZip(this byte[] @this, Encoding encoding)
        {
            if (@this == null || @this.Length == 0)
                return string.Empty;

            const int bufferSize = 1024;
            using (var memoryStream = new MemoryStream(@this))
            {
                using (var zipStream = new GZipStream(memoryStream, CompressionMode.Decompress))
                {
                    // 内存流 用于接收解压的字节
                    using (var outStream = new MemoryStream())
                    {
                        var buffer = new byte[bufferSize];
                        int totalBytes = 0;
                        int readBytes;
                        while ((readBytes = zipStream.Read(buffer, 0, bufferSize)) > 0)
                        {
                            outStream.Write(buffer, 0, readBytes);
                            totalBytes += readBytes;
                        }
                        return encoding.GetString(outStream.GetBuffer(), 0, totalBytes);
                    }
                }
            }
        }

        /// <summary>
        ///  自定义扩展方法：从指定的压缩文件中解压出字符串。
        ///  如果指定的压缩文件不存在，则返回空字符串。
        /// </summary>
        /// <param name="zipFilePath">待解压的文件路径</param>
        /// <returns>返回解压后的字符串</returns>
        public static string DecompressFromFileByGZip(this string zipFilePath)
        {
            if (!File.Exists(zipFilePath))
                return string.Empty;

            using (FileStream originalStream = File.Open(zipFilePath, FileMode.Open))
            {
                using (MemoryStream destStream = new MemoryStream())
                {
                    using (GZipStream gZipStream = new GZipStream(originalStream, CompressionMode.Decompress))
                    {
                        gZipStream.CopyTo(destStream);
                    }
                    byte[] bytes = destStream.ToArray();
                    return Encoding.UTF8.GetString(bytes);
                }
            }
        }

        #endregion
    }
}