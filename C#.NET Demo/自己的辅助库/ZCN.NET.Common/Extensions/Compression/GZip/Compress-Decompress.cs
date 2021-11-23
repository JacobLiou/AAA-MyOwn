using System.IO;
using System.IO.Compression;
using System.Text;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /*΢��ٷ��ĵ���https://docs.microsoft.com/zh-cn/dotnet/api/system.io.compression.gzipstream?view=netcore-3.1*/

        #region Compress

        /// <summary>
        ///   �Զ�����չ������ʹ�ò���ϵͳ��ǰ��ANSI�����ʽѹ���ַ���������ѹ������ֽ����顣
        ///   ����ַ���Ϊ Null���ա��հף��򷵻� null
        /// </summary>
        /// <param name="this">��չ����</param>
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
        ///   �Զ�����չ������ʹ��ָ���ı����ʽѹ���ַ���������ѹ������ֽ����顣
        ///   ����ַ���Ϊ Null���ա��հף��򷵻� null
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <param name="encoding">�����ʽ</param>
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
        ///   �Զ�����չ������ʹ��ָ���ı����ʽѹ���ַ�����ָ�����ļ���
        ///   ����ַ���Ϊ Null���ա��հף��򲻴���ѹ���ļ���
        ///   �����Ҫ��ѹ��������ö�Ӧ�� DecompressFormFileByGZip()����
        /// </summary>
        /// <param name="compressData">��ѹ���ַ���</param>
        /// <param name="zipFilePath">ѹ������ļ�����(������ȫ·��)</param>
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
        ///   �Զ�����չ������ʹ�ò���ϵͳ��ǰ��ANSI�����ʽ��ѹ�������ؽ�ѹ������ַ�����
        ///   ����ֽ�����Ϊ Null ���� ����Ϊ0���򷵻ؿ��ַ���
        /// </summary>
        /// <param name="this">��չ����8λ�޷�����������</param>
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
                    // �ڴ��� ���ڽ��ս�ѹ���ֽ�
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
        ///   �Զ�����չ������ ʹ��ָ���ı����ʽ��ѹ�������ؽ�ѹ������ַ�����
        ///   ����ֽ�����Ϊ Null ���� ����Ϊ0���򷵻ؿ��ַ���
        /// </summary>
        /// <param name="this">��չ����8λ�޷�����������</param>
        /// <param name="encoding">�����ʽ</param>
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
                    // �ڴ��� ���ڽ��ս�ѹ���ֽ�
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
        ///  �Զ�����չ��������ָ����ѹ���ļ��н�ѹ���ַ�����
        ///  ���ָ����ѹ���ļ������ڣ��򷵻ؿ��ַ�����
        /// </summary>
        /// <param name="zipFilePath">����ѹ���ļ�·��</param>
        /// <returns>���ؽ�ѹ����ַ���</returns>
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